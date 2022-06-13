
namespace espaceVertV2
{
    partial class Produit
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
            this.recherche = new System.Windows.Forms.Button();
            this.rechercheprod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valeurprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produit";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1132, 795);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Ajouterproduit);
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(1037, 143);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(320, 46);
            this.recherche.TabIndex = 7;
            this.recherche.Text = "Rechercher";
            this.recherche.UseVisualStyleBackColor = true;
            this.recherche.Click += new System.EventHandler(this.searchProd);
            // 
            // rechercheprod
            // 
            this.rechercheprod.Location = new System.Drawing.Point(443, 147);
            this.rechercheprod.Name = "rechercheprod";
            this.rechercheprod.Size = new System.Drawing.Size(485, 39);
            this.rechercheprod.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rechercher le produit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprod,
            this.nomprod,
            this.typeprod,
            this.quantiteprod,
            this.valeurprod,
            this.stockname,
            this.locationprod,
            this.Supprimer,
            this.modifier});
            this.dataGridView1.Location = new System.Drawing.Point(23, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1377, 539);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.misejour);
            // 
            // idprod
            // 
            this.idprod.HeaderText = "Id";
            this.idprod.MinimumWidth = 10;
            this.idprod.Name = "idprod";
            this.idprod.Width = 200;
            // 
            // nomprod
            // 
            this.nomprod.HeaderText = "Produit";
            this.nomprod.MinimumWidth = 10;
            this.nomprod.Name = "nomprod";
            this.nomprod.Width = 200;
            // 
            // typeprod
            // 
            this.typeprod.HeaderText = "Type";
            this.typeprod.MinimumWidth = 10;
            this.typeprod.Name = "typeprod";
            this.typeprod.Width = 200;
            // 
            // quantiteprod
            // 
            this.quantiteprod.HeaderText = "Quantité";
            this.quantiteprod.MinimumWidth = 10;
            this.quantiteprod.Name = "quantiteprod";
            this.quantiteprod.Width = 200;
            // 
            // valeurprod
            // 
            this.valeurprod.HeaderText = "Prix";
            this.valeurprod.MinimumWidth = 10;
            this.valeurprod.Name = "valeurprod";
            this.valeurprod.Width = 200;
            // 
            // stockname
            // 
            this.stockname.HeaderText = "Stock";
            this.stockname.MinimumWidth = 10;
            this.stockname.Name = "stockname";
            this.stockname.Width = 200;
            // 
            // locationprod
            // 
            this.locationprod.HeaderText = "Location";
            this.locationprod.MinimumWidth = 10;
            this.locationprod.Name = "locationprod";
            this.locationprod.Width = 200;
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
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1439, 853);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rechercheprod);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load);
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
        private System.Windows.Forms.Button recherche;
        private System.Windows.Forms.TextBox rechercheprod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn valeurprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockname;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationprod;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.DataGridViewButtonColumn modifier;
    }
}