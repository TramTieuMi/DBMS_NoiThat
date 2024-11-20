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
            this.txtNhacNho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhacNho.Location = new System.Drawing.Point(65, 30);
            this.txtNhacNho.Name = "txtNhacNho";
            this.txtNhacNho.Size = new System.Drawing.Size(121, 20);
            this.txtNhacNho.TabIndex = 0;
            this.txtNhacNho.Text = "Value Nhắc nhở";
            // 
            // UCNhacNho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.txtNhacNho);
            this.Name = "UCNhacNho";
            this.Size = new System.Drawing.Size(1198, 80);
            this.Load += new System.EventHandler(this.UCNhacNho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txtNhacNho;
    }
}
