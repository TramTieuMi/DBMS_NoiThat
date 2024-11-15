namespace DBMS_NoiThat.admin
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
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnTimKiemSP = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.txtbTimKiemSP = new System.Windows.Forms.TextBox();
            this.PictureBoxHinhAnhSP = new System.Windows.Forms.PictureBox();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHinhAnhSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(80, 966);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(75, 35);
            this.btnThemSP.TabIndex = 1;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(203, 966);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(75, 35);
            this.btnXoaSP.TabIndex = 2;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Location = new System.Drawing.Point(339, 966);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(75, 35);
            this.btnSuaSP.TabIndex = 3;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnTimKiemSP
            // 
            this.btnTimKiemSP.Location = new System.Drawing.Point(391, 69);
            this.btnTimKiemSP.Name = "btnTimKiemSP";
            this.btnTimKiemSP.Size = new System.Drawing.Size(90, 33);
            this.btnTimKiemSP.TabIndex = 4;
            this.btnTimKiemSP.Text = "Tìm kiếm ";
            this.btnTimKiemSP.UseVisualStyleBackColor = true;
            this.btnTimKiemSP.Click += new System.EventHandler(this.btnTimKiemSP_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(474, 966);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(75, 35);
            this.btnTaiLai.TabIndex = 5;
            this.btnTaiLai.Text = "Tải lại ";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // txtbTimKiemSP
            // 
            this.txtbTimKiemSP.Location = new System.Drawing.Point(25, 72);
            this.txtbTimKiemSP.Name = "txtbTimKiemSP";
            this.txtbTimKiemSP.Size = new System.Drawing.Size(350, 26);
            this.txtbTimKiemSP.TabIndex = 70;
            this.txtbTimKiemSP.TextChanged += new System.EventHandler(this.txtbTimKiemSP_TextChanged_1);
            // 
            // PictureBoxHinhAnhSP
            // 
            this.PictureBoxHinhAnhSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxHinhAnhSP.BackColor = System.Drawing.Color.Silver;
            this.PictureBoxHinhAnhSP.Location = new System.Drawing.Point(924, 126);
            this.PictureBoxHinhAnhSP.Name = "PictureBoxHinhAnhSP";
            this.PictureBoxHinhAnhSP.Size = new System.Drawing.Size(474, 398);
            this.PictureBoxHinhAnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxHinhAnhSP.TabIndex = 67;
            this.PictureBoxHinhAnhSP.TabStop = false;
            this.PictureBoxHinhAnhSP.Click += new System.EventHandler(this.PictureBoxHinhAnhSP_Click);
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Location = new System.Drawing.Point(25, 143);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 62;
            this.dataGridViewSanPham.RowTemplate.Height = 28;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(717, 802);
            this.dataGridViewSanPham.TabIndex = 71;
            this.dataGridViewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellClick);
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
            this.ClientSize = new System.Drawing.Size(1501, 1050);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Controls.Add(this.txtbTimKiemSP);
            this.Controls.Add(this.PictureBoxHinhAnhSP);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnTimKiemSP);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnThemSP);
            this.Name = "QuanLySanPham";
            this.Text = "QuanLySanPham";
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHinhAnhSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnTimKiemSP;
        private System.Windows.Forms.Button btnTaiLai;
        public System.Windows.Forms.PictureBox PictureBoxHinhAnhSP;
        private System.Windows.Forms.TextBox txtbTimKiemSP;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
    }
}