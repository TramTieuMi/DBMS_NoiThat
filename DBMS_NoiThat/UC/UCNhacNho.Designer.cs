namespace DBMS_NoiThat.UC
{
    partial class UCNhacNho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNhacNho = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // txtNhacNho
            // 
            this.txtNhacNho.BackColor = System.Drawing.Color.Transparent;
            this.txtNhacNho.Location = new System.Drawing.Point(108, 46);
            this.txtNhacNho.Name = "txtNhacNho";
            this.txtNhacNho.Size = new System.Drawing.Size(108, 18);
            this.txtNhacNho.TabIndex = 0;
            this.txtNhacNho.Text = "guna2HtmlLabel1";
            // 
            // UCNhacNho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txtNhacNho);
            this.Name = "UCNhacNho";
            this.Size = new System.Drawing.Size(1198, 150);
            this.Load += new System.EventHandler(this.UCNhacNho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txtNhacNho;
    }
}
