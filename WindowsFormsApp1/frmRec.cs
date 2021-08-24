using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using WindowsFormsApp1;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace Form4_recette
{
    public partial class frmRec : Form
    {
        static int IdRecette;
        string chcon = frmAccueil.chcon;
        OleDbConnection connec;
        Boolean deja = false;
        string ing = "";
        public frmRec(int id)
        {
            IdRecette = id;
            InitializeComponent();
        }


        DataSet dsLocal = new DataSet();
        
        private void Form1_Load(object sender, EventArgs e)
        {

            connec = new OleDbConnection(chcon);

            Entete resultat = new Entete(IdRecette);
            resultat.Location = new System.Drawing.Point(12, 12);
            this.Controls.Add(resultat);

            connec.Open();
            string req = @"SELECT numEtape, texteEtape, imageEtape FROM EtapesRecette WHERE codeRecette =" + IdRecette + " ORDER BY numEtape;";
            OleDbCommand cmd = new OleDbCommand(req, connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            int y = 0;

            while (dr.Read())
            {

                string Etap;
                try
                {
                    Etap = dr.GetString(2);

                }
                catch
                {
                    Etap = "";

                }
                AffRecette Etapes = new AffRecette(dr.GetInt32(0).ToString(), dr.GetString(1), Etap);


                Etapes.Location = new System.Drawing.Point(20, y);
                pnlEtape.Controls.Add(Etapes);
                y += 150;
            }


            string reqNbIng = "SELECT count(codeIngredient) FROM IngrédientsRecette WHERE codeRecette = " + IdRecette;
            int nbIng = int.Parse(new OleDbCommand(reqNbIng, connec).ExecuteScalar().ToString());


            // Récupération du nom de l'ingrédient
            string reqNomIng = @"SELECT DISTINCT i.libIngredient FROM Ingrédients i LEFT JOIN IngrédientsRecette ir ON i.codeIngredient = ir.codeIngredient WHERE ir.codeIngredient IN (SELECT codeIngredient FROM IngrédientsRecette WHERE codeRecette = " + IdRecette + ")";
            OleDbDataReader d = new OleDbCommand(reqNomIng, connec).ExecuteReader();
            int j = 0;
            int x = 10;
            int yIngr = 10;
            while (d.Read())
            {
                Label l = new Label
                {
                    AutoSize = true,
                    Location = new Point(x, yIngr),
                    Tag = j,
                    Text = d.GetString(0),
                };
                pnlIngr.Controls.Add(l);
                yIngr += 20;
                j++;
            }
            foreach (Label l in pnlIngr.Controls)
            {
                string reqQte = @"SELECT quantite FROM IngrédientsRecette WHERE codeIngredient = (SELECT codeIngredient FROM Ingrédients WHERE libIngredient ='" + l.Text.Replace("'", "''") + "') AND codeRecette = " + IdRecette;
                float qteIng = (float)(new OleDbCommand(reqQte, connec).ExecuteScalar());

                string reqUnit = @"SELECT unité FROM IngrédientsRecette WHERE codeIngredient = (SELECT codeIngredient FROM Ingrédients WHERE libIngredient ='" + l.Text.Replace("'", "''") + "') AND codeRecette = " + IdRecette;
                string unit = new OleDbCommand(reqUnit, connec).ExecuteScalar().ToString();
                l.Text = " - " + qteIng.ToString() + " " + unit + " " + l.Text;
                ing += l.Text;
                ing += "\n";
            }

            connec.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

            //On récupère toutes les informations en déconnecté
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                DataTable schemaTable = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                string requete;
                foreach (DataRow ligne in schemaTable.Rows)
                {

                    String nomDeTable = ligne[2].ToString();
                    requete = "SELECT * FROM [" + nomDeTable + "]";
                    OleDbCommand cd = new OleDbCommand(requete, connec);
                    OleDbDataAdapter da = new OleDbDataAdapter(cd);
                    da.Fill(dsLocal, nomDeTable);
                }

            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur de connexion à la base");
            }
            catch (OleDbException)
            {
                MessageBox.Show("Erreur dans la requête SQL !");
            }

            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }

            }

            String nomRecette = "";
            String imageRecette = "";
            String descriptionRecette = "";
            String tempRecette = "";

            for (int i = 0; i < dsLocal.Tables["Recettes"].Rows.Count; i++)
            {
                if (dsLocal.Tables["Recettes"].Rows[i]["CodeRecette"].ToString() == IdRecette.ToString())
                {
                    nomRecette = dsLocal.Tables["Recettes"].Rows[i]["description"].ToString();
                    imageRecette = dsLocal.Tables["Recettes"].Rows[i]["imageDesc"].ToString();
                    descriptionRecette = dsLocal.Tables["Recettes"].Rows[i]["Commentaire"].ToString();
                    tempRecette = dsLocal.Tables["Recettes"].Rows[i]["tempsCuisson"].ToString();
                }
            }

            
            
            Dictionary<int, String> descriptionsEtapes = new Dictionary<int, string>();
            Dictionary<int, String> imageEtapes = new Dictionary<int, string>();
            for (int i = 0; i < dsLocal.Tables["EtapesRecette"].Rows.Count; i++)
            {
                if (dsLocal.Tables["EtapesRecette"].Rows[i]["codeRecette"].ToString() == IdRecette.ToString())
                {
                    try
                    {
                        descriptionsEtapes.Add((int)dsLocal.Tables["EtapesRecette"].Rows[i]["numEtape"], dsLocal.Tables["EtapesRecette"].Rows[i]["texteEtape"].ToString());
                    }
                    catch { break; }
                    try
                    {
                        imageEtapes.Add((int)dsLocal.Tables["EtapesRecette"].Rows[i]["numEtape"], dsLocal.Tables["EtapesRecette"].Rows[i]["imageEtape"].ToString());
                    }
                    catch { break; }
                    
                    
                }

            }



            try
            {
                //TODO : Si le document est impossible à créer : Try catch
                //On crée le document  (A4)
                Boolean ok = false;
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.Title = "Enregistrer le pdf sous :";
                ofd.FileName = "Recette - " + nomRecette + ".pdf";
                ofd.Filter = "Documents PDF|*.pdf";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ok = true;
                }
                if (ok)
                {
                    Document doc = new Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 40);
                    //On crée un flux de données
                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(ofd.FileName, FileMode.Create));
                    //On ouvre le document
                    doc.Open();



                    //On écrit le titre
                    Chunk titre = new Chunk("Récapitulatifs pour : " + nomRecette);
                    titre.SetUnderline(1, -3);
                    doc.Add(titre);


                    iTextSharp.text.Image pic;
                    //On crée l'entête
                    try
                    {
                        pic = iTextSharp.text.Image.GetInstance("../../../Images/Images/" + imageRecette);
                    }
                    catch
                    {
                        pic = iTextSharp.text.Image.GetInstance("../../../Images/Images/lama.png");
                    }
                    pic.ScaleToFit(100, 100);
                    pic.SetAbsolutePosition(110, 680);
                    doc.Add(pic);

                    PdfContentByte descr = wri.DirectContent;
                    // On gère la police
                    descr.SetColorFill(BaseColor.BLACK);
                    descr.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 12f);
                    //On écrit
                    descr.BeginText();

                    //Entête 
                    int y = 770;
                    int sautLigne = 15;
                    descr.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Recette : " + nomRecette, 240, y, 0);
                    y -= sautLigne;
                    y -= sautLigne;

                    foreach (String ligne in lignes(descriptionRecette, 65))
                    {
                        descr.ShowTextAligned(PdfContentByte.LINE_CAP_BUTT, ligne, 240, y, 0);
                        y -= sautLigne;
                    }
                    y -= sautLigne;
                    descr.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Temps : " + tempRecette + " minutes", 240, y, 0);
                    y -= sautLigne * 4;

                    //On s'occupe des étapes
                    for (int i = 1; i <= descriptionsEtapes.Count; i++)
                    {


                        if (y < 100)
                        {
                            descr.EndText();
                            doc.NewPage();

                            //On determine la police
                            descr.SetColorFill(BaseColor.BLACK);
                            descr.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 12f);
                            descr.BeginText();
                            y = 800;
                        }
                        //Tracer un trait
                        descr.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "________________________________________________________________", 65, y - 3, 0);

                        //On écrit le numéro de l'étape, l'image et la description
                        descr.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Etape n°" + i.ToString(), 65, y, 0);
                        y -= sautLigne * 2;


                        iTextSharp.text.Image picE;
                        //On crée l'entête
                        try
                        {
                            picE = iTextSharp.text.Image.GetInstance("../../../Images/Images/" + imageEtapes[i]);
                        }
                        catch
                        {
                            picE = iTextSharp.text.Image.GetInstance("../../../Images/Images/lama.png");
                        }
                        picE.ScaleToFit(70, 70);
                        picE.SetAbsolutePosition(65, y - 50);
                        int basDeLimage = y - 50;
                        doc.Add(picE);
                        foreach (String ligne in lignes(descriptionsEtapes[i], 70))
                        {
                            descr.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ligne, 150, y, 0);
                            y -= sautLigne;
                        }

                        //Si le texte était court
                        if (basDeLimage < y)
                        {
                            y = basDeLimage;
                        }
                        y -= sautLigne * 3;


                    }
                    descr.EndText();


                    //Affichage de la liste de courses
                    var rect = new iTextSharp.text.Rectangle(1000, 0, 0, 100);
                    rect.Border = iTextSharp.text.Rectangle.TOP_BORDER;
                    rect.BorderWidth = 1;
                    rect.BorderColor = new BaseColor(0, 0, 0);
                    descr.Rectangle(rect);

                    y = 80;
                    descr.BeginText();
                    int o = 0;
                    foreach (string s in ing.Split('\n'))
                    {
                        if (o == 0)
                        {
                            descr.ShowTextAligned(PdfContentByte.ALIGN_LEFT, s, 50, y, 0);
                            o++;
                        }
                        else if (o == 1)
                        {
                            descr.ShowTextAligned(PdfContentByte.ALIGN_LEFT, s, 250, y, 0);
                            o++;
                        }
                        else if (o == 2)
                        {
                            descr.ShowTextAligned(PdfContentByte.ALIGN_LEFT, s, 450, y, 0);
                            o = 0;
                            y -= sautLigne;
                        }


                    }



                    //On enregistre
                    descr.EndText();




                    doc.NewPage();

                    //On ferme le document
                    doc.Close();
                    Process.Start(ofd.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Impossible d'écrire le pdf \nLe dossier d'accès n'est pas disponible en écriture ou le fichier est ouvert dans une autre application.");

            }
        }
                
    

    



        //Fonction qui prend en entrée du texte et une taille de ligne, et qui renvoie un tableau, chaque case correspondant à une ligne.
        //Permet de gérer le saut de ligne automatique
        private String[] lignes(String texte, int tailleLigne)
        {

            List<String> lignes = new List<String>();

            //On crée la liste de mots
            String[] listeMots = texte.Split();

            //Pour chaque ligne
            int j = 0;
            while (j < listeMots.Length)
            {
                //On génére une ligne à la bonne taille
                String ligne = "";
                while ((j < listeMots.Length) && (ligne.Length + listeMots[j].Length + 1 <= tailleLigne))
                {
                    ligne += listeMots[j];
                    ligne += " ";
                    j++;
                }



                lignes.Add(ligne);

            }



            return lignes.ToArray();
        }
    }
}
