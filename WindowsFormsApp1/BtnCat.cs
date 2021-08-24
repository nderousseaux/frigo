using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class BtnCat : UserControl
    {
        public BtnCat()
        {
            InitializeComponent();
        }
        frmAccueil from;
        
        //constructeur
        public BtnCat(string nom, GroupBox gpb, GroupBox grp, string tag, frmAccueil frm)
        {
            InitializeComponent();
            btnSelec.Text = nom;
            grpChoix = gpb;
            grpRecap = grp;
            btnSelec.Tag = tag;
            from = frm;
        }


        OleDbConnection connec = new OleDbConnection(frmAccueil.chcon);
        DataSet dsLocal = new DataSet();

        // initialisation d'objet utilisé dans le code
        Label l1 = new Label();
        
        GroupBox grpChoix = new GroupBox(); // là ou se trouverons les checkbox
        GroupBox grpRecap = new GroupBox(); // là ou seront les labels qui récapitules les ingrédients

        private void BtnCat_Load(object sender, EventArgs e)
        {
            try
            {
                connec.Open();
                DataTable schemaTable = connec.GetOleDbSchemaTable(
                OleDbSchemaGuid.Tables,new object[] { null, null, null, "TABLE" });

                 foreach (DataRow r in schemaTable.Rows)
                 {
                    string nomTable = r[2].ToString();
                    string recup = @"select * from [" + nomTable + "]";

                        //execution de la requete
                        OleDbCommand cd = new OleDbCommand(recup, connec);
                        OleDbDataAdapter da = new OleDbDataAdapter(cd);
                        da.Fill(dsLocal, nomTable);
                    }

                }
            catch (Exception ex) //pour les operateurs et les requetes
            {
                MessageBox.Show(ex.Message);
            }
            
            finally
            {
                connec.Close();
            }

        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            grpChoix.Visible = true;
            grpRecap.Visible = true;
            
            grpChoix.ForeColor = Color.White;
            if (grpChoix.Text == "")
            {
                grpChoix.Text = btnSelec.Text;
            }
            else
            {
                grpChoix.Text = "";
                grpChoix.Text = btnSelec.Text;
            }
           
            int bordGauche = 20;
            int bordHaut = 20;
            int compteur = 0;

            grpChoix.Controls.Clear();

            //récupère les ingredient a partir du tag du bouton clique et les places dans des checkbox
            foreach (DataRow r in dsLocal.Tables["Ingrédients"].Rows)
            {
                if (btnSelec.Tag.ToString() == r[2].ToString())
                {
                    CheckBox c = new CheckBox();

                    c.Tag = r[0].ToString();
                    c.AutoSize = true;
                    c.Left = bordGauche;
                    c.Top = bordHaut + 5;
                    c.Text = r[1].ToString();
                    c.ForeColor = Color.Red;
                    c.Click += new EventHandler(CheckBox_Click);
                    grpChoix.Controls.Add(c);
                    compteur++;
                    bordGauche += 180;
                    
                    if (compteur > 2) // on ne veut pas plus de 3 checkbox par ligne
                    {
                        bordGauche = 20;
                        bordHaut = bordHaut + c.Height + 5;
                        compteur = 0;
                    }
                    if (c.Checked == false) // si rien n'est selectionnee un label apparaît
                    {
                        l1.Text = "Vous n'avez rien sélectionné";
                        l1.Location = new System.Drawing.Point(50, 45);
                        l1.AutoSize = true;
                        l1.Visible = true;
                        l1.ForeColor = Color.Red;
                        grpRecap.Controls.Add(l1);
                    }
                }
            }
        }

        int y = 65;
        int compteur = 0; // compte le nb de checkbox sur une ligne
        
        private void CheckBox_Click(object sender, EventArgs e)
        {
            //grpRecap.Controls.Clear();
            Label l1r = new Label();
            if (compteur < 3) //on ne veut pas plus de 3 checkbox selectionnees
            {
                
                if (((CheckBox)sender).Checked)
                {

                    l1.Visible = false;
                    
                    //recapitule sous forme de label le texte des checkbox selectionnées
                    grpRecap.Controls.Add(l1r);
                    l1r.Text = ((CheckBox)sender).Text;
                    l1r.Tag = ((CheckBox)sender).Tag.ToString() ;
                    
                    l1r.Location = new System.Drawing.Point(50, y);
                    l1r.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    l1r.AutoSize = true;
                    l1r.Visible = true;
                    l1r.ForeColor = Color.Red;
                    grpRecap.Controls.Add(l1r);
                    y += 25;
                    compteur++;

                    //creation du bouton de réinitialisation des ingredients selectionnees
                    Button btnReinit = new Button();
                    btnReinit.Location = new System.Drawing.Point(440, 150);
                    btnReinit.AutoSize = true;
                    btnReinit.Text = "Reinitialiser";
                    grpRecap.Controls.Add(btnReinit);
                    btnReinit.Click += new EventHandler(ButtonReinit_Click);
                }
            }
            else
            {
                //si plus de 3 ingrédients sont selectionner, le 4e checkbox est decocher et un message d'erreur est affiche
                ((CheckBox)sender).Checked = false;
                MessageBox.Show("Vous ne pouvez sélectionner que 3 ingrédients maximum.");
                MessageBox.Show("Veuillez cliquer sur réinitialiser pour pouvoir choisir d'autre ingrédients sinon vous pouvez passer à la suite");
            }
        }

        private void ButtonReinit_Click(object sender, EventArgs e)
        {
            foreach(CheckBox c in grpChoix.Controls)
            {
                if (c.Checked == true)
                {


                    l1.Text = "Vous n'avez aucun ingréients de sélectionné !";

                    l1.Location = new System.Drawing.Point(50, 45);
                    l1.AutoSize = true;
                    l1.Visible = true;
                    l1.ForeColor = Color.Red;
                    grpRecap.Controls.Add(l1);

                    c.Checked = false;
                    compteur = 0;
                    y = 65;
                }

            }
            grpRecap.Controls.Clear();
            from.Refresh();

        }
        

    }
 
}
