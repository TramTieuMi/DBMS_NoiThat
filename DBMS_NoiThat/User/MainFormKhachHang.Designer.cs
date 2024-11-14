namespace DBMS_NoiThat.user
{
    partial class MainFormKhachHang
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
            this.components = new System.ComponentModel.Container();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_left = new System.Windows.Forms.Panel();
            this.BTN_Chat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonLSMH = new System.Windows.Forms.Button();
            this.buttonGioHang = new System.Windows.Forms.Button();
            this.buttonTTCN = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.hello = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.White;
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(202, 100);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1115, 555);
            this.panel_Body.TabIndex = 11;
            this.panel_Body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Body_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.Gray;
            this.panel_left.Controls.Add(this.BTN_Chat);
            this.panel_left.Controls.Add(this.pictureBox1);
            this.panel_left.Controls.Add(this.labelMenu);
            this.panel_left.Controls.Add(this.buttonLogOut);
            this.panel_left.Controls.Add(this.pictureBox1);
            this.panel_left.Controls.Add(this.buttonLSMH);
            this.panel_left.Controls.Add(this.buttonGioHang);
            this.panel_left.Controls.Add(this.buttonTTCN);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 100);
            this.panel_left.Margin = new System.Windows.Forms.Padding(2);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(202, 555);
            this.panel_left.TabIndex = 9;
            // 
            // BTN_Chat
            // 
            this.BTN_Chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Chat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_Chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Chat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Chat.ForeColor = System.Drawing.Color.White;
            this.BTN_Chat.Location = new System.Drawing.Point(7, 227);
            this.BTN_Chat.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Chat.Name = "BTN_Chat";
            this.BTN_Chat.Size = new System.Drawing.Size(172, 41);
            this.BTN_Chat.TabIndex = 7;
            this.BTN_Chat.Text = "Hộp Thoại Tư Vấn";
            this.BTN_Chat.UseVisualStyleBackColor = false;
            this.BTN_Chat.Click += new System.EventHandler(this.BTN_Chat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBMS_NoiThat.Properties.Resources.thiet_ke_logo_cong_ty_noi_that_house;
            this.pictureBox1.Location = new System.Drawing.Point(80, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelMenu
            // 
            this.labelMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Black;
            this.labelMenu.Location = new System.Drawing.Point(7, 27);
            this.labelMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(96, 38);
            this.labelMenu.TabIndex = 4;
            this.labelMenu.Text = "MENU";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMenu.Click += new System.EventHandler(this.labelMenu_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonLogOut.Location = new System.Drawing.Point(8, 272);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(172, 41);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonLSMH
            // 
            this.buttonLSMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLSMH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLSMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLSMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLSMH.ForeColor = System.Drawing.Color.White;
            this.buttonLSMH.Location = new System.Drawing.Point(7, 182);
            this.buttonLSMH.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLSMH.Name = "buttonLSMH";
            this.buttonLSMH.Size = new System.Drawing.Size(172, 41);
            this.buttonLSMH.TabIndex = 3;
            this.buttonLSMH.Text = "Lịch Sử Mua Hàng";
            this.buttonLSMH.UseVisualStyleBackColor = false;
            this.buttonLSMH.Click += new System.EventHandler(this.buttonLSMH_Click);
            // 
            // buttonGioHang
            // 
            this.buttonGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGioHang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGioHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGioHang.ForeColor = System.Drawing.Color.White;
            this.buttonGioHang.Location = new System.Drawing.Point(7, 139);
            this.buttonGioHang.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGioHang.Name = "buttonGioHang";
            this.buttonGioHang.Size = new System.Drawing.Size(172, 41);
            this.buttonGioHang.TabIndex = 2;
            this.buttonGioHang.Text = "Giỏ Hàng";
            this.buttonGioHang.UseVisualStyleBackColor = false;
            this.buttonGioHang.Click += new System.EventHandler(this.buttonGioHang_Click);
            // 
            // buttonTTCN
            // 
            this.buttonTTCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTTCN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTTCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTTCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTTCN.ForeColor = System.Drawing.Color.White;
            this.buttonTTCN.Location = new System.Drawing.Point(7, 99);
            this.buttonTTCN.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTTCN.Name = "buttonTTCN";
            this.buttonTTCN.Size = new System.Drawing.Size(172, 41);
            this.buttonTTCN.TabIndex = 1;
            this.buttonTTCN.Text = "Thông Tin Cá Nhân";
            this.buttonTTCN.UseVisualStyleBackColor = false;
            this.buttonTTCN.Click += new System.EventHandler(this.buttonTTCN_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTitle.Location = new System.Drawing.Point(22, 32);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(142, 29);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "BoConcept";
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Top.Controls.Add(this.hello);
            this.panel_Top.Controls.Add(this.lbTitle);
            this.panel_Top.Controls.Add(this.labelDate);
            this.panel_Top.Controls.Add(this.labelTime);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1317, 100);
            this.panel_Top.TabIndex = 10;
            // 
            // hello
            // 
            this.hello.BackColor = System.Drawing.Color.Transparent;
            this.hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello.Location = new System.Drawing.Point(168, 41);
            this.hello.Margin = new System.Windows.Forms.Padding(2);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(104, 19);
            this.hello.TabIndex = 4;
            this.hello.Text = "label welcome";
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(501, 6);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(389, 31);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "label1";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Black;
            this.labelTime.Location = new System.Drawing.Point(1050, 61);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(230, 25);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "label1";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainFormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 655);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_Top);
            this.Name = "MainFormKhachHang";
            this.Text = "MainFormKhachHang";
            this.Load += new System.EventHandler(this.MainFormKhachHang_Load);
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLSMH;
        private System.Windows.Forms.Button buttonGioHang;
        private System.Windows.Forms.Button buttonTTCN;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel hello;
        private System.Windows.Forms.Button BTN_Chat;
    }
}