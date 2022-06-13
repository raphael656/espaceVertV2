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
    public partial class Client : Form
    {
        ClientGestion ClientGestion = new ClientGestion();
        public Client()
        {
            InitializeComponent();
        }


        private void Client_Load(object sender, EventArgs e)
        {
            foreach (Models.Client client in ClientGestion.TousLesClient())
            {

                dataGridView1.Rows.Add(client.Idclient, client.Nomclient, client.Prenomclient, client.Adresseclient, client.Villeclient, client.Codepostalclient, client.Emailclient, "Supprimer", "Modifier");



            }
            
        }

        private void Ajouterclient(object sender, EventArgs e)
        {
            AjoutClient f = new AjoutClient();
            f.Show();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Supprimer") { 
                int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                ClientGestion.DeleteClient(id);

                dataGridView1.Rows.Clear();
                foreach (Models.Client client in ClientGestion.TousLesClient())
                {

                    dataGridView1.Rows.Add(client.Idclient, client.Nomclient, client.Prenomclient, client.Adresseclient, client.Villeclient, client.Codepostalclient, client.Emailclient, "Supprimer", "Modifier");



                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "modifier")
            {
                int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                int code = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
              string  nomclient = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
               string prenomclient = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
               string adrclient = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
               string villeclient = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
               string emailclient = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                ClientGestion.ModifierClients(id, nomclient, prenomclient, adrclient, villeclient, code, emailclient);

               
            }   




        }

        private void rechercheClient_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            string nom = rechercheNom.Text;
            foreach (Models.Client client in ClientGestion.FindClientNom(nom))
            {

                dataGridView1.Rows.Add(client.Idclient, client.Nomclient, client.Prenomclient, client.Adresseclient, client.Villeclient, client.Codepostalclient, client.Emailclient, "Supprimer", "Modifier");


            }
        }
    }
}
