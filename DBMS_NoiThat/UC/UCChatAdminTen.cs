using DBMS_NoiThat.admin;
using DBMS_NoiThat.Entity;
using Do_An_Tuyen_Dung;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DBMS_NoiThat.Entity;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using System.Data.SqlClient;
using DBMS_NoiThat.user;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.IO;
namespace DBMS_NoiThat.UC
{
    public partial class UCChatAdminTen : UserControl
    {
        // Khai báo sự kiện BtnTenClicked
        public event EventHandler<ChatBox> BtnTenClicked;
        private DBConnection dbConnection; // Declare an instance of DBConnection
        private SqlConnection connection;   // Declare the SqlConnection variable


        public UCChatAdminTen()
        {
            InitializeComponent();
        }

        private ChatBox chatBox;

        public UCChatAdminTen(ChatBox chatBox) 
        {
            InitializeComponent();
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
            this.chatBox = chatBox;
            BTN_Ten.Text = chatBox.HovaTen1;

            if (chatBox.TrangThai1 == "gui,chua xem" )
            {
                BTN_Ten.FillColor = System.Drawing.Color.Green;
            }else {
                BTN_Ten.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);

            }
            
        }

        private void BTN_Ten_Click(object sender, EventArgs e)
        {
            BTN_Ten.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
            // Kích hoạt sự kiện BtnTenClicked và truyền đối tượng chatBox
            using (SqlCommand cmd = new SqlCommand("sp_CapNhatTrangThai", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số cho thủ tục
                cmd.Parameters.AddWithValue("@Email", chatBox.Email1);

                // Mở kết nối và thực thi thủ tục
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            
            BtnTenClicked?.Invoke(this, chatBox);
        }
    }

}
