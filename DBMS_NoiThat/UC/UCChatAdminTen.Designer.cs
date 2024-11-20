namespace DBMS_NoiThat.UC
{
    partial class UCChatAdminTen
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
            this.BTN_Ten = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // BTN_Ten
            // 
            this.BTN_Ten.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Ten.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Ten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Ten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Ten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_Ten.ForeColor = System.Drawing.Color.White;
            this.BTN_Ten.Location = new System.Drawing.Point(0, 0);
            this.BTN_Ten.Name = "BTN_Ten";
            this.BTN_Ten.Size = new System.Drawing.Size(250, 60);
            this.BTN_Ten.TabIndex = 0;
            this.BTN_Ten.Text = "guna2Button1";
            this.BTN_Ten.Click += new System.EventHandler(this.BTN_Ten_Click);
            // 
            // UCChatAdminTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_Ten);
            this.Name = "UCChatAdminTen";
            this.Size = new System.Drawing.Size(250, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BTN_Ten;
    }
}
