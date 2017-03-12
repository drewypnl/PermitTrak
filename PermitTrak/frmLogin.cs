using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace PermitTrak
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            try
            {
                InitializeComponent();

                //Disable the menu bar entries not required
                refPermitTrakMDI.mdi.mnuFileLogin.Enabled = false;
                refPermitTrakMDI.mdi.mnuFilelogOff.Enabled = false;
                refPermitTrakMDI.mdi.mnuFileExit.Enabled = true;
                refPermitTrakMDI.mdi.mnuPermits.Enabled = false;
                refPermitTrakMDI.mdi.mnuIsolations.Enabled = false;
                refPermitTrakMDI.mdi.mnuUtilities.Enabled = false;
                refPermitTrakMDI.mdi.mnuTools.Enabled = false;
                refPermitTrakMDI.mdi.mnuWindow.Enabled = false;
                refPermitTrakMDI.mdi.mnuHelp.Enabled = false;
                refPermitTrakMDI.mdi.treeParent.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            try
            {
                refPermitTrakMDI.mdi.mnuFileLogin.Enabled = true;

                //Close form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Check for null value in user name box
                if (String.IsNullOrEmpty(txtUserName.Text))
                {
                    MessageBox.Show("A user name must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Check for null value on password box
                if (String.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("A password must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Change the cursor to hour glass
                this.Cursor = Cursors.WaitCursor;

//********************************************************************************************************************************

                //Read DBPath from appsettings file and assign to DBConnString variable
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM tblEmployees " +
                                                    "WHERE ChangePass = true AND EmployeeName ='" + txtUserName.Text + "';", conn);
                //Open the DB connection
                conn.Open();

                //Change the cursor to hour glass
                this.Cursor = Cursors.WaitCursor;

                //Add the count of the results to the variable count
                int countPass = (int) cmd.ExecuteScalar();

                //Close the connection
                conn.Close();

                //Count the retrieved results. If the count is more than 1 confirm the user has logged on 
                if (countPass > 0)
                {
                    MessageBox.Show("This is the first time you have logged on to the system. You must change your password to continue.", "Change Password.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Open form change pass to allow user to change thir password
                    frmChangePass objfrmChangePass = new frmChangePass();
                    objfrmChangePass.MdiParent = frmPermitTrakParent.ActiveForm;
                    objfrmChangePass.StartPosition = FormStartPosition.CenterScreen;
                    objfrmChangePass.Show();

                    clsGlobal.userName = txtUserName.Text;
                    clsGlobal.password = txtPassword.Text;

                    //Change the cursor to normal
                    this.Cursor = Cursors.Default;

                    //Close the form
                    this.Close();
                    return;
                }

//********************************************************************************************************************************

                //Build an OleDbCommand based on the SELECT query
                cmd = new OleDbCommand("SELECT COUNT(*) FROM tblEmployees " +
                                                    "WHERE EmployeeName='" + txtUserName.Text +
                                                    "' AND LoginPassword='" + txtPassword.Text + "';", conn);
                //Open the DB connection
                conn.Open();

                //Add the count of the results to the variable count
                int countUser = (int) cmd.ExecuteScalar();

                //Close the connection
                conn.Close();

                //Count the retrieved results. If the count is more than 1 confirm the user has logged on 
                if (countUser>0)
                {
                    //Load the global variables with the user name and password textbox values
                    clsGlobal.userName = txtUserName.Text;
                    clsGlobal.password = txtPassword.Text;

                    //Update the status strip text to reflect successful logon
                    refPermitTrakMDI.mdi.mdiStatusLabel.Text = "Logged On";
                    refPermitTrakMDI.mdi.mnuFileLogin.Enabled = false;
                    refPermitTrakMDI.mdi.mnuFilelogOff.Enabled = true;
                    refPermitTrakMDI.mdi.mnuFile.Enabled = true;
                    refPermitTrakMDI.mdi.mnuPermits.Enabled = true;
                    refPermitTrakMDI.mdi.mnuIsolations.Enabled = true;
                    refPermitTrakMDI.mdi.mnuUtilities.Enabled = true;
                    refPermitTrakMDI.mdi.mnuTools.Enabled = true;
                    refPermitTrakMDI.mdi.mnuWindow.Enabled = true;
                    refPermitTrakMDI.mdi.mnuHelp.Enabled = true;
                    refPermitTrakMDI.mdi.treeParent.Enabled = true;

                    //Change the cursor to normal
                    this.Cursor = Cursors.Default;

                    //Close form
                    this.Close();
                    return;
                }
                else
                {
                    //No usernameandpassword is retrieved. Show a message box to alert the user
                    MessageBox.Show("The username and password combination is not recognised.\n\n" +
                                    "If this problem persists contact the system administrator.", "Login Error.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Set the text boxes to null values
                    txtUserName.Text = null;
                    txtPassword.Text = null;

                    //Change the cursor to hour glass
                    this.Cursor = Cursors.WaitCursor;

                    return;

                }

            }
            catch (Exception ex)
            {
                //Change the cursor to normal
                this.Cursor = Cursors.Default;

                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.cmdLogin.PerformClick();
            }
        }
    }
}
