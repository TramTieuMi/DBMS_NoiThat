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
            timerSendCode.Interval = 1000; // 1000 ms = 1 giây khoảng thời gian sự kiện Tick sẽ được kích hoạt mỗi 1 giây.
            timerSendCode.Tick += timerSend_Tick; // Gán sự kiện Tick

            // Khởi tạo nút và label
            btnSendCode.Enabled = true;
            labelNotice.Text = "";

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

        
    
        bool checkEmail(string em)
        {
            // kiểm tra tính hợp lệ của một địa chỉ email
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
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

        private void btnSendCode_Click_1(object sender, EventArgs e)
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
                MailMessage message = new MailMessage(); //thư viện xây dựng một email
                to = txtEmail.Text.Trim(); //thêm email người nhận vào thông điệp
                from = "22133010@student.hcmute.edu.vn"; //email của bạn
                pass = "PNDuog@5432106#";// pass email
                messageBody = "Code: " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from); //là email người gửi.
                message.Body = messageBody; // chứa nội dung mã xác nhận.
                message.Subject = "Account creation code"; // là tiêu đề email.

                //Cấu hình SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true; // Kích hoạt SSL để bảo mật kết nối.
                smtp.Port = 587; //Cổng 587 là cổng SMTP có hỗ trợ SSL.
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; //sử dụng để chỉ định phương thức gửi email cho đối tượng SmtpClient
                smtp.Credentials = new NetworkCredential(from, pass); //Xác thực với thông tin tài khoản email của người gửi.
                try
                {
                    //Nếu thành công, hiển thị thông báo
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {

            if (checkCode() == true)
            {
                labelNotice.Visible = false;
                btnSendCode.Enabled = false;
                btnVerifyCode.Enabled = false;
                TaoTaiKhoan taoTaiKhoan = new TaoTaiKhoan();
                taoTaiKhoan.txtEmail.Text = txtEmail.Text.Trim();
                taoTaiKhoan.ShowDialog();
                this.Close();


            }
           

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
