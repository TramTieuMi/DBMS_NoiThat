using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using DBMS_NoiThat.user;

namespace DBMS_NoiThat
{
    public partial class Register : Form
    {
        private Timer timerSendCode;
        int time = 60;
        string randomCode;
        public static string to;
        DBConnection myDB = new DBConnection();
        public Register()
        {
            InitializeComponent();
            // Khởi tạo Timer
            timerSendCode = new Timer();
            timerSendCode.Interval = 1000; // 1000 ms = 1 giây
            timerSendCode.Tick += timerSend_Tick; // Gán sự kiện Tick

            // Khởi tạo nút và label
            btnSendCode.Enabled = true;
            labelNotice.Text = "";

            txtUserName.Visible = false;
            txtPassword.Visible = false;
            txtRePassword.Visible = false;
        }
        private bool existEmail()
        {
            DBConnection myDB = new DBConnection();
            myDB.OpenConnection();
            try
            {


                myDB.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT dbo.CheckEmailExists(@Email)", myDB.GetConnection());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                bool status = (bool)cmd.ExecuteScalar();
                myDB.CloseConnection();
                if (status)
                {
                    return true;

                }

        }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message, "Add Account",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            return false;

        }
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            try
            {
                // Bắt đầu đếm thời gian khi người dùng nhấn nút gửi mã
                btnSendCode.Enabled = false;
                btnVerifyCode.Enabled = true;
                time = 60;
                timerSendCode.Start(); // Bắt đầu timer
                if (txtEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your email address", "Add Acount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (existEmail() == true)
                {
                    MessageBox.Show("Email already used, please enter another email",
                    "Add Acount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = txtEmail.Text.Trim();
                from = "22133010@student.hcmute.edu.vn"; //email của bạn
                pass = "PNDuog@5432106#";// pass email
                messageBody = "Code: " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Account creation code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code send successfully", "Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timerSend.Enabled = true;
            }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        
        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            
            if (checkCode() == true)
            {
                labelNotice.Visible = false;
                btnSendCode.Enabled = false;
                btnVerifyCode.Enabled = false;
                txtUserName.Visible = true;
                txtPassword.Visible = true;
                txtRePassword.Visible = true;
                
            }
          

        }
        bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        private bool checkInfor()
        {
            if (txtUserName.Text.Trim() == "" ||
                txtPassword.Text.Trim() == "" ||
                txtRePassword.Text.Trim() == "" ||
                txtCode.Text.Trim() == "")
                return false;
            return true;
        }

        private bool checkCode()
        {
            if (txtCode.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your code", "Forget Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (randomCode == txtCode.Text.ToString().Trim())
            {
                to = txtEmail.Text.Trim();

            }
            else
            {
                MessageBox.Show("Wrong code");
                return false;
            }
            return true;
        }
        private bool checkUserExist(string usn)
        {
            DBConnection myDB = new DBConnection();
            myDB.OpenConnection();
            try
            {


                myDB.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT dbo.CheckUserExists(@TenDangNhap)", myDB.GetConnection());
                cmd.Parameters.AddWithValue("@TenDangNhap", txtUserName.Text.Trim());
                bool status = (bool)cmd.ExecuteScalar();
                myDB.CloseConnection();
                if (status)
                {
                    return true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message, "Add Account",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            return false;

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInfor())
                {


                    if (txtPassword.Text != txtRePassword.Text)
                    {
                        MessageBox.Show("Password authentication is wrong, please check again", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Text = "";
                        return;

                    }

                    else if (checkUserExist(txtUserName.Text.ToString().Trim()) == true)
                    {
                        MessageBox.Show("This username has already existed", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        myDB.OpenConnection();
                        try
                        {

                            SqlCommand cmd = new SqlCommand("[AddEmailToKHACHHANG]", myDB.GetConnection());
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmd.ExecuteNonQuery();

                            SqlCommand cmd1 = new SqlCommand("[proc_AddUser]", myDB.GetConnection());
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.Parameters.AddWithValue("@TenDangNhap", txtUserName.Text.Trim());
                            cmd1.Parameters.AddWithValue("@MatKhau", txtPassword.Text.Trim());
                            cmd1.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmd1.Parameters.AddWithValue("@RoleID", 2);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Account sucessfully created", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUserName.Text = "";
                            txtPassword.Text = "";
                            txtRePassword.Text = "";
                            this.Close();

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Registration error" + ex.Message, "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Please do not leave information blank", "Create Account",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerSend_Tick(object sender, EventArgs e)
        {
            try
            {
                if (time >= 0)
                {
                    // Cập nhật label với thời gian đếm ngược
                    labelNotice.Text = "Resend code in " + time + " seconds";
                    time--;
                }
                else
                {
                    // Đặt lại thời gian và dừng timer
                   labelNotice.Text = "";
                   // time = 60; // Reset thời gian đếm ngược
                    btnSendCode.Enabled = true; // Bật lại nút gửi mã
                    btnVerifyCode.Enabled = false;
                    timerSendCode.Stop(); // Dừng timer
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show(ex.Message);
            }
        }
    }
}
