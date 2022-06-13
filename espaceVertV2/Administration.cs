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
    public partial class Administration : Form
    {
        AdminGestion dminGestion = new AdminGestion();
        public Administration()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                dminGestion.DeleteAdmin(id);

                dataGridView1.Rows.Clear();
                foreach (Models.Admin admin in dminGestion.TousLesAdmin())
                {

                    dataGridView1.Rows.Add(admin.Idadmin, admin.Identifiant, admin.Password, "Supprimer", "Modifier");


                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "modifier")
            {
                int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                string nomclient = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string prenomclient = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


                dminGestion.ModifierProduit(id, nomclient, prenomclient);


            }
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            foreach (Models.Admin admin in dminGestion.TousLesAdmin())
            {

                dataGridView1.Rows.Add(admin.Idadmin, admin.Identifiant, admin.Password, "Supprimer", "Modifier");


            }
        }

        private void AjouterAdmin_Click(object sender, EventArgs e)
        {
            AjouterAdmin f = new AjouterAdmin();
            f.Show();
        }
    }
}
