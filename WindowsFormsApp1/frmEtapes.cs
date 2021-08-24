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

namespace FormEtape_Etape
{
    public partial class frmEtape : Form
    {
        OleDbConnection connec;
        public static int IdRecette;
        public frmEtape(int id)
        {
            IdRecette = id;
            
            InitializeComponent();
        }

        

        
        
        public static int nbEtapes; //nb d'etape total
        public static int numEtape = 1; //etape initialise automatiquement a 1

        private void FrmEtape_Load(object sender, EventArgs e)
        {
            string chcon = frmAccueil.chcon;
            OleDbConnection connec = new OleDbConnection(chcon);
            connec.Open();
            string reqNbSteps = @"SELECT count(numEtape) FROM EtapesRecette WHERE codeRecette = " + IdRecette; // on recupere le nombre d'etape de la recette
            OleDbCommand cmd = new OleDbCommand(reqNbSteps, connec);
            nbEtapes = int.Parse(cmd.ExecuteScalar().ToString());
            lblEtape.Text = "Etape " + numEtape.ToString() + " sur " + nbEtapes; 

            Affichage Etape = new Affichage(IdRecette); //usercontrol
            panel1.Controls.Add(Etape);
            connec.Close();

        }

        private void btnNextEt_Click(object sender, EventArgs e)
        {
            if(numEtape != nbEtapes) 
            {
                panel1.Controls.Clear();
                numEtape += 1;
                lblEtape.Text = "Etape " + numEtape.ToString() + " sur " + nbEtapes;
                Affichage Etape = new Affichage(IdRecette);
                panel1.Controls.Add(Etape);
            }
        }

        private void btnLastEt_Click(object sender, EventArgs e)
        {
            if (numEtape !=  1)
            {
                panel1.Controls.Clear();
                numEtape -= 1;
                lblEtape.Text = "Etape " + numEtape.ToString() + " sur " + nbEtapes;
                Affichage Etape = new Affichage(IdRecette);
                panel1.Controls.Add(Etape);
            }
        }

        private void btnNextFrm_Click(object sender, EventArgs e)
        {

        }

        private void btnLastFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
