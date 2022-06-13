
namespace espaceVertV2
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dashboar = new System.Windows.Forms.Button();
            this.aide = new System.Windows.Forms.Button();
            this.location = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.Button();
            this.produit = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.Administrer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1814, 101);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Espace Vert";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Administrer);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Dashboar);
            this.panel2.Controls.Add(this.aide);
            this.panel2.Controls.Add(this.location);
            this.panel2.Controls.Add(this.client);
            this.panel2.Controls.Add(this.produit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.ForeColor = System.Drawing.Color.FloralWhite;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 865);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(332, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1480, 863);
            this.panel3.TabIndex = 2;
            // 
            // Dashboar
            // 
            this.Dashboar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Dashboar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dashboar.Location = new System.Drawing.Point(-2, -2);
            this.Dashboar.Name = "Dashboar";
            this.Dashboar.Size = new System.Drawing.Size(338, 113);
            this.Dashboar.TabIndex = 7;
            this.Dashboar.Text = "Dashboard";
            this.Dashboar.UseVisualStyleBackColor = false;
            this.Dashboar.Click += new System.EventHandler(this.dashboard);
            // 
            // aide
            // 
            this.aide.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.aide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aide.Location = new System.Drawing.Point(-2, 529);
            this.aide.Name = "aide";
            this.aide.Size = new System.Drawing.Size(338, 113);
            this.aide.TabIndex = 5;
            this.aide.Text = "Aide";
            this.aide.UseVisualStyleBackColor = false;
            // 
            // location
            // 
            this.location.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.location.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.location.Location = new System.Drawing.Point(-2, 315);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(338, 113);
            this.location.TabIndex = 4;
            this.location.Text = "Location";
            this.location.UseVisualStyleBackColor = false;
            this.location.Click += new System.EventHandler(this.location_Click);
            // 
            // client
            // 
            this.client.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.client.Location = new System.Drawing.Point(-2, 206);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(338, 113);
            this.client.TabIndex = 3;
            this.client.Text = "Client";
            this.client.UseVisualStyleBackColor = false;
            this.client.Click += new System.EventHandler(this.clientdash);
            // 
            // produit
            // 
            this.produit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.produit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produit.Location = new System.Drawing.Point(-2, 97);
            this.produit.Name = "produit";
            this.produit.Size = new System.Drawing.Size(338, 113);
            this.produit.TabIndex = 2;
            this.produit.Text = "Produit";
            this.produit.UseVisualStyleBackColor = false;
            this.produit.Click += new System.EventHandler(this.produitdash);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(338, 101);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1476, 865);
            this.panelMain.TabIndex = 2;
            this.panelMain.Click += new System.EventHandler(this.dashboard);
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // Administrer
            // 
            this.Administrer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Administrer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Administrer.Location = new System.Drawing.Point(-2, 424);
            this.Administrer.Name = "Administrer";
            this.Administrer.Size = new System.Drawing.Size(338, 113);
            this.Administrer.TabIndex = 8;
            this.Administrer.Text = "Admin";
            this.Administrer.UseVisualStyleBackColor = false;
            this.Administrer.Click += new System.EventHandler(this.Administratio);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 966);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1840, 1037);
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Dashboar;
        private System.Windows.Forms.Button aide;
        private System.Windows.Forms.Button location;
        private System.Windows.Forms.Button client;
        private System.Windows.Forms.Button produit;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button adminmodif;
        private System.Windows.Forms.Button Administrer;
    }
}