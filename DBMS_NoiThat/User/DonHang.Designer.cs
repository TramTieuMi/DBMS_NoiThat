using System;
using System.Windows.Forms;

namespace DBMS_NoiThat
{
    partial class DonHang
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
            this.TB_DiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.TB_SDTNguoiNhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.TB_TenNguoiNhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel23 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel21 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LB_SoTien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LB_SDTNguoiDat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LB_TenNguoiDat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LB_MaKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LB_MaDonHang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BTN_MuaHang = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FPN_HienThi = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.Controls.Add(this.TB_DiaChi);
            this.guna2Panel1.Controls.Add(this.TB_SDTNguoiNhan);
            this.guna2Panel1.Controls.Add(this.TB_TenNguoiNhan);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel22);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel23);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel21);
            this.guna2Panel1.Controls.Add(this.LB_SoTien);
            this.guna2Panel1.Controls.Add(this.LB_SDTNguoiDat);
            this.guna2Panel1.Controls.Add(this.LB_TenNguoiDat);
            this.guna2Panel1.Controls.Add(this.LB_MaKH);
            this.guna2Panel1.Controls.Add(this.LB_MaDonHang);
            this.guna2Panel1.Controls.Add(this.BTN_MuaHang);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel11);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel10);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel9);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.FPN_HienThi);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1099, 563);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // TB_DiaChi
            // 
            this.TB_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_DiaChi.DefaultText = "Tên";
            this.TB_DiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_DiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_DiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_DiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_DiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_DiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_DiaChi.Location = new System.Drawing.Point(280, 933);
            this.TB_DiaChi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TB_DiaChi.Name = "TB_DiaChi";
            this.TB_DiaChi.PasswordChar = '\0';
            this.TB_DiaChi.PlaceholderText = "";
            this.TB_DiaChi.SelectedText = "";
            this.TB_DiaChi.Size = new System.Drawing.Size(700, 38);
            this.TB_DiaChi.TabIndex = 28;
            // 
            // TB_SDTNguoiNhan
            // 
            this.TB_SDTNguoiNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_SDTNguoiNhan.DefaultText = "Tên";
            this.TB_SDTNguoiNhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_SDTNguoiNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_SDTNguoiNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_SDTNguoiNhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_SDTNguoiNhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_SDTNguoiNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SDTNguoiNhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_SDTNguoiNhan.Location = new System.Drawing.Point(280, 873);
            this.TB_SDTNguoiNhan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TB_SDTNguoiNhan.Name = "TB_SDTNguoiNhan";
            this.TB_SDTNguoiNhan.PasswordChar = '\0';
            this.TB_SDTNguoiNhan.PlaceholderText = "";
            this.TB_SDTNguoiNhan.SelectedText = "";
            this.TB_SDTNguoiNhan.Size = new System.Drawing.Size(390, 38);
            this.TB_SDTNguoiNhan.TabIndex = 27;
            // 
            // TB_TenNguoiNhan
            // 
            this.TB_TenNguoiNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_TenNguoiNhan.DefaultText = "Tên";
            this.TB_TenNguoiNhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_TenNguoiNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_TenNguoiNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_TenNguoiNhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_TenNguoiNhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_TenNguoiNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TenNguoiNhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_TenNguoiNhan.Location = new System.Drawing.Point(280, 813);
            this.TB_TenNguoiNhan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TB_TenNguoiNhan.Name = "TB_TenNguoiNhan";
            this.TB_TenNguoiNhan.PasswordChar = '\0';
            this.TB_TenNguoiNhan.PlaceholderText = "";
            this.TB_TenNguoiNhan.SelectedText = "";
            this.TB_TenNguoiNhan.Size = new System.Drawing.Size(390, 38);
            this.TB_TenNguoiNhan.TabIndex = 26;
            // 
            // guna2HtmlLabel22
            // 
            this.guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel22.Location = new System.Drawing.Point(313, 541);
            this.guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            this.guna2HtmlLabel22.Size = new System.Drawing.Size(390, 40);
            this.guna2HtmlLabel22.TabIndex = 25;
            this.guna2HtmlLabel22.Text = "Thông Tin Người Đặt Hàng";
            // 
            // guna2HtmlLabel23
            // 
            this.guna2HtmlLabel23.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel23.Location = new System.Drawing.Point(306, 744);
            this.guna2HtmlLabel23.Name = "guna2HtmlLabel23";
            this.guna2HtmlLabel23.Size = new System.Drawing.Size(417, 40);
            this.guna2HtmlLabel23.TabIndex = 24;
            this.guna2HtmlLabel23.Text = "Thông Tin Người Nhận Hàng";
            // 
            // guna2HtmlLabel21
            // 
            this.guna2HtmlLabel21.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel21.Location = new System.Drawing.Point(819, 1155);
            this.guna2HtmlLabel21.Name = "guna2HtmlLabel21";
            this.guna2HtmlLabel21.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel21.TabIndex = 22;
            this.guna2HtmlLabel21.Text = null;
            // 
            // LB_SoTien
            // 
            this.LB_SoTien.BackColor = System.Drawing.Color.Transparent;
            this.LB_SoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SoTien.Location = new System.Drawing.Point(519, 1024);
            this.LB_SoTien.Name = "LB_SoTien";
            this.LB_SoTien.Size = new System.Drawing.Size(204, 31);
            this.LB_SoTien.TabIndex = 21;
            this.LB_SoTien.Text = "guna2HtmlLabel12";
            // 
            // LB_SDTNguoiDat
            // 
            this.LB_SDTNguoiDat.BackColor = System.Drawing.Color.Transparent;
            this.LB_SDTNguoiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SDTNguoiDat.Location = new System.Drawing.Point(280, 678);
            this.LB_SDTNguoiDat.Name = "LB_SDTNguoiDat";
            this.LB_SDTNguoiDat.Size = new System.Drawing.Size(167, 27);
            this.LB_SDTNguoiDat.TabIndex = 18;
            this.LB_SDTNguoiDat.Text = "guna2HtmlLabel15";
            // 
            // LB_TenNguoiDat
            // 
            this.LB_TenNguoiDat.BackColor = System.Drawing.Color.Transparent;
            this.LB_TenNguoiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TenNguoiDat.Location = new System.Drawing.Point(768, 618);
            this.LB_TenNguoiDat.Name = "LB_TenNguoiDat";
            this.LB_TenNguoiDat.Size = new System.Drawing.Size(167, 27);
            this.LB_TenNguoiDat.TabIndex = 17;
            this.LB_TenNguoiDat.Text = "guna2HtmlLabel16";
            // 
            // LB_MaKH
            // 
            this.LB_MaKH.BackColor = System.Drawing.Color.Transparent;
            this.LB_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MaKH.Location = new System.Drawing.Point(280, 618);
            this.LB_MaKH.Name = "LB_MaKH";
            this.LB_MaKH.Size = new System.Drawing.Size(167, 27);
            this.LB_MaKH.TabIndex = 16;
            this.LB_MaKH.Text = "guna2HtmlLabel17";
            // 
            // LB_MaDonHang
            // 
            this.LB_MaDonHang.BackColor = System.Drawing.Color.Transparent;
            this.LB_MaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MaDonHang.Location = new System.Drawing.Point(170, 489);
            this.LB_MaDonHang.Name = "LB_MaDonHang";
            this.LB_MaDonHang.Size = new System.Drawing.Size(167, 27);
            this.LB_MaDonHang.TabIndex = 13;
            this.LB_MaDonHang.Text = "guna2HtmlLabel20";
            // 
            // BTN_MuaHang
            // 
            this.BTN_MuaHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_MuaHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_MuaHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_MuaHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_MuaHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_MuaHang.ForeColor = System.Drawing.Color.White;
            this.BTN_MuaHang.Location = new System.Drawing.Point(427, 1102);
            this.BTN_MuaHang.Name = "BTN_MuaHang";
            this.BTN_MuaHang.Size = new System.Drawing.Size(180, 45);
            this.BTN_MuaHang.TabIndex = 12;
            this.BTN_MuaHang.Text = "Mua Hàng";
            this.BTN_MuaHang.Click += new System.EventHandler(this.BTN_MuaHang_Click);
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(346, 1024);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(163, 31);
            this.guna2HtmlLabel11.TabIndex = 11;
            this.guna2HtmlLabel11.Text = "Tổng Số Tiền :";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(27, 878);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(247, 27);
            this.guna2HtmlLabel10.TabIndex = 10;
            this.guna2HtmlLabel10.Text = "Số Điện Thoại Người Nhận :";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(27, 818);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(157, 27);
            this.guna2HtmlLabel9.TabIndex = 9;
            this.guna2HtmlLabel9.Text = "Tên Người Nhận :";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(27, 678);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(230, 27);
            this.guna2HtmlLabel8.TabIndex = 8;
            this.guna2HtmlLabel8.Text = "Số Điện Thoại Người Đặt :";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(591, 618);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(140, 27);
            this.guna2HtmlLabel7.TabIndex = 7;
            this.guna2HtmlLabel7.Text = "Tên Người Đặt :";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(27, 618);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(156, 27);
            this.guna2HtmlLabel6.TabIndex = 6;
            this.guna2HtmlLabel6.Text = "Mã Khách Hàng :";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(937, 922);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel5.TabIndex = 5;
            this.guna2HtmlLabel5.Text = null;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(27, 938);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(171, 27);
            this.guna2HtmlLabel4.TabIndex = 4;
            this.guna2HtmlLabel4.Text = "Địa Chỉ Nhận Hàng";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(27, 489);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(135, 27);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Mã Đơn Hàng :";
            // 
            // FPN_HienThi
            // 
            this.FPN_HienThi.AutoScroll = true;
            this.FPN_HienThi.Location = new System.Drawing.Point(0, 60);
            this.FPN_HienThi.Name = "FPN_HienThi";
            this.FPN_HienThi.Size = new System.Drawing.Size(1074, 394);
            this.FPN_HienThi.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(417, 11);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(286, 40);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Đơn Hàng Của Bạn";
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 563);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "DonHang";
            this.Text = "DonHang";
            this.Load += new System.EventHandler(this.DonHang_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel FPN_HienThi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button BTN_MuaHang;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel LB_SoTien;
        private Guna.UI2.WinForms.Guna2HtmlLabel LB_SDTNguoiDat;
        private Guna.UI2.WinForms.Guna2HtmlLabel LB_TenNguoiDat;
        private Guna.UI2.WinForms.Guna2HtmlLabel LB_MaKH;
        private Guna.UI2.WinForms.Guna2HtmlLabel LB_MaDonHang;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel21;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel22;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel23;
        private Guna.UI2.WinForms.Guna2TextBox TB_TenNguoiNhan;
        private Guna.UI2.WinForms.Guna2TextBox TB_DiaChi;
        private Guna.UI2.WinForms.Guna2TextBox TB_SDTNguoiNhan;
    }
}