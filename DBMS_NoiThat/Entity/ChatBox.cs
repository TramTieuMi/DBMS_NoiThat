using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DBMS_NoiThat.Entity
{
    public class ChatBox
    {
        string Email;
        string HovaTen;
        DateTime NgayGui;
        string TrangThai;
        string NoiDung;

        public ChatBox(string email, string hovaTen, DateTime ngayGui, string trangThai, string noiDung)
        {
            Email = email;
            HovaTen = hovaTen;
            NgayGui = ngayGui;
            TrangThai = trangThai;
            NoiDung = noiDung;
        }

        public string Email1 { get => Email; set => Email = value; }
        public string HovaTen1 { get => HovaTen; set => HovaTen = value; }
        public DateTime NgayGui1 { get => NgayGui; set => NgayGui = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }
        public string NoiDung1 { get => NoiDung; set => NoiDung = value; }
    }
}
