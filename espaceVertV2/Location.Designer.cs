
namespace espaceVertV2
{
    partial class Location
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rechercelocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idlocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prixlocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationdatedebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationdatedefin = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1132, 795);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rechercher location";
            // 
            // rechercelocation
            // 
            this.rechercelocation.Location = new System.Drawing.Point(440, 133);
            this.rechercelocation.Name = "rechercelocation";
            this.rechercelocation.Size = new System.Drawing.Size(485, 39);
            this.rechercelocation.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(984, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlocation,
            this.nomclient,
            this.Prixlocation,
            this.locationdatedebut,
            this.locationdatedefin,
            this.Supprimer,
            this.modifier});
            this.dataGridView1.Location = new System.Drawing.Point(32, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1377, 539);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idlocation
            // 
            this.idlocation.HeaderText = "Id";
            this.idlocation.MinimumWidth = 10;
            this.idlocation.Name = "idlocation";
            this.idlocation.Width = 200;
            // 
            // nomclient
            // 
            this.nomclient.HeaderText = "Nom client";
            this.nomclient.MinimumWidth = 10;
            this.nomclient.Name = "nomclient";
            this.nomclient.Width = 200;
            // 
            // Prixlocation
            // 
            this.Prixlocation.HeaderText = "Prix location";
            this.Prixlocation.MinimumWidth = 10;
            this.Prixlocation.Name = "Prixlocation";
            this.Prixlocation.Width = 200;
            // 
            // locationdatedebut
            // 
            this.locationdatedebut.HeaderText = "Date de début ";
            this.locationdatedebut.MinimumWidth = 10;
            this.locationdatedebut.Name = "locationdatedebut";
            this.locationdatedebut.Width = 200;
            // 
            // locationdatedefin
            // 
            this.locationdatedefin.HeaderText = "Date de fin";
            this.locationdatedefin.MinimumWidth = 10;
            this.locationdatedefin.Name = "locationdatedefin";
            this.locationdatedefin.Width = 200;
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
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 853);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rechercelocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Location";
            this.Text = "Location";
            this.Load += new System.EventHandler(this.Location_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rechercelocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prixlocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationdatedebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationdatedefin;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.DataGridViewButtonColumn modifier;
    }
}