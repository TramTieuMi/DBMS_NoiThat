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
        private static readonly string stringConnection = @"Data Source=NGOCNAM;Initial Catalog=data;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection); 
        }
    }
}
