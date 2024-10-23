using DBMS_NoiThat.Entity;
using DBMS_NoiThat.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_NoiThat.user
{
    public partial class GioHang : Form
    {
        public GioHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FPN_HienThi_Paint(object sender, PaintEventArgs e)
        {

        }
        List<EGioHang> listGH ;
        public GioHang(int MaGioHang)
        {
            InitializeComponent();
            LoadGioHang(MaGioHang);
        }
        public void LoadGioHang(int MaGioHang)
        {
            List<EGioHang> gioHangs = new List<EGioHang>();
            foreach (EGioHang gioHang in gioHangs)
            {
                if(gioHang.MaGioHang1 == MaGioHang)
                {
                    listGH.Add(gioHang);
                    UCGioHang ucgh = new UCGioHang(gioHang);
                    int dis = (FPN_HienThi.Width - (2 * ucgh.Width)) / 3;
                    ucgh.Margin = new Padding(dis, dis, 0, 0);
                    FPN_HienThi.Controls.Add(ucgh);

                }         
            }
        }

        private void BTN_MuaHang_Click(object sender, EventArgs e)
        {
           
            foreach (EGioHang gh in listGH)
            {
                if(gh.Check == true)
                {
                    
                }
            }
        }
    }
}
