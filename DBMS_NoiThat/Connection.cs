using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Do_An_Tuyen_Dung
{
    internal class Connection
    {
        private static readonly string stringConnection = @"Data Source=DESKTOP-UR1R776\SQLEXPRESS;Initial Catalog=data;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection); 
        }
    }
}
