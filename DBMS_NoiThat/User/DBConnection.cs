using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_NoiThat.user
{
    internal class DBConnection
    {
        SqlConnection sqlCon;
        public DBConnection()
        {
            sqlCon = new SqlConnection(@"Data Source=NGOCNAM;Initial Catalog=NoiThat;Integrated Security=True");
        }

        public SqlConnection GetConnection()
        {
            return sqlCon;
        }

      

        public void OpenConnection()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed) // Nết trạng thái là đóng kết nối
                {
                    sqlCon.Open();                          // Mở kết nối
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    // Nếu có lỗi thì thông báo
            }
        }

      

        public void CloseConnection()
        {
            if (sqlCon.State == ConnectionState.Open) // Nếu kết nối đang được mở
            {
                sqlCon.Close();     // Đóng kết nối
            }
        }

       
    }
}
