using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PermitTrak
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewPassword.Text))
                {
                    MessageBox.Show("A new password must be entered.", "New Password.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNewPassword.BackColor = Color.Red;
                    txtNewPassword.ForeColor = Color.White;
                    return;
                }

                if (string.IsNullOrEmpty(txtConfirmPass.Text))
                {
                    MessageBox.Show("A password conirmation must be entered.", "Confirm Password.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtConfirmPass.BackColor = Color.Red;
                    txtConfirmPass.ForeColor = Color.White;
                    return;
                }

                if (string.Compare(txtConfirmPass.Text,txtConfirmPass.Text) > 0)
                {
                    MessageBox.Show("The new password and confirmation must match.", "Check Password.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Open a connection to the database
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                //Build an OleDbCommand based on the SELECT query
                OleDbCommand cmd = new OleDbCommand("UPDATE tblEmployees SET LoginPassword = @LoginPassword, ChangePass = @ChangePass " +
                                                    "WHERE EmployeeName = '" + clsGlobal.userName + "';", conn);

                //Add values to the query parameters
                cmd.Parameters.AddWithValue("@LoginPassword", txtNewPassword.Text);
                cmd.Parameters.AddWithValue("@ChangePass", false);

                //Open the DB connection
                conn.Open();

                //Execute the query
                cmd.ExecuteNonQuery();

                //Close the conection
                conn.Close();

                //Show message box to inform user the employee has been entered
                MessageBox.Show("Your password has been updated on the system.", "Password updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Open the form frmLogin as a child to the parent
                frmLogin objfrmLogin = new frmLogin();
                objfrmLogin.MdiParent = frmPermitTrakParent.ActiveForm;
                objfrmLogin.StartPosition = FormStartPosition.CenterScreen;
                objfrmLogin.Show();

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
