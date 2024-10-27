using DBMS_NoiThat.Entity;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

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
            InitializeComponent();
            this.gioHang = gioHang;
            //LB_MaSanPham = new Label();
            LB_MaSanPham.Text = gioHang.MaSanPham1.ToString();
            //LB_TenSanPham = new Label();
            LB_TenSanPham.Text = gioHang.TenSanPham1;
            //LB_Gia = new Label();
            LB_Gia.Text = gioHang.SoTien1.ToString();
            //TB_SoLuong = new Guna2TextBox();
            TB_SoLuong.Text = gioHang.SoLuong1.ToString();
            //MessageBox.Show(LB_TenSanPham.Text);
            //CK_Chon = new CheckBox();
            CK_Chon.Checked = gioHang.Check ;

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

        private void CK_Chon_CheckedChanged(object sender, EventArgs e)
        {
            if (CK_Chon.Checked == true)
            {
                gioHang.Check = true;
            }
        }
        public void AddCheckVaSouong(bool check, int soLuong)
        {
            check = CK_Chon.Checked;
            soLuong = Convert.ToInt32(TB_SoLuong.Text);
        }

        private void LB_MaSanPham_Click(object sender, EventArgs e)
        {

        }

        private void LB_TenSanPham_Click(object sender, EventArgs e)
        {

        }

        private void LB_Gia_Click(object sender, EventArgs e)
        {

        }

        private void TB_SoLuong_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
