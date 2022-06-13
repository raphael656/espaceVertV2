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
    public partial class AjoutClient : Form
    {
        ClientGestion ClientGestion = new ClientGestion();
        public AjoutClient()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AjoutClient_Load(object sender, EventArgs e)
        {

        }

        private void ajoutNouveauClient(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomclientajout.Text) || string.IsNullOrEmpty(prenomclientajout.Text))
            {
                MessageBox.Show("Les champs ne sont pas tous remplis");
            }
            else
            {
                int codepostal = Int32.Parse(codepostalclientajout.Text);
                Models.Client client = new Models.Client(nomclientajout.Text, prenomclientajout.Text, adresseclientajout.Text, villeclientajout.Text, codepostal, emailclientajout.Text);
                ClientGestion.AddClient(client);

                MessageBox.Show("votre client a bien été ajouté :)");

            }
        }

        private void annulerAjout(object sender, EventArgs e)
        {
            Close();
        }
    }
}
