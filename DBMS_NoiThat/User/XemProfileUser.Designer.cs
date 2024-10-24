namespace DBMS_NoiThat.user
{
    partial class XemProfileUser
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
            this.lbHTSdt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbHTEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbHTDiaChi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbHTTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            // lbHTSdt
            // 
            this.lbHTSdt.BackColor = System.Drawing.Color.Transparent;
            this.lbHTSdt.Location = new System.Drawing.Point(231, 232);
            this.lbHTSdt.Name = "lbHTSdt";
            this.lbHTSdt.Size = new System.Drawing.Size(57, 18);
            this.lbHTSdt.TabIndex = 8;
            this.lbHTSdt.Text = "value sdt";
            // 
            // lbHTEmail
            // 
            this.lbHTEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbHTEmail.Location = new System.Drawing.Point(231, 293);
            this.lbHTEmail.Name = "lbHTEmail";
            this.lbHTEmail.Size = new System.Drawing.Size(72, 18);
            this.lbHTEmail.TabIndex = 7;
            this.lbHTEmail.Text = "value email";
            // 
            // lbHTDiaChi
            // 
            this.lbHTDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lbHTDiaChi.Location = new System.Drawing.Point(232, 177);
            this.lbHTDiaChi.Name = "lbHTDiaChi";
            this.lbHTDiaChi.Size = new System.Drawing.Size(82, 18);
            this.lbHTDiaChi.TabIndex = 6;
            this.lbHTDiaChi.Text = "Value Dia chi";
            // 
            // lbHTTen
            // 
            this.lbHTTen.BackColor = System.Drawing.Color.Transparent;
            this.lbHTTen.Location = new System.Drawing.Point(232, 121);
            this.lbHTTen.Name = "lbHTTen";
            this.lbHTTen.Size = new System.Drawing.Size(65, 18);
            this.lbHTTen.TabIndex = 5;
            this.lbHTTen.Text = "Value Ten";
            // 
            // XemProfileUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 523);
            this.Controls.Add(this.lbHTSdt);
            this.Controls.Add(this.lbHTEmail);
            this.Controls.Add(this.lbHTDiaChi);
            this.Controls.Add(this.lbHTTen);
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lbHTSdt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbHTEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbHTDiaChi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbHTTen;
    }
}