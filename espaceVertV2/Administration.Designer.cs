
namespace espaceVertV2
{
    partial class Administration
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idadmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identifiantadmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordadmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AjouterAdmin = new System.Windows.Forms.Button();
            this.rechercheNom = new System.Windows.Forms.TextBox();
            this.rechercheAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administration";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idadmin,
            this.identifiantadmin,
            this.passwordadmin,
            this.Supprimer,
            this.modifier});
            this.dataGridView1.Location = new System.Drawing.Point(161, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 539);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idadmin
            // 
            this.idadmin.HeaderText = "Id";
            this.idadmin.MinimumWidth = 10;
            this.idadmin.Name = "idadmin";
            this.idadmin.Width = 200;
            // 
            // identifiantadmin
            // 
            this.identifiantadmin.HeaderText = "Identifiant";
            this.identifiantadmin.MinimumWidth = 10;
            this.identifiantadmin.Name = "identifiantadmin";
            this.identifiantadmin.Width = 200;
            // 
            // passwordadmin
            // 
            this.passwordadmin.HeaderText = "Mot de passe";
            this.passwordadmin.MinimumWidth = 10;
            this.passwordadmin.Name = "passwordadmin";
            this.passwordadmin.Width = 250;
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
            // AjouterAdmin
            // 
            this.AjouterAdmin.Location = new System.Drawing.Point(1039, 795);
            this.AjouterAdmin.Name = "AjouterAdmin";
            this.AjouterAdmin.Size = new System.Drawing.Size(256, 46);
            this.AjouterAdmin.TabIndex = 14;
            this.AjouterAdmin.Text = "Ajouter";
            this.AjouterAdmin.UseVisualStyleBackColor = true;
            this.AjouterAdmin.Click += new System.EventHandler(this.AjouterAdmin_Click);
            // 
            // rechercheNom
            // 
            this.rechercheNom.Location = new System.Drawing.Point(464, 149);
            this.rechercheNom.Name = "rechercheNom";
            this.rechercheNom.Size = new System.Drawing.Size(485, 39);
            this.rechercheNom.TabIndex = 15;
            this.rechercheNom.Tag = "";
            // 
            // rechercheAdmin
            // 
            this.rechercheAdmin.Location = new System.Drawing.Point(1039, 142);
            this.rechercheAdmin.Name = "rechercheAdmin";
            this.rechercheAdmin.Size = new System.Drawing.Size(320, 46);
            this.rechercheAdmin.TabIndex = 16;
            this.rechercheAdmin.Text = "Rechercher";
            this.rechercheAdmin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(125, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rechercher l\' admin";
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 853);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rechercheAdmin);
            this.Controls.Add(this.rechercheNom);
            this.Controls.Add(this.AjouterAdmin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AjouterAdmin;
        private System.Windows.Forms.TextBox rechercheNom;
        private System.Windows.Forms.Button rechercheAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifiantadmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordadmin;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.DataGridViewButtonColumn modifier;
        private System.Windows.Forms.Label label2;
    }
}