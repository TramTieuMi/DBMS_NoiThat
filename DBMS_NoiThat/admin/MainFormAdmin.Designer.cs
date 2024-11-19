namespace DBMS_NoiThat.user
{
    partial class MainFormAdmin
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
            this.hello = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelIDNV = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonQLDH = new System.Windows.Forms.Button();
            this.buttonSP = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.BTN_ChatBox = new System.Windows.Forms.Button();
            this.buttonThongKeDoanhThu = new System.Windows.Forms.Button();
            this.buttonQLTT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Body = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NhacNho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // hello
            // 
            this.hello.BackColor = System.Drawing.Color.Transparent;
            this.hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello.Location = new System.Drawing.Point(31, 66);
            this.hello.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(173, 31);
            this.hello.TabIndex = 4;
            this.hello.Text = "label welcome";
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(1241, 80);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(231, 31);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "label1";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMenu
            // 
            this.labelMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.Black;
            this.labelMenu.Location = new System.Drawing.Point(12, 44);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(95, 42);
            this.labelMenu.TabIndex = 4;
            this.labelMenu.Text = "MENU";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMenu.Click += new System.EventHandler(this.labelMenu_Click);
            // 
            // labelIDNV
            // 
            this.labelIDNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDNV.ForeColor = System.Drawing.Color.White;
            this.labelIDNV.Location = new System.Drawing.Point(29, 123);
            this.labelIDNV.Name = "labelIDNV";
            this.labelIDNV.Size = new System.Drawing.Size(193, 38);
            this.labelIDNV.TabIndex = 3;
            this.labelIDNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonLogOut.Location = new System.Drawing.Point(19, 587);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(229, 50);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBMS_NoiThat.Properties.Resources.thiet_ke_logo_cong_ty_noi_that_house;
            this.pictureBox1.Location = new System.Drawing.Point(123, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.Gray;
            this.panel_Top.Controls.Add(this.hello);
            this.panel_Top.Controls.Add(this.lbTitle);
            this.panel_Top.Controls.Add(this.labelDate);
            this.panel_Top.Controls.Add(this.labelTime);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(269, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1487, 123);
            this.panel_Top.TabIndex = 13;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTitle.Location = new System.Drawing.Point(24, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(172, 36);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "BoConcept";
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(903, 25);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(569, 38);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "label1";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonQLDH
            // 
            this.buttonQLDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonQLDH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonQLDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQLDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLDH.ForeColor = System.Drawing.Color.White;
            this.buttonQLDH.Location = new System.Drawing.Point(16, 340);
            this.buttonQLDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQLDH.Name = "buttonQLDH";
            this.buttonQLDH.Size = new System.Drawing.Size(229, 50);
            this.buttonQLDH.TabIndex = 3;
            this.buttonQLDH.Text = "Quản Lý Đơn Hàng";
            this.buttonQLDH.UseVisualStyleBackColor = false;
            this.buttonQLDH.Click += new System.EventHandler(this.buttonQLDH_Click);
            // 
            // buttonSP
            // 
            this.buttonSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSP.ForeColor = System.Drawing.Color.White;
            this.buttonSP.Location = new System.Drawing.Point(16, 260);
            this.buttonSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSP.Name = "buttonSP";
            this.buttonSP.Size = new System.Drawing.Size(229, 50);
            this.buttonSP.TabIndex = 2;
            this.buttonSP.Text = "Quản Lý Sản Phẩm";
            this.buttonSP.UseVisualStyleBackColor = false;
            this.buttonSP.Click += new System.EventHandler(this.buttonSP_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.Gray;
            this.panel_left.Controls.Add(this.BTN_ChatBox);
            this.panel_left.Controls.Add(this.buttonThongKeDoanhThu);
            this.panel_left.Controls.Add(this.labelMenu);
            this.panel_left.Controls.Add(this.labelIDNV);
            this.panel_left.Controls.Add(this.buttonLogOut);
            this.panel_left.Controls.Add(this.pictureBox1);
            this.panel_left.Controls.Add(this.buttonQLDH);
            this.panel_left.Controls.Add(this.buttonSP);
            this.panel_left.Controls.Add(this.buttonQLTT);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(269, 806);
            this.panel_left.TabIndex = 12;
            // 
            // BTN_ChatBox
            // 
            this.BTN_ChatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_ChatBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_ChatBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ChatBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ChatBox.ForeColor = System.Drawing.Color.White;
            this.BTN_ChatBox.Location = new System.Drawing.Point(15, 501);
            this.BTN_ChatBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_ChatBox.Name = "BTN_ChatBox";
            this.BTN_ChatBox.Size = new System.Drawing.Size(229, 50);
            this.BTN_ChatBox.TabIndex = 8;
            this.BTN_ChatBox.Text = "Hộp Thoại Tư Vấn";
            this.BTN_ChatBox.UseVisualStyleBackColor = false;
            this.BTN_ChatBox.Click += new System.EventHandler(this.BTN_ChatBox_Click);
            // 
            // buttonThongKeDoanhThu
            // 
            this.buttonThongKeDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonThongKeDoanhThu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonThongKeDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThongKeDoanhThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKeDoanhThu.ForeColor = System.Drawing.Color.White;
            this.buttonThongKeDoanhThu.Location = new System.Drawing.Point(15, 423);
            this.buttonThongKeDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThongKeDoanhThu.Name = "buttonThongKeDoanhThu";
            this.buttonThongKeDoanhThu.Size = new System.Drawing.Size(229, 50);
            this.buttonThongKeDoanhThu.TabIndex = 7;
            this.buttonThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
            this.buttonThongKeDoanhThu.UseVisualStyleBackColor = false;
            this.buttonThongKeDoanhThu.Click += new System.EventHandler(this.buttonThongKeDoanhThu_Click);
            // 
            // buttonQLTT
            // 
            this.buttonQLTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonQLTT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonQLTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQLTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLTT.ForeColor = System.Drawing.Color.White;
            this.buttonQLTT.Location = new System.Drawing.Point(16, 185);
            this.buttonQLTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQLTT.Name = "buttonQLTT";
            this.buttonQLTT.Size = new System.Drawing.Size(229, 50);
            this.buttonQLTT.TabIndex = 1;
            this.buttonQLTT.Text = "Quản Lý Thông Tin";
            this.buttonQLTT.UseVisualStyleBackColor = false;
            this.buttonQLTT.Click += new System.EventHandler(this.buttonQLTT_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Body.Controls.Add(this.pictureBox2);
            this.panel_Body.Location = new System.Drawing.Point(269, 123);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1487, 694);
            this.panel_Body.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DBMS_NoiThat.Properties.Resources.thiet_ke_logo_cong_ty_noi_that_house;
            this.pictureBox2.Location = new System.Drawing.Point(476, 121);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(593, 449);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 806);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_left);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel hello;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMenu;
        public System.Windows.Forms.Label labelIDNV;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonQLDH;
        private System.Windows.Forms.Button buttonSP;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button buttonQLTT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonThongKeDoanhThu;
        private System.Windows.Forms.Button BTN_ChatBox;
    }
}