namespace DBMS_NoiThat.user
{
    partial class XemSanPhamForm
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
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.radioButtonMauSac = new System.Windows.Forms.RadioButton();
            this.radioButtonGia = new System.Windows.Forms.RadioButton();
            this.radioButtonTenSP = new System.Windows.Forms.RadioButton();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.dgvXemSanPham = new System.Windows.Forms.DataGridView();
            this.labelSofa = new System.Windows.Forms.Label();
            this.labelChairs = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemSanPham)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTo
            // 
            this.labelTo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.Color.Black;
            this.labelTo.Location = new System.Drawing.Point(53, 188);
            this.labelTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(67, 16);
            this.labelTo.TabIndex = 50;
            this.labelTo.Text = "To:";
            this.labelTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFrom
            // 
            this.labelFrom.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.ForeColor = System.Drawing.Color.Black;
            this.labelFrom.Location = new System.Drawing.Point(62, 135);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(67, 16);
            this.labelFrom.TabIndex = 49;
            this.labelFrom.Text = "From:";
            this.labelFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(77, 217);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(104, 20);
            this.textBoxTo.TabIndex = 48;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(74, 157);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(104, 20);
            this.textBoxFrom.TabIndex = 47;
            // 
            // radioButtonMauSac
            // 
            this.radioButtonMauSac.AutoSize = true;
            this.radioButtonMauSac.Location = new System.Drawing.Point(198, 191);
            this.radioButtonMauSac.Name = "radioButtonMauSac";
            this.radioButtonMauSac.Size = new System.Drawing.Size(68, 17);
            this.radioButtonMauSac.TabIndex = 46;
            this.radioButtonMauSac.TabStop = true;
            this.radioButtonMauSac.Text = "Màu Sắc";
            this.radioButtonMauSac.UseVisualStyleBackColor = true;
            // 
            // radioButtonGia
            // 
            this.radioButtonGia.AutoSize = true;
            this.radioButtonGia.Location = new System.Drawing.Point(12, 191);
            this.radioButtonGia.Name = "radioButtonGia";
            this.radioButtonGia.Size = new System.Drawing.Size(41, 17);
            this.radioButtonGia.TabIndex = 45;
            this.radioButtonGia.TabStop = true;
            this.radioButtonGia.Text = "Giá";
            this.radioButtonGia.UseVisualStyleBackColor = true;
            // 
            // radioButtonTenSP
            // 
            this.radioButtonTenSP.AutoSize = true;
            this.radioButtonTenSP.Location = new System.Drawing.Point(300, 191);
            this.radioButtonTenSP.Name = "radioButtonTenSP";
            this.radioButtonTenSP.Size = new System.Drawing.Size(44, 17);
            this.radioButtonTenSP.TabIndex = 44;
            this.radioButtonTenSP.TabStop = true;
            this.radioButtonTenSP.Text = "Tên";
            this.radioButtonTenSP.UseVisualStyleBackColor = true;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(368, 189);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(441, 20);
            this.textBoxTimKiem.TabIndex = 43;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(872, 181);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(109, 37);
            this.buttonTimKiem.TabIndex = 42;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // dgvXemSanPham
            // 
            this.dgvXemSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemSanPham.Location = new System.Drawing.Point(65, 252);
            this.dgvXemSanPham.Name = "dgvXemSanPham";
            this.dgvXemSanPham.RowHeadersWidth = 62;
            this.dgvXemSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXemSanPham.Size = new System.Drawing.Size(957, 297);
            this.dgvXemSanPham.TabIndex = 41;
            this.dgvXemSanPham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXemSanPham_CellDoubleClick);
            // 
            // labelSofa
            // 
            this.labelSofa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSofa.ForeColor = System.Drawing.Color.Black;
            this.labelSofa.Location = new System.Drawing.Point(406, 135);
            this.labelSofa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSofa.Name = "labelSofa";
            this.labelSofa.Size = new System.Drawing.Size(96, 38);
            this.labelSofa.TabIndex = 39;
            this.labelSofa.Text = "Sofa";
            this.labelSofa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChairs
            // 
            this.labelChairs.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChairs.ForeColor = System.Drawing.Color.Black;
            this.labelChairs.Location = new System.Drawing.Point(532, 135);
            this.labelChairs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChairs.Name = "labelChairs";
            this.labelChairs.Size = new System.Drawing.Size(96, 38);
            this.labelChairs.TabIndex = 37;
            this.labelChairs.Text = "Ghế";
            this.labelChairs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox4);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(400, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(358, 132);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DBMS_NoiThat.Properties.Resources.Screenshot_2024_10_23_085902;
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DBMS_NoiThat.Properties.Resources.Screenshot_2024_10_23_085922;
            this.pictureBox4.Location = new System.Drawing.Point(121, 2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(107, 113);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DBMS_NoiThat.Properties.Resources.Screenshot_2024_10_23_085947;
            this.pictureBox5.Location = new System.Drawing.Point(232, 2);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(111, 113);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(155, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "What are you looking for?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBed
            // 
            this.labelBed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBed.ForeColor = System.Drawing.Color.Black;
            this.labelBed.Location = new System.Drawing.Point(645, 135);
            this.labelBed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBed.Name = "labelBed";
            this.labelBed.Size = new System.Drawing.Size(96, 38);
            this.labelBed.TabIndex = 40;
            this.labelBed.Text = "Bed";
            this.labelBed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XemSanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 561);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.radioButtonMauSac);
            this.Controls.Add(this.radioButtonGia);
            this.Controls.Add(this.radioButtonTenSP);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.dgvXemSanPham);
            this.Controls.Add(this.labelSofa);
            this.Controls.Add(this.labelChairs);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBed);
            this.Name = "XemSanPhamForm";
            this.Text = "XemSanPhamForm";
            this.Click += new System.EventHandler(this.XemSanPhamForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemSanPham)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.RadioButton radioButtonMauSac;
        private System.Windows.Forms.RadioButton radioButtonGia;
        private System.Windows.Forms.RadioButton radioButtonTenSP;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dgvXemSanPham;
        private System.Windows.Forms.Label labelSofa;
        private System.Windows.Forms.Label labelChairs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBed;
    }
}