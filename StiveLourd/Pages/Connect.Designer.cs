
namespace StiveLourd.Pages
{
    partial class Connect
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
            this.btn_connexion = new System.Windows.Forms.Button();
            this.navContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // navContainer
            // 
            this.navContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.navContainer.Controls.Add(this.btn_connexion);
            this.navContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navContainer.Location = new System.Drawing.Point(0, 0);
            this.navContainer.Name = "navContainer";
            this.navContainer.Size = new System.Drawing.Size(800, 450);
            this.navContainer.TabIndex = 0;
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(304, 181);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(162, 30);
            this.btn_connexion.TabIndex = 0;
            this.btn_connexion.Text = "CONNEXION";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navContainer);
            this.Name = "Connect";
            this.Text = "Connect";
            this.navContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navContainer;
        private System.Windows.Forms.Button btn_connexion;
    }
}