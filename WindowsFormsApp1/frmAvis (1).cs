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

namespace avis
{
    public partial class frmA : Form
    {
        
        string chcon = frmAccueil.chcon;
        OleDbConnection connec;
        public frmA()
        {
            
            InitializeComponent();
        }
        
        DataSet ds = new DataSet();

        Bitmap NB = new Bitmap(@"../../casseroleB.jpg");
        Bitmap CO = new Bitmap(@"../../imageNB.jpg");
        int note = 1;



        private void frmAvis_Load(object sender, EventArgs e)
        {
            connec = new OleDbConnection(chcon);

            foreach (PictureBox pib in grpNote.Controls)
            {
                pib.Image = NB;
            }

            Table();
            try
            {

                connec.Open();
                DataTable schemaTable = connec.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });
                
                foreach (DataRow r in schemaTable.Rows)
                {
                    string nomTable = r[2].ToString();
                    string recup = @"select * from [" + nomTable + "]";
                    OleDbCommand cd = new OleDbCommand(recup, connec);
                    OleDbDataAdapter da = new OleDbDataAdapter(cd);
                    da.Fill(ds, nomTable);
                    
                }
                connec.Close();

                

                foreach (DataRow r in ds.Tables["Recettes"].Rows)
                {
                    string select = r[1].ToString();
                    cboChoix.Items.Add(select);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connec.Close();
        }

        private void txtPseudo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == ',') || ((char.IsPunctuation(e.KeyChar) && (txtPseudo.Text.Length == 0))))
            {
                e.Handled = true;
            }

            txtPseudo.MaxLength = 10;
            
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {



            try {
                if (cboChoix.Text != string.Empty && note != 0)
                {
                    dataGrid1.Visible = true;

                    DataRow dr;
                    dr = ds.Tables["tblAvis"].NewRow();

                    dr["Recette"] = cboChoix.Text;
                    dr["Pseudo"] = txtPseudo.Text;
                    dr["Date"] = System.DateTime.Now;
                    dr["note"] = note;
                    dr["Avis"] = txtAvis.Text;

                    ds.Tables["tblAvis"].Rows.Add(dr);
                }
                else
                {
                    MessageBox.Show("Vous devez séléctionner un plat");

                }
            }
            catch
            {
                MessageBox.Show("Vous avez déja noté ce plat !");
            }
            
            
            
        }

        private void pibCass1_Click(object sender, EventArgs e)
        {

            PictureBox p = (PictureBox)sender;
            int tagP = Convert.ToInt32(p.Tag);
            

            foreach(PictureBox pib in grpNote.Controls)
            {
                int tagePib = Convert.ToInt32(pib.Tag);
                if(tagePib <= tagP)
                {
                    pib.Image = CO;
                }
                else
                {
                    pib.Image = NB;
                }
            }
            
            note = int.Parse((((PictureBox)sender).Tag.ToString()));

        }

        public void Table()
        {
            DataTable tblAvis = ds.Tables.Add("tblAvis");
            DataColumn avis =
            tblAvis.Columns.Add("Recette", typeof(string));
            tblAvis.Columns.Add("Pseudo", typeof(string));
            tblAvis.Columns.Add("Date", typeof(DateTime));
            tblAvis.Columns.Add("Note", typeof(Int32));
            tblAvis.Columns.Add("Avis", typeof(string));
            tblAvis.PrimaryKey = new DataColumn[] { avis };
            DataView view = new DataView(tblAvis);
            dataGrid1.DataSource = view;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

