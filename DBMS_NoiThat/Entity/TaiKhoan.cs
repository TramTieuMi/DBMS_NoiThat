using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung
{
    internal class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;

        public TaiKhoan()
        {
        }
        public TaiKhoan(string tenTaiKhoan, string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }
        //public List<TaiKhoan> taiKhoans(string email)
        //{
        //    List<TaiKhoan> taiKhoans = new List<TaiKhoan>();

        //    using (SqlConnection sqlConnection = Connection.GetSqlConnection())
        //    {
        //        sqlConnection.Open();

        //        // Sử dụng truy vấn tham số hóa
        //        string query = "SELECT * FROM TAIKHOAN WHERE Email = @Email";
        //        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

        //        // Thêm tham số vào câu lệnh
        //        sqlCommand.Parameters.AddWithValue("@Email", email);

        //        SqlDataReader dataReader = sqlCommand.ExecuteReader();

        //        while (dataReader.Read())
        //        {
        //            taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
        //        }

        //        sqlConnection.Close();
        //    }

        //    return taiKhoans;
        //}

        


        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
