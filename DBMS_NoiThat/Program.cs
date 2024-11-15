
﻿using DBMS_NoiThat.admin;
using DBMS_NoiThat.user;

using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;



using System.Windows.Forms;

namespace DBMS_NoiThat
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FDangNhap());
        }
    }
}
