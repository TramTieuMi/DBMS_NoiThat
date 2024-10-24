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
        EGioHang eGioHang;
        public UCDonHang(EGioHang eGioHang)
        {
            this.eGioHang = eGioHang;
            LB_MaSP.Text = eGioHang.MaSanPham1.ToString();
            LB_TenSP.Text = eGioHang.TenSanPham1;
            LB_SoLuong.Text = eGioHang.SoLuong1.ToString();
            LB_Gia.Text = eGioHang.SoTien1.ToString();
            InitializeComponent();
        }
    }
}
