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
<<<<<<< HEAD
        private static readonly string stringConnection = @"Data Source=DESKTOP-UR1R776\SQLEXPRESS;Initial Catalog=data;Integrated Security=True;TrustServerCertificate=True";
=======
        //Data Source=NGOCNAM;Initial Catalog=data;Integrated Security=True
        private static readonly string stringConnection = @"Data Source=NGOCNAM;Initial Catalog=data;Integrated Security=True";
>>>>>>> da9fbc1f522df9079382bb0e0352ab091f46ddd6
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection); 
        }
    }
}
