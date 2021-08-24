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
using Recettes;

namespace typeRecette
{
    public partial class frmChoixCui : Form
    {
        public frmChoixCui()
        {
            InitializeComponent();
        }


        Dictionary<String, int[]> dico;
        public frmChoixCui(Dictionary<String, int[]> dico)
        {
            InitializeComponent();
            this.dico = dico;
            
        }

        OleDbConnection connec = new OleDbConnection();
        //Appel de la variable globale
        string chcon = frmAccueil.chcon;

        //variable global
        DataSet dsLocale = new DataSet();

        int compteur = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. ouvrir la connexion
            connec.ConnectionString = chcon;
            connec.Open();

            // 2. Appel de oled...
            DataTable schemaTable = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            // 3. Parcours de cette table
            string req;
            for (int i = 0; i < schemaTable.Rows.Count; i++)
            {
                string nomTable = schemaTable.Rows[i][2].ToString();
                req = "select * from [" + nomTable +"]";

                //parametrage de l'objet commande
                OleDbCommand cd = new OleDbCommand(req, connec);
                OleDbDataAdapter da = new OleDbDataAdapter(cd);
                da.Fill(dsLocale, nomTable);
            }
           
            //Fermeture de la connection
            connec.Close();

            //initialisation de x et y pour la position
            int y = 50;
            int x = 20;

            //remplissage du grbPlat avec des radiobutton
            for(int i = 0; i<dsLocale.Tables["Catégories"].Rows.Count; i++)
            {

                if (compteur < 3)
                {
                    RadioButton rb = new RadioButton();
                    rb.Location = new System.Drawing.Point(x, y);
                    rb.Text = dsLocale.Tables["Catégories"].Rows[i]["libCategorie"].ToString(); // le texte du rb est le nom de la catégorie
                    rb.Tag = dsLocale.Tables["Catégories"].Rows[i]["CodeCategorie"]; //le tag de chaque rb est le code de la catégorie
                    rb.AutoSize = true;
                    grbPlat.Controls.Add(rb); // on ajoute les rb au groupBox des plats
                    x += 150;
                    compteur++;
                }
                else
                {
                    RadioButton rb = new RadioButton();
                    rb.Location = new System.Drawing.Point(x, y);
                    rb.Text = dsLocale.Tables["Catégories"].Rows[i]["libCategorie"].ToString();
                    rb.Tag = dsLocale.Tables["Catégories"].Rows[i]["CodeCategorie"];
                    rb.AutoSize = true;
                    grbPlat.Controls.Add(rb);
                    x = 20;
                    y += 35;
                    compteur = 0;
                }
                
            }
            
        }

        private void btnPageSuivante_Click(object sender, EventArgs e)
        {

            //On incrémente le dico
            
            int[] ingredients = new int[dico["Ingredients"].Length];
            int i = 0;
            foreach (int j in dico["Ingredients"])
            {
                ingredients[i] = j;
                i++;
                
            }


            Dictionary<String, int[]> dicoNouv = new Dictionary<String, int[]>(){
                { "Ingredients", ingredients},
            };


            //Type de plat
            int typeDePlat;
            bool selectionPlat = false;
            foreach(RadioButton r in grbPlat.Controls)
            {
                if (r.Checked)
                {
                    selectionPlat = true;
                    typeDePlat = Int32.Parse(r.Tag.ToString());
                    dicoNouv.Add("TypeDePlat", new int[1] { typeDePlat });
                } 
            }
            if (!selectionPlat)
            {
                { dicoNouv.Add("TypeDePlat", new int[0]); }
            }

            //Budget
            int budget;
            bool selectionBudget = false;
            foreach (RadioButton r in grpBudget.Controls)
            {
                if (r.Checked)
                {
                    selectionBudget = true;
                    budget = Int32.Parse(r.Tag.ToString());
                    dicoNouv.Add("Budget", new int[1] { budget });
                }
            }
            if (!selectionBudget)
            {
                dicoNouv.Add("Budget", new int[0]);
            }

            //Cuisson
            int cuisson;
            bool selectionCuisson = false;

            if(txtTemps.Text != String.Empty)
            {
                selectionCuisson = true;
                cuisson = Int32.Parse(txtTemps.Text);
                dicoNouv.Add("TmpCuisson", new int[1] { cuisson });
            }
            else { dicoNouv.Add("TmpCuisson", new int[0]); }

            if(!selectionCuisson || !selectionBudget || !selectionPlat)
            {
                MessageBox.Show("Attention : Certains champs n'ont pas été remplit. \n La recherche ne prendra donc pas en compte le filtre que vous avez omis.");
            }

            frmRecettes frm = new frmRecettes(dicoNouv);
            frm.ShowDialog();
        }

        private void txtTemps_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void txtTemps_KeyPress(object sender, KeyPressEventArgs e)
        {
            // On interdit tout les caractère qui ne sont pas des chiffres
            if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.Enter) || (char.IsPunctuation(e.KeyChar)) || (e.KeyChar == '+') || (e.KeyChar == '=') || (e.KeyChar == '^') || (e.KeyChar == '$'))
            {
                e.Handled = true;
            }

            // On intialise la longueur max que la textbox peut accueillir
            txtTemps.MaxLength = 3;

        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
