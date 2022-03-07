using StiveLourd.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StiveLourd.Pages
{
    public partial class DetailsCustomer : Form
    {
        private Label TitrePage;
        private Label phoneLabel;
        private Label VilleLabel;
        private Label CpLabel;
        private Label AdresseLabel;
        private Label EmailLabel;
        private Label LastnameLabel;
        private Label FirstnameLabel;
        private Label label1;
        private Label label2;
        private Label ReferenceLabel;
        private Panel navContainer;

        public DetailsCustomer(Client client)
        {
            InitializeComponent();
            LastnameLabel.Text=client.lastName;
            FirstnameLabel.Text=client.firstName;
            AdresseLabel.Text=client.address;
            EmailLabel.Text=client.email;
            phoneLabel.Text=client.phoneNumber;
            CpLabel.Text=client.cp;
            VilleLabel.Text=client.city;
            ReferenceLabel.Text=client.customerReference;
        }

        private void InitializeComponent()
        {
            this.navContainer = new System.Windows.Forms.Panel();
            this.TitrePage = new System.Windows.Forms.Label();
            this.FirstnameLabel = new System.Windows.Forms.Label();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AdresseLabel = new System.Windows.Forms.Label();
            this.CpLabel = new System.Windows.Forms.Label();
            this.VilleLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.ReferenceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // navContainer
            // 
            this.navContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.navContainer.Controls.Add(this.label1);
            this.navContainer.Controls.Add(this.label2);
            this.navContainer.Controls.Add(this.ReferenceLabel);
            this.navContainer.Controls.Add(this.phoneLabel);
            this.navContainer.Controls.Add(this.VilleLabel);
            this.navContainer.Controls.Add(this.CpLabel);
            this.navContainer.Controls.Add(this.AdresseLabel);
            this.navContainer.Controls.Add(this.EmailLabel);
            this.navContainer.Controls.Add(this.LastnameLabel);
            this.navContainer.Controls.Add(this.FirstnameLabel);
            this.navContainer.Controls.Add(this.TitrePage);
            this.navContainer.Location = new System.Drawing.Point(0, 0);
            this.navContainer.Name = "navContainer";
            this.navContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navContainer.Size = new System.Drawing.Size(954, 715);
            this.navContainer.TabIndex = 7;
            // 
            // TitrePage
            // 
            this.TitrePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitrePage.AutoSize = true;
            this.TitrePage.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.TitrePage.Location = new System.Drawing.Point(348, 34);
            this.TitrePage.Name = "TitrePage";
            this.TitrePage.Size = new System.Drawing.Size(231, 45);
            this.TitrePage.TabIndex = 57;
            this.TitrePage.Text = "FICHE CLIENT";
            this.TitrePage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstnameLabel.Location = new System.Drawing.Point(47, 113);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(277, 69);
            this.FirstnameLabel.TabIndex = 58;
            this.FirstnameLabel.Text = "firstname";
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastnameLabel.Location = new System.Drawing.Point(47, 182);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(219, 55);
            this.LastnameLabel.TabIndex = 59;
            this.LastnameLabel.Text = "lastname";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(64, 467);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(49, 20);
            this.EmailLabel.TabIndex = 60;
            this.EmailLabel.Text = "email";
            // 
            // AdresseLabel
            // 
            this.AdresseLabel.AutoSize = true;
            this.AdresseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresseLabel.Location = new System.Drawing.Point(64, 311);
            this.AdresseLabel.Name = "AdresseLabel";
            this.AdresseLabel.Size = new System.Drawing.Size(69, 20);
            this.AdresseLabel.TabIndex = 61;
            this.AdresseLabel.Text = "adresse";
            // 
            // CpLabel
            // 
            this.CpLabel.AutoSize = true;
            this.CpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpLabel.Location = new System.Drawing.Point(64, 344);
            this.CpLabel.Name = "CpLabel";
            this.CpLabel.Size = new System.Drawing.Size(27, 20);
            this.CpLabel.TabIndex = 62;
            this.CpLabel.Text = "cp";
            // 
            // VilleLabel
            // 
            this.VilleLabel.AutoSize = true;
            this.VilleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VilleLabel.Location = new System.Drawing.Point(64, 377);
            this.VilleLabel.Name = "VilleLabel";
            this.VilleLabel.Size = new System.Drawing.Size(38, 20);
            this.VilleLabel.TabIndex = 63;
            this.VilleLabel.Text = "ville";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(64, 430);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(54, 20);
            this.phoneLabel.TabIndex = 64;
            this.phoneLabel.Text = "phone";
            // 
            // ReferenceLabel
            // 
            this.ReferenceLabel.AutoSize = true;
            this.ReferenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceLabel.Location = new System.Drawing.Point(721, 160);
            this.ReferenceLabel.Name = "ReferenceLabel";
            this.ReferenceLabel.Size = new System.Drawing.Size(80, 20);
            this.ReferenceLabel.TabIndex = 65;
            this.ReferenceLabel.Text = "reference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Référence client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Adresse";
            // 
            // DetailsCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(954, 715);
            this.Controls.Add(this.navContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsCustomer";
            this.navContainer.ResumeLayout(false);
            this.navContainer.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
