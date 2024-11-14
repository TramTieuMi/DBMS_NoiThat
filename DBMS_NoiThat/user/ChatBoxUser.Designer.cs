namespace DBMS_NoiThat.user
{
    partial class ChatBoxUser
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BTN_Gui = new Guna.UI2.WinForms.Guna2Button();
            this.FLP_NoiDung = new System.Windows.Forms.FlowLayoutPanel();
            this.TB_NoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.BTN_Gui);
            this.guna2Panel1.Controls.Add(this.FLP_NoiDung);
            this.guna2Panel1.Controls.Add(this.TB_NoiDung);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(868, 523);
            this.guna2Panel1.TabIndex = 0;
            // 
            // BTN_Gui
            // 
            this.BTN_Gui.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Gui.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Gui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Gui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Gui.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_Gui.ForeColor = System.Drawing.Color.White;
            this.BTN_Gui.Location = new System.Drawing.Point(763, 455);
            this.BTN_Gui.Name = "BTN_Gui";
            this.BTN_Gui.Size = new System.Drawing.Size(102, 67);
            this.BTN_Gui.TabIndex = 2;
            this.BTN_Gui.Text = "Gửi";
            this.BTN_Gui.Click += new System.EventHandler(this.BTN_Gui_Click);
            // 
            // FLP_NoiDung
            // 
            this.FLP_NoiDung.AutoScroll = true;
            this.FLP_NoiDung.Location = new System.Drawing.Point(0, 0);
            this.FLP_NoiDung.Name = "FLP_NoiDung";
            this.FLP_NoiDung.Size = new System.Drawing.Size(867, 455);
            this.FLP_NoiDung.TabIndex = 1;
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
            this.TB_NoiDung.Location = new System.Drawing.Point(0, 455);
            this.TB_NoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_NoiDung.Name = "TB_NoiDung";
            this.TB_NoiDung.PasswordChar = '\0';
            this.TB_NoiDung.PlaceholderText = "";
            this.TB_NoiDung.SelectedText = "";
            this.TB_NoiDung.Size = new System.Drawing.Size(763, 68);
            this.TB_NoiDung.TabIndex = 0;
            // 
            // ChatBoxUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 523);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ChatBoxUser";
            this.Text = "ChatBoxUser";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox TB_NoiDung;
        private Guna.UI2.WinForms.Guna2Button BTN_Gui;
        private System.Windows.Forms.FlowLayoutPanel FLP_NoiDung;
    }
}