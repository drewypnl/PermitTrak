using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace PermitTrak
{
    public partial class frmPermitTrakParent : Form

    {

        public frmPermitTrakParent()
        {
            try
            {
                InitializeComponent();
                Application.EnableVisualStyles();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            try
            {
                //Message box to confirm whether the user wants to exit or not
                DialogResult msgBoxResult = MessageBox.Show("You are about to exit PermitTrak. Are you sure?", "Exit.",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //Run the code based on the button clicked
                if (msgBoxResult == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<frmAbout>().Count() == 0)
                {
                    //Open the form frmAbout
                    frmAbout objfrmAbout = new frmAbout();
                    objfrmAbout.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuToolsPreferences_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<frmOptions>().Count()==0)
                {
                    //Open the form frmOptions as a child to the parent
                    frmOptions objfrmOptions = new frmOptions();
                    objfrmOptions.MdiParent = this;
                    objfrmOptions.StartPosition = FormStartPosition.CenterScreen;
                    objfrmOptions.Show();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmPermitTrakParent_Load(object sender, EventArgs e)
        {
            try
            {   
                //Set the variables on form load
                refPermitTrakMDI.mdi = this;
                clsGlobal.configFileName = @"C:\PermitTrak\PermitTrakSettings.txt";
                mdiStatusLabel.Text = "Ready";

                //Open the form frmLogin as a child to the parent
                frmLogin objfrmLogin = new frmLogin();
                objfrmLogin.MdiParent = this;
                objfrmLogin.StartPosition = FormStartPosition.CenterScreen;
                objfrmLogin.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuFileLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<frmLogin>().Count() == 0)
                {
                    //Open the form frmLogin as a child to the parent
                    frmLogin objfrmLogin = new frmLogin();
                    objfrmLogin.MdiParent = this;
                    objfrmLogin.StartPosition = FormStartPosition.CenterScreen;
                    objfrmLogin.Show();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuToolsAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<frmEmployees>().Count() == 0)
                {
                    //Open employees form as a child to the parent
                    frmEmployees objfrmEmployees = new frmEmployees();
                    objfrmEmployees.MdiParent = this;
                    objfrmEmployees.StartPosition = FormStartPosition.CenterParent;
                    objfrmEmployees.Show();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuFilelogOff_Click(object sender, EventArgs e)
        {
            try
            {
               DialogResult msgBoxResult = MessageBox.Show("You are about to log off. Are you sure?", "Log Off.",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgBoxResult == DialogResult.Yes)
                {
                    //Set the status bar text
                    mdiStatusLabel.Text = "Ready";

                    //Set the username and password global variables to null
                    clsGlobal.userName = null;
                    clsGlobal.password = null;

                    //Open the form frmLogin as a child to the parent
                    frmLogin objfrmLogin = new frmLogin();
                    objfrmLogin.MdiParent = this;
                    objfrmLogin.StartPosition = FormStartPosition.CenterScreen;
                    objfrmLogin.Show();
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void treeParent_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                //Permit node selected
                if (e.Node.Name == "ndePermitsNewPermit")
                {
                    mnuPermitsNewPermit.PerformClick();
                }
                else if (e.Node.Name == "ndePermitsCancel")
                {
                    mnuPermitsCancel.PerformClick();
                }
                else if (e.Node.Name == "ndePermitsApproval")
                {

                }
                else if (e.Node.Name == "ndePermitsCancel")
                {

                }
                else if (e.Node.Name == "ndePermitsIssuing")
                {

                }
                else if (e.Node.Name == "ndePermitsAcceptance")
                {

                }
                else if (e.Node.Name == "ndePermitsRPCancel")
                {

                }
                else if (e.Node.Name == "ndePermitsVICancel")
                {
                
                }
                //Isolation node selected
                else if (e.Node.Name == "ndeIsolationsNewIsolation")
                {
                
                }
                else if (e.Node.Name == "ndeIsolationsCancel")
                {

                }
                else if (e.Node.Name == "ndeIsolationsIssueElec")
                {

                }
                else if (e.Node.Name == "ndeIsolationsIssueMech")
                {

                }
                else if (e.Node.Name == "ndeIsolationsReceipt")
                {

                }
                else if (e.Node.Name == "ndeIsolationsClearence")
                {

                }
                else if (e.Node.Name == "ndeIsolationsCancellation")
                {
                
                }
                //Permit utilities node selected 
                else if (e.Node.Name == "ndePermitUtilsDailySign")
                {

                }
                else if (e.Node.Name == "ndePermitUtilsEdit")
                {

                }
                else if (e.Node.Name == "ndePermitUtilsSerch")
                {

                }
                else if (e.Node.Name == "ndePermitUtilsPrintReports")
                {
                
                }
                //Isolation utilities node selected
                else if (e.Node.Name == "ndeIsolationUtilsPadlock")
                {

                }
                else if (e.Node.Name == "ndeIsolationUtilsEdit")
                {

                }
                else if (e.Node.Name == "ndeIsolationUtilsSerch")
                {

                }
                else if (e.Node.Name == "ndeIsolationUtilsPrintReports")
                {
                
                }
                //Tools node selected
                else if (e.Node.Name == "ndeToolsAddEmployee")
                {
                    mnuToolsAddEmployee.PerformClick();
                }
                else if (e.Node.Name == "ndeToolsCompanies")
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuPermitsNewPermit_Click(object sender, EventArgs e)
        {
            frmAddPermit objAddPermit = new frmAddPermit();
            objAddPermit.MdiParent = this;
            objAddPermit.StartPosition = FormStartPosition.CenterScreen;
            objAddPermit.Show();

        }

        private void mnuPermitsCancel_Click(object sender, EventArgs e)
        {
            frmCancelPermit objfrmCancelPermit = new frmCancelPermit();
            objfrmCancelPermit.MdiParent = this;
            objfrmCancelPermit.StartPosition = FormStartPosition.CenterScreen;
            objfrmCancelPermit.Show();

        }
    }
}
