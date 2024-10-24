namespace DBMS_NoiThat.user
{
    partial class XemThongTinUser
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbHoten = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbDiachi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbSdt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSdt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(52, 31);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(297, 31);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // lbHoten
            // 
            this.lbHoten.BackColor = System.Drawing.Color.Transparent;
            this.lbHoten.Location = new System.Drawing.Point(68, 121);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(45, 18);
            this.lbHoten.TabIndex = 1;
            this.lbHoten.Text = "Họ tên:";
            // 
            // lbDiachi
            // 
            this.lbDiachi.BackColor = System.Drawing.Color.Transparent;
            this.lbDiachi.Location = new System.Drawing.Point(68, 177);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(46, 18);
            this.lbDiachi.TabIndex = 2;
            this.lbDiachi.Text = "Địa chỉ:";
            // 
            // lbEmail
            // 
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Location = new System.Drawing.Point(67, 293);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(40, 18);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email:";
            // 
            // lbSdt
            // 
            this.lbSdt.BackColor = System.Drawing.Color.Transparent;
            this.lbSdt.Location = new System.Drawing.Point(67, 232);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(84, 18);
            this.lbSdt.TabIndex = 4;
            this.lbSdt.Text = "Số điện thoại:";
            // 
            // txtSdt
            // 
            this.txtSdt.BackColor = System.Drawing.Color.Transparent;
            this.txtSdt.Location = new System.Drawing.Point(231, 232);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(57, 18);
            this.txtSdt.TabIndex = 8;
            this.txtSdt.Text = "value sdt";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Location = new System.Drawing.Point(231, 293);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(72, 18);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "value email";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.txtDiaChi.Location = new System.Drawing.Point(232, 177);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(82, 18);
            this.txtDiaChi.TabIndex = 6;
            this.txtDiaChi.Text = "Value Dia chi";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.Transparent;
            this.txtHoTen.Location = new System.Drawing.Point(232, 121);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(65, 18);
            this.txtHoTen.TabIndex = 5;
            this.txtHoTen.Text = "Value Ten";
            // 
            // XemProfileUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 523);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lbSdt);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbDiachi);
            this.Controls.Add(this.lbHoten);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "XemProfileUser";
            this.Text = "XemProfileUser";
            this.Load += new System.EventHandler(this.XemProfileUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbHoten;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbDiachi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbSdt;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtSdt;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtDiaChi;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtHoTen;
    }
}