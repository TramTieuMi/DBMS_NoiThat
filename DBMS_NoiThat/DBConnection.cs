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
        // SqlConnection sqlCon;
        //Data Source=NGOCNAM;Initial Catalog=data_daydu;Integrated Security=True
        //Data Source=DESKTOP-T4EF20F\TANDANH;Initial Catalog=data;Integrated Security=True
        SqlConnection sqlCon;
        // SqlConnection conAdmin = new SqlConnection(@"Data Source=DESKTOP-T4EF20F\TANDANH;Initial Catalog=data;Integrated Security=True");
        public DBConnection()
        {
            

            sqlCon = new SqlConnection(@"Data Source=KHANG\LTWEB;Initial Catalog=""data_daydu (1)"";Integrated Security=True;TrustServerCertificate=True");

        }

        public SqlConnection GetConnection()
        {
            return sqlCon;
        }

        //public SqlConnection getConnectionAdmin
        //{
        //    get
        //    {
        //        return conAdmin;
        //    }
        //}
      
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

        //public void OpenConnectionAdmin()
        //{
        //    if (conAdmin.State == ConnectionState.Closed)
        //    {
        //        conAdmin.Open();
        //    }
        //}

        public void CloseConnection()
        {
            if (sqlCon.State == ConnectionState.Open) // Nếu kết nối đang được mở
            {
                sqlCon.Close();     // Đóng kết nối
            }
        }

        //public void CloseConnectionAdmin()
        //{
        //    if (conAdmin.State == ConnectionState.Open)
        //    {
        //        conAdmin.Close();
        //    }
        //}

        
    }
}
