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
using typeRecette;
using System.IO;
using avis;

namespace WindowsFormsApp1
{
    public partial class frmAccueil : Form
    {
        int appui = 2;
        String chemin;
        public static string chcon;
        public frmAccueil()
        {
            this.chemin = Directory.GetCurrentDirectory();

            chemin = Directory.GetParent(chemin).ToString();
            chemin = Directory.GetParent(chemin).ToString();
            chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + chemin + "/baseFrigov2000.mdb";
            InitializeComponent();
        }
        
        //On crée une variable globale de connection
        
        OleDbConnection connec = new OleDbConnection();

        DataSet dsLocal = new DataSet();

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            

            
            try
            {
                
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
                    
                
                connec.Close();

                int x = 0;
                int y = 22;
                foreach (DataRow r in dsLocal.Tables["Famille"].Rows)
                {
                    string cat = r[1].ToString();
                    BtnCat select = new BtnCat(cat, grpChoix, grpRecap, r[0].ToString(), this);
                    select.Location = new System.Drawing.Point(x, y);
                    grpSelect.Controls.Add(select);

                    y += 25;
                    
                }
                
            }
            catch (InvalidOperationException) //pour les operateurs
            {
                MessageBox.Show("Erreur de connexion à la base !");
            }
            catch (OleDbException) // Pour les requete
            {
                MessageBox.Show("Erreur dans la requete SQL !");
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
  
            int nbIng = 3;
            if(grpRecap.Controls.Count >= 3)
            {
                nbIng = grpRecap.Controls.Count - 2;
            }
            else
            {
                nbIng = grpRecap.Controls.Count -1 ;
            }
            
            if(nbIng > 0)
            {
                int[] ingredients = new int[nbIng];

                //On génére le dictionnaire
                int i = 0;
                foreach (Object l in grpRecap.Controls)
                {
                    if (l is Label)
                    {
                        if (((Label)l).Tag != null)
                        {
                            if (Int32.Parse(((Label)l).Tag.ToString()) != 0)
                            {
                                ingredients[i] = Int32.Parse(((Label)l).Tag.ToString());
                                i++;
                            }

                        }
                    }


                }
                Dictionary<String, int[]> dico = new Dictionary<String, int[]>(){
                { "Ingredients", ingredients},
            };

                //MessageBox.Show(ingredients[1].ToString());
                frmChoixCui frm = new frmChoixCui(dico);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sélectionnez au moins un ingrédient !");
            }

            

            
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            frmAvis frm2 = new frmAvis();
            frm2.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
