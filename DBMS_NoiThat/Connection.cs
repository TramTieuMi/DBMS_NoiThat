﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Do_An_Tuyen_Dung
{
    internal class Connection
    {
        //Data Source=NGOCNAM;Initial Catalog=NoiThat;Integrated Security=True
       
        private static readonly string stringConnection = @"Data Source=KHANG\LTWEB;Initial Catalog=data_daydu;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection); 
        }
    }
}
