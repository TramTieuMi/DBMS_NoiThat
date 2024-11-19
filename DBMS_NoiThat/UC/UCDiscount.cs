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
    public partial class UCDiscount : UserControl
    {
        public event Action<string> OnApplyDiscount; // Sự kiện để thông báo mã giảm giá
        public UCDiscount()
        {
            InitializeComponent();
        }
        Discount discount;
        public UCDiscount(Discount discount)
        {
            InitializeComponent();
            this.discount = discount;
            LB_MGG.Text = discount.MaGiamGia1;
            LB_GTG.Text = discount.SoLuongGiam1.ToString();
            LB_LiDo.Text = discount.LiDo1;
        }

        private void BTN_AD_Click(object sender, EventArgs e)
        {
            OnApplyDiscount?.Invoke(discount.MaGiamGia1);
        }
    }
}
