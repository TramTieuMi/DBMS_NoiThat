namespace DBMS_NoiThat.admin
{
    partial class ChatBoxAdmin
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
            this.TB_Nhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.FLP_Chat = new System.Windows.Forms.FlowLayoutPanel();
            this.FLP_Ten = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.BTN_Gui);
            this.guna2Panel1.Controls.Add(this.TB_Nhap);
            this.guna2Panel1.Controls.Add(this.FLP_Chat);
            this.guna2Panel1.Controls.Add(this.FLP_Ten);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1117, 587);
            this.guna2Panel1.TabIndex = 0;
            // 
            // BTN_Gui
            // 
            this.BTN_Gui.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Gui.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Gui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Gui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Gui.FillColor = System.Drawing.Color.Black;
            this.BTN_Gui.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_Gui.ForeColor = System.Drawing.Color.White;
            this.BTN_Gui.Location = new System.Drawing.Point(1002, 520);
            this.BTN_Gui.Name = "BTN_Gui";
            this.BTN_Gui.Size = new System.Drawing.Size(113, 67);
            this.BTN_Gui.TabIndex = 3;
            this.BTN_Gui.Text = "Gửi";
            this.BTN_Gui.Click += new System.EventHandler(this.BTN_Gui_Click);
            // 
            // TB_Nhap
            // 
            this.TB_Nhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Nhap.DefaultText = "";
            this.TB_Nhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_Nhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_Nhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_Nhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_Nhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_Nhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_Nhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_Nhap.Location = new System.Drawing.Point(250, 520);
            this.TB_Nhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Nhap.Name = "TB_Nhap";
            this.TB_Nhap.PasswordChar = '\0';
            this.TB_Nhap.PlaceholderText = "";
            this.TB_Nhap.SelectedText = "";
            this.TB_Nhap.Size = new System.Drawing.Size(750, 67);
            this.TB_Nhap.TabIndex = 2;
            // 
            // FLP_Chat
            // 
            this.FLP_Chat.AutoScroll = true;
            this.FLP_Chat.Location = new System.Drawing.Point(250, 0);
            this.FLP_Chat.Name = "FLP_Chat";
            this.FLP_Chat.Size = new System.Drawing.Size(867, 520);
            this.FLP_Chat.TabIndex = 1;
            // 
            // FLP_Ten
            // 
            this.FLP_Ten.AutoScroll = true;
            this.FLP_Ten.Location = new System.Drawing.Point(0, 0);
            this.FLP_Ten.Name = "FLP_Ten";
            this.FLP_Ten.Size = new System.Drawing.Size(250, 587);
            this.FLP_Ten.TabIndex = 0;
            // 
            // ChatBoxAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 587);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ChatBoxAdmin";
            this.Text = "ChatBoxAdmin";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel FLP_Ten;
        private System.Windows.Forms.FlowLayoutPanel FLP_Chat;
        private Guna.UI2.WinForms.Guna2TextBox TB_Nhap;
        private Guna.UI2.WinForms.Guna2Button BTN_Gui;
    }
}