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
            SqlCommand cmd = new SqlCommand("GetChatboxDetails", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string email = reader["Email"].ToString();
                DateTime ngayGui = Convert.ToDateTime(reader["NgayGui"]);
                string trangThai = reader["TrangThai"].ToString();
                string noiDung = reader["NoiDung"].ToString();
                string hovaTen = reader["HovaTen"].ToString();
                ChatBox chatBox = new ChatBox(email, hovaTen, ngayGui, trangThai, noiDung);
                UCChatAdminTen uccb = new UCChatAdminTen(chatBox);              
                int dis = (FLP_Ten.Width - (2 * uccb.Width)) / 3;
                uccb.Margin = new Padding(dis, dis, 0, 0);
                FLP_Ten.Controls.Add(uccb);
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
            FLP_Chat.Controls.Clear();
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
            connection.Close();
        }

        private void BTN_Gui_Click(object sender, EventArgs e)
        {
            
            using (SqlCommand cmd = new SqlCommand("sp_ThemChatBox", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", em);
                DateTime ngayHienTai = DateTime.Now;
                cmd.Parameters.AddWithValue("@NgayGui", ngayHienTai);
                cmd.Parameters.AddWithValue("@TrangThai", "nhan,chua xem");
                cmd.Parameters.AddWithValue("@NoiDung", TB_Nhap.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            LoadNoiDung(em);
            TB_Nhap.Text = "";
        }
    }
}
