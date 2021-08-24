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
using WindowsFormsApp1;

namespace FormEtape_Etape
{
    public partial class Affichage : UserControl
    {
        string chcon = frmAccueil.chcon;
        OleDbConnection connec;
        


        public Affichage()
        {
            InitializeComponent();
        }

        static int IdRecette;

        public Affichage(int id)
        {
            InitializeComponent();
            IdRecette = id;
        }

        private void lblPara_Click(object sender, EventArgs e)
        {

        }

        private void Affichage_Load(object sender, EventArgs e)
        {
            connec = new OleDbConnection(chcon);
            connec.Open();

            string reqEtape = @"select texteEtape from EtapesRecette where codeRecette =" + IdRecette + "and numEtape = " + frmEtape.numEtape + ";";
            OleDbCommand cmdEtape = new OleDbCommand(reqEtape, connec);
            string etape = cmdEtape.ExecuteScalar().ToString();
            lblPara.Text = etape;

            string reqImage = @"select imageEtape from EtapesRecette where codeRecette =" + IdRecette + "and numEtape = " + frmEtape.numEtape + ";";
            OleDbCommand cmdImage = new OleDbCommand(reqImage, connec);
            string imaged = cmdImage.ExecuteScalar().ToString();


            if (img.Images.ContainsKey(imaged))
            {
                pibImage.BackgroundImage = img.Images[imaged];
            }
            else
            {
                pibImage.BackgroundImage = img.Images["lama.png"];
            }
             
             
        }
    }
            
        
    }
    

