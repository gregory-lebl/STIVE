
namespace StiveLourd.Pages
{
    partial class AddCommSuppliers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formFournisseur = new System.Windows.Forms.Panel();
            this.dataGridView_cmd = new System.Windows.Forms.DataGridView();
            this.Ref_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_unitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_ht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNumSIRET = new System.Windows.Forms.TextBox();
            this.labelNumSIRET = new System.Windows.Forms.Label();
            this.textBoxNomFour = new System.Windows.Forms.TextBox();
            this.labelNomFour = new System.Windows.Forms.Label();
            this.NumeroCommande = new System.Windows.Forms.Label();
            this.labelCmdNum = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.FollowBy = new System.Windows.Forms.Label();
            this.btn_new_cmd_fournisseur = new System.Windows.Forms.Button();
            this.TitrePage = new System.Windows.Forms.Label();
            this.labelFollowBy = new System.Windows.Forms.Label();
            this.formFournisseur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cmd)).BeginInit();
            this.SuspendLayout();
            // 
            // formFournisseur
            // 
            this.formFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.formFournisseur.Controls.Add(this.dataGridView_cmd);
            this.formFournisseur.Controls.Add(this.textBoxNumSIRET);
            this.formFournisseur.Controls.Add(this.labelNumSIRET);
            this.formFournisseur.Controls.Add(this.textBoxNomFour);
            this.formFournisseur.Controls.Add(this.labelNomFour);
            this.formFournisseur.Controls.Add(this.NumeroCommande);
            this.formFournisseur.Controls.Add(this.labelCmdNum);
            this.formFournisseur.Controls.Add(this.DateLabel);
            this.formFournisseur.Controls.Add(this.labelDate);
            this.formFournisseur.Controls.Add(this.FollowBy);
            this.formFournisseur.Controls.Add(this.btn_new_cmd_fournisseur);
            this.formFournisseur.Controls.Add(this.TitrePage);
            this.formFournisseur.Controls.Add(this.labelFollowBy);
            this.formFournisseur.Location = new System.Drawing.Point(0, 0);
            this.formFournisseur.Name = "formFournisseur";
            this.formFournisseur.Size = new System.Drawing.Size(954, 707);
            this.formFournisseur.TabIndex = 4;
            this.formFournisseur.Paint += new System.Windows.Forms.PaintEventHandler(this.formFournisseur_Paint);
            // 
            // dataGridView_cmd
            // 
            this.dataGridView_cmd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_cmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ref_produit,
            this.quantite,
            this.prix_unitaire,
            this.montant_ht});
            this.dataGridView_cmd.Location = new System.Drawing.Point(36, 308);
            this.dataGridView_cmd.Name = "dataGridView_cmd";
            this.dataGridView_cmd.RowHeadersWidth = 51;
            this.dataGridView_cmd.RowTemplate.Height = 24;
            this.dataGridView_cmd.Size = new System.Drawing.Size(870, 219);
            this.dataGridView_cmd.TabIndex = 50;
            // 
            // Ref_produit
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.Ref_produit.DefaultCellStyle = dataGridViewCellStyle5;
            this.Ref_produit.HeaderText = "Références produits";
            this.Ref_produit.MinimumWidth = 125;
            this.Ref_produit.Name = "Ref_produit";
            this.Ref_produit.Width = 150;
            // 
            // quantite
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.quantite.DefaultCellStyle = dataGridViewCellStyle6;
            this.quantite.HeaderText = "Quantité";
            this.quantite.MinimumWidth = 125;
            this.quantite.Name = "quantite";
            this.quantite.Width = 125;
            // 
            // prix_unitaire
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.prix_unitaire.DefaultCellStyle = dataGridViewCellStyle7;
            this.prix_unitaire.HeaderText = "Prix Unitaire";
            this.prix_unitaire.MinimumWidth = 125;
            this.prix_unitaire.Name = "prix_unitaire";
            this.prix_unitaire.ReadOnly = true;
            this.prix_unitaire.Width = 125;
            // 
            // montant_ht
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.montant_ht.DefaultCellStyle = dataGridViewCellStyle8;
            this.montant_ht.HeaderText = "Montant HT";
            this.montant_ht.MinimumWidth = 125;
            this.montant_ht.Name = "montant_ht";
            this.montant_ht.ReadOnly = true;
            this.montant_ht.Width = 150;
            // 
            // textBoxNumSIRET
            // 
            this.textBoxNumSIRET.Location = new System.Drawing.Point(461, 218);
            this.textBoxNumSIRET.Name = "textBoxNumSIRET";
            this.textBoxNumSIRET.Size = new System.Drawing.Size(445, 22);
            this.textBoxNumSIRET.TabIndex = 48;
            // 
            // labelNumSIRET
            // 
            this.labelNumSIRET.AutoSize = true;
            this.labelNumSIRET.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumSIRET.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelNumSIRET.Location = new System.Drawing.Point(461, 192);
            this.labelNumSIRET.Name = "labelNumSIRET";
            this.labelNumSIRET.Size = new System.Drawing.Size(120, 23);
            this.labelNumSIRET.TabIndex = 47;
            this.labelNumSIRET.Text = "Numéro SIRET";
            // 
            // textBoxNomFour
            // 
            this.textBoxNomFour.Location = new System.Drawing.Point(32, 218);
            this.textBoxNomFour.Name = "textBoxNomFour";
            this.textBoxNomFour.Size = new System.Drawing.Size(382, 22);
            this.textBoxNomFour.TabIndex = 46;
            // 
            // labelNomFour
            // 
            this.labelNomFour.AutoSize = true;
            this.labelNomFour.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelNomFour.Location = new System.Drawing.Point(32, 192);
            this.labelNomFour.Name = "labelNomFour";
            this.labelNomFour.Size = new System.Drawing.Size(137, 23);
            this.labelNomFour.TabIndex = 45;
            this.labelNomFour.Text = "Nom fournisseur";
            // 
            // NumeroCommande
            // 
            this.NumeroCommande.AutoSize = true;
            this.NumeroCommande.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroCommande.ForeColor = System.Drawing.Color.Gray;
            this.NumeroCommande.Location = new System.Drawing.Point(787, 125);
            this.NumeroCommande.Name = "NumeroCommande";
            this.NumeroCommande.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NumeroCommande.Size = new System.Drawing.Size(123, 23);
            this.NumeroCommande.TabIndex = 44;
            this.NumeroCommande.Text = "N° Commande";
            // 
            // labelCmdNum
            // 
            this.labelCmdNum.AutoSize = true;
            this.labelCmdNum.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCmdNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelCmdNum.Location = new System.Drawing.Point(787, 99);
            this.labelCmdNum.Name = "labelCmdNum";
            this.labelCmdNum.Size = new System.Drawing.Size(123, 23);
            this.labelCmdNum.TabIndex = 43;
            this.labelCmdNum.Text = "Commande N°";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.Gray;
            this.DateLabel.Location = new System.Drawing.Point(109, 125);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateLabel.Size = new System.Drawing.Size(46, 23);
            this.DateLabel.TabIndex = 42;
            this.DateLabel.Text = "Date";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelDate.Location = new System.Drawing.Point(28, 125);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 23);
            this.labelDate.TabIndex = 41;
            this.labelDate.Text = "Date";
            // 
            // FollowBy
            // 
            this.FollowBy.AutoSize = true;
            this.FollowBy.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowBy.ForeColor = System.Drawing.Color.Gray;
            this.FollowBy.Location = new System.Drawing.Point(107, 99);
            this.FollowBy.Name = "FollowBy";
            this.FollowBy.Size = new System.Drawing.Size(97, 23);
            this.FollowBy.TabIndex = 40;
            this.FollowBy.Text = "Utlisateur 1";
            this.FollowBy.Click += new System.EventHandler(this.FollowBy_Click);
            // 
            // btn_new_cmd_fournisseur
            // 
            this.btn_new_cmd_fournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.btn_new_cmd_fournisseur.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_cmd_fournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btn_new_cmd_fournisseur.Location = new System.Drawing.Point(754, 559);
            this.btn_new_cmd_fournisseur.Name = "btn_new_cmd_fournisseur";
            this.btn_new_cmd_fournisseur.Size = new System.Drawing.Size(152, 91);
            this.btn_new_cmd_fournisseur.TabIndex = 24;
            this.btn_new_cmd_fournisseur.Text = "Nouvelle Commande fournisseur";
            this.btn_new_cmd_fournisseur.UseVisualStyleBackColor = false;
            // 
            // TitrePage
            // 
            this.TitrePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitrePage.AutoSize = true;
            this.TitrePage.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.TitrePage.Location = new System.Drawing.Point(202, 23);
            this.TitrePage.Name = "TitrePage";
            this.TitrePage.Size = new System.Drawing.Size(632, 45);
            this.TitrePage.TabIndex = 23;
            this.TitrePage.Text = "NOUVELLE COMMANDE FOURNISSEUR";
            this.TitrePage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFollowBy
            // 
            this.labelFollowBy.AutoSize = true;
            this.labelFollowBy.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFollowBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.labelFollowBy.Location = new System.Drawing.Point(28, 99);
            this.labelFollowBy.Name = "labelFollowBy";
            this.labelFollowBy.Size = new System.Drawing.Size(75, 23);
            this.labelFollowBy.TabIndex = 1;
            this.labelFollowBy.Text = "Suivi par";
            // 
            // AddCommSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 707);
            this.Controls.Add(this.formFournisseur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCommSuppliers";
            this.Text = "AddCommSuppliers";
            this.formFournisseur.ResumeLayout(false);
            this.formFournisseur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cmd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formFournisseur;
        private System.Windows.Forms.Label NumeroCommande;
        private System.Windows.Forms.Label labelCmdNum;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label FollowBy;
        private System.Windows.Forms.Button btn_new_cmd_fournisseur;
        private System.Windows.Forms.Label TitrePage;
        private System.Windows.Forms.Label labelFollowBy;
        private System.Windows.Forms.TextBox textBoxNumSIRET;
        private System.Windows.Forms.Label labelNumSIRET;
        private System.Windows.Forms.TextBox textBoxNomFour;
        private System.Windows.Forms.Label labelNomFour;
        private System.Windows.Forms.DataGridView dataGridView_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_unitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_ht;
    }
}