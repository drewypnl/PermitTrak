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
    public partial class frmCancelPermit : Form
    {
        public frmCancelPermit()
        {
            try
            {
                InitializeComponent();

                //Set connection variable with value from properties.settings
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                BindingSource bind = new BindingSource();

                OleDbCommand cmdCancelPermit = new OleDbCommand("SELECT tblCompanies.CompanyName, tblPermitHeader.PermitID, tblPermitHeader.PermitNumber, " +
                                        "tblPermitHeader.StartDate, tblPermitHeader.TaskDescription, tblPermitStatus.SectionReached FROM " +
                                        "(tblCompanies INNER JOIN tblPermitHeader ON tblCompanies.CompanyID = tblPermitHeader.CompanyID) " +
                                        "INNER JOIN tblPermitStatus ON tblPermitHeader.PermitID = " +
                                        "tblPermitStatus.PermitID WHERE tblPermitStatus.SectionReached=4;", conn);
                //Open the DB connection
                conn.Open();

                OleDbDataAdapter adapt = new OleDbDataAdapter(cmdCancelPermit);

                DataTable table = new DataTable();

                adapt.Fill(table);

                BindingSource bindSource = new BindingSource();

                bindSource.DataSource = table;

                txtPermitID.DataBindings.Add("Text", bindSource, "PermitID");
                txtPermitNumber.DataBindings.Add("Text", bindSource, "PermitNumber");
                txtStartDate.DataBindings.Add("Text", bindSource, "StartDate");
                txtDescription.DataBindings.Add("Text", bindSource, "TaskDescription");
                txtCompanyName.DataBindings.Add("Text", bindSource, "CompanyName");

                dataRepeatCancelPermit.DataSource = bindSource;
               

                //conn.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You are about to cancel Permit Number " + txtPermitNumber.Text + ", are you sure?", "Cancel Permit.",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                ///Update the permit status
                OleDbCommand cmdUpdatePermitStatus = new OleDbCommand("UPDATE tblPermitStatus SET SectionReached = @SectionReached WHERE PermitID = " + int.Parse(txtPermitID.Text) + ";", conn);

                //Add values to the query parameters
                cmdUpdatePermitStatus.Parameters.AddWithValue("@SectionReached", 9);

                //Open the DB connection
                conn.Open();

                //Execute the query
                cmdUpdatePermitStatus.ExecuteNonQuery();

                //Close the conection
                conn.Close();
            }
            else if (dr == DialogResult.No)
            {

            }
        }
    }
}
