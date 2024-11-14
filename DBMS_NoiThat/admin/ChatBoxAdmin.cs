using DBMS_NoiThat.Entity;
using DBMS_NoiThat.UC;
using DBMS_NoiThat.user;
using Do_An_Tuyen_Dung;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DBMS_NoiThat.admin
{
    public partial class ChatBoxAdmin : Form
    {
        private DBConnection dbConnection; // Declare an instance of DBConnection
        private SqlConnection connection;   // Declare the SqlConnection variable
        public ChatBoxAdmin()
        {
            InitializeComponent();

            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
            loadTen();
        }
        string em;
        public void loadTen()
        {
            connection.Open();

            // Tạo câu lệnh gọi thủ tục
            SqlCommand cmd = new SqlCommand("GetChatboxDetails", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // Lấy dữ liệu từ SqlDataReader
                string email = reader["Email"].ToString();
                DateTime ngayGui = Convert.ToDateTime(reader["NgayGui"]);
                string trangThai = reader["TrangThai"].ToString();
                string noiDung = reader["NoiDung"].ToString();
                string hovaTen = reader["HovaTen"].ToString();
                // Tạo đối tượng ChatBox với dữ liệu vừa đọc được
                ChatBox chatBox = new ChatBox(email, hovaTen, ngayGui, trangThai, noiDung);

                // Tạo UCChatAdminTen với đối tượng ChatBox
                UCChatAdminTen uccb = new UCChatAdminTen(chatBox);              

                // Căn chỉnh khoảng cách giữa các điều khiển trong FlowLayoutPanel
                int dis = (FLP_Ten.Width - (2 * uccb.Width)) / 3;
                uccb.Margin = new Padding(dis, dis, 0, 0);

                // Thêm UserControl vào FlowLayoutPanel
                FLP_Ten.Controls.Add(uccb);

                // Đăng ký sự kiện BtnTenClicked
                uccb.BtnTenClicked += (s, cb) => LoadNoiDung(cb.Email1);
            }

            reader.Close();
            connection.Close();
        }


        public void LoadNoiDung(string email)
        {
            em = email;
            SqlCommand command = new SqlCommand("sp_LayChatBoxTheoEmail", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Email", em );

            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string hovaTen = reader["HovaTen"].ToString();
                    DateTime ngayGui = Convert.ToDateTime(reader["NgayGui"]);
                    string trangThai = reader["TrangThai"].ToString();
                    string noiDung = reader["NoiDung"].ToString();

                    ChatBox chatBox = new ChatBox(email, hovaTen, ngayGui, trangThai, noiDung);
                    UCChatNoiDung ucnd = new UCChatNoiDung(chatBox,1);
                    int dis = (FLP_Chat.Width - (2 * ucnd.Width)) / 3;
                    ucnd.Margin = new Padding(dis, dis, 0, 0);
                    FLP_Chat.Controls.Add(ucnd);
                }
            }
        }

        private void BTN_Gui_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_ThemChatBox", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số cho thủ tục
                cmd.Parameters.AddWithValue("@Email", em);
                DateTime ngayHienTai = DateTime.Now;
                cmd.Parameters.AddWithValue("@NgayGui", ngayHienTai);
                cmd.Parameters.AddWithValue("@TrangThai", "Chưa Xem");
                cmd.Parameters.AddWithValue("@NoiDung", TB_Nhap.Text);

                // Mở kết nối và thực thi thủ tục
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
