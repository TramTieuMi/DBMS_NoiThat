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
    public partial class UCChatNoiDung : UserControl
    {
        public UCChatNoiDung()
        {
            InitializeComponent();
        }
        ChatBox chatBox;
        public UCChatNoiDung(ChatBox chatBox, int role)
        {
            InitializeComponent();
            this.chatBox = chatBox;
            TB_NoiDung.Text = chatBox.NoiDung1;

            if(role == 1 ) {
                if (chatBox.TrangThai1 == "nhan,chua xem" || chatBox.TrangThai1 == "nhan,da xem")
                {
                    LB_Ten.Text =  "Bạn " + " " + chatBox.NgayGui1.ToString() ;
                }
                else
                {
                    if (chatBox.TrangThai1 == "gui,chua xem")
                    {
                        LB_Ten.Text = chatBox.HovaTen1 + chatBox.NgayGui1.ToString() + " Chưa Xem";
                    }
                    else
                    {
                        LB_Ten.Text = chatBox.HovaTen1 + chatBox.NgayGui1.ToString() + " Đã Xem";
                    }
                }
            }
            else {
                if (chatBox.TrangThai1 == "nhan,chua xem" || chatBox.TrangThai1 == "nhan,da xem")
                {
                    LB_Ten.Text = "Nhân Viên Của Shop " + chatBox.NgayGui1.ToString();
                }
                else
                {
                    if (chatBox.TrangThai1 == "gui,chua xem")
                    {
                        LB_Ten.Text = "Bạn " + chatBox.NgayGui1.ToString() + " Chưa Xem";
                    }
                    else
                    {
                        LB_Ten.Text = "Bạn " + chatBox.NgayGui1.ToString() + " Đã Xem";
                    }
                }
            }


            
        }
    }
}
