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

namespace Form4_recette
{
    public partial class Entete : UserControl
    {
        string chcon = frmAccueil.chcon;
        OleDbConnection connec;
        public Entete()
        {
            InitializeComponent();
        }

        

        static int IdRecette;

        public Entete(int id)
        {
            InitializeComponent();
            IdRecette = id;
            
        }

        private void Entete_Load(object sender, EventArgs e)
        {
            connec = new OleDbConnection(chcon);
            connec.Open();

           
            string reqTitre = @"select description from Recettes where codeRecette = " + IdRecette.ToString() + ";";
            OleDbCommand cmdTitre = new OleDbCommand(reqTitre, connec); //execution de la requete
            string titre = cmdTitre.ExecuteScalar().ToString(); // recuperation de la requete
            lblTitre.Text = titre.ToString(); // Affichage resultat



            string reqTime = @"select tempsCuisson from Recettes where codeRecette = " + IdRecette.ToString() + ";";
            OleDbCommand cmdTime = new OleDbCommand(reqTime, connec);//execution de la requete
            string time = cmdTime.ExecuteScalar().ToString(); ; //récupère toute les infos de cmd
            lblTime.Text = time.ToString();


            string reqPers = @"select nbPersonnes from Recettes where codeRecette = " + IdRecette.ToString() + ";";
            OleDbCommand cmdPers = new OleDbCommand(reqPers, connec);//execution de la requete
            string pers = cmdPers.ExecuteScalar().ToString(); //récupère toute les infos de cmd
            lblPeople.Text = pers.ToString();

            string reqCout = @"select categPrix from Recettes where codeRecette = " + IdRecette.ToString() + ";";
            OleDbCommand cmdCout = new OleDbCommand(reqCout, connec);//execution de la requete
            string cout = cmdCout.ExecuteScalar().ToString(); //récupère toute les infos de cmd
            if(cout == "1")
            {
                lblCost.Text = "Bon marché";
            }
            else if(cout == "2")
            {
                lblCost.Text = "Coût moyen";
            }
            else
            {
                lblCost.Text = "Assez cher";
            }

            
            string reqImage = @"select imageDesc from Recettes where codeRecette = " + IdRecette.ToString() + ";";
            OleDbCommand cmdImage = new OleDbCommand(reqImage, connec);//execution de la requete
            string Imaged = cmdImage.ExecuteScalar().ToString(); //récupère toute les infos de cmd
            pibRece.Image = img.Images[Imaged];

            connec.Close();





        }
    }
}
