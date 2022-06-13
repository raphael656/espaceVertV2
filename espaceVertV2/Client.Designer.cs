
namespace espaceVertV2
{
    partial class Client
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rechercheClient = new System.Windows.Forms.Button();
            this.rechercheNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepostalclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1439, 105);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client";
            // 
            // rechercheClient
            // 
            this.rechercheClient.Location = new System.Drawing.Point(1026, 136);
            this.rechercheClient.Name = "rechercheClient";
            this.rechercheClient.Size = new System.Drawing.Size(320, 46);
            this.rechercheClient.TabIndex = 2;
            this.rechercheClient.Text = "Rechercher";
            this.rechercheClient.UseVisualStyleBackColor = true;
            this.rechercheClient.Click += new System.EventHandler(this.rechercheClient_Click);
            // 
            // rechercheNom
            // 
            this.rechercheNom.Location = new System.Drawing.Point(484, 140);
            this.rechercheNom.Name = "rechercheNom";
            this.rechercheNom.Size = new System.Drawing.Size(485, 39);
            this.rechercheNom.TabIndex = 3;
            this.rechercheNom.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(185, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rechercher le client";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1090, 795);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Ajouterclient);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprod,
            this.nomclient,
            this.prenomclient,
            this.adrclient,
            this.villeclient,
            this.codepostalclient,
            this.emailclient,
            this.Supprimer,
            this.modifier});
            this.dataGridView1.Location = new System.Drawing.Point(23, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1377, 539);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idprod
            // 
            this.idprod.HeaderText = "Id";
            this.idprod.MinimumWidth = 10;
            this.idprod.Name = "idprod";
            this.idprod.Width = 200;
            // 
            // nomclient
            // 
            this.nomclient.HeaderText = "Nom";
            this.nomclient.MinimumWidth = 10;
            this.nomclient.Name = "nomclient";
            this.nomclient.Width = 200;
            // 
            // prenomclient
            // 
            this.prenomclient.HeaderText = "Prenom";
            this.prenomclient.MinimumWidth = 10;
            this.prenomclient.Name = "prenomclient";
            this.prenomclient.Width = 200;
            // 
            // adrclient
            // 
            this.adrclient.HeaderText = "Adresse";
            this.adrclient.MinimumWidth = 10;
            this.adrclient.Name = "adrclient";
            this.adrclient.Width = 200;
            // 
            // villeclient
            // 
            this.villeclient.HeaderText = "Ville";
            this.villeclient.MinimumWidth = 10;
            this.villeclient.Name = "villeclient";
            this.villeclient.Width = 200;
            // 
            // codepostalclient
            // 
            this.codepostalclient.HeaderText = "Code postal";
            this.codepostalclient.MinimumWidth = 10;
            this.codepostalclient.Name = "codepostalclient";
            this.codepostalclient.Width = 200;
            // 
            // emailclient
            // 
            this.emailclient.HeaderText = "Email";
            this.emailclient.MinimumWidth = 10;
            this.emailclient.Name = "emailclient";
            this.emailclient.Width = 200;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.MinimumWidth = 10;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Width = 200;
            // 
            // modifier
            // 
            this.modifier.HeaderText = "Modifier";
            this.modifier.MinimumWidth = 10;
            this.modifier.Name = "modifier";
            this.modifier.Width = 200;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1439, 853);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rechercheNom);
            this.Controls.Add(this.rechercheClient);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rechercheClient;
        private System.Windows.Forms.TextBox rechercheNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepostalclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailclient;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.DataGridViewButtonColumn modifier;
    }
}