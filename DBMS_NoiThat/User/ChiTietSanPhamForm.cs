using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_NoiThat
{
    public partial class ChiTietSanPhamForm : Form
    {
        public ChiTietSanPhamForm()
        {
            InitializeComponent();
        }

        private void ButtonTroVe_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChiTietSanPhamForm_Load(object sender, EventArgs e)
        {

        }
    }
}
