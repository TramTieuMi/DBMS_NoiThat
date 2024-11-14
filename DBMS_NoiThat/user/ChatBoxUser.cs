using DBMS_NoiThat.Entity;
using DBMS_NoiThat.UC;
using Do_An_Tuyen_Dung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_NoiThat.user
{
    public partial class ChatBoxUser : Form
    {
        private DBConnection dbConnection; // Declare an instance of DBConnection
        private SqlConnection connection;   // Declare the SqlConnection variable
        string em = "";
        public ChatBoxUser()
        {
            InitializeComponent();
        }
        public ChatBoxUser(string email)
        {
            InitializeComponent();
            em = email;
            loadNoiDung(email);
        }
        public void loadNoiDung(string em)
        {
            SqlCommand command = new SqlCommand("sp_LayChatBoxTheoEmail", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Email", em);

            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string email = reader["Email"].ToString();
                    string hovaTen = reader["HovaTen"].ToString();
                    DateTime ngayGui = Convert.ToDateTime(reader["NgayGui"]);
                    string trangThai = reader["TrangThai"].ToString();
                    string noiDung = reader["NoiDung"].ToString();

                    ChatBox chatBox = new ChatBox(email, hovaTen, ngayGui, trangThai, noiDung);
                    UCChatNoiDung ucnd = new UCChatNoiDung(chatBox, 2);
                    int dis = (FLP_NoiDung.Width - (2 * ucnd.Width)) / 3;
                    ucnd.Margin = new Padding(dis, dis, 0, 0);
                    FLP_NoiDung.Controls.Add(ucnd);
                }
            }
        }
        

        private void BTN_Gui_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_ThemChatBox", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số cho thủ tục
                cmd.Parameters.AddWithValue("@EmailGui", em);
                DateTime ngayHienTai = DateTime.Now;
                cmd.Parameters.AddWithValue("@NgayGui", ngayHienTai);
                cmd.Parameters.AddWithValue("@TrangThai", "Chưa Xem");
                cmd.Parameters.AddWithValue("@NoiDung", TB_NoiDung.Text);

                // Mở kết nối và thực thi thủ tục
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
