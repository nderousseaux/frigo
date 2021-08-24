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




namespace Recettes
{
    public partial class frmRecettes : Form
    {
        public frmRecettes()
        {
            InitializeComponent();
        }

        //Temporaire : dictionnaire recu par le formulaire père
        static int[] ingredients = { 8 };
        static int[] typeDePlat = { };
        static int[] typeDeCuisine = { };
        static int[] budget = { };
        static int[] tmpCuisson = { 120 };
        static int[] IdRecette = { 7};

        IDictionary<String, int[]> dico = new Dictionary<String, int[]>(){
                { "Ingredients", ingredients},
                { "TypeDePlat",  typeDePlat},
                { "TypeDeCuisine", typeDeCuisine},
                { "Budget", budget },
                {"TmpCuisson", tmpCuisson },
                {"IdRecette", IdRecette }
            };

        OleDbConnection connec = new OleDbConnection();
        string chcon = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:/Users/natha/Google Drive/D21_projet/Fichier projet/baseFrigo1.mdb";

        

        private void frmRecettes_Load(object sender, EventArgs e)
        {
            
           


            //On crée la requete sql 

            //On crée la partie ingrédients
            String requeteIngredient = "";
            foreach (int ingredient in dico["Ingredients"])
            {
                requeteIngredient += "AND r.codeRecette IN (SELECT codeRecette FROM [IngrédientsRecette] WHERE codeIngredient = " + ingredient + ") ";
            }

            //On crée la partie type de cuisine
            String requeteCuisine = "";
            foreach (int cuisine in dico["TypeDeCuisine"])
            {
                requeteCuisine += "AND r.codeRecette IN (SELECT codeRecette FROM [CatégoriesRecette] WHERE codeCategorie = " + cuisine + ") ";
            }

            //On crée la partie type de plat
            String requetePlat = "";
            foreach (int plat in dico["TypeDePlat"])
            {
                requetePlat += "AND r.codeRecette IN (SELECT codeRecette FROM [CatégoriesRecette] WHERE codeCategorie = " + plat + ") ";
            }

            String requete = "" +
                "SELECT DISTINCT r.description, r.tempsCuisson, r.imageDesc, r.categPrix " +
                "FROM Recettes r, [IngrédientsRecette] ir, [CatégoriesRecette] cr " +
                "WHERE r.CodeRecette = ir.CodeRecette " +
                "AND r.CodeRecette = cr.CodeRecette " +
                requeteIngredient +
                requeteCuisine +
                requetePlat +
                "AND r.tempsCuisson <= " + tmpCuisson[0]+ ";";

           

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
                //On crée une nouvelle instance de recette
                while (reader.Read())
                {
                    //On crée l'user control
                    ficheRecette fiche = new ficheRecette(reader.GetString(0), reader.GetInt32(3), reader.GetInt32(1), reader.GetString(2));
                    fiche.Location = new System.Drawing.Point(0, y);
                    pan1.Controls.Add(fiche);

                    //On crée les deux boutons
                    PictureBox picRecetteComplete = new PictureBox();
                    picRecetteComplete.Location = new System.Drawing.Point(645, y+65);
                    picRecetteComplete.Size = new System.Drawing.Size(50, 50);
                    picRecetteComplete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picRecetteComplete.Image = global::Recettes.Properties.Resources.voirLoupe;
                    pan1.Controls.Add(picRecetteComplete);

                    PictureBox picRecette = new PictureBox();
                    picRecette.Location = new System.Drawing.Point(700, y + 65);
                    picRecette.Size = new System.Drawing.Size(50, 50);
                    picRecette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picRecette.Image = global::Recettes.Properties.Resources.ampoule;
                    pan1.Controls.Add(picRecette);

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

        
    }
}
