
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
            this.TitrePage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitrePage
            // 
            this.TitrePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitrePage.AutoSize = true;
            this.TitrePage.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.TitrePage.Location = new System.Drawing.Point(314, 23);
            this.TitrePage.Name = "TitrePage";
            this.TitrePage.Size = new System.Drawing.Size(346, 45);
            this.TitrePage.TabIndex = 55;
            this.TitrePage.Text = "FICHE FOURNISSEUR";
            // 
            // DetailsSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(954, 707);
            this.Controls.Add(this.TitrePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsSupplier";
            this.Text = "DetailsSupplier";
            this.Load += new System.EventHandler(this.DetailsSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitrePage;
    }
}