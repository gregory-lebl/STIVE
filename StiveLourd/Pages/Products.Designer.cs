
namespace StiveLourd.Pages
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navContainer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TitrePage = new System.Windows.Forms.Label();
            this.labelNomFournisseur = new System.Windows.Forms.Label();
            this.listBoxNomFournisseur = new System.Windows.Forms.ListBox();
            this.labelCepage = new System.Windows.Forms.Label();
            this.listBoxCépage = new System.Windows.Forms.ListBox();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.listBoxAnnee = new System.Windows.Forms.ListBox();
            this.labelVolumeUnitaire = new System.Windows.Forms.Label();
            this.listBoxVolumeUnitaire = new System.Windows.Forms.ListBox();
            this.labelFamille = new System.Windows.Forms.Label();
            this.listBoxFamille = new System.Windows.Forms.ListBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.data_produits = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.references = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_produits)).BeginInit();
            this.SuspendLayout();
            // 
            // navContainer
            // 
            this.navContainer.Controls.Add(this.button2);
            this.navContainer.Controls.Add(this.data_produits);
            this.navContainer.Controls.Add(this.TitrePage);
            this.navContainer.Controls.Add(this.labelNomFournisseur);
            this.navContainer.Controls.Add(this.listBoxNomFournisseur);
            this.navContainer.Controls.Add(this.labelCepage);
            this.navContainer.Controls.Add(this.listBoxCépage);
            this.navContainer.Controls.Add(this.labelAnnee);
            this.navContainer.Controls.Add(this.listBoxAnnee);
            this.navContainer.Controls.Add(this.labelVolumeUnitaire);
            this.navContainer.Controls.Add(this.listBoxVolumeUnitaire);
            this.navContainer.Controls.Add(this.labelFamille);
            this.navContainer.Controls.Add(this.listBoxFamille);
            this.navContainer.Controls.Add(this.textBoxDesignation);
            this.navContainer.Controls.Add(this.labelDesignation);
            this.navContainer.Controls.Add(this.button1);
            this.navContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navContainer.Location = new System.Drawing.Point(0, 0);
            this.navContainer.Name = "navContainer";
            this.navContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navContainer.Size = new System.Drawing.Size(1454, 850);
            this.navContainer.TabIndex = 7;
            this.navContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.navContainer_Paint);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(914, 498);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 2;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitrePage
            // 
            this.TitrePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitrePage.AutoSize = true;
            this.TitrePage.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.TitrePage.Location = new System.Drawing.Point(438, 41);
            this.TitrePage.Name = "TitrePage";
            this.TitrePage.Size = new System.Drawing.Size(183, 45);
            this.TitrePage.TabIndex = 36;
            this.TitrePage.Text = "PRODUITS";
            this.TitrePage.Click += new System.EventHandler(this.TitrePage_Click);
            // 
            // labelNomFournisseur
            // 
            this.labelNomFournisseur.AutoSize = true;
            this.labelNomFournisseur.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomFournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelNomFournisseur.Location = new System.Drawing.Point(35, 254);
            this.labelNomFournisseur.Name = "labelNomFournisseur";
            this.labelNomFournisseur.Size = new System.Drawing.Size(140, 23);
            this.labelNomFournisseur.TabIndex = 35;
            this.labelNomFournisseur.Text = "Nom Fournisseur";
            // 
            // listBoxNomFournisseur
            // 
            this.listBoxNomFournisseur.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNomFournisseur.FormattingEnabled = true;
            this.listBoxNomFournisseur.ItemHeight = 23;
            this.listBoxNomFournisseur.Items.AddRange(new object[] {
            "NomFournisseur 1",
            "NomFournisseur 2",
            "NomFournisseur 3"});
            this.listBoxNomFournisseur.Location = new System.Drawing.Point(35, 278);
            this.listBoxNomFournisseur.Name = "listBoxNomFournisseur";
            this.listBoxNomFournisseur.Size = new System.Drawing.Size(239, 27);
            this.listBoxNomFournisseur.TabIndex = 34;
            // 
            // labelCepage
            // 
            this.labelCepage.AutoSize = true;
            this.labelCepage.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelCepage.Location = new System.Drawing.Point(802, 166);
            this.labelCepage.Name = "labelCepage";
            this.labelCepage.Size = new System.Drawing.Size(68, 23);
            this.labelCepage.TabIndex = 33;
            this.labelCepage.Text = "Cépage";
            // 
            // listBoxCépage
            // 
            this.listBoxCépage.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCépage.FormattingEnabled = true;
            this.listBoxCépage.ItemHeight = 23;
            this.listBoxCépage.Items.AddRange(new object[] {
            "Cépage 1",
            "Cépage 2",
            "Cépage 3"});
            this.listBoxCépage.Location = new System.Drawing.Point(802, 192);
            this.listBoxCépage.Name = "listBoxCépage";
            this.listBoxCépage.Size = new System.Drawing.Size(120, 27);
            this.listBoxCépage.TabIndex = 32;
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelAnnee.Location = new System.Drawing.Point(574, 166);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(59, 23);
            this.labelAnnee.TabIndex = 31;
            this.labelAnnee.Text = "Année";
            // 
            // listBoxAnnee
            // 
            this.listBoxAnnee.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAnnee.FormattingEnabled = true;
            this.listBoxAnnee.ItemHeight = 23;
            this.listBoxAnnee.Items.AddRange(new object[] {
            "Annee 1",
            "Annee 2",
            "Annee 3"});
            this.listBoxAnnee.Location = new System.Drawing.Point(574, 192);
            this.listBoxAnnee.Name = "listBoxAnnee";
            this.listBoxAnnee.Size = new System.Drawing.Size(120, 27);
            this.listBoxAnnee.TabIndex = 30;
            // 
            // labelVolumeUnitaire
            // 
            this.labelVolumeUnitaire.AutoSize = true;
            this.labelVolumeUnitaire.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumeUnitaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelVolumeUnitaire.Location = new System.Drawing.Point(300, 168);
            this.labelVolumeUnitaire.Name = "labelVolumeUnitaire";
            this.labelVolumeUnitaire.Size = new System.Drawing.Size(133, 23);
            this.labelVolumeUnitaire.TabIndex = 29;
            this.labelVolumeUnitaire.Text = "Volume Unitaire";
            // 
            // listBoxVolumeUnitaire
            // 
            this.listBoxVolumeUnitaire.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVolumeUnitaire.FormattingEnabled = true;
            this.listBoxVolumeUnitaire.ItemHeight = 23;
            this.listBoxVolumeUnitaire.Items.AddRange(new object[] {
            "VolumeUnitaire 1",
            "VolumeUnitaire 2",
            "VolumeUnitaire 3"});
            this.listBoxVolumeUnitaire.Location = new System.Drawing.Point(300, 192);
            this.listBoxVolumeUnitaire.Name = "listBoxVolumeUnitaire";
            this.listBoxVolumeUnitaire.Size = new System.Drawing.Size(172, 27);
            this.listBoxVolumeUnitaire.TabIndex = 28;
            // 
            // labelFamille
            // 
            this.labelFamille.AutoSize = true;
            this.labelFamille.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelFamille.Location = new System.Drawing.Point(35, 168);
            this.labelFamille.Name = "labelFamille";
            this.labelFamille.Size = new System.Drawing.Size(62, 23);
            this.labelFamille.TabIndex = 27;
            this.labelFamille.Text = "Famille";
            // 
            // listBoxFamille
            // 
            this.listBoxFamille.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFamille.FormattingEnabled = true;
            this.listBoxFamille.ItemHeight = 23;
            this.listBoxFamille.Items.AddRange(new object[] {
            "Famille 1",
            "Famille 2",
            "Famille 3"});
            this.listBoxFamille.Location = new System.Drawing.Point(35, 192);
            this.listBoxFamille.Name = "listBoxFamille";
            this.listBoxFamille.Size = new System.Drawing.Size(159, 27);
            this.listBoxFamille.TabIndex = 26;
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(35, 123);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(382, 22);
            this.textBoxDesignation.TabIndex = 25;
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesignation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelDesignation.Location = new System.Drawing.Point(35, 97);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(187, 23);
            this.labelDesignation.TabIndex = 24;
            this.labelDesignation.Text = "Désignation du produit";
            // 
            // data_produits
            // 
            this.data_produits.AllowUserToAddRows = false;
            this.data_produits.AllowUserToDeleteRows = false;
            this.data_produits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.data_produits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.data_produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_produits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantite,
            this.volumeUnitaire,
            this.annee,
            this.cepage,
            this.famille,
            this.designation,
            this.references});
            this.data_produits.GridColor = System.Drawing.SystemColors.Control;
            this.data_produits.Location = new System.Drawing.Point(35, 475);
            this.data_produits.Name = "data_produits";
            this.data_produits.ReadOnly = true;
            this.data_produits.RowHeadersWidth = 51;
            this.data_produits.RowTemplate.Height = 24;
            this.data_produits.Size = new System.Drawing.Size(1004, 347);
            this.data_produits.StandardTab = true;
            this.data_produits.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.button2.Location = new System.Drawing.Point(672, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 70);
            this.button2.TabIndex = 38;
            this.button2.Text = "Ajouter produit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // quantite
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.quantite.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantite.HeaderText = "Quantité";
            this.quantite.MinimumWidth = 6;
            this.quantite.Name = "quantite";
            this.quantite.ReadOnly = true;
            this.quantite.Width = 125;
            // 
            // volumeUnitaire
            // 
            this.volumeUnitaire.HeaderText = "Volume Unitaire";
            this.volumeUnitaire.MinimumWidth = 6;
            this.volumeUnitaire.Name = "volumeUnitaire";
            this.volumeUnitaire.ReadOnly = true;
            this.volumeUnitaire.Width = 125;
            // 
            // annee
            // 
            this.annee.HeaderText = "Année";
            this.annee.MinimumWidth = 6;
            this.annee.Name = "annee";
            this.annee.ReadOnly = true;
            this.annee.Width = 125;
            // 
            // cepage
            // 
            this.cepage.HeaderText = "Cépage";
            this.cepage.MinimumWidth = 6;
            this.cepage.Name = "cepage";
            this.cepage.ReadOnly = true;
            this.cepage.Width = 125;
            // 
            // famille
            // 
            this.famille.HeaderText = "Famille";
            this.famille.MinimumWidth = 6;
            this.famille.Name = "famille";
            this.famille.ReadOnly = true;
            this.famille.Width = 125;
            // 
            // designation
            // 
            this.designation.HeaderText = "Désignation";
            this.designation.MinimumWidth = 6;
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            this.designation.Width = 200;
            // 
            // references
            // 
            this.references.HeaderText = "Références";
            this.references.MinimumWidth = 6;
            this.references.Name = "references";
            this.references.ReadOnly = true;
            this.references.Width = 125;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1454, 850);
            this.Controls.Add(this.navContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.Text = "Index";
            this.navContainer.ResumeLayout(false);
            this.navContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_produits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel navContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView data_produits;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepage;
        private System.Windows.Forms.DataGridViewTextBoxColumn famille;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn references;
        private System.Windows.Forms.Label TitrePage;
        private System.Windows.Forms.Label labelNomFournisseur;
        private System.Windows.Forms.ListBox listBoxNomFournisseur;
        private System.Windows.Forms.Label labelCepage;
        private System.Windows.Forms.ListBox listBoxCépage;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.ListBox listBoxAnnee;
        private System.Windows.Forms.Label labelVolumeUnitaire;
        private System.Windows.Forms.ListBox listBoxVolumeUnitaire;
        private System.Windows.Forms.Label labelFamille;
        private System.Windows.Forms.ListBox listBoxFamille;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.Label labelDesignation;
    }
}