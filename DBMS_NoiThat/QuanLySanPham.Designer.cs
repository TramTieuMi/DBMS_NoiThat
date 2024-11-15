namespace WindowsFormsApp1
{
    partial class QuanLySanPham
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
            this.btnLoadData_SP = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem_SP = new System.Windows.Forms.Button();
            this.HinhAnh = new System.Windows.Forms.TextBox();
            this.TenSanPham = new System.Windows.Forms.TextBox();
            this.MaSanPham = new System.Windows.Forms.TextBox();
            this.lblGiaSanPham = new System.Windows.Forms.Label();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnEdit_SP = new System.Windows.Forms.Button();
            this.btnDelete_SP = new System.Windows.Forms.Button();
            this.btnSave_SP = new System.Windows.Forms.Button();
            this.KichThuoc = new System.Windows.Forms.TextBox();
            this.MoTa = new System.Windows.Forms.TextBox();
            this.ChatLieu = new System.Windows.Forms.TextBox();
            this.lblMauSac = new System.Windows.Forms.Label();
            this.lblKichThuoc = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblChatLieu = new System.Windows.Forms.Label();
            this.MauSac = new System.Windows.Forms.TextBox();
            this.GiaSanPham = new System.Windows.Forms.TextBox();
            this.SoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadData_SP
            // 
            this.btnLoadData_SP.Location = new System.Drawing.Point(634, 379);
            this.btnLoadData_SP.Name = "btnLoadData_SP";
            this.btnLoadData_SP.Size = new System.Drawing.Size(134, 57);
            this.btnLoadData_SP.TabIndex = 33;
            this.btnLoadData_SP.Text = "Tải lại";
            this.btnLoadData_SP.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(600, 75);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(188, 26);
            this.txtTimKiem.TabIndex = 30;
            // 
            // btnTimKiem_SP
            // 
            this.btnTimKiem_SP.Location = new System.Drawing.Point(690, 20);
            this.btnTimKiem_SP.Name = "btnTimKiem_SP";
            this.btnTimKiem_SP.Size = new System.Drawing.Size(98, 47);
            this.btnTimKiem_SP.TabIndex = 29;
            this.btnTimKiem_SP.Text = "Tìm kiếm";
            this.btnTimKiem_SP.UseVisualStyleBackColor = true;
            this.btnTimKiem_SP.Click += new System.EventHandler(this.btnTimKiem_Click_Click);
            // 
            // HinhAnh
            // 
            this.HinhAnh.Location = new System.Drawing.Point(178, 99);
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Size = new System.Drawing.Size(100, 26);
            this.HinhAnh.TabIndex = 27;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Location = new System.Drawing.Point(178, 57);
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Size = new System.Drawing.Size(100, 26);
            this.TenSanPham.TabIndex = 26;
            // 
            // MaSanPham
            // 
            this.MaSanPham.Location = new System.Drawing.Point(178, 14);
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Size = new System.Drawing.Size(100, 26);
            this.MaSanPham.TabIndex = 25;
            // 
            // lblGiaSanPham
            // 
            this.lblGiaSanPham.AutoSize = true;
            this.lblGiaSanPham.Location = new System.Drawing.Point(32, 143);
            this.lblGiaSanPham.Name = "lblGiaSanPham";
            this.lblGiaSanPham.Size = new System.Drawing.Size(108, 20);
            this.lblGiaSanPham.TabIndex = 24;
            this.lblGiaSanPham.Text = "Giá sản phẩm";
            // 
            // lblHinhAnh
            // 
            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Location = new System.Drawing.Point(32, 105);
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.Size = new System.Drawing.Size(73, 20);
            this.lblHinhAnh.TabIndex = 23;
            this.lblHinhAnh.Text = "Hình ảnh";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Location = new System.Drawing.Point(32, 63);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(118, 20);
            this.lblTenSanPham.TabIndex = 22;
            this.lblTenSanPham.Text = "Tên sản phẩm  ";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Location = new System.Drawing.Point(32, 20);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(109, 20);
            this.lblMaSanPham.TabIndex = 21;
            this.lblMaSanPham.Text = "Mã sản phẩm ";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(36, 227);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.Size = new System.Drawing.Size(549, 209);
            this.dgvSanPham.TabIndex = 20;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
            // 
            // btnEdit_SP
            // 
            this.btnEdit_SP.Location = new System.Drawing.Point(634, 244);
            this.btnEdit_SP.Name = "btnEdit_SP";
            this.btnEdit_SP.Size = new System.Drawing.Size(134, 57);
            this.btnEdit_SP.TabIndex = 19;
            this.btnEdit_SP.Text = "Sửa sản phẩm";
            this.btnEdit_SP.UseVisualStyleBackColor = true;
            this.btnEdit_SP.Click += new System.EventHandler(this.btnEdit_Click_Click);
            // 
            // btnDelete_SP
            // 
            this.btnDelete_SP.Location = new System.Drawing.Point(634, 307);
            this.btnDelete_SP.Name = "btnDelete_SP";
            this.btnDelete_SP.Size = new System.Drawing.Size(134, 57);
            this.btnDelete_SP.TabIndex = 18;
            this.btnDelete_SP.Text = "Xóa sản phẩm";
            this.btnDelete_SP.UseVisualStyleBackColor = true;
            this.btnDelete_SP.Click += new System.EventHandler(this.btnDelete_Click_Click);
            // 
            // btnSave_SP
            // 
            this.btnSave_SP.Location = new System.Drawing.Point(634, 175);
            this.btnSave_SP.Name = "btnSave_SP";
            this.btnSave_SP.Size = new System.Drawing.Size(134, 57);
            this.btnSave_SP.TabIndex = 17;
            this.btnSave_SP.Text = "Thêm sản phẩm";
            this.btnSave_SP.UseVisualStyleBackColor = true;
            this.btnSave_SP.Click += new System.EventHandler(this.btnAdd_Click_Click);
            // 
            // KichThuoc
            // 
            this.KichThuoc.Location = new System.Drawing.Point(443, 96);
            this.KichThuoc.Name = "KichThuoc";
            this.KichThuoc.Size = new System.Drawing.Size(100, 26);
            this.KichThuoc.TabIndex = 40;
            // 
            // MoTa
            // 
            this.MoTa.Location = new System.Drawing.Point(443, 54);
            this.MoTa.Name = "MoTa";
            this.MoTa.Size = new System.Drawing.Size(100, 26);
            this.MoTa.TabIndex = 39;
            // 
            // ChatLieu
            // 
            this.ChatLieu.Location = new System.Drawing.Point(443, 11);
            this.ChatLieu.Name = "ChatLieu";
            this.ChatLieu.Size = new System.Drawing.Size(100, 26);
            this.ChatLieu.TabIndex = 38;
            // 
            // lblMauSac
            // 
            this.lblMauSac.AutoSize = true;
            this.lblMauSac.Location = new System.Drawing.Point(297, 140);
            this.lblMauSac.Name = "lblMauSac";
            this.lblMauSac.Size = new System.Drawing.Size(69, 20);
            this.lblMauSac.TabIndex = 37;
            this.lblMauSac.Text = "Màu sắc";
            // 
            // lblKichThuoc
            // 
            this.lblKichThuoc.AutoSize = true;
            this.lblKichThuoc.Location = new System.Drawing.Point(297, 102);
            this.lblKichThuoc.Name = "lblKichThuoc";
            this.lblKichThuoc.Size = new System.Drawing.Size(87, 20);
            this.lblKichThuoc.TabIndex = 36;
            this.lblKichThuoc.Text = "Kích thước ";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(297, 60);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(57, 20);
            this.lblMoTa.TabIndex = 35;
            this.lblMoTa.Text = "Mô Tả ";
            // 
            // lblChatLieu
            // 
            this.lblChatLieu.AutoSize = true;
            this.lblChatLieu.Location = new System.Drawing.Point(297, 17);
            this.lblChatLieu.Name = "lblChatLieu";
            this.lblChatLieu.Size = new System.Drawing.Size(77, 20);
            this.lblChatLieu.TabIndex = 34;
            this.lblChatLieu.Text = "Chất Liệu";
            // 
            // MauSac
            // 
            this.MauSac.Location = new System.Drawing.Point(443, 134);
            this.MauSac.Name = "MauSac";
            this.MauSac.Size = new System.Drawing.Size(100, 26);
            this.MauSac.TabIndex = 41;
            // 
            // GiaSanPham
            // 
            this.GiaSanPham.Location = new System.Drawing.Point(178, 137);
            this.GiaSanPham.Name = "GiaSanPham";
            this.GiaSanPham.Size = new System.Drawing.Size(100, 26);
            this.GiaSanPham.TabIndex = 42;
            // 
            // SoLuong
            // 
            this.SoLuong.Location = new System.Drawing.Point(443, 175);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(100, 26);
            this.SoLuong.TabIndex = 44;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(297, 175);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(72, 20);
            this.lblSoLuong.TabIndex = 43;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.GiaSanPham);
            this.Controls.Add(this.MauSac);
            this.Controls.Add(this.KichThuoc);
            this.Controls.Add(this.MoTa);
            this.Controls.Add(this.ChatLieu);
            this.Controls.Add(this.lblMauSac);
            this.Controls.Add(this.lblKichThuoc);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblChatLieu);
            this.Controls.Add(this.btnLoadData_SP);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem_SP);
            this.Controls.Add(this.HinhAnh);
            this.Controls.Add(this.TenSanPham);
            this.Controls.Add(this.MaSanPham);
            this.Controls.Add(this.lblGiaSanPham);
            this.Controls.Add(this.lblHinhAnh);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.lblMaSanPham);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.btnEdit_SP);
            this.Controls.Add(this.btnDelete_SP);
            this.Controls.Add(this.btnSave_SP);
            this.Name = "QuanLySanPham";
            this.Text = "QuanLySanPham";
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData_SP;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem_SP;
        private System.Windows.Forms.TextBox HinhAnh;
        private System.Windows.Forms.TextBox TenSanPham;
        private System.Windows.Forms.TextBox MaSanPham;
        private System.Windows.Forms.Label lblGiaSanPham;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnEdit_SP;
        private System.Windows.Forms.Button btnDelete_SP;
        private System.Windows.Forms.Button btnSave_SP;
        private System.Windows.Forms.TextBox KichThuoc;
        private System.Windows.Forms.TextBox MoTa;
        private System.Windows.Forms.TextBox ChatLieu;
        private System.Windows.Forms.Label lblMauSac;
        private System.Windows.Forms.Label lblKichThuoc;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblChatLieu;
        private System.Windows.Forms.TextBox MauSac;
        private System.Windows.Forms.TextBox GiaSanPham;
        private System.Windows.Forms.TextBox SoLuong;
        private System.Windows.Forms.Label lblSoLuong;
    }
}