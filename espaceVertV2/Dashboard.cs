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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadform(new ContenuDashboard());
        }
        public void loadform(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void dashboard(object sender, EventArgs e)
        {
            loadform(new ContenuDashboard());
        }

        private void produitdash(object sender, EventArgs e)
        {
            loadform(new Produit());
        }

        private void clientdash(object sender, EventArgs e)
        {
            loadform(new Client());
        }

        private void location_Click(object sender, EventArgs e)
        {
            loadform(new Location());
        }



        private void adminModif(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Administratio(object sender, EventArgs e)
        {
            loadform(new Administration());
        }
    }
}
