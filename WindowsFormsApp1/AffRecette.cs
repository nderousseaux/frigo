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

namespace Form4_recette
{
    public partial class AffRecette : UserControl
    {
        public AffRecette()
        {
            InitializeComponent();
        }

        OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= C:\Users\Emilie\Desktop\DUT\S2\D21\Fichier projet\baseFrigov2000.mdb");


        public AffRecette(string numEt, string txtEt, string image)
        {
            InitializeComponent();
            this.lblNumEt.Text = "Etape : " + numEt;
            this.lblpara.Text = txtEt;
            
            if (img.Images.ContainsKey(image))
            {
                pibEtape.Image = img.Images[image];
            }
            else
            {
                pibEtape.Image = img.Images["lama.png"];
            }
        }

        private void AffRecette_Load(object sender, EventArgs e)
        {
            

           
            

        }
    }
}
