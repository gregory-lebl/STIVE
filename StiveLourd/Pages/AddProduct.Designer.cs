
namespace StiveLourd.Pages
{
    partial class AddProduct
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
            this.formProduits = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TitrePage = new System.Windows.Forms.Label();
            this.labelNomFournisseur = new System.Windows.Forms.Label();
            this.listBoxNomFournisseur = new System.Windows.Forms.ListBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stiveDBDataSet = new StiveLourd.StiveDBDataSet();
            this.labelCepage = new System.Windows.Forms.Label();
            this.listBoxCépage = new System.Windows.Forms.ListBox();
            this.cepageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelAnnee = new System.Windows.Forms.Label();
            this.listBoxAnnee = new System.Windows.Forms.ListBox();
            this.anneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelVolumeUnitaire = new System.Windows.Forms.Label();
            this.listBoxVolumeUnitaire = new System.Windows.Forms.ListBox();
            this.capacityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFamille = new System.Windows.Forms.Label();
            this.listBoxFamille = new System.Windows.Forms.ListBox();
            this.familyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxApprovisionnement = new System.Windows.Forms.TextBox();
            this.labelApprovisionnement = new System.Windows.Forms.Label();
            this.textBoxStockMini = new System.Windows.Forms.TextBox();
            this.labelStockMini = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.labelPrix = new System.Windows.Forms.Label();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.anneeTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.AnneeTableAdapter();
            this.tableAdapterManager = new StiveLourd.StiveDBDataSetTableAdapters.TableAdapterManager();
            this.capacityTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.CapacityTableAdapter();
            this.cepageTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.CepageTableAdapter();
            this.familyTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.FamilyTableAdapter();
            this.supplierTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.SupplierTableAdapter();
            this.capacityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cepageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formProduits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepageBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // formProduits
            // 
            this.formProduits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.formProduits.Controls.Add(this.button1);
            this.formProduits.Controls.Add(this.TitrePage);
            this.formProduits.Controls.Add(this.labelNomFournisseur);
            this.formProduits.Controls.Add(this.listBoxNomFournisseur);
            this.formProduits.Controls.Add(this.labelCepage);
            this.formProduits.Controls.Add(this.listBoxCépage);
            this.formProduits.Controls.Add(this.labelAnnee);
            this.formProduits.Controls.Add(this.listBoxAnnee);
            this.formProduits.Controls.Add(this.labelVolumeUnitaire);
            this.formProduits.Controls.Add(this.listBoxVolumeUnitaire);
            this.formProduits.Controls.Add(this.labelFamille);
            this.formProduits.Controls.Add(this.listBoxFamille);
            this.formProduits.Controls.Add(this.textBoxApprovisionnement);
            this.formProduits.Controls.Add(this.labelApprovisionnement);
            this.formProduits.Controls.Add(this.textBoxStockMini);
            this.formProduits.Controls.Add(this.labelStockMini);
            this.formProduits.Controls.Add(this.textBoxStock);
            this.formProduits.Controls.Add(this.labelStock);
            this.formProduits.Controls.Add(this.textBoxDescription);
            this.formProduits.Controls.Add(this.labelDescription);
            this.formProduits.Controls.Add(this.textBoxPrix);
            this.formProduits.Controls.Add(this.labelPrix);
            this.formProduits.Controls.Add(this.textBoxDesignation);
            this.formProduits.Controls.Add(this.labelDesignation);
            this.formProduits.Location = new System.Drawing.Point(0, 0);
            this.formProduits.Name = "formProduits";
            this.formProduits.Size = new System.Drawing.Size(954, 707);
            this.formProduits.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.button1.Location = new System.Drawing.Point(810, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 70);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ajouter produit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitrePage
            // 
            this.TitrePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitrePage.AutoSize = true;
            this.TitrePage.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.TitrePage.Location = new System.Drawing.Point(270, 23);
            this.TitrePage.Name = "TitrePage";
            this.TitrePage.Size = new System.Drawing.Size(452, 45);
            this.TitrePage.TabIndex = 23;
            this.TitrePage.Text = "AJOUT NOUVEAU PRODUIT";
            // 
            // labelNomFournisseur
            // 
            this.labelNomFournisseur.AutoSize = true;
            this.labelNomFournisseur.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomFournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelNomFournisseur.Location = new System.Drawing.Point(34, 236);
            this.labelNomFournisseur.Name = "labelNomFournisseur";
            this.labelNomFournisseur.Size = new System.Drawing.Size(140, 23);
            this.labelNomFournisseur.TabIndex = 22;
            this.labelNomFournisseur.Text = "Nom Fournisseur";
            // 
            // listBoxNomFournisseur
            // 
            this.listBoxNomFournisseur.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierBindingSource, "Name", true));
            this.listBoxNomFournisseur.DataSource = this.supplierBindingSource;
            this.listBoxNomFournisseur.DisplayMember = "Name";
            this.listBoxNomFournisseur.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNomFournisseur.FormattingEnabled = true;
            this.listBoxNomFournisseur.ItemHeight = 23;
            this.listBoxNomFournisseur.Location = new System.Drawing.Point(34, 260);
            this.listBoxNomFournisseur.Name = "listBoxNomFournisseur";
            this.listBoxNomFournisseur.Size = new System.Drawing.Size(239, 27);
            this.listBoxNomFournisseur.TabIndex = 21;
            this.listBoxNomFournisseur.ValueMember = "SupplierId";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // stiveDBDataSet
            // 
            this.stiveDBDataSet.DataSetName = "StiveDBDataSet";
            this.stiveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelCepage
            // 
            this.labelCepage.AutoSize = true;
            this.labelCepage.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelCepage.Location = new System.Drawing.Point(801, 148);
            this.labelCepage.Name = "labelCepage";
            this.labelCepage.Size = new System.Drawing.Size(68, 23);
            this.labelCepage.TabIndex = 20;
            this.labelCepage.Text = "Cépage";
            // 
            // listBoxCépage
            // 
            this.listBoxCépage.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cepageBindingSource, "Name", true));
            this.listBoxCépage.DataSource = this.cepageBindingSource1;
            this.listBoxCépage.DisplayMember = "Name";
            this.listBoxCépage.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCépage.FormattingEnabled = true;
            this.listBoxCépage.ItemHeight = 23;
            this.listBoxCépage.Location = new System.Drawing.Point(801, 174);
            this.listBoxCépage.Name = "listBoxCépage";
            this.listBoxCépage.Size = new System.Drawing.Size(120, 27);
            this.listBoxCépage.TabIndex = 19;
            this.listBoxCépage.ValueMember = "CepageId";
            // 
            // cepageBindingSource
            // 
            this.cepageBindingSource.DataMember = "Cepage";
            this.cepageBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelAnnee.Location = new System.Drawing.Point(573, 148);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(59, 23);
            this.labelAnnee.TabIndex = 18;
            this.labelAnnee.Text = "Année";
            // 
            // listBoxAnnee
            // 
            this.listBoxAnnee.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.anneeBindingSource, "Number", true));
            this.listBoxAnnee.DataSource = this.anneeBindingSource;
            this.listBoxAnnee.DisplayMember = "Number";
            this.listBoxAnnee.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAnnee.FormattingEnabled = true;
            this.listBoxAnnee.ItemHeight = 23;
            this.listBoxAnnee.Location = new System.Drawing.Point(573, 174);
            this.listBoxAnnee.Name = "listBoxAnnee";
            this.listBoxAnnee.Size = new System.Drawing.Size(120, 27);
            this.listBoxAnnee.TabIndex = 17;
            this.listBoxAnnee.ValueMember = "AnneeId";
            // 
            // anneeBindingSource
            // 
            this.anneeBindingSource.DataMember = "Annee";
            this.anneeBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // labelVolumeUnitaire
            // 
            this.labelVolumeUnitaire.AutoSize = true;
            this.labelVolumeUnitaire.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumeUnitaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelVolumeUnitaire.Location = new System.Drawing.Point(299, 150);
            this.labelVolumeUnitaire.Name = "labelVolumeUnitaire";
            this.labelVolumeUnitaire.Size = new System.Drawing.Size(133, 23);
            this.labelVolumeUnitaire.TabIndex = 16;
            this.labelVolumeUnitaire.Text = "Volume Unitaire";
            // 
            // listBoxVolumeUnitaire
            // 
            this.listBoxVolumeUnitaire.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.capacityBindingSource, "BottleCapacity", true));
            this.listBoxVolumeUnitaire.DataSource = this.capacityBindingSource1;
            this.listBoxVolumeUnitaire.DisplayMember = "BottleCapacity";
            this.listBoxVolumeUnitaire.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVolumeUnitaire.FormattingEnabled = true;
            this.listBoxVolumeUnitaire.ItemHeight = 23;
            this.listBoxVolumeUnitaire.Location = new System.Drawing.Point(299, 174);
            this.listBoxVolumeUnitaire.Name = "listBoxVolumeUnitaire";
            this.listBoxVolumeUnitaire.Size = new System.Drawing.Size(172, 27);
            this.listBoxVolumeUnitaire.TabIndex = 15;
            this.listBoxVolumeUnitaire.ValueMember = "CapacityId";
            // 
            // capacityBindingSource
            // 
            this.capacityBindingSource.DataMember = "Capacity";
            this.capacityBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // labelFamille
            // 
            this.labelFamille.AutoSize = true;
            this.labelFamille.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelFamille.Location = new System.Drawing.Point(34, 150);
            this.labelFamille.Name = "labelFamille";
            this.labelFamille.Size = new System.Drawing.Size(62, 23);
            this.labelFamille.TabIndex = 14;
            this.labelFamille.Text = "Famille";
            // 
            // listBoxFamille
            // 
            this.listBoxFamille.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.familyBindingSource, "Name", true));
            this.listBoxFamille.DataSource = this.familyBindingSource;
            this.listBoxFamille.DisplayMember = "Name";
            this.listBoxFamille.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFamille.FormattingEnabled = true;
            this.listBoxFamille.ItemHeight = 23;
            this.listBoxFamille.Location = new System.Drawing.Point(34, 174);
            this.listBoxFamille.Name = "listBoxFamille";
            this.listBoxFamille.Size = new System.Drawing.Size(159, 27);
            this.listBoxFamille.TabIndex = 13;
            this.listBoxFamille.ValueMember = "FamilyId";
            // 
            // familyBindingSource
            // 
            this.familyBindingSource.DataMember = "Family";
            this.familyBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // textBoxApprovisionnement
            // 
            this.textBoxApprovisionnement.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApprovisionnement.Location = new System.Drawing.Point(34, 631);
            this.textBoxApprovisionnement.Name = "textBoxApprovisionnement";
            this.textBoxApprovisionnement.Size = new System.Drawing.Size(200, 30);
            this.textBoxApprovisionnement.TabIndex = 12;
            // 
            // labelApprovisionnement
            // 
            this.labelApprovisionnement.AutoSize = true;
            this.labelApprovisionnement.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApprovisionnement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelApprovisionnement.Location = new System.Drawing.Point(34, 611);
            this.labelApprovisionnement.Name = "labelApprovisionnement";
            this.labelApprovisionnement.Size = new System.Drawing.Size(159, 23);
            this.labelApprovisionnement.TabIndex = 11;
            this.labelApprovisionnement.Text = "Approvisionnement";
            // 
            // textBoxStockMini
            // 
            this.textBoxStockMini.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStockMini.Location = new System.Drawing.Point(34, 569);
            this.textBoxStockMini.Name = "textBoxStockMini";
            this.textBoxStockMini.Size = new System.Drawing.Size(200, 30);
            this.textBoxStockMini.TabIndex = 10;
            // 
            // labelStockMini
            // 
            this.labelStockMini.AutoSize = true;
            this.labelStockMini.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockMini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelStockMini.Location = new System.Drawing.Point(34, 549);
            this.labelStockMini.Name = "labelStockMini";
            this.labelStockMini.Size = new System.Drawing.Size(128, 23);
            this.labelStockMini.TabIndex = 9;
            this.labelStockMini.Text = "Stock Minimum";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(34, 512);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(200, 30);
            this.textBoxStock.TabIndex = 8;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelStock.Location = new System.Drawing.Point(34, 492);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(50, 23);
            this.labelStock.TabIndex = 7;
            this.labelStock.Text = "Stock";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(34, 393);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(887, 90);
            this.textBoxDescription.TabIndex = 6;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelDescription.Location = new System.Drawing.Point(34, 373);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(182, 23);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Description du produit";
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrix.Location = new System.Drawing.Point(34, 326);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(200, 30);
            this.textBoxPrix.TabIndex = 4;
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelPrix.Location = new System.Drawing.Point(34, 306);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(103, 23);
            this.labelPrix.TabIndex = 3;
            this.labelPrix.Text = "Prix Unitaire";
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(34, 105);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(382, 22);
            this.textBoxDesignation.TabIndex = 2;
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesignation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelDesignation.Location = new System.Drawing.Point(34, 79);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(187, 23);
            this.labelDesignation.TabIndex = 1;
            this.labelDesignation.Text = "Désignation du produit";
            // 
            // anneeTableAdapter
            // 
            this.anneeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnneeTableAdapter = this.anneeTableAdapter;
            this.tableAdapterManager.ArticleRowTableAdapter = null;
            this.tableAdapterManager.ArticleTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CapacityTableAdapter = this.capacityTableAdapter;
            this.tableAdapterManager.CepageTableAdapter = this.cepageTableAdapter;
            this.tableAdapterManager.ClientOrderTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FamilyTableAdapter = this.familyTableAdapter;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UpdateOrder = StiveLourd.StiveDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // capacityTableAdapter
            // 
            this.capacityTableAdapter.ClearBeforeFill = true;
            // 
            // cepageTableAdapter
            // 
            this.cepageTableAdapter.ClearBeforeFill = true;
            // 
            // familyTableAdapter
            // 
            this.familyTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // capacityBindingSource1
            // 
            this.capacityBindingSource1.DataMember = "Capacity";
            this.capacityBindingSource1.DataSource = this.stiveDBDataSet;
            // 
            // cepageBindingSource1
            // 
            this.cepageBindingSource1.DataMember = "Cepage";
            this.cepageBindingSource1.DataSource = this.stiveDBDataSet;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(954, 707);
            this.Controls.Add(this.formProduits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProduct";
            this.Text = "       ";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.formProduits.ResumeLayout(false);
            this.formProduits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepageBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formProduits;
        private System.Windows.Forms.TextBox textBoxApprovisionnement;
        private System.Windows.Forms.Label labelApprovisionnement;
        private System.Windows.Forms.TextBox textBoxStockMini;
        private System.Windows.Forms.Label labelStockMini;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.Label labelFamille;
        private System.Windows.Forms.ListBox listBoxFamille;
        private System.Windows.Forms.Label labelNomFournisseur;
        private System.Windows.Forms.ListBox listBoxNomFournisseur;
        private System.Windows.Forms.Label labelCepage;
        private System.Windows.Forms.ListBox listBoxCépage;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.ListBox listBoxAnnee;
        private System.Windows.Forms.Label labelVolumeUnitaire;
        private System.Windows.Forms.ListBox listBoxVolumeUnitaire;
        private System.Windows.Forms.Label TitrePage;
        private System.Windows.Forms.Button button1;
        private StiveDBDataSet stiveDBDataSet;
        private System.Windows.Forms.BindingSource anneeBindingSource;
        private StiveDBDataSetTableAdapters.AnneeTableAdapter anneeTableAdapter;
        private StiveDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private StiveDBDataSetTableAdapters.CapacityTableAdapter capacityTableAdapter;
        private System.Windows.Forms.BindingSource capacityBindingSource;
        private StiveDBDataSetTableAdapters.CepageTableAdapter cepageTableAdapter;
        private System.Windows.Forms.BindingSource cepageBindingSource;
        private StiveDBDataSetTableAdapters.FamilyTableAdapter familyTableAdapter;
        private System.Windows.Forms.BindingSource familyBindingSource;
        private StiveDBDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource cepageBindingSource1;
        private System.Windows.Forms.BindingSource capacityBindingSource1;
    }
}