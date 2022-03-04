
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.navContainer = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.familyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stiveDBDataSet = new StiveLourd.StiveDBDataSet();
            this.familyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.capacityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.anneeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.cepageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cepageBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.articleDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TitrePage = new System.Windows.Forms.Label();
            this.labelNomFournisseur = new System.Windows.Forms.Label();
            this.listBoxNomFournisseur = new System.Windows.Forms.ListBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelCepage = new System.Windows.Forms.Label();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.labelVolumeUnitaire = new System.Windows.Forms.Label();
            this.labelFamille = new System.Windows.Forms.Label();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.labelref = new System.Windows.Forms.Label();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cepageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.anneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capacityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKArticleAnneeAnneeIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.ArticleTableAdapter();
            this.tableAdapterManager = new StiveLourd.StiveDBDataSetTableAdapters.TableAdapterManager();
            this.anneeTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.AnneeTableAdapter();
            this.capacityTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.CapacityTableAdapter();
            this.cepageTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.CepageTableAdapter();
            this.clientOrderTableAdapter1 = new StiveLourd.StiveDBDataSetTableAdapters.ClientOrderTableAdapter();
            this.familyTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.FamilyTableAdapter();
            this.supplierTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.SupplierTableAdapter();
            this.ShowProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.navContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepageBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKArticleAnneeAnneeIdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // navContainer
            // 
            this.navContainer.Controls.Add(this.comboBox1);
            this.navContainer.Controls.Add(this.comboBox4);
            this.navContainer.Controls.Add(this.comboBox3);
            this.navContainer.Controls.Add(this.comboBox2);
            this.navContainer.Controls.Add(this.comboBox5);
            this.navContainer.Controls.Add(this.articleDataGridView);
            this.navContainer.Controls.Add(this.button1);
            this.navContainer.Controls.Add(this.button2);
            this.navContainer.Controls.Add(this.TitrePage);
            this.navContainer.Controls.Add(this.labelNomFournisseur);
            this.navContainer.Controls.Add(this.listBoxNomFournisseur);
            this.navContainer.Controls.Add(this.labelCepage);
            this.navContainer.Controls.Add(this.labelAnnee);
            this.navContainer.Controls.Add(this.labelVolumeUnitaire);
            this.navContainer.Controls.Add(this.labelFamille);
            this.navContainer.Controls.Add(this.textBoxRef);
            this.navContainer.Controls.Add(this.labelref);
            this.navContainer.Location = new System.Drawing.Point(0, 0);
            this.navContainer.Name = "navContainer";
            this.navContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navContainer.Size = new System.Drawing.Size(954, 715);
            this.navContainer.TabIndex = 7;
            this.navContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.navContainer_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(356, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 47;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.familyBindingSource1, "Name", true));
            this.comboBox4.DataSource = this.familyBindingSource;
            this.comboBox4.DisplayMember = "Name";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(23, 199);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(168, 24);
            this.comboBox4.TabIndex = 46;
            this.comboBox4.ValueMember = "FamilyId";
            // 
            // familyBindingSource1
            // 
            this.familyBindingSource1.DataMember = "Family";
            this.familyBindingSource1.DataSource = this.stiveDBDataSet;
            // 
            // stiveDBDataSet
            // 
            this.stiveDBDataSet.DataSetName = "StiveDBDataSet";
            this.stiveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // familyBindingSource
            // 
            this.familyBindingSource.DataMember = "Family";
            this.familyBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.capacityBindingSource1, "BottleCapacity", true));
            this.comboBox3.DataSource = this.capacityBindingSource1;
            this.comboBox3.DisplayMember = "BottleCapacity";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(269, 199);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(168, 24);
            this.comboBox3.TabIndex = 45;
            this.comboBox3.ValueMember = "CapacityId";
            // 
            // capacityBindingSource1
            // 
            this.capacityBindingSource1.DataMember = "Capacity";
            this.capacityBindingSource1.DataSource = this.stiveDBDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.anneeBindingSource1, "Number", true));
            this.comboBox2.DataSource = this.anneeBindingSource1;
            this.comboBox2.DisplayMember = "Number";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(515, 199);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 24);
            this.comboBox2.TabIndex = 44;
            this.comboBox2.ValueMember = "Number";
            // 
            // anneeBindingSource1
            // 
            this.anneeBindingSource1.DataMember = "Annee";
            this.anneeBindingSource1.DataSource = this.stiveDBDataSet;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cepageBindingSource, "Name", true));
            this.comboBox5.DataSource = this.cepageBindingSource2;
            this.comboBox5.DisplayMember = "Name";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(761, 199);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(168, 24);
            this.comboBox5.TabIndex = 43;
            this.comboBox5.ValueMember = "CepageId";
            // 
            // cepageBindingSource
            // 
            this.cepageBindingSource.DataMember = "Cepage";
            this.cepageBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // cepageBindingSource2
            // 
            this.cepageBindingSource2.DataMember = "Cepage";
            this.cepageBindingSource2.DataSource = this.stiveDBDataSet;
            // 
            // articleDataGridView
            // 
            this.articleDataGridView.AllowUserToAddRows = false;
            this.articleDataGridView.AllowUserToDeleteRows = false;
            this.articleDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.articleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowProduct});
            this.articleDataGridView.Location = new System.Drawing.Point(23, 384);
            this.articleDataGridView.Name = "articleDataGridView";
            this.articleDataGridView.ReadOnly = true;
            this.articleDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.articleDataGridView.RowHeadersWidth = 51;
            this.articleDataGridView.RowTemplate.Height = 24;
            this.articleDataGridView.Size = new System.Drawing.Size(908, 311);
            this.articleDataGridView.TabIndex = 38;
            this.articleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articleDataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(895, 256);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 2;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.button2.Location = new System.Drawing.Point(713, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 31);
            this.button2.TabIndex = 38;
            this.button2.Text = "Ajouter un produit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TitrePage
            // 
            this.TitrePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitrePage.AutoSize = true;
            this.TitrePage.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.TitrePage.Location = new System.Drawing.Point(391, 33);
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
            this.labelNomFournisseur.Location = new System.Drawing.Point(20, 280);
            this.labelNomFournisseur.Name = "labelNomFournisseur";
            this.labelNomFournisseur.Size = new System.Drawing.Size(140, 23);
            this.labelNomFournisseur.TabIndex = 35;
            this.labelNomFournisseur.Text = "Nom Fournisseur";
            // 
            // listBoxNomFournisseur
            // 
            this.listBoxNomFournisseur.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierBindingSource, "Name", true));
            this.listBoxNomFournisseur.DataSource = this.supplierBindingSource1;
            this.listBoxNomFournisseur.DisplayMember = "Name";
            this.listBoxNomFournisseur.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNomFournisseur.FormattingEnabled = true;
            this.listBoxNomFournisseur.ItemHeight = 23;
            this.listBoxNomFournisseur.Location = new System.Drawing.Point(23, 304);
            this.listBoxNomFournisseur.Name = "listBoxNomFournisseur";
            this.listBoxNomFournisseur.Size = new System.Drawing.Size(239, 27);
            this.listBoxNomFournisseur.TabIndex = 34;
            this.listBoxNomFournisseur.ValueMember = "SupplierId";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataMember = "Supplier";
            this.supplierBindingSource1.DataSource = this.stiveDBDataSet;
            // 
            // labelCepage
            // 
            this.labelCepage.AutoSize = true;
            this.labelCepage.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelCepage.Location = new System.Drawing.Point(756, 173);
            this.labelCepage.Name = "labelCepage";
            this.labelCepage.Size = new System.Drawing.Size(68, 23);
            this.labelCepage.TabIndex = 33;
            this.labelCepage.Text = "Cépage";
            this.labelCepage.Click += new System.EventHandler(this.labelCepage_Click);
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelAnnee.Location = new System.Drawing.Point(514, 173);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(59, 23);
            this.labelAnnee.TabIndex = 31;
            this.labelAnnee.Text = "Année";
            // 
            // labelVolumeUnitaire
            // 
            this.labelVolumeUnitaire.AutoSize = true;
            this.labelVolumeUnitaire.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumeUnitaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelVolumeUnitaire.Location = new System.Drawing.Point(266, 175);
            this.labelVolumeUnitaire.Name = "labelVolumeUnitaire";
            this.labelVolumeUnitaire.Size = new System.Drawing.Size(133, 23);
            this.labelVolumeUnitaire.TabIndex = 29;
            this.labelVolumeUnitaire.Text = "Volume Unitaire";
            // 
            // labelFamille
            // 
            this.labelFamille.AutoSize = true;
            this.labelFamille.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelFamille.Location = new System.Drawing.Point(20, 175);
            this.labelFamille.Name = "labelFamille";
            this.labelFamille.Size = new System.Drawing.Size(62, 23);
            this.labelFamille.TabIndex = 27;
            this.labelFamille.Text = "Famille";
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(23, 130);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(382, 22);
            this.textBoxRef.TabIndex = 25;
            // 
            // labelref
            // 
            this.labelref.AutoSize = true;
            this.labelref.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelref.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelref.Location = new System.Drawing.Point(20, 104);
            this.labelref.Name = "labelref";
            this.labelref.Size = new System.Drawing.Size(170, 23);
            this.labelref.TabIndex = 24;
            this.labelref.Text = "Référence du produit";
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataMember = "Article";
            this.articleBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // cepageBindingSource1
            // 
            this.cepageBindingSource1.DataMember = "Cepage";
            this.cepageBindingSource1.DataSource = this.stiveDBDataSet;
            // 
            // anneeBindingSource
            // 
            this.anneeBindingSource.DataMember = "Annee";
            this.anneeBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // capacityBindingSource
            // 
            this.capacityBindingSource.DataMember = "Capacity";
            this.capacityBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // fKArticleAnneeAnneeIdBindingSource
            // 
            this.fKArticleAnneeAnneeIdBindingSource.DataMember = "FK_Article_Annee_AnneeId";
            this.fKArticleAnneeAnneeIdBindingSource.DataSource = this.anneeBindingSource;
            // 
            // articleTableAdapter
            // 
            this.articleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnneeTableAdapter = this.anneeTableAdapter;
            this.tableAdapterManager.ArticleRowTableAdapter = null;
            this.tableAdapterManager.ArticleTableAdapter = this.articleTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CapacityTableAdapter = this.capacityTableAdapter;
            this.tableAdapterManager.CepageTableAdapter = this.cepageTableAdapter;
            this.tableAdapterManager.ClientOrderTableAdapter = this.clientOrderTableAdapter1;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FamilyTableAdapter = this.familyTableAdapter;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UpdateOrder = StiveLourd.StiveDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // anneeTableAdapter
            // 
            this.anneeTableAdapter.ClearBeforeFill = true;
            // 
            // capacityTableAdapter
            // 
            this.capacityTableAdapter.ClearBeforeFill = true;
            // 
            // cepageTableAdapter
            // 
            this.cepageTableAdapter.ClearBeforeFill = true;
            // 
            // clientOrderTableAdapter1
            // 
            this.clientOrderTableAdapter1.ClearBeforeFill = true;
            // 
            // familyTableAdapter
            // 
            this.familyTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // ShowProduct
            // 
            this.ShowProduct.HeaderText = "";
            this.ShowProduct.MinimumWidth = 6;
            this.ShowProduct.Name = "ShowProduct";
            this.ShowProduct.ReadOnly = true;
            this.ShowProduct.Text = "Voir le produit";
            this.ShowProduct.Width = 125;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(954, 715);
            this.Controls.Add(this.navContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Products_Load);
            this.navContainer.ResumeLayout(false);
            this.navContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepageBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKArticleAnneeAnneeIdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel navContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TitrePage;
        private System.Windows.Forms.Label labelNomFournisseur;
        private System.Windows.Forms.ListBox listBoxNomFournisseur;
        private System.Windows.Forms.Label labelCepage;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.Label labelVolumeUnitaire;
        private System.Windows.Forms.Label labelFamille;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.Label labelref;
        private StiveDBDataSet stiveDBDataSet;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private StiveDBDataSetTableAdapters.ArticleTableAdapter articleTableAdapter;
        private StiveDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView articleDataGridView;
        private StiveDBDataSetTableAdapters.FamilyTableAdapter familyTableAdapter;
        private System.Windows.Forms.BindingSource familyBindingSource;
        private StiveDBDataSetTableAdapters.CepageTableAdapter cepageTableAdapter;
        private System.Windows.Forms.BindingSource cepageBindingSource;
        private System.Windows.Forms.BindingSource cepageBindingSource1;
        private StiveDBDataSetTableAdapters.AnneeTableAdapter anneeTableAdapter;
        private System.Windows.Forms.BindingSource anneeBindingSource;
        private StiveDBDataSetTableAdapters.CapacityTableAdapter capacityTableAdapter;
        private StiveDBDataSetTableAdapters.ClientOrderTableAdapter clientOrderTableAdapter1;
        private System.Windows.Forms.BindingSource capacityBindingSource;
        private StiveDBDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource fKArticleAnneeAnneeIdBindingSource;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource familyBindingSource1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource capacityBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource anneeBindingSource1;
        private System.Windows.Forms.BindingSource cepageBindingSource2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private System.Windows.Forms.DataGridViewButtonColumn ShowProduct;
    }
}