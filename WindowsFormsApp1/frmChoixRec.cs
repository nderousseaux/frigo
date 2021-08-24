using Form4_recette;
using FormEtape_Etape;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Recettes
{
    public partial class frmRecettes : Form
    {
        public frmRecettes()
        {
            InitializeComponent();
        }

        Dictionary<String, int[]> dico;
        public frmRecettes(Dictionary<String, int[]> dico)
        {
            InitializeComponent();
            this.dico = dico;

        }

        OleDbConnection connec = new OleDbConnection();
        string chcon = frmAccueil.chcon;



        private void frmRecettes_Load(object sender, EventArgs e)
        {
            
           


            //On crée la requete sql 

            //On crée la partie ingrédients
            String requeteIngredient = "";
            foreach (int ingredient in dico["Ingredients"])
            {
                requeteIngredient += "AND r.codeRecette IN (SELECT codeRecette FROM [IngrédientsRecette] WHERE codeIngredient = " + ingredient + ") ";
            }

            /*
            //On crée la partie type de cuisine
            String requeteCuisine = "";
            foreach (int cuisine in dico["TypeDeCuisine"])
            {
                requeteCuisine += "AND r.codeRecette IN (SELECT codeRecette FROM [CatégoriesRecette] WHERE codeCategorie = " + cuisine + ") ";
            }*/

            //On crée la partie type de plat
            String requetePlat = "";
            foreach (int plat in dico["TypeDePlat"])
            {
                requetePlat += "AND r.codeRecette IN (SELECT codeRecette FROM [CatégoriesRecette] WHERE codeCategorie = " + plat + ") ";
            }

            //On crée la partie budget
            String requetebudget = "";
            foreach (int budget in dico["Budget"])
            {
                requetePlat += "AND r.categPrix <= " + dico["Budget"][0].ToString();
            }

            String requete = "" +
                "SELECT DISTINCT r.description, r.tempsCuisson, r.imageDesc, r.categPrix, r.codeRecette " +
                "FROM Recettes r, [IngrédientsRecette] ir, [CatégoriesRecette] cr " +
                "WHERE r.CodeRecette = ir.CodeRecette " +
                "AND r.CodeRecette = cr.CodeRecette " +
                requeteIngredient +
                /*requeteCuisine +*/
                requetePlat +
                requetebudget;


            if(dico["TmpCuisson"].Length> 0)
            {
                requete += "AND r.tempsCuisson <= " + dico["TmpCuisson"][0].ToString();
            }

            requete += ";";
            

            //Pour chaque recettes, une nouvelle instance de "fiche recette"
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                OleDbDataReader reader = cd.ExecuteReader();
                int y = 10;
                bool first = true;
                //On crée une nouvelle instance de recette
                while (reader.Read())
                {
                    if (first) {
                        pan1.Controls.Clear();
                        first = false;
                    }
                    //On crée l'user control
                    ficheRecette fiche = new ficheRecette(reader.GetString(0), reader.GetInt32(3), reader.GetInt32(1), reader.GetString(2));
                    fiche.Location = new System.Drawing.Point(0, y);
                    pan1.Controls.Add(fiche);

                    //On crée les deux boutons
                    PictureBox picRecetteComplete = new PictureBox();
                    picRecetteComplete.Tag = reader.GetInt32(4);
                    
                    picRecetteComplete.Cursor = System.Windows.Forms.Cursors.Hand;
                    picRecetteComplete.Location = new System.Drawing.Point(645, y+65);
                    picRecetteComplete.Size = new System.Drawing.Size(50, 50);
                    picRecetteComplete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picRecetteComplete.Image = imageList1.Images["voirLoupe.jpg"];
                    pan1.Controls.Add(picRecetteComplete);

                    picRecetteComplete.Click += new System.EventHandler(afficherRecette);

                    PictureBox picRecette = new PictureBox();
                    picRecette.Tag = reader.GetInt32(4);
                    picRecette.Cursor = System.Windows.Forms.Cursors.Hand;
                    picRecette.Location = new System.Drawing.Point(700, y + 65);
                    picRecette.Size = new System.Drawing.Size(50, 50);
                    picRecette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picRecette.Image = imageList1.Images["ampoule.png"];
                    pan1.Controls.Add(picRecette);

                    picRecette.Click += new System.EventHandler(afficherRecetteEtape);

                    y += 210;
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

            


        }

        private void afficherRecetteEtape(object sender, EventArgs e)
        {
            frmEtape frm = new frmEtape(Int32.Parse(((PictureBox)sender).Tag.ToString()));
            frm.ShowDialog();
        }
        private void afficherRecette(object sender, EventArgs e)
        {
            frmRec frm1 = new frmRec(Int32.Parse(((PictureBox)sender).Tag.ToString()));
            frm1.ShowDialog();
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
