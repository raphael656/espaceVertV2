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
    public partial class pluschere : Form
    {
        ProduitGestion ProduitGestion = new ProduitGestion();
        public pluschere()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Models.Produit produit in ProduitGestion.TousLesProduits())
            {

            }

        }

        private void pluschere_Load(object sender, EventArgs e)
        {
            foreach (Models.Produit produit in ProduitGestion.TousLesProduits())
            {
                dataGridView1.Rows.Add(produit.Nomproduit);
                
            }

            }
    }
}
