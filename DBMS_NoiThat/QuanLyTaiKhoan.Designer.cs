namespace WindowsFormsApp1
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
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbRoleID = new System.Windows.Forms.ComboBox();
            this.btnTimKiem_Click = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.chkTenDangNhap = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd_Click
            // 
            this.btnAdd_Click.Location = new System.Drawing.Point(636, 58);
            this.btnAdd_Click.Name = "btnAdd_Click";
            this.btnAdd_Click.Size = new System.Drawing.Size(134, 57);
            this.btnAdd_Click.TabIndex = 0;
            this.btnAdd_Click.Text = "Thêm Tài khoản";
            this.btnAdd_Click.UseVisualStyleBackColor = true;
            this.btnAdd_Click.Click += new System.EventHandler(this.btnSave_Click_Click);
            // 
            // btnDelete_Click
            // 
            this.btnDelete_Click.Location = new System.Drawing.Point(636, 190);
            this.btnDelete_Click.Name = "btnDelete_Click";
            this.btnDelete_Click.Size = new System.Drawing.Size(134, 57);
            this.btnDelete_Click.TabIndex = 1;
            this.btnDelete_Click.Text = "Xóa Tài khoản";
            this.btnDelete_Click.UseVisualStyleBackColor = true;
            this.btnDelete_Click.Click += new System.EventHandler(this.btnDelete_Click_Click);
            // 
            // btnEdit_Click
            // 
            this.btnEdit_Click.Location = new System.Drawing.Point(636, 127);
            this.btnEdit_Click.Name = "btnEdit_Click";
            this.btnEdit_Click.Size = new System.Drawing.Size(134, 57);
            this.btnEdit_Click.TabIndex = 2;
            this.btnEdit_Click.Text = "Sửa Tài khoản";
            this.btnEdit_Click.UseVisualStyleBackColor = true;
            this.btnEdit_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(38, 177);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.RowTemplate.Height = 28;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(549, 261);
            this.dgvTaiKhoan.TabIndex = 3;
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chức vụ";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(180, 16);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(121, 26);
            this.txtTenDangNhap.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(180, 59);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(121, 26);
            this.txtMatKhau.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(180, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // cmbRoleID
            // 
            this.cmbRoleID.FormattingEnabled = true;
            this.cmbRoleID.Location = new System.Drawing.Point(180, 136);
            this.cmbRoleID.Name = "cmbRoleID";
            this.cmbRoleID.Size = new System.Drawing.Size(121, 28);
            this.cmbRoleID.TabIndex = 11;
            // 
            // btnTimKiem_Click
            // 
            this.btnTimKiem_Click.Location = new System.Drawing.Point(489, 101);
            this.btnTimKiem_Click.Name = "btnTimKiem_Click";
            this.btnTimKiem_Click.Size = new System.Drawing.Size(98, 27);
            this.btnTimKiem_Click.TabIndex = 12;
            this.btnTimKiem_Click.Text = "Tìm kiếm";
            this.btnTimKiem_Click.UseVisualStyleBackColor = true;
            this.btnTimKiem_Click.Click += new System.EventHandler(this.btnTimKiem_Click_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(327, 136);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 26);
            this.txtTimKiem.TabIndex = 13;
            // 
            // chkTenDangNhap
            // 
            this.chkTenDangNhap.AutoSize = true;
            this.chkTenDangNhap.Location = new System.Drawing.Point(327, 64);
            this.chkTenDangNhap.Name = "chkTenDangNhap";
            this.chkTenDangNhap.Size = new System.Drawing.Size(142, 24);
            this.chkTenDangNhap.TabIndex = 14;
            this.chkTenDangNhap.Text = "Tên đăng nhập";
            this.chkTenDangNhap.UseVisualStyleBackColor = true;
            this.chkTenDangNhap.CheckedChanged += new System.EventHandler(this.chkTenDangNhap_CheckedChanged);
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(327, 101);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(74, 24);
            this.chkEmail.TabIndex = 15;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(636, 262);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(134, 57);
            this.btnLoadData.TabIndex = 16;
            this.btnLoadData.Text = "Tải lại";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.chkEmail);
            this.Controls.Add(this.chkTenDangNhap);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem_Click);
            this.Controls.Add(this.cmbRoleID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.btnEdit_Click);
            this.Controls.Add(this.btnDelete_Click);
            this.Controls.Add(this.btnAdd_Click);
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
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbRoleID;
        private System.Windows.Forms.Button btnTimKiem_Click;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.CheckBox chkTenDangNhap;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.Button btnLoadData;
    }
}