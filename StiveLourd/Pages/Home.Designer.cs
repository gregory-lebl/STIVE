
namespace StiveLourd.Pages
{
    partial class Home
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
            this.navContainer = new System.Windows.Forms.Panel();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.btn_facture = new System.Windows.Forms.Button();
            this.btn_add_client = new System.Windows.Forms.Button();
            this.btn_new_comm_fournisseur = new System.Windows.Forms.Button();
            this.btn_add_fournisseur = new System.Windows.Forms.Button();
            this.btn_add_produit = new System.Windows.Forms.Button();
            this.navContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // navContainer
            // 
            this.navContainer.Controls.Add(this.btn_add_user);
            this.navContainer.Controls.Add(this.btn_facture);
            this.navContainer.Controls.Add(this.btn_add_client);
            this.navContainer.Controls.Add(this.btn_new_comm_fournisseur);
            this.navContainer.Controls.Add(this.btn_add_fournisseur);
            this.navContainer.Controls.Add(this.btn_add_produit);
            this.navContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navContainer.Location = new System.Drawing.Point(0, 0);
            this.navContainer.Name = "navContainer";
            this.navContainer.Size = new System.Drawing.Size(954, 707);
            this.navContainer.TabIndex = 5;
            // 
            // btn_add_user
            // 
            this.btn_add_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.btn_add_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_user.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btn_add_user.Location = new System.Drawing.Point(653, 251);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(258, 150);
            this.btn_add_user.TabIndex = 5;
            this.btn_add_user.Text = "ADD Utilisateur";
            this.btn_add_user.UseVisualStyleBackColor = false;
            // 
            // btn_facture
            // 
            this.btn_facture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.btn_facture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_facture.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btn_facture.Location = new System.Drawing.Point(347, 251);
            this.btn_facture.Name = "btn_facture";
            this.btn_facture.Size = new System.Drawing.Size(250, 150);
            this.btn_facture.TabIndex = 4;
            this.btn_facture.Text = "Factures";
            this.btn_facture.UseVisualStyleBackColor = false;
            // 
            // btn_add_client
            // 
            this.btn_add_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.btn_add_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_client.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btn_add_client.Location = new System.Drawing.Point(41, 251);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Size = new System.Drawing.Size(250, 150);
            this.btn_add_client.TabIndex = 3;
            this.btn_add_client.Text = "ADD Client";
            this.btn_add_client.UseVisualStyleBackColor = false;
            this.btn_add_client.Click += new System.EventHandler(this.btn_add_client_Click);
            // 
            // btn_new_comm_fournisseur
            // 
            this.btn_new_comm_fournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.btn_new_comm_fournisseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_comm_fournisseur.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_comm_fournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btn_new_comm_fournisseur.Location = new System.Drawing.Point(653, 50);
            this.btn_new_comm_fournisseur.Name = "btn_new_comm_fournisseur";
            this.btn_new_comm_fournisseur.Size = new System.Drawing.Size(258, 150);
            this.btn_new_comm_fournisseur.TabIndex = 2;
            this.btn_new_comm_fournisseur.Text = "Nouvelle Commande Fournisseur";
            this.btn_new_comm_fournisseur.UseVisualStyleBackColor = false;
            this.btn_new_comm_fournisseur.Click += new System.EventHandler(this.btn_new_comm_fournisseur_Click);
            // 
            // btn_add_fournisseur
            // 
            this.btn_add_fournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.btn_add_fournisseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_fournisseur.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_fournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btn_add_fournisseur.Location = new System.Drawing.Point(347, 50);
            this.btn_add_fournisseur.Name = "btn_add_fournisseur";
            this.btn_add_fournisseur.Size = new System.Drawing.Size(250, 150);
            this.btn_add_fournisseur.TabIndex = 1;
            this.btn_add_fournisseur.Text = "ADD Fournisseur";
            this.btn_add_fournisseur.UseVisualStyleBackColor = false;
            this.btn_add_fournisseur.Click += new System.EventHandler(this.btn_add_fournisseur_Click);
            // 
            // btn_add_produit
            // 
            this.btn_add_produit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.btn_add_produit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_produit.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_produit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btn_add_produit.Location = new System.Drawing.Point(41, 50);
            this.btn_add_produit.Name = "btn_add_produit";
            this.btn_add_produit.Size = new System.Drawing.Size(250, 150);
            this.btn_add_produit.TabIndex = 0;
            this.btn_add_produit.Text = "ADD Produit";
            this.btn_add_produit.UseVisualStyleBackColor = false;
            this.btn_add_produit.Click += new System.EventHandler(this.btn_add_produit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 707);
            this.Controls.Add(this.navContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.navContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel navContainer;
        private System.Windows.Forms.Button btn_add_produit;
        private System.Windows.Forms.Button btn_add_client;
        private System.Windows.Forms.Button btn_new_comm_fournisseur;
        private System.Windows.Forms.Button btn_add_fournisseur;
        private System.Windows.Forms.Button btn_facture;
        private System.Windows.Forms.Button btn_add_user;
    }
}