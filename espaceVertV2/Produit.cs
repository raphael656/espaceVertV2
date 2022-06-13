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
    public partial class Produit : Form
    {

        ProduitGestion ProduitGestion = new ProduitGestion();
        public Produit()
        {
            InitializeComponent();
        }

        private void Ajouterproduit(object sender, EventArgs e)
        {
            AjoutProduit f = new AjoutProduit();
            f.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Produit_Load(object sender, EventArgs e)
        {
            foreach (Models.Produit produit in ProduitGestion.TousLesProduits())
            {
               
                    dataGridView1.Rows.Add(produit.Idproduit, produit.Nomproduit,produit.Typeproduit,produit.Quantitetotalproduit,produit.Valeurproduit,produit.Quantitestockproduit,produit.Quantitelocationproduit,"Supprimer", "Modifier");

              

            }




        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                ProduitGestion.DeleteProduit(id);

                dataGridView1.Rows.Clear();
                foreach (Models.Produit produit in ProduitGestion.TousLesProduits())
                {

                    dataGridView1.Rows.Add(produit.Idproduit, produit.Nomproduit,produit.Typeproduit,produit.Quantitetotalproduit,produit.Valeurproduit,produit.Quantitestockproduit,produit.Quantitelocationproduit, "Supprimer", "Modifier");



                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "modifier")
            {
                int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                int valeur = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                string nomproduit = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string type = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string quantite = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                int stock = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                string location = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                ProduitGestion.ModifierProduit(id, nomproduit, type, quantite, valeur, stock, location);


            }



        }

        private void misejour(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchProd(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string nom = rechercheprod.Text;
            foreach (Models.Produit produit in ProduitGestion.FindProduitNom(nom))
            {

                dataGridView1.Rows.Add(produit.Idproduit, produit.Nomproduit, produit.Typeproduit, produit.Quantitetotalproduit, produit.Valeurproduit, produit.Quantitestockproduit, produit.Quantitelocationproduit, "Supprimer", "Modifier");


            }
        }
    }
}
