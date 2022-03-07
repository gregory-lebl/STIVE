
namespace StiveLourd.Pages
{
    partial class DetailsSupplier
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
            this.TitrePage = new System.Windows.Forms.Label();
            this.navContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // navContainer
            // 
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
            this.TitrePage.Location = new System.Drawing.Point(304, 28);
            this.TitrePage.Name = "TitrePage";
            this.TitrePage.Size = new System.Drawing.Size(346, 45);
            this.TitrePage.TabIndex = 56;
            this.TitrePage.Text = "FICHE FOURNISSEUR";
            // 
            // DetailsSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(954, 715);
            this.Controls.Add(this.navContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsSupplier";
            this.Text = "DetailsSupplier";
            this.Load += new System.EventHandler(this.DetailsSupplier_Load);
            this.navContainer.ResumeLayout(false);
            this.navContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navContainer;
        private System.Windows.Forms.Label TitrePage;
    }
}