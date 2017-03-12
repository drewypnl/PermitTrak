using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PermitTrak
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //When the timer has completed close the form
                timer1.Enabled = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
