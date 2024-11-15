namespace DBMS_NoiThat
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
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.PictureBoxHinhAnhSP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHinhAnhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(117, 556);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(67, 28);
            this.btnThemSP.TabIndex = 1;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(227, 556);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(67, 28);
            this.btnXoaSP.TabIndex = 2;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Location = new System.Drawing.Point(348, 556);
            this.btnSuaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(67, 28);
            this.btnSuaSP.TabIndex = 3;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnTimKiemSP
            // 
            this.btnTimKiemSP.Location = new System.Drawing.Point(348, 55);
            this.btnTimKiemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemSP.Name = "btnTimKiemSP";
            this.btnTimKiemSP.Size = new System.Drawing.Size(80, 26);
            this.btnTimKiemSP.TabIndex = 4;
            this.btnTimKiemSP.Text = "Tìm kiếm ";
            this.btnTimKiemSP.UseVisualStyleBackColor = true;
            this.btnTimKiemSP.Click += new System.EventHandler(this.btnTimKiemSP_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(468, 556);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(67, 28);
            this.btnTaiLai.TabIndex = 5;
            this.btnTaiLai.Text = "Tải lại ";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // txtbTimKiemSP
            // 
            this.txtbTimKiemSP.Location = new System.Drawing.Point(22, 58);
            this.txtbTimKiemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbTimKiemSP.Name = "txtbTimKiemSP";
            this.txtbTimKiemSP.Size = new System.Drawing.Size(312, 22);
            this.txtbTimKiemSP.TabIndex = 70;
            this.txtbTimKiemSP.TextChanged += new System.EventHandler(this.txtbTimKiemSP_TextChanged_1);
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Location = new System.Drawing.Point(22, 114);
            this.dataGridViewSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 62;
            this.dataGridViewSanPham.RowTemplate.Height = 28;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(637, 409);
            this.dataGridViewSanPham.TabIndex = 71;
            this.dataGridViewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellClick);
            this.dataGridViewSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellContentClick);
            // 
            // PictureBoxHinhAnhSP
            // 
            this.PictureBoxHinhAnhSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxHinhAnhSP.BackColor = System.Drawing.Color.Silver;
            this.PictureBoxHinhAnhSP.Location = new System.Drawing.Point(813, 23);
            this.PictureBoxHinhAnhSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxHinhAnhSP.Name = "PictureBoxHinhAnhSP";
            this.PictureBoxHinhAnhSP.Size = new System.Drawing.Size(421, 318);
            this.PictureBoxHinhAnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxHinhAnhSP.TabIndex = 67;
            this.PictureBoxHinhAnhSP.TabStop = false;
            this.PictureBoxHinhAnhSP.Click += new System.EventHandler(this.PictureBoxHinhAnhSP_Click);
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 690);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Controls.Add(this.txtbTimKiemSP);
            this.Controls.Add(this.PictureBoxHinhAnhSP);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnTimKiemSP);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnThemSP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLySanPham";
            this.Text = "QuanLySanPham";
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHinhAnhSP)).EndInit();
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