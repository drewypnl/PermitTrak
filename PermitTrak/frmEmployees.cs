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
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            try
            {
                //Close form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'projectTrak_DataSet.tblEmployees' table. You can move, or remove it, as needed.
                this.tblEmployeesTableAdapter.Fill(this.projectTrak_DataSet.tblEmployees);
                // TODO: This line of code loads data into the 'projectTrak_DataSet.tblCompanies' table. You can move, or remove it, as needed.
                this.tblCompaniesTableAdapter.Fill(this.projectTrak_DataSet.tblCompanies);

                this.grpEditEmployeeInfo.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void cmdAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if the employee name text box is empty
                if (string.IsNullOrEmpty(txtAddEmployeeName.Text))
                {
                    MessageBox.Show("An employee name must be entered.", "Employee Name.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddEmployeeName.BackColor = Color.Red;
                    txtAddEmployeeName.ForeColor = Color.White;
                    return;
                }

                //Check if the company combo box is empty
                if (string.IsNullOrEmpty(cboAddCompany.Text))
                {
                    MessageBox.Show("A company must be entered.", "Company.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboAddCompany.BackColor = Color.Red;
                    cboAddCompany.ForeColor = Color.White;
                    return;
                }

                //Check if the contact number text box is empty
                if (string.IsNullOrEmpty(txtAddContactNumber.Text))
                {
                    MessageBox.Show("A contact number must be entered.", "Contact Number.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddContactNumber.BackColor = Color.Red;
                    txtAddContactNumber.ForeColor = Color.White;
                    return;
                }

                //Check if the access level text box is empty
                if (string.IsNullOrEmpty(txtAddAccessLevel.Text))
                {
                    MessageBox.Show("An access level must be entered.", "Access Level.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddAccessLevel.BackColor = Color.Red;
                    txtAddAccessLevel.ForeColor = Color.White;
                    return;
                }
                if(int.Parse(txtAddAccessLevel.Text)>5)
                {
                    MessageBox.Show("The access level must be between 1 and 5.", "Access Level.", MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    txtAddAccessLevel.BackColor = Color.Red;
                    txtAddAccessLevel.ForeColor = Color.White;
                    return;
                }

                //Open a connection from the DB string in the settings file
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                //Build an OleDbCommand based on the SELECT query
                OleDbCommand cmdCountEmployee = new OleDbCommand("SELECT COUNT(*) FROM tblEmployees " +
                                                        "WHERE EmployeeName='" + txtAddEmployeeName.Text + "';", conn);
                //Open the DB connection
                conn.Open();

                //Add the count of the results to the variable count
                int count = (int)cmdCountEmployee.ExecuteScalar();

                //Close the connection
                conn.Close();

                //Count the retrieved results. If the count is more than 1 confirm the user has logged on 
                if (count > 0)
                {
                    //The employee name already exists. Show a message box to alert the user
                    MessageBox.Show("The employee name is already entered on the system.", "Login Error.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Convert the text value of the access level text box to an integer value.
                int adminLevel;
                adminLevel = Convert.ToInt32(txtAddAccessLevel.Text);

                //Build an OleDbCommand based on the SELECT query
                OleDbCommand cmdAddEmployee = new OleDbCommand("INSERT INTO tblEmployees ( CompanyID, EmployeeName, ConveyorAware, PermitCoordinator, " +
                                                    "PermitResPerson, IsoResPerson, AppointedPerson, AppContact, LoginPassword, Admin, ChangePass ) " +
                                                    "VALUES ( @cboCompany, @EmployeeName, @chkConveyorAware, @chkPermitCoord, " +
                                                    "@chkPermitResPerson, @chkIsoResPerson, @chkIsoAppoint, @txtContactNumber, " +
                                                    "@Password, @txtAccessLevel, @ChangePass );", conn);

                //Add values to the query parameters
                cmdAddEmployee.Parameters.AddWithValue("@cboCompany", cboAddCompany.SelectedValue);
                cmdAddEmployee.Parameters.AddWithValue("@EmployeeName", txtAddEmployeeName.Text);
                cmdAddEmployee.Parameters.AddWithValue("@chkConveyorAware", chkAddConveyorAware.Checked);
                cmdAddEmployee.Parameters.AddWithValue("@chkPermitCoord", chkAddPermitCoord.Checked);
                cmdAddEmployee.Parameters.AddWithValue("@chkPermitResPerson", chkAddPermitResPerson.Checked);
                cmdAddEmployee.Parameters.AddWithValue("@chkIsoResPerson", chkAddIsoResPerson.Checked);
                cmdAddEmployee.Parameters.AddWithValue("@chkIsoAppoint", chkAddIsoAppoint.Checked);
                cmdAddEmployee.Parameters.AddWithValue("@txtContactNumber", txtAddContactNumber.Text);
                cmdAddEmployee.Parameters.AddWithValue("@Password", "Password");
                cmdAddEmployee.Parameters.AddWithValue("@txtAccessLevel", adminLevel);
                cmdAddEmployee.Parameters.AddWithValue("@ChangePass", true);

                //Open the DB connection
                conn.Open();

                //Execute the query
                cmdAddEmployee.ExecuteNonQuery();

                //Close the conection
                conn.Close();

                //Show message box to inform user the employee has been entered
                MessageBox.Show(txtAddEmployeeName.Text + " has been added to the system.", "Employee Added.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Requery the datagrid view of table tblEmployee
                this.tblEmployeesTableAdapter.Fill(this.projectTrak_DataSet.tblEmployees);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void cmdUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("You are about to update the details for " + txtEditEmployeeName.Text + ", are you sure?", "Confirm Update.",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.OK)
                {
                    //Open a connection to the database
                    OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                    //Convert textbox values to integers for the query
                    int adminLevel;
                    adminLevel = Convert.ToInt32(txtEditAccessLevel.Text);
                    int employeeID;
                    employeeID = Convert.ToInt32(txtEmployeeID.Text);

                    //Build an OleDbCommand based on the SELECT query
                    OleDbCommand cmd = new OleDbCommand("UPDATE tblEmployees SET CompanyID = @CompanyID, EmployeeName = @EmployeeName, ConveyorAware = @ConveyorAware, " +
                                                        "PermitCoordinator = @PermitCoord, PermitResPerson = @PermitResPerson, IsoResPerson = @IsoResPerson, " +
                                                        "AppointedPerson = @AppointedPerson, AppContact = @AppContact, Admin = @Admin " +
                                                        "WHERE EmployeeID = " + employeeID + ";", conn);

                    //Add values to the query parameters
                    cmd.Parameters.AddWithValue("@CompanyID", cboEditCompany.SelectedValue);
                    cmd.Parameters.AddWithValue("@EmployeeName", txtEditEmployeeName.Text);
                    cmd.Parameters.AddWithValue("@ConveyorAware", chkEditConveyorAware.Checked);
                    cmd.Parameters.AddWithValue("@PermitCoord", chkEditPermitCoord.Checked);
                    cmd.Parameters.AddWithValue("@PermitResPerson", chkEditPermitResPerson.Checked);
                    cmd.Parameters.AddWithValue("@IsoResPerson", chkEditIsoResPerson.Checked);
                    cmd.Parameters.AddWithValue("@AppointedPerson", chkEditIsoAppoint.Checked);
                    cmd.Parameters.AddWithValue("@AppContact", txtEditContactNumber.Text);
                    cmd.Parameters.AddWithValue("@Admin", adminLevel);

                    //Open the DB connection
                    conn.Open();

                    //Execute the query
                    cmd.ExecuteNonQuery();

                    //Close the conection
                    conn.Close();

                    //Show message box to inform user the employee has been entered
                    MessageBox.Show(txtEditEmployeeName.Text + " has been updated on the system.", "Employee updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Requery the datagrid view of table tblEmployee
                    this.tblEmployeesTableAdapter.Fill(this.projectTrak_DataSet.tblEmployees);
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

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show("You are about to delete the details for " + txtEditEmployeeName.Text + ", are you sure?\n\n" +
                                                    "WARNING: You cannot undo this action." , "Confirm Delete.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.OK)
                {
                    //Open a connection to the database
                    OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                    //Convert textbox values to integers for the query
                    int employeeID;
                    employeeID = Convert.ToInt32(txtEmployeeID.Text);

                    //Build an OleDbCommand based on the SELECT query
                    OleDbCommand cmd = new OleDbCommand("UPDATE tblEmployees SET Removed = @Removed WHERE EmployeeID = " + employeeID + ";", conn);

                    //Add values to the query parameters
                    cmd.Parameters.AddWithValue("@Removed", true);

                    //Open the DB connection
                    conn.Open();

                    //Execute the query
                    cmd.ExecuteNonQuery();

                    //Close the conection
                    conn.Close();

                    //Show message box to inform user the employee has been entered
                    MessageBox.Show(txtEditEmployeeName.Text + " has been removed from the system.", "Employee updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Requery the datagrid view of table tblEmployee
                    this.tblEmployeesTableAdapter.Fill(this.projectTrak_DataSet.tblEmployees);
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

        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                grpEditEmployeeInfo.Enabled = true;

                string cellValue = dataGridViewEmployees.Rows[e.RowIndex].Cells[0].Value.ToString();
                int.Parse(cellValue);

                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                //Build an OleDbCommand based on the SELECT query
                OleDbCommand cmd = new OleDbCommand("SELECT EmployeeID, CompanyID, EmployeeName, ConveyorAware, PermitCoordinator, PermitResPerson, IsoResPerson, AppointedPerson, " +
                                                    "AppContact, Admin FROM tblEmployees WHERE EmployeeID=" + cellValue + ";", conn);
                //Open the DB connection
                conn.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();

                cboEditCompany.Text = reader["CompanyID"].ToString();
                txtEditEmployeeName.Text = reader["EmployeeName"].ToString();
                txtEditContactNumber.Text = reader["AppContact"].ToString();
                txtEditAccessLevel.Text = reader["Admin"].ToString();
                txtEmployeeID.Text = reader["EmployeeID"].ToString();
                chkEditConveyorAware.Checked = bool.Parse(reader["ConveyorAware"].ToString());
                chkEditPermitCoord.Checked = bool.Parse(reader["PermitCoordinator"].ToString());
                chkEditPermitResPerson.Checked = bool.Parse(reader["PermitResPerson"].ToString());
                chkEditIsoResPerson.Checked = bool.Parse(reader["IsoResPerson"].ToString());
                chkEditIsoAppoint.Checked = bool.Parse(reader["AppointedPerson"].ToString());

                //Close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
