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
    public partial class UCNhacNho : UserControl
    {
        public UCNhacNho()
        {
            InitializeComponent();
            //LoadMessages();
        }

        private void UCNhacNho_Load(object sender, EventArgs e)
        {
            
        }

        // Hàm gán nội dung cho Label
        public void SetMessage(string message)
        {
            txtNhacNho.Text = message;
        }
    }
}
