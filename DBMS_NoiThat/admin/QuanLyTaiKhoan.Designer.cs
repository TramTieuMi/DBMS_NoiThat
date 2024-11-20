namespace DBMS_NoiThat.admin
{
    partial class QuanLyTaiKhoan
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
            this.btnAdd_Click = new System.Windows.Forms.Button();
            this.btnDelete_Click = new System.Windows.Forms.Button();
            this.btnEdit_Click = new System.Windows.Forms.Button();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnTimKiem_Click = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd_Click
            // 
            this.btnAdd_Click.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd_Click.Location = new System.Drawing.Point(1122, 252);
            this.btnAdd_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd_Click.Name = "btnAdd_Click";
            this.btnAdd_Click.Size = new System.Drawing.Size(134, 58);
            this.btnAdd_Click.TabIndex = 0;
            this.btnAdd_Click.Text = "Thêm Tài khoản";
            this.btnAdd_Click.UseVisualStyleBackColor = true;
            this.btnAdd_Click.Click += new System.EventHandler(this.btnSave_Click_Click);
            // 
            // btnDelete_Click
            // 
            this.btnDelete_Click.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete_Click.Location = new System.Drawing.Point(1122, 385);
            this.btnDelete_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete_Click.Name = "btnDelete_Click";
            this.btnDelete_Click.Size = new System.Drawing.Size(134, 58);
            this.btnDelete_Click.TabIndex = 1;
            this.btnDelete_Click.Text = "Xóa Tài khoản";
            this.btnDelete_Click.UseVisualStyleBackColor = true;
            this.btnDelete_Click.Click += new System.EventHandler(this.btnDelete_Click_Click);
            // 
            // btnEdit_Click
            // 
            this.btnEdit_Click.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit_Click.Location = new System.Drawing.Point(1122, 322);
            this.btnEdit_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit_Click.Name = "btnEdit_Click";
            this.btnEdit_Click.Size = new System.Drawing.Size(134, 58);
            this.btnEdit_Click.TabIndex = 2;
            this.btnEdit_Click.Text = "Sửa Tài khoản";
            this.btnEdit_Click.UseVisualStyleBackColor = true;
            this.btnEdit_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(87, 55);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(116, 20);
            this.lblTenDangNhap.TabIndex = 4;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(87, 119);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(75, 20);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(87, 182);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(233, 49);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(263, 26);
            this.txtTenDangNhap.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(233, 112);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(263, 26);
            this.txtMatKhau.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(233, 176);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // btnTimKiem_Click
            // 
            this.btnTimKiem_Click.Location = new System.Drawing.Point(981, 48);
            this.btnTimKiem_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem_Click.Name = "btnTimKiem_Click";
            this.btnTimKiem_Click.Size = new System.Drawing.Size(98, 42);
            this.btnTimKiem_Click.TabIndex = 12;
            this.btnTimKiem_Click.Text = "Tìm kiếm";
            this.btnTimKiem_Click.UseVisualStyleBackColor = true;
            this.btnTimKiem_Click.Click += new System.EventHandler(this.btnTimKiem_Click_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(561, 48);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(402, 26);
            this.txtTimKiem.TabIndex = 13;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(1122, 458);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(134, 58);
            this.btnLoadData.TabIndex = 16;
            this.btnLoadData.Text = "Tải lại";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbRole.Location = new System.Drawing.Point(233, 237);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(263, 28);
            this.cmbRole.TabIndex = 17;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(88, 237);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(94, 20);
            this.lblRole.TabIndex = 18;
            this.lblRole.Text = "Chọn quyền";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(91, 293);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.RowTemplate.Height = 28;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(972, 515);
            this.dgvTaiKhoan.TabIndex = 19;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick_1);
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1640, 862);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem_Click);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.btnEdit_Click);
            this.Controls.Add(this.btnDelete_Click);
            this.Controls.Add(this.btnAdd_Click);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyTaiKhoan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd_Click;
        private System.Windows.Forms.Button btnDelete_Click;
        private System.Windows.Forms.Button btnEdit_Click;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnTimKiem_Click;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
    }
}