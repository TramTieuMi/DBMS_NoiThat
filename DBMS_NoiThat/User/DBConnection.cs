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
        // @"Data Source=NGOCNAM;Initial Catalog=NoiThat;Integrated Security=True"
        SqlConnection sqlcon;
        public DBConnection()
        {
            sqlcon = new SqlConnection(@"Data Source=NGOCNAM;Initial Catalog=NoiThat;Integrated Security=True");
        }
        public SqlConnection GetConnection()
        {
            return sqlcon;
        }
        public void OpenConnection()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public void CloseConnection()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

       
    }
}
