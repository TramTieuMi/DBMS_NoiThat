using DBMS_NoiThat.Entity;
using DBMS_NoiThat.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            InitializeComponent();
            this.eDonHang = eDonHang;
            LB_MaSP.Text = eDonHang.MaSanPham1.ToString();
            LB_TenSP.Text = eDonHang.TenSanPham1;
            LB_SoLuong.Text = eDonHang.SoLuong1.ToString();
            LB_Gia.Text = eDonHang.SoTien1.ToString();
            using (MemoryStream picture = new MemoryStream(eDonHang.Pic))
            {
                PB_hienthi.SizeMode = PictureBoxSizeMode.Zoom; 
                PB_hienthi.Image = Image.FromStream(picture); 
                PB_hienthi.Refresh(); 
            }
        }


        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
