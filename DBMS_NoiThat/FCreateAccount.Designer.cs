using System;
using System.Drawing;
using System.Reflection.Emit;

namespace Do_An_Tuyen_Dung
{
    partial class FCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCreateAccount));
            this.textBox_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_TenTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_MatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_SignUp = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBox_Role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // textBox_Email
            // 
            this.textBox_Email.BackColor = System.Drawing.Color.Transparent;
            this.textBox_Email.BorderRadius = 18;
            this.textBox_Email.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.textBox_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Email.DefaultText = "";
            this.textBox_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Email.Location = new System.Drawing.Point(112, 271);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.PasswordChar = '\0';
            this.textBox_Email.PlaceholderText = "";
            this.textBox_Email.SelectedText = "";
            this.textBox_Email.Size = new System.Drawing.Size(188, 29);
            this.textBox_Email.TabIndex = 11;
            // 
            // textBox_TenTaiKhoan
            // 
            this.textBox_TenTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.textBox_TenTaiKhoan.BorderRadius = 18;
            this.textBox_TenTaiKhoan.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.textBox_TenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_TenTaiKhoan.DefaultText = "";
            this.textBox_TenTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_TenTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_TenTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_TenTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_TenTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_TenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_TenTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(103, 221);
            this.textBox_TenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            this.textBox_TenTaiKhoan.PasswordChar = '\0';
            this.textBox_TenTaiKhoan.PlaceholderText = "";
            this.textBox_TenTaiKhoan.SelectedText = "";
            this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(188, 29);
            this.textBox_TenTaiKhoan.TabIndex = 10;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.BackColor = System.Drawing.Color.Transparent;
            this.textBox_MatKhau.BorderRadius = 18;
            this.textBox_MatKhau.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.textBox_MatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_MatKhau.DefaultText = "";
            this.textBox_MatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_MatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_MatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_MatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_MatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_MatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_MatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_MatKhau.Location = new System.Drawing.Point(102, 317);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '\0';
            this.textBox_MatKhau.PlaceholderText = "";
            this.textBox_MatKhau.SelectedText = "";
            this.textBox_MatKhau.Size = new System.Drawing.Size(188, 29);
            this.textBox_MatKhau.TabIndex = 13;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.btn_SignUp.BorderRadius = 22;
            this.btn_SignUp.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btn_SignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.btn_SignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.Location = new System.Drawing.Point(103, 472);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(188, 42);
            this.btn_SignUp.TabIndex = 16;
            this.btn_SignUp.Text = "SIGN UP";
            // 
            // ComboBox_Role
            // 
            this.ComboBox_Role.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Role.BorderRadius = 18;
            this.ComboBox_Role.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.ComboBox_Role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Role.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Role.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_Role.ItemHeight = 30;
            this.ComboBox_Role.Items.AddRange(new object[] {
            "Nha Tuyen Dung",
            "Ung Vien"});
            this.ComboBox_Role.Location = new System.Drawing.Point(103, 367);
            this.ComboBox_Role.Name = "ComboBox_Role";
            this.ComboBox_Role.Size = new System.Drawing.Size(189, 36);
            this.ComboBox_Role.Sorted = true;
            this.ComboBox_Role.TabIndex = 19;
            // 
            // FCreateAccount
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(416, 526);
            this.Controls.Add(this.ComboBox_Role);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_TenTaiKhoan);
            this.Name = "FCreateAccount";
            this.Load += new System.EventHandler(this.FCreateAccount_Load_1);
            this.ResumeLayout(false);

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       // private void guna2TextBox2_TextChanged(object sender, EventArgs e) => this.Text = textBox_Email.Text;

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox_TenTaiKhoan.Text;
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBox_Email;
        private Guna.UI2.WinForms.Guna2TextBox textBox_TenTaiKhoan;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBox_MatKhau;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_SignUp;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Role;
    }
}