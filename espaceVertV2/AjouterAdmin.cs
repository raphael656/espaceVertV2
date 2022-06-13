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
    public partial class AjouterAdmin : Form
    {
        AdminGestion admnGestion = new AdminGestion();
        public AjouterAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(identifiantadmins.Text) || string.IsNullOrEmpty(passwordadmin.Text))
            {
                MessageBox.Show("Les champs ne sont pas tous remplis");
            }
            else
            {



                Models.Admin admin = new Models.Admin(identifiantadmins.Text, passwordadmin.Text);
                admnGestion.AddAdmin(admin);

                MessageBox.Show("votre Administrateur a bien été ajouté :)");

            }
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AjouterAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
