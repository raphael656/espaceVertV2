using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using espaceVertV2.Gestion;

namespace espaceVertV2
{
    public partial class Location : Form
    {
        LocationGestion LocationGestion = new LocationGestion();
        ClientGestion lientGestion = new ClientGestion();
        public Location()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                LocationGestion.DeleteLocation(id);

                dataGridView1.Rows.Clear();
                foreach (Models.Location location in LocationGestion.ToutLesLocation())
                {
                    Models.Client clientLocation = lientGestion.FindClientId(location.FaireClientIdclient);
                    dataGridView1.Rows.Add(location.Idlocation, clientLocation.Nomclient, location.Prixlocation, location.Datedebutlocation, location.Datefinlocation, "Supprimer", "modifier");
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "modifier")
            {
                int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                int code = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                string nomclient = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string prenomclient = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string adrclient = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string villeclient = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string emailclient = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                lientGestion.ModifierClients(id, nomclient, prenomclient, adrclient, villeclient, code, emailclient);


            }

        }

        private void Location_Load(object sender, EventArgs e)
        {
            foreach (Models.Location location in LocationGestion.ToutLesLocation())
            {

                Models.Client clientLocation = lientGestion.FindClientId(location.FaireClientIdclient);
                dataGridView1.Rows.Add(location.Idlocation, clientLocation.Nomclient, location.Prixlocation, location.Datedebutlocation, location.Datefinlocation);
          

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string nom = rechercelocation.Text;
            
          Models.Client client = lientGestion.FirstClientNom(nom);

           
                Models.Location location = LocationGestion.Findlocationidclient(client.Idclient);
                dataGridView1.Rows.Add(location.Idlocation, client.Nomclient, location.Prixlocation, location.Datedebutlocation, location.Datefinlocation);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjoutLocation f = new AjoutLocation();
            f.Show();
        }
    }
}
