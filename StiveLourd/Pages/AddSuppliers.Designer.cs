
namespace StiveLourd.Pages
{
    partial class AddSuppliers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSuppliers));
            this.formFournisseur = new System.Windows.Forms.Panel();
            this.panel_search_ref_prod = new System.Windows.Forms.Panel();
            this.btn_new_ref_prod = new System.Windows.Forms.Button();
            this.labelProdFour = new System.Windows.Forms.Label();
            this.VilleText = new System.Windows.Forms.TextBox();
            this.labelVilleFour = new System.Windows.Forms.Label();
            this.CpText = new System.Windows.Forms.TextBox();
            this.labelCPFour = new System.Windows.Forms.Label();
            this.AdresseText = new System.Windows.Forms.TextBox();
            this.labelAdresseFour = new System.Windows.Forms.Label();
            this.TelephoneText = new System.Windows.Forms.TextBox();
            this.labelNumTelFour = new System.Windows.Forms.Label();
            this.SiretText = new System.Windows.Forms.TextBox();
            this.labelNumSIRET = new System.Windows.Forms.Label();
            this.btn_ajouter_fournisseur = new System.Windows.Forms.Button();
            this.TitrePage = new System.Windows.Forms.Label();
            this.NomText = new System.Windows.Forms.TextBox();
            this.labelNomFour = new System.Windows.Forms.Label();
            this.Produit = new System.Windows.Forms.ListBox();
            this.stiveDBDataSet = new StiveLourd.StiveDBDataSet();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.ArticleTableAdapter();
            this.formFournisseur.SuspendLayout();
            this.panel_search_ref_prod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formFournisseur
            // 
            this.formFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.formFournisseur.Controls.Add(this.panel_search_ref_prod);
            this.formFournisseur.Controls.Add(this.VilleText);
            this.formFournisseur.Controls.Add(this.labelVilleFour);
            this.formFournisseur.Controls.Add(this.CpText);
            this.formFournisseur.Controls.Add(this.labelCPFour);
            this.formFournisseur.Controls.Add(this.AdresseText);
            this.formFournisseur.Controls.Add(this.labelAdresseFour);
            this.formFournisseur.Controls.Add(this.TelephoneText);
            this.formFournisseur.Controls.Add(this.labelNumTelFour);
            this.formFournisseur.Controls.Add(this.SiretText);
            this.formFournisseur.Controls.Add(this.labelNumSIRET);
            this.formFournisseur.Controls.Add(this.btn_ajouter_fournisseur);
            this.formFournisseur.Controls.Add(this.TitrePage);
            this.formFournisseur.Controls.Add(this.NomText);
            this.formFournisseur.Controls.Add(this.labelNomFour);
            this.formFournisseur.Location = new System.Drawing.Point(0, 0);
            this.formFournisseur.Name = "formFournisseur";
            this.formFournisseur.Size = new System.Drawing.Size(954, 707);
            this.formFournisseur.TabIndex = 3;
            // 
            // panel_search_ref_prod
            // 
            this.panel_search_ref_prod.Controls.Add(this.Produit);
            this.panel_search_ref_prod.Controls.Add(this.btn_new_ref_prod);
            this.panel_search_ref_prod.Controls.Add(this.labelProdFour);
            this.panel_search_ref_prod.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_search_ref_prod.Location = new System.Drawing.Point(16, 357);
            this.panel_search_ref_prod.Name = "panel_search_ref_prod";
            this.panel_search_ref_prod.Size = new System.Drawing.Size(233, 106);
            this.panel_search_ref_prod.TabIndex = 39;
            // 
            // btn_new_ref_prod
            // 
            this.btn_new_ref_prod.AutoSize = true;
            this.btn_new_ref_prod.Image = ((System.Drawing.Image)(resources.GetObject("btn_new_ref_prod.Image")));
            this.btn_new_ref_prod.Location = new System.Drawing.Point(3, 67);
            this.btn_new_ref_prod.Name = "btn_new_ref_prod";
            this.btn_new_ref_prod.Size = new System.Drawing.Size(36, 36);
            this.btn_new_ref_prod.TabIndex = 41;
            this.btn_new_ref_prod.UseVisualStyleBackColor = false;
            // 
            // labelProdFour
            // 
            this.labelProdFour.AutoSize = true;
            this.labelProdFour.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelProdFour.Location = new System.Drawing.Point(3, 2);
            this.labelProdFour.Name = "labelProdFour";
            this.labelProdFour.Size = new System.Drawing.Size(219, 23);
            this.labelProdFour.TabIndex = 39;
            this.labelProdFour.Text = "Produits Fournis (référence)";
            // 
            // VilleText
            // 
            this.VilleText.Location = new System.Drawing.Point(301, 286);
            this.VilleText.Name = "VilleText";
            this.VilleText.Size = new System.Drawing.Size(585, 22);
            this.VilleText.TabIndex = 34;
            // 
            // labelVilleFour
            // 
            this.labelVilleFour.AutoSize = true;
            this.labelVilleFour.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVilleFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelVilleFour.Location = new System.Drawing.Point(301, 260);
            this.labelVilleFour.Name = "labelVilleFour";
            this.labelVilleFour.Size = new System.Drawing.Size(42, 23);
            this.labelVilleFour.TabIndex = 33;
            this.labelVilleFour.Text = "Ville";
            // 
            // CpText
            // 
            this.CpText.Location = new System.Drawing.Point(12, 286);
            this.CpText.Name = "CpText";
            this.CpText.Size = new System.Drawing.Size(227, 22);
            this.CpText.TabIndex = 32;
            // 
            // labelCPFour
            // 
            this.labelCPFour.AutoSize = true;
            this.labelCPFour.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelCPFour.Location = new System.Drawing.Point(12, 260);
            this.labelCPFour.Name = "labelCPFour";
            this.labelCPFour.Size = new System.Drawing.Size(100, 23);
            this.labelCPFour.TabIndex = 31;
            this.labelCPFour.Text = "Code Postal";
            // 
            // AdresseText
            // 
            this.AdresseText.Location = new System.Drawing.Point(301, 212);
            this.AdresseText.Name = "AdresseText";
            this.AdresseText.Size = new System.Drawing.Size(585, 22);
            this.AdresseText.TabIndex = 30;
            // 
            // labelAdresseFour
            // 
            this.labelAdresseFour.AutoSize = true;
            this.labelAdresseFour.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresseFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelAdresseFour.Location = new System.Drawing.Point(301, 186);
            this.labelAdresseFour.Name = "labelAdresseFour";
            this.labelAdresseFour.Size = new System.Drawing.Size(69, 23);
            this.labelAdresseFour.TabIndex = 29;
            this.labelAdresseFour.Text = "Adresse";
            // 
            // TelephoneText
            // 
            this.TelephoneText.Location = new System.Drawing.Point(12, 212);
            this.TelephoneText.Name = "TelephoneText";
            this.TelephoneText.Size = new System.Drawing.Size(227, 22);
            this.TelephoneText.TabIndex = 28;
            // 
            // labelNumTelFour
            // 
            this.labelNumTelFour.AutoSize = true;
            this.labelNumTelFour.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumTelFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelNumTelFour.Location = new System.Drawing.Point(12, 186);
            this.labelNumTelFour.Name = "labelNumTelFour";
            this.labelNumTelFour.Size = new System.Drawing.Size(180, 23);
            this.labelNumTelFour.TabIndex = 27;
            this.labelNumTelFour.Text = "Numéro de Téléphone";
            // 
            // SiretText
            // 
            this.SiretText.Location = new System.Drawing.Point(441, 125);
            this.SiretText.Name = "SiretText";
            this.SiretText.Size = new System.Drawing.Size(445, 22);
            this.SiretText.TabIndex = 26;
            // 
            // labelNumSIRET
            // 
            this.labelNumSIRET.AutoSize = true;
            this.labelNumSIRET.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumSIRET.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelNumSIRET.Location = new System.Drawing.Point(441, 99);
            this.labelNumSIRET.Name = "labelNumSIRET";
            this.labelNumSIRET.Size = new System.Drawing.Size(120, 23);
            this.labelNumSIRET.TabIndex = 25;
            this.labelNumSIRET.Text = "Numéro SIRET";
            // 
            // btn_ajouter_fournisseur
            // 
            this.btn_ajouter_fournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.btn_ajouter_fournisseur.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_fournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btn_ajouter_fournisseur.Location = new System.Drawing.Point(783, 600);
            this.btn_ajouter_fournisseur.Name = "btn_ajouter_fournisseur";
            this.btn_ajouter_fournisseur.Size = new System.Drawing.Size(111, 70);
            this.btn_ajouter_fournisseur.TabIndex = 24;
            this.btn_ajouter_fournisseur.Text = "Ajouter fournisseur";
            this.btn_ajouter_fournisseur.UseVisualStyleBackColor = false;
            // 
            // TitrePage
            // 
            this.TitrePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitrePage.AutoSize = true;
            this.TitrePage.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.TitrePage.Location = new System.Drawing.Point(202, 23);
            this.TitrePage.Name = "TitrePage";
            this.TitrePage.Size = new System.Drawing.Size(534, 45);
            this.TitrePage.TabIndex = 23;
            this.TitrePage.Text = "AJOUT NOUVEAU FOURNISSEUR";
            this.TitrePage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NomText
            // 
            this.NomText.Location = new System.Drawing.Point(12, 125);
            this.NomText.Name = "NomText";
            this.NomText.Size = new System.Drawing.Size(382, 22);
            this.NomText.TabIndex = 2;
            // 
            // labelNomFour
            // 
            this.labelNomFour.AutoSize = true;
            this.labelNomFour.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelNomFour.Location = new System.Drawing.Point(12, 99);
            this.labelNomFour.Name = "labelNomFour";
            this.labelNomFour.Size = new System.Drawing.Size(137, 23);
            this.labelNomFour.TabIndex = 1;
            this.labelNomFour.Text = "Nom fournisseur";
            // 
            // Produit
            // 
            this.Produit.DataSource = this.articleBindingSource;
            this.Produit.DisplayMember = "Ref";
            this.Produit.FormattingEnabled = true;
            this.Produit.ItemHeight = 23;
            this.Produit.Location = new System.Drawing.Point(7, 29);
            this.Produit.Name = "Produit";
            this.Produit.Size = new System.Drawing.Size(216, 27);
            this.Produit.TabIndex = 42;
            this.Produit.ValueMember = "Id";
            // 
            // stiveDBDataSet
            // 
            this.stiveDBDataSet.DataSetName = "StiveDBDataSet";
            this.stiveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataMember = "Article";
            this.articleBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // articleTableAdapter
            // 
            this.articleTableAdapter.ClearBeforeFill = true;
            // 
            // AddSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 707);
            this.Controls.Add(this.formFournisseur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSuppliers";
            this.Text = "AddSuppliers";
            this.Load += new System.EventHandler(this.AddSuppliers_Load);
            this.formFournisseur.ResumeLayout(false);
            this.formFournisseur.PerformLayout();
            this.panel_search_ref_prod.ResumeLayout(false);
            this.panel_search_ref_prod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formFournisseur;
        private System.Windows.Forms.Button btn_ajouter_fournisseur;
        private System.Windows.Forms.Label TitrePage;
        private System.Windows.Forms.TextBox NomText;
        private System.Windows.Forms.Label labelNomFour;
        private System.Windows.Forms.TextBox TelephoneText;
        private System.Windows.Forms.Label labelNumTelFour;
        private System.Windows.Forms.TextBox SiretText;
        private System.Windows.Forms.Label labelNumSIRET;
        private System.Windows.Forms.TextBox CpText;
        private System.Windows.Forms.Label labelCPFour;
        private System.Windows.Forms.TextBox AdresseText;
        private System.Windows.Forms.Label labelAdresseFour;
        private System.Windows.Forms.TextBox VilleText;
        private System.Windows.Forms.Label labelVilleFour;
        private System.Windows.Forms.Panel panel_search_ref_prod;
        private System.Windows.Forms.Button btn_new_ref_prod;
        private System.Windows.Forms.Label labelProdFour;
        private System.Windows.Forms.ListBox Produit;
        private StiveDBDataSet stiveDBDataSet;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private StiveDBDataSetTableAdapters.ArticleTableAdapter articleTableAdapter;
    }
}