using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO; 

namespace PermitTrak
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                frmSplash objfrmSplash = new frmSplash();
                objfrmSplash.ShowDialog();
                frmPermitTrakParent g_objfrmPermitTrakParent = new frmPermitTrakParent();
                Application.Run(g_objfrmPermitTrakParent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
