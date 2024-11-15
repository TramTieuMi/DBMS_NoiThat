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
            this.btnThemSP.Location = new System.Drawing.Point(132, 695);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(75, 35);
            this.btnThemSP.TabIndex = 1;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(255, 695);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(75, 35);
            this.btnXoaSP.TabIndex = 2;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Location = new System.Drawing.Point(391, 695);
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
            this.btnTaiLai.Location = new System.Drawing.Point(526, 695);
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
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Location = new System.Drawing.Point(25, 143);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 62;
            this.dataGridViewSanPham.RowTemplate.Height = 28;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(717, 511);
            this.dataGridViewSanPham.TabIndex = 71;
            this.dataGridViewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellClick);
            this.dataGridViewSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellContentClick);
            // 
            // PictureBoxHinhAnhSP
            // 
            this.PictureBoxHinhAnhSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxHinhAnhSP.BackColor = System.Drawing.Color.Silver;
            this.PictureBoxHinhAnhSP.Location = new System.Drawing.Point(845, 122);
            this.PictureBoxHinhAnhSP.Name = "PictureBoxHinhAnhSP";
            this.PictureBoxHinhAnhSP.Size = new System.Drawing.Size(474, 398);
            this.PictureBoxHinhAnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxHinhAnhSP.TabIndex = 67;
            this.PictureBoxHinhAnhSP.TabStop = false;
            this.PictureBoxHinhAnhSP.Click += new System.EventHandler(this.PictureBoxHinhAnhSP_Click);
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