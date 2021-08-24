using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recettes
{
    public partial class ficheRecette : UserControl
    {
        public ficheRecette(String titre, int prix, int temps, String image)
        {
            InitializeComponent();
            lblNomRecette.Text = titre;
            lblTemp.Text = temps.ToString() + " minutes";

            if (imgList.Images.ContainsKey(image))
            {
                picImage.Image = imgList.Images[image];
            }
            else
            {
                picImage.Image = imgList.Images["lama.png"];
            }
            


            //On affiche "Bon marché", "Prix moyen", "Assez cher" en fonction du code prix (1,2 ou 3)
            switch (prix)
            {
                case 1:
                    lblPrix.Text = "Bon marché";
                    break;
                case 2:
                    lblPrix.Text = "Prix moyen";
                    break;
                case 3:
                    lblPrix.Text = "Assez cher";
                    break;
                default:
                    lblPrix.Text = "Prix inconnu";
                    break;
            }

        }

        private void ficheRecette_Load(object sender, EventArgs e)
        {

        }
    }
}
