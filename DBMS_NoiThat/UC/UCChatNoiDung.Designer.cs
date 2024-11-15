namespace DBMS_NoiThat.UC
{
    partial class UCChatNoiDung
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
            this.LB_Ten = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TB_NoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // LB_Ten
            // 
            this.LB_Ten.BackColor = System.Drawing.Color.Transparent;
            this.LB_Ten.Location = new System.Drawing.Point(17, 4);
            this.LB_Ten.Name = "LB_Ten";
            this.LB_Ten.Size = new System.Drawing.Size(108, 18);
            this.LB_Ten.TabIndex = 0;
            this.LB_Ten.Text = "guna2HtmlLabel1";
            // 
            // TB_NoiDung
            // 
            this.TB_NoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_NoiDung.DefaultText = "";
            this.TB_NoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_NoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_NoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_NoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_NoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_NoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_NoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_NoiDung.Location = new System.Drawing.Point(3, 29);
            this.TB_NoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_NoiDung.Name = "TB_NoiDung";
            this.TB_NoiDung.PasswordChar = '\0';
            this.TB_NoiDung.PlaceholderText = "";
            this.TB_NoiDung.SelectedText = "";
            this.TB_NoiDung.Size = new System.Drawing.Size(840, 37);
            this.TB_NoiDung.TabIndex = 1;
            // 
            // UCChatNoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_NoiDung);
            this.Controls.Add(this.LB_Ten);
            this.Name = "UCChatNoiDung";
            this.Size = new System.Drawing.Size(840, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LB_Ten;
        private Guna.UI2.WinForms.Guna2TextBox TB_NoiDung;
    }
}
