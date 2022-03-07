
namespace StiveLourd.Pages
{
    partial class Customers
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TitrePage = new System.Windows.Forms.Label();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.labelFamille = new System.Windows.Forms.Label();
            this.listBoxFamille = new System.Windows.Forms.ListBox();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.labelref = new System.Windows.Forms.Label();
            this.customersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stiveDBDataSet1 = new StiveLourd.StiveDBDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stiveDBDataSet = new StiveLourd.StiveDBDataSet();
            this.customersTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.CustomersTableAdapter();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.navContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // navContainer
            // 
            this.navContainer.AutoSize = true;
            this.navContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.navContainer.Controls.Add(this.label1);
            this.navContainer.Controls.Add(this.textBox2);
            this.navContainer.Controls.Add(this.label2);
            this.navContainer.Controls.Add(this.textBox1);
            this.navContainer.Controls.Add(this.TitrePage);
            this.navContainer.Controls.Add(this.clientDataGridView);
            this.navContainer.Controls.Add(this.button2);
            this.navContainer.Controls.Add(this.labelFamille);
            this.navContainer.Controls.Add(this.listBoxFamille);
            this.navContainer.Controls.Add(this.textBoxRef);
            this.navContainer.Controls.Add(this.labelref);
            this.navContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navContainer.Location = new System.Drawing.Point(0, 0);
            this.navContainer.Name = "navContainer";
            this.navContainer.Size = new System.Drawing.Size(954, 707);
            this.navContainer.TabIndex = 13;
            this.navContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.navContainer_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(556, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "Prénom du Client";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(560, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(382, 22);
            this.textBox2.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(9, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nom du Client";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 22);
            this.textBox1.TabIndex = 55;
            // 
            // TitrePage
            // 
            this.TitrePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitrePage.AutoSize = true;
            this.TitrePage.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.TitrePage.Location = new System.Drawing.Point(401, 9);
            this.TitrePage.Name = "TitrePage";
            this.TitrePage.Size = new System.Drawing.Size(150, 45);
            this.TitrePage.TabIndex = 54;
            this.TitrePage.Text = "CLIENTS";
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AllowUserToAddRows = false;
            this.clientDataGridView.AllowUserToDeleteRows = false;
            this.clientDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Location = new System.Drawing.Point(13, 362);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.ReadOnly = true;
            this.clientDataGridView.RowHeadersWidth = 51;
            this.clientDataGridView.RowTemplate.Height = 24;
            this.clientDataGridView.Size = new System.Drawing.Size(929, 316);
            this.clientDataGridView.TabIndex = 52;
            this.clientDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.button2.Location = new System.Drawing.Point(724, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 31);
            this.button2.TabIndex = 53;
            this.button2.Text = "Ajouter un client";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelFamille
            // 
            this.labelFamille.AutoSize = true;
            this.labelFamille.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelFamille.Location = new System.Drawing.Point(9, 270);
            this.labelFamille.Name = "labelFamille";
            this.labelFamille.Size = new System.Drawing.Size(42, 23);
            this.labelFamille.TabIndex = 43;
            this.labelFamille.Text = "Ville";
            // 
            // listBoxFamille
            // 
            this.listBoxFamille.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFamille.FormattingEnabled = true;
            this.listBoxFamille.ItemHeight = 23;
            this.listBoxFamille.Location = new System.Drawing.Point(13, 294);
            this.listBoxFamille.Name = "listBoxFamille";
            this.listBoxFamille.Size = new System.Drawing.Size(511, 27);
            this.listBoxFamille.TabIndex = 42;
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(13, 114);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(253, 22);
            this.textBoxRef.TabIndex = 41;
            // 
            // labelref
            // 
            this.labelref.AutoSize = true;
            this.labelref.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelref.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelref.Location = new System.Drawing.Point(9, 88);
            this.labelref.Name = "labelref";
            this.labelref.Size = new System.Drawing.Size(78, 23);
            this.labelref.TabIndex = 40;
            this.labelref.Text = "N° Client";
            // 
            // customersBindingSource2
            // 
            this.customersBindingSource2.DataMember = "Customers";
            this.customersBindingSource2.DataSource = this.stiveDBDataSet1;
            // 
            // stiveDBDataSet1
            // 
            this.stiveDBDataSet1.DataSetName = "StiveDBDataSet";
            this.stiveDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // stiveDBDataSet
            // 
            this.stiveDBDataSet.DataSetName = "StiveDBDataSet";
            this.stiveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.stiveDBDataSet;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 707);
            this.Controls.Add(this.navContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.navContainer.ResumeLayout(false);
            this.navContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navContainer;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelFamille;
        private System.Windows.Forms.ListBox listBoxFamille;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.Label labelref;
        private System.Windows.Forms.Label TitrePage;
        private StiveDBDataSet stiveDBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private StiveDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private StiveDBDataSet stiveDBDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource2;
    }
}