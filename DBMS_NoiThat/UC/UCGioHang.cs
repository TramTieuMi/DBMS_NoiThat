using DBMS_NoiThat.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_NoiThat.UC
{
    public partial class UCGioHang : UserControl
    {
        public UCGioHang()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        EGioHang gioHang;
        public UCGioHang(EGioHang gioHang)
        {   
            this.gioHang = gioHang;
            LB_MaSanPham.Text = gioHang.MaSanPham1.ToString();
            LB_TenSanPham.Text = gioHang.TenSanPham1;
            LB_Gia.Text = gioHang.SoTien1.ToString();
            TB_SoLuong.Text = gioHang.SoLuong1.ToString();
            CK_Chon.Checked = gioHang.Check;
            InitializeComponent();
        }

        private void BTN_Giam_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TB_SoLuong.Text);
            num = num - 1;
            TB_SoLuong.Text = num.ToString();
        }

        private void BTN_Tang_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TB_SoLuong.Text);
            num = num + 1;
            TB_SoLuong.Text = num.ToString();
        }
    }
}
