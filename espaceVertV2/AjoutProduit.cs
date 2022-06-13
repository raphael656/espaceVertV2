using espaceVertV2.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace espaceVertV2
{
    public partial class AjoutProduit : Form
    {
        ProduitGestion ProduitGestion = new ProduitGestion();
        public AjoutProduit()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AjoutProduits(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomproduit.Text))
            {
                MessageBox.Show("Les champs ne sont pas tous remplis");
            }
            else
            {

                int valeur = Int32.Parse(Valeur.Text);
                
                Models.Produit produit = new Models.Produit(nomproduit.Text, Quantite.Text, Type.Text, valeur, Int32.Parse(Stock.Text), Location.Text);
                ProduitGestion.AddProduit(produit);

                MessageBox.Show("votre client a bien été ajouté :)");

            }
        }

        private void AnnulerProduit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
