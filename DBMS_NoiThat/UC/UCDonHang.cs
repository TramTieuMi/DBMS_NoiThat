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
    public partial class UCDonHang : UserControl
    {
        public UCDonHang()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void UCDonHang_Load(object sender, EventArgs e)
        {

        }
        EDonHang eDonHang;
        public UCDonHang(EDonHang eDonHang)
        {
            this.eDonHang = eDonHang;
            LB_MaSP.Text = eDonHang.MaSanPham1.ToString();
            LB_TenSP.Text = eDonHang.TenSanPham1;
            LB_SoLuong.Text = eDonHang.SoLuong1.ToString();
            LB_Gia.Text = eDonHang.SoTien1.ToString();
            InitializeComponent();
        }
    }
}
