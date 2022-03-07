
namespace StiveLourd.Pages
{
    partial class Commands
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
            this.navContainer = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clientOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stiveDBDataSet = new StiveLourd.StiveDBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxFamille = new System.Windows.Forms.ListBox();
            this.purchaseOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TitrePage = new System.Windows.Forms.Label();
            this.purchaseOrderTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.PurchaseOrderTableAdapter();
            this.tableAdapterManager = new StiveLourd.StiveDBDataSetTableAdapters.TableAdapterManager();
            this.articleRowTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.ArticleRowTableAdapter();
            this.clientOrderTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.ClientOrderTableAdapter();
            this.fKArticleRowClientOrderClientOrderIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.navContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKArticleRowClientOrderClientOrderIdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // navContainer
            // 
            this.navContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.navContainer.Controls.Add(this.label4);
            this.navContainer.Controls.Add(this.label3);
            this.navContainer.Controls.Add(this.listBox1);
            this.navContainer.Controls.Add(this.label2);
            this.navContainer.Controls.Add(this.label1);
            this.navContainer.Controls.Add(this.textBox2);
            this.navContainer.Controls.Add(this.textBox1);
            this.navContainer.Controls.Add(this.listBoxFamille);
            this.navContainer.Controls.Add(this.purchaseOrderDataGridView);
            this.navContainer.Controls.Add(this.TitrePage);
            this.navContainer.Location = new System.Drawing.Point(0, 0);
            this.navContainer.Name = "navContainer";
            this.navContainer.Size = new System.Drawing.Size(954, 762);
            this.navContainer.TabIndex = 11;
            this.navContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.navContainer_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(574, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 66;
            this.label4.Text = "Année";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(11, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 65;
            this.label3.Text = "Statut";
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientOrderBindingSource, "StatusId", true));
            this.listBox1.DataSource = this.clientOrderBindingSource;
            this.listBox1.DisplayMember = "Date";
            this.listBox1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(578, 215);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 27);
            this.listBox1.TabIndex = 64;
            this.listBox1.ValueMember = "Date";
            // 
            // clientOrderBindingSource
            // 
            this.clientOrderBindingSource.DataMember = "ClientOrder";
            this.clientOrderBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // stiveDBDataSet
            // 
            this.stiveDBDataSet.DataSetName = "StiveDBDataSet";
            this.stiveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Référence Commande";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(554, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "Référence Client";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(558, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(373, 22);
            this.textBox2.TabIndex = 61;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 22);
            this.textBox1.TabIndex = 60;
            // 
            // listBoxFamille
            // 
            this.listBoxFamille.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientOrderBindingSource, "StatusId", true));
            this.listBoxFamille.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFamille.FormattingEnabled = true;
            this.listBoxFamille.ItemHeight = 23;
            this.listBoxFamille.Location = new System.Drawing.Point(15, 215);
            this.listBoxFamille.Name = "listBoxFamille";
            this.listBoxFamille.Size = new System.Drawing.Size(382, 27);
            this.listBoxFamille.TabIndex = 59;
            // 
            // purchaseOrderDataGridView
            // 
            this.purchaseOrderDataGridView.AllowUserToAddRows = false;
            this.purchaseOrderDataGridView.AllowUserToDeleteRows = false;
            this.purchaseOrderDataGridView.AutoGenerateColumns = false;
            this.purchaseOrderDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.purchaseOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseOrderDataGridView.DataSource = this.purchaseOrderBindingSource;
            this.purchaseOrderDataGridView.Location = new System.Drawing.Point(12, 311);
            this.purchaseOrderDataGridView.Name = "purchaseOrderDataGridView";
            this.purchaseOrderDataGridView.ReadOnly = true;
            this.purchaseOrderDataGridView.RowHeadersWidth = 51;
            this.purchaseOrderDataGridView.RowTemplate.Height = 24;
            this.purchaseOrderDataGridView.Size = new System.Drawing.Size(919, 347);
            this.purchaseOrderDataGridView.TabIndex = 55;
            // 
            // purchaseOrderBindingSource
            // 
            this.purchaseOrderBindingSource.DataMember = "PurchaseOrder";
            this.purchaseOrderBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // TitrePage
            // 
            this.TitrePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitrePage.AutoSize = true;
            this.TitrePage.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.TitrePage.Location = new System.Drawing.Point(354, 25);
            this.TitrePage.Name = "TitrePage";
            this.TitrePage.Size = new System.Drawing.Size(240, 45);
            this.TitrePage.TabIndex = 55;
            this.TitrePage.Text = "COMMANDES";
            // 
            // purchaseOrderTableAdapter
            // 
            this.purchaseOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnneeTableAdapter = null;
            this.tableAdapterManager.ArticleRowTableAdapter = this.articleRowTableAdapter;
            this.tableAdapterManager.ArticleTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CapacityTableAdapter = null;
            this.tableAdapterManager.CepageTableAdapter = null;
            this.tableAdapterManager.ClientOrderTableAdapter = this.clientOrderTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FamilyTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderTableAdapter = this.purchaseOrderTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StiveLourd.StiveDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // articleRowTableAdapter
            // 
            this.articleRowTableAdapter.ClearBeforeFill = true;
            // 
            // clientOrderTableAdapter
            // 
            this.clientOrderTableAdapter.ClearBeforeFill = true;
            // 
            // fKArticleRowClientOrderClientOrderIdBindingSource
            // 
            this.fKArticleRowClientOrderClientOrderIdBindingSource.DataMember = "FK_ArticleRow_ClientOrder_ClientOrderId";
            this.fKArticleRowClientOrderClientOrderIdBindingSource.DataSource = this.clientOrderBindingSource;
            // 
            // Commands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 762);
            this.Controls.Add(this.navContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Commands";
            this.Text = "Commands";
            this.Load += new System.EventHandler(this.Commands_Load);
            this.navContainer.ResumeLayout(false);
            this.navContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKArticleRowClientOrderClientOrderIdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navContainer;
        private System.Windows.Forms.Label TitrePage;
        private StiveDBDataSet stiveDBDataSet;
        private System.Windows.Forms.BindingSource purchaseOrderBindingSource;
        private StiveDBDataSetTableAdapters.PurchaseOrderTableAdapter purchaseOrderTableAdapter;
        private StiveDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView purchaseOrderDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxFamille;
        private StiveDBDataSetTableAdapters.ClientOrderTableAdapter clientOrderTableAdapter;
        private System.Windows.Forms.BindingSource clientOrderBindingSource;
        private StiveDBDataSetTableAdapters.ArticleRowTableAdapter articleRowTableAdapter;
        private System.Windows.Forms.BindingSource fKArticleRowClientOrderClientOrderIdBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
    }
}