using System;
using System.Windows.Forms;

namespace DBMS_NoiThat.user
{
    partial class GioHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_MaGioHang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FPN_HienThi = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_MuaHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LB_MaGioHang);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.FPN_HienThi);
            this.panel1.Controls.Add(this.BTN_MuaHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 584);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LB_MaGioHang
            // 
            this.LB_MaGioHang.BackColor = System.Drawing.Color.Transparent;
            this.LB_MaGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MaGioHang.Location = new System.Drawing.Point(877, 19);
            this.LB_MaGioHang.Name = "LB_MaGioHang";
            this.LB_MaGioHang.Size = new System.Drawing.Size(191, 31);
            this.LB_MaGioHang.TabIndex = 3;
            this.LB_MaGioHang.Text = "guna2HtmlLabel2";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(716, 19);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(155, 31);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Mã Giỏ Hàng :";
            // 
            // FPN_HienThi
            // 
            this.FPN_HienThi.Location = new System.Drawing.Point(0, 71);
            this.FPN_HienThi.Name = "FPN_HienThi";
            this.FPN_HienThi.Size = new System.Drawing.Size(1086, 436);
            this.FPN_HienThi.TabIndex = 1;
            this.FPN_HienThi.Paint += new System.Windows.Forms.PaintEventHandler(this.FPN_HienThi_Paint);
            // 
            // BTN_MuaHang
            // 
            this.BTN_MuaHang.Location = new System.Drawing.Point(461, 519);
            this.BTN_MuaHang.Name = "BTN_MuaHang";
            this.BTN_MuaHang.Size = new System.Drawing.Size(181, 53);
            this.BTN_MuaHang.TabIndex = 0;
            this.BTN_MuaHang.Text = "Mua Hàng";
            this.BTN_MuaHang.UseVisualStyleBackColor = true;
            this.BTN_MuaHang.Click += new System.EventHandler(this.BTN_MuaHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giỏ Hàng Của Bạn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 584);
            this.Controls.Add(this.panel1);
            this.Name = "GioHang";
            this.Text = "GioHang";
            this.Load += new System.EventHandler(this.GioHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FPN_HienThi_Paint(object sender, PaintEventArgs e)
        {
           // throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_MuaHang;
        private System.Windows.Forms.FlowLayoutPanel FPN_HienThi;
        private Guna.UI2.WinForms.Guna2HtmlLabel LB_MaGioHang;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}