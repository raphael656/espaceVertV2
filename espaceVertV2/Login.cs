using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using espaceVertV2.Gestion;
using System.Windows.Forms;
using espaceVertV2.Models;

namespace espaceVertV2
{
    public partial class Login : Form
    {

        public static bool Authentified = false;
         AdminGestion AdminsGestion = new AdminGestion();

        public Login()
        {
            InitializeComponent();
            //AdminGestion = new AdminGestion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Connecter(object sender, EventArgs e)
        {
            Admin admin = AdminsGestion.FindAdminIdentifiant(textidentifiant.Text);

          

            if (admin is null || admin.Password != textmotdepasse.Text)
            {
                MessageBox.Show("Identification incorrect");
                return;
            }
            else if (admin.Identifiant == textidentifiant.Text && admin.Password == textmotdepasse.Text)
            {
                Authentified = true;
                Close();
                
            }
            
        }

        private void Quitter(object sender, EventArgs e)
        {
           Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
