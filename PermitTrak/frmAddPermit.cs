using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace PermitTrak
{
    public partial class frmAddPermit : Form
    {
        public frmAddPermit()
        {
            InitializeComponent();
        }

        private void frmAddPermit_Load(object sender, EventArgs e)
        {
            try
            {
                //This line of code loads data into the 'projectTrak_DataSet.tblLocation' table.
                this.tblLocationTableAdapter.Fill(this.projectTrak_DataSet.tblLocation);
                //This line of code loads data into the 'projectTrak_DataSet.tblLevel' table.
                this.tblLevelTableAdapter.Fill(this.projectTrak_DataSet.tblLevel);
                //This line of code loads data into the 'projectTrak_DataSet.tblEmployees' table.
                this.tblEmployeesTableAdapter.Fill(this.projectTrak_DataSet.tblEmployees);
                //This line of code loads data into the 'projectTrak_DataSet.tblCompanies' table.
                this.tblCompaniesTableAdapter.Fill(this.projectTrak_DataSet.tblCompanies);

                //Set the form variables
                clsGlobal.SectionReached = 1;
                clsGlobal.PermitType = "Mon-Fri Days";
                ((Control)this.pgeSection2).Enabled = false;
                ((Control)this.pgeSection3).Enabled = false;

//*********************************************************************************************************************************
//Get the max permit number value and add one to it
               
                //Set connection variable with value from properties.settings
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                OleDbCommand cmdMaxPermitNo = new OleDbCommand("SELECT MAX(PermitNumber) FROM tblPermitHeader;", conn);
                //Open the DB connection
                conn.Open();

                //Add the count of the results to the variable count
                int maxPermitNo = (int)cmdMaxPermitNo.ExecuteScalar();

                //Close the connection
                conn.Close();

                //Add 1 to max value of permit number 
                maxPermitNo = maxPermitNo + 1;

//**********************************************************************************************************************************
//Insert the next permit number value into the table tblPermitHeader

                //Build an OleDbCommand based on the SELECT query
                OleDbCommand cmdAppendPermitNo = new OleDbCommand("INSERT INTO tblPermitHeader ( PermitNumber ) " +
                                                    "VALUES ( @txtPermitNumber );", conn);

                //Add values to the query parameters
                cmdAppendPermitNo.Parameters.AddWithValue("@txtPemitNumber", maxPermitNo);

                //Open the DB connection
                conn.Open();

                //Execute the query
                cmdAppendPermitNo.ExecuteNonQuery();

                //Close the conection
                conn.Close();

//**********************************************************************************************************************************
//Read the new max permit number value from table tblPermitHeader, get the value of field PermitID and add it to textbox txtPermitID

                //Build an OleDbCommand based on the SELECT query
                OleDbCommand cmdPermitID = new OleDbCommand("SELECT PermitID, PermitNumber FROM tblPermitHeader WHERE PermitNumber= " + maxPermitNo + ";", conn);
                //Open the DB connection
                conn.Open();

                OleDbDataReader reader = cmdPermitID.ExecuteReader();
                reader.Read();

                txtPermitID.Text = reader["PermitID"].ToString();
                txtPermitNumber.Text = reader["PermitNumber"].ToString();

                conn.Close();

//**********************************************************************************************************************************
//Insert a record for the permit status in to the table tblPermitStatus

                //Build an OleDbCommand based on the SELECT query
                OleDbCommand cmdInsertPermitStatus = new OleDbCommand("INSERT INTO tblPermitStatus ( PermitID, SectionReached ) " +
                                                    "VALUES ( @txtPermitID, @SectionReached );", conn);

                //Add values to the query parameters
                cmdInsertPermitStatus.Parameters.AddWithValue("@txtPermitID", txtPermitID.Text);
                cmdInsertPermitStatus.Parameters.AddWithValue("@SectionReached", 1);

                //Open the DB connection
                conn.Open();

                //Execute the query
                cmdInsertPermitStatus.ExecuteNonQuery();

                //Close the conection
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("You are about to exit an incomplete permit. If you exit now all details that have been entered will be lost.",
                                                    "Exit Permit.", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.OK)
                {
                    //Open a connection to the database
                    OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                    //Open the DB connection
                    conn.Open();

                    //Delete permit header information
                    OleDbCommand cmdDeletePermitHeader = new OleDbCommand("DELETE FROM tblPermitHeader WHERE tblPermitHeader.PermitID= " + txtPermitID.Text + ";", conn);
                    //Execute the query
                    cmdDeletePermitHeader.ExecuteNonQuery();

                    //Delete permit manager information
                    OleDbCommand cmdDeletePermitManager = new OleDbCommand("DELETE FROM tblPermitManager WHERE tblPermitManager.PermitID= " + txtPermitID.Text + ";", conn);
                    //Execute the query
                    cmdDeletePermitManager.ExecuteNonQuery();

                    //Delete permit hresponsible person information
                    OleDbCommand cmdDeletePermitRP = new OleDbCommand("DELETE FROM tblPermitRP WHERE tblPermitRP.PermitID= " + txtPermitID.Text + ";", conn);
                    //Execute the query
                    cmdDeletePermitRP.ExecuteNonQuery();

                    //Delete permit status information
                    OleDbCommand cmdDeletePermitStatus = new OleDbCommand("DELETE FROM tblPermitStatus WHERE tblPermitStatus.PermitID= " + txtPermitID.Text + ";", conn);
                    //Execute the query
                    cmdDeletePermitStatus.ExecuteNonQuery();

                    //Delete permit ticks information
                    OleDbCommand cmdDeletePermitTicks = new OleDbCommand("DELETE FROM tblPermitTicks WHERE tblPermitTicks.PermitID= " + txtPermitID.Text + ";",conn);
                    //Execute the query
                    cmdDeletePermitTicks.ExecuteNonQuery();

                    //Delete permit requirements information
                    OleDbCommand cmdDeletePermitReq = new OleDbCommand("DELETE FROM tblLocalRequirements WHERE tblLocalRequirements.PermitID= " + txtPermitID.Text + ";", conn);
                    //Execute the query
                    cmdDeletePermitReq.ExecuteNonQuery();

                    //Delete permit location information
                    OleDbCommand cmdDeletePermitLoc = new OleDbCommand("DELETE FROM tblLNKPermitLoc WHERE tblLNKPermitLoc.PermitID= " + txtPermitID.Text + ";", conn);
                    //Execute the query
                    cmdDeletePermitLoc.ExecuteNonQuery();

                    //Delete permit level information
                    OleDbCommand cmdDeletePermitLevel = new OleDbCommand("DELETE FROM tblLNKPermitLevel WHERE tblLNKPermitLevel.PermitID= " + txtPermitID.Text + ";", conn);
                    //Execute the query
                    cmdDeletePermitLevel.ExecuteNonQuery();

                    //Delete employee required access information
                    OleDbCommand cmdDeleteEmpReqAccess = new OleDbCommand("DELETE FROM tblEmpReqAccess WHERE tblEmpReqAccess.PermitID= " + txtPermitID.Text + ";", conn);
                    //Execute the query
                    cmdDeleteEmpReqAccess.ExecuteNonQuery();

                    //Close the conection
                    conn.Close();

                    this.Close();

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

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                //Build an OleDbCommand based on the SELECT query
                OleDbCommand cmdAddEmpReqAccess = new OleDbCommand("INSERT INTO tblEmpReqAccess ( PermitID, EmployeeID ) " +
                                        "VALUES ( @txtPermitID, @cboEmployeeID );" , conn);

                //Add values to the query parameters
                cmdAddEmpReqAccess.Parameters.AddWithValue("@txtPermitID", txtPermitID.Text);
                cmdAddEmpReqAccess.Parameters.AddWithValue("@cboEmployeeID", cboAddEmployee.SelectedValue);

                //Open the DB connection
                conn.Open();

                //Execute the query
                cmdAddEmpReqAccess.ExecuteNonQuery();

                //Close the conection
                conn.Close();

                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT tblEmployees.EmployeeName FROM ( tblEmployees INNER JOIN tblEmpReqAccess " +
                                        "ON tblEmployees.EmployeeID = tblEmpReqAccess.EmployeeID ) " +
                                        "WHERE tblEmpReqAccess.PermitID = " + txtPermitID.Text + ";", conn);

                DataSet ds = new DataSet();

                conn.Open();

                adapter.Fill(ds, "tblEmpReqAccess_table");

                conn.Close();

                dataEmployeeReqAccess.DataSource = ds;

                dataEmployeeReqAccess.DataMember = "tblEmpReqAccess_table";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PermitTrak",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtStartDate_Click(object sender, EventArgs e)
        {
            //Set the textbox colour to red and the text to white
            txtStartDate.BackColor = Color.White;
            txtStartDate.ForeColor = Color.Black;
        }

        private void txtStartTime_Click(object sender, EventArgs e)
        {
            //Set the textbox colour to red and the text to white
            txtStartTime.BackColor = Color.White;
            txtStartTime.ForeColor = Color.Black;
        }

        private void txtFinishTime_Click(object sender, EventArgs e)
        {
            //Set the textbox colour to red and the text to white
            txtFinishTime.BackColor = Color.White;
            txtFinishTime.ForeColor = Color.Black;
        }

        private void txtDuration_Click(object sender, EventArgs e)
        {
            //Set the textbox colour to red and the text to white
            txtDuration.BackColor = Color.White;
            txtDuration.ForeColor = Color.Black;
        }

        private void lstLevel_Click(object sender, EventArgs e)
        {
            //Set the textbox colour to red and the text to white
            lstLevel.BackColor = Color.White;
            lstLevel.ForeColor = Color.Black;
        }

        private void lstLocation_Click(object sender, EventArgs e)
        {
            //Set the textbox colour to red and the text to white
            lstLocation.BackColor = Color.White;
            lstLocation.ForeColor = Color.Black;
        }

        private void txtDescription_Click(object sender, EventArgs e)
        {
            //Set the textbox colour to red and the text to white
            txtDescription.BackColor = Color.White;
            txtDescription.ForeColor = Color.Black;
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            //If the section reached value is 1, add the values to the relevant tables
            if (clsGlobal.SectionReached == 1)
            {

                //Check for a null or empty value
                if (string.IsNullOrEmpty(txtStartTime.Text))
                {
                    MessageBox.Show("A start time must be entered.", "Time Missing.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtStartTime.BackColor = Color.Red;
                    txtStartTime.ForeColor = Color.White;
                    return;
                }
                //Check for a null or empty value
                else if (string.IsNullOrEmpty(txtFinishTime.Text))
                {
                    MessageBox.Show("A finish time must be entered.", "Time Missing.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFinishTime.BackColor = Color.Red;
                    txtFinishTime.ForeColor = Color.White;
                    return;
                }
                //Check for a null or empty value
                else if (string.IsNullOrEmpty(lstLevel.SelectedItem.ToString()) && string.IsNullOrEmpty(lstLocation.SelectedItem.ToString()))
                {
                    MessageBox.Show("A level or loaction must be selected.", "Level or Location Missing.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lstLevel.BackColor = Color.Red;
                    lstLevel.ForeColor = Color.White;

                    lstLocation.BackColor = Color.Red;
                    lstLocation.ForeColor = Color.White;
                    return;
                }
                //Check for a null or empty value
                else if (string.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("A description must be entered.", "Description Missing.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescription.BackColor = Color.Red;
                    txtDescription.ForeColor = Color.White;
                    return;
                }

                //Confirm the section has been completed and the user wants to continue
                DialogResult dr = MessageBox.Show("Section 1 has been completed. Do you wish to continue?", "Confirm Section 1 Complete.",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    //Convert textbox values to integers for the query
                    int PermitID;
                    PermitID = Convert.ToInt32(txtPermitID.Text);
                    int CompanyID;
                    CompanyID = Convert.ToInt32(cboCompany.SelectedValue);
                    int LineManagerID;
                    LineManagerID = Convert.ToInt32(cboLineManager.SelectedValue);
                    int ResPersonID;
                    ResPersonID = Convert.ToInt32(cboResPerson.SelectedValue);

                    //Convert start date, finish date and duration text values to variables
                    int duration;
                    duration = int.Parse(txtDuration.Text);
                    DateTime startDate;
                    startDate = Convert.ToDateTime(txtStartDate.Text);
                    DateTime finishDate;
                    finishDate = startDate.AddDays(duration - 1);

                    //Check last day of week days permit 
                    if (optDayMonFri.Checked==true)
                    {
                        if (finishDate.DayOfWeek==DayOfWeek.Saturday || finishDate.DayOfWeek==DayOfWeek.Sunday)
                        {
                            MessageBox.Show("A weekday permit must run from Monday to Friday.", "Wrong Finish.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                     }       

                    //Check last day of weekend permit
                    else if (optDaysWeekend.Checked==true)
                    {
                        if(finishDate.DayOfWeek == DayOfWeek.Saturday || finishDate.DayOfWeek == DayOfWeek.Sunday && duration > 2)
                        {
                            MessageBox.Show("A weekend permit must run on a Saturday and Sunday.", "Wrong Finish.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    //Check last night of nights permit
                    else if (optNightsMonThur.Checked==true)
                    {
                        if(finishDate.DayOfWeek == DayOfWeek.Friday || finishDate.DayOfWeek == DayOfWeek.Saturday ||
                            finishDate.DayOfWeek == DayOfWeek.Sunday && duration > 4)
                        {
                            MessageBox.Show("A night permit must run from Monday to Thursday.", "Wrong Finish.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    //Set variable with the default connection string for the DB
                    OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

//************************************************************************************************************************************

                    //Update permit header with the permit details
                    OleDbCommand cmdUpdatePermitHeader = new OleDbCommand("UPDATE tblPermitHeader SET CompanyID = @cboCompanyID, DateRaised = @DateRaised, " +
                                "StartDate = @txtStartDate, FinishDate= @FinishDate, StartTime = @txtStartTime, FinishTime = @txtFinishTime, " +
                                "Type = PermitType, Duration = @txtDuration, TaskDescription = @txtTaskDescription WHERE PermitID = @txtPermitID;", conn);
                    
                    //Add values to the query parameters
                    cmdUpdatePermitHeader.Parameters.AddWithValue("@cboCompanyID", CompanyID);
                    cmdUpdatePermitHeader.Parameters.AddWithValue("@DateRaised", DateTime.Now.ToShortDateString());
                    cmdUpdatePermitHeader.Parameters.AddWithValue("@txtStartDate", txtStartDate.Text);
                    cmdUpdatePermitHeader.Parameters.AddWithValue("@FinishDate", finishDate);
                    cmdUpdatePermitHeader.Parameters.AddWithValue("@txtStartTime", txtStartTime.Text);
                    cmdUpdatePermitHeader.Parameters.AddWithValue("@txtFinishTime", txtFinishTime.Text);
                    cmdUpdatePermitHeader.Parameters.AddWithValue("@PermitType", clsGlobal.PermitType);
                    cmdUpdatePermitHeader.Parameters.AddWithValue("@txtDuration", txtDuration.Text);
                    cmdUpdatePermitHeader.Parameters.AddWithValue("@txtTaskDescription", txtDescription.Text);
                    cmdUpdatePermitHeader.Parameters.AddWithValue("@txtPermitID", PermitID);

                    //Insert the permit line manager value in to the table
                    OleDbCommand cmdInsertLineManager = new OleDbCommand("INSERT INTO tblPermitManager ( PermitID, EmployeeID ) " +
                                "VALUES ( @PermitID, @LineManager );", conn);

                    cmdInsertLineManager.Parameters.AddWithValue("@PermitID", PermitID);
                    cmdInsertLineManager.Parameters.AddWithValue("@LineManager", LineManagerID);

                    //Insert the permit responsible person value in to the table
                    OleDbCommand cmdInsertResPerson = new OleDbCommand("INSERT INTO tblPermitRP ( PermitID, EmployeeID ) " +
                                "VALUES ( @PermitID, @ResPerson );", conn);

                    cmdInsertResPerson.Parameters.AddWithValue("@PermitID", PermitID);
                    cmdInsertResPerson.Parameters.AddWithValue("@ResPerson", ResPersonID);

                    //Insert the permit working area value in to the table
                    OleDbCommand cmdInsert1Metre = new OleDbCommand("INSERT INTO tblPermitTicks ( PermitID, Within1Metre ) " +
                                "VALUES ( @PermitID, @Within1Metre );", conn);

                    cmdInsert1Metre.Parameters.AddWithValue("@PermitID", PermitID);
                    cmdInsert1Metre.Parameters.AddWithValue("@Within1Metre", ResPersonID);

                    //Open the DB connection
                    conn.Open();

                    //Execute the query
                    cmdUpdatePermitHeader.ExecuteNonQuery();
                    cmdInsertLineManager.ExecuteNonQuery();
                    cmdInsertResPerson.ExecuteNonQuery();
                    cmdInsert1Metre.ExecuteNonQuery();

                    conn.Close();

//**************************************************************************************************************************************

                    //Insert the permit level values in to the table
                    foreach (DataRowView objDataRowView in lstLevel.SelectedItems)
                    {

                        OleDbCommand cmdInsertLevel = new OleDbCommand("INSERT INTO tblLNKPermitLevel ( PermitID, LevelID ) VALUES ( @PermitID, @LevelID );", conn);
                        conn.Open();
                        cmdInsertLevel.Parameters.AddWithValue("@PermitID", PermitID);
                        cmdInsertLevel.Parameters.AddWithValue("@LevelID", int.Parse(objDataRowView["LevelID"].ToString()));
                        cmdInsertLevel.ExecuteNonQuery();
                        conn.Close();

                    }

                    //Insert the permit location values in to the table
                    foreach (DataRowView objDataRowView in lstLocation.SelectedItems)
                    {

                        OleDbCommand cmdInsertLocation = new OleDbCommand("INSERT INTO tblLNKPermitLoc ( PermitID, LocationID ) VALUES ( @PermitID, @LocationID );", conn);
                        conn.Open();
                        cmdInsertLocation.Parameters.AddWithValue("@PermitID", PermitID);
                        cmdInsertLocation.Parameters.AddWithValue("@LocationID", int.Parse(objDataRowView["LocationID"].ToString()));
                        cmdInsertLocation.ExecuteNonQuery();
                        conn.Close();

                    }

                    //Update the permit status
                    OleDbCommand cmdUpdatePermitStatus = new OleDbCommand("UPDATE tblPermitStatus SET SectionReached = @SectionReached WHERE PermitID = " + PermitID + ";", conn);

                    //Add values to the query parameters
                    cmdUpdatePermitStatus.Parameters.AddWithValue("@SectionReached", 2);

                    //Open the DB connection
                    conn.Open();

                    //Execute the query
                    cmdUpdatePermitStatus.ExecuteNonQuery();

                    //Close the conection
                    conn.Close();

                    //Set the section reached variable to 2
                    clsGlobal.SectionReached = 2;

                    //Disable section 1, enable and switch to section 2 and of the permit
                    tabPermitSections.SelectedTab = pgeSection2;
                    ((Control)this.pgeSection1).Enabled = false;
                    ((Control)this.pgeSection2).Enabled = true;
                    ((Control)this.grpLocalReq).Enabled = false;

                }
                else if (dr==DialogResult.No)
                {
                    return;
                }

            }
            else if (clsGlobal.SectionReached == 2)
            {
                //Check for a null or empty value
                if (chkLocalReq.Checked=true && string.IsNullOrEmpty(txtATPNumber.Text))
                {
                    MessageBox.Show("An ATP Number must be entered.", "ATP Missing.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtATPNumber.BackColor = Color.Red;
                    txtATPNumber.ForeColor = Color.White;
                    return;
                }
                else if (chkLocalReq.Checked = true && string.IsNullOrEmpty(txtMaximoNumber.Text))
                {
                    MessageBox.Show("A Maximo Number Number must be entered.", "Maximo No. Missing.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaximoNumber.BackColor = Color.Red;
                    txtMaximoNumber.ForeColor = Color.White;
                    return;
                }
                else if (chkLocalReq.Checked = true && string.IsNullOrEmpty(txtMSNumber.Text))
                {
                    MessageBox.Show("An MS Number Number must be entered.", "MS Number Missing.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMSNumber.BackColor = Color.Red;
                    txtMSNumber.ForeColor = Color.White;
                    return;
                }

                //Confirm the section has been completed and the user wants to continue
                DialogResult dr = MessageBox.Show("Section 2 has been completed. Do you wish to continue?", "Confirm Section 2 Complete.",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    //Set variable with the default connection string for the DB
                    OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                    //Insert the permit local requirements value in to the table
                    OleDbCommand cmdInsertLocalReq = new OleDbCommand("INSERT INTO tblLocalRequirements ( PermitID, LocalRequirements, " +
                                                        "ATPNumber, MaximoNo, MSNumber, PlansApproval, SurveyOnly ) VALUES ( @PermitID, @LocalRequirements, " +
                                                        "@ATPNumber, @MaximoNo, @MSNumber, @PlannersApproval, @SurveyOnly );", conn);

                    cmdInsertLocalReq.Parameters.AddWithValue("@PermitID", txtPermitID.Text);
                    cmdInsertLocalReq.Parameters.AddWithValue("@LocalRequirements", chkLocalReq.Checked);
                    cmdInsertLocalReq.Parameters.AddWithValue("@ATPNumber", txtATPNumber.Text);
                    cmdInsertLocalReq.Parameters.AddWithValue("@MaximoNo", txtMaximoNumber.Text);
                    cmdInsertLocalReq.Parameters.AddWithValue("@MSNumber", txtMSNumber.Text);
                    cmdInsertLocalReq.Parameters.AddWithValue("@PlannersApproval", chkPlannersApproval.Checked);
                    cmdInsertLocalReq.Parameters.AddWithValue("@SurveyOnly", chkSurveyOnly.Checked);

                    //Update the permit status
                    OleDbCommand cmdUpdatePermitStatus = new OleDbCommand("UPDATE tblPermitStatus SET SectionReached = @SectionReached WHERE PermitID = " + txtPermitID.Text + ";", conn);

                    //Add values to the query parameters
                    cmdUpdatePermitStatus.Parameters.AddWithValue("@SectionReached", 3);

                    //Open the DB connection
                    conn.Open();

                    //Execute the query
                    cmdInsertLocalReq.ExecuteNonQuery();
                    cmdUpdatePermitStatus.ExecuteNonQuery();

                    conn.Close();

                    //Set the section reached variable to 2
                    clsGlobal.SectionReached = 3;

                }
                else
                {
                    return;
                }

                //Disable section 2, enable and switch to section 3 and of the permit
                tabPermitSections.SelectedTab = pgeSection3;
                ((Control)this.pgeSection2).Enabled = false;
                ((Control)this.pgeSection3).Enabled = true;
                grpDisruption.Enabled = false;
                clsGlobal.disLevel = "Low";
                

            }
            else if (clsGlobal.SectionReached == 3)
            {
                //Check for a null or empty value
                if (chkAreaInsp.Checked == false)
                {
                    MessageBox.Show("The work area for the permit must be inspected and viewed.", "Area Inspected.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                } 

                //Check for a null or empty value
                if (chkLikelyDis.Checked = true && string.IsNullOrEmpty(txtDisComments.Text))
                {
                    MessageBox.Show("If site disruption is selected comments must be entered.", "Comment Missing.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDisComments.BackColor = Color.Red;
                    txtDisComments.ForeColor = Color.White;
                    return;
                }

                //Confirm the section has been completed and the user wants to continue
                DialogResult dr = MessageBox.Show("Section 3 has been completed. The permit is now due to be approved", "Confirm Section 3 Complete.",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    //Set variable with the default connection string for the DB
                    OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ProjectTrak_Local_BE_ConnectionString);

                    //***************************************************************************************************************************************
                    //Insert the permit local requirements value in to the table
                    OleDbCommand cmdInsertTicks = new OleDbCommand("UPDATE tblPermitTicks SET LocDrawing = @LocDrawing, AreaInspected = @AreaInspected, " +
                                    "LikelyDisruption = @Disruption, IsolationReq = @IsolationRequested WHERE PermitID= " + txtPermitID.Text + ";", conn);

                    cmdInsertTicks.Parameters.AddWithValue("@LocDrawing", chkDrawingAtt.Checked);
                    cmdInsertTicks.Parameters.AddWithValue("@AreaInspected", chkAreaInsp.Checked);
                    cmdInsertTicks.Parameters.AddWithValue("@Disruption", chkLikelyDis.Checked);
                    cmdInsertTicks.Parameters.AddWithValue("@IsolationRequested", chkElecMeckIso.Checked);

                    OleDbCommand cmdInsertComments = new OleDbCommand("INSERT INTO tblPermitDisComments ( PermitID, DisLevel, DisComments ) " +
                                        "VALUES ( @PermitID, @DisLevel, @DisComments );", conn);

                    cmdInsertComments.Parameters.AddWithValue("@PermitID", txtPermitID.Text);
                    cmdInsertComments.Parameters.AddWithValue("@DisLevel", clsGlobal.disLevel);
                    cmdInsertComments.Parameters.AddWithValue("@DisComments", txtDisComments.Text);

                    OleDbCommand cmdUpdatePermitStatus = new OleDbCommand("UPDATE tblPermitStatus SET SectionReached = @SectionReached WHERE PermitID = " + txtPermitID.Text + ";", conn);

                    //Add values to the query parameters
                    cmdUpdatePermitStatus.Parameters.AddWithValue("@SectionReached", 4);

                    //Open the DB connection
                    conn.Open();

                    //Execute the query
                    cmdInsertTicks.ExecuteNonQuery();
                    cmdInsertComments.ExecuteNonQuery();
                    cmdUpdatePermitStatus.ExecuteNonQuery();

                    conn.Close();

                }
                else
                {
                    return;
                }

                this.Close();
            }
        }

        private void optDayMonFri_Click(object sender, EventArgs e)
        {
            clsGlobal.PermitType = "Mon-Fri Days";
        }

        private void optNightsMonThur_Click(object sender, EventArgs e)
        {
            clsGlobal.PermitType = "Weekend";
        }

        private void optDaysWeekend_Click(object sender, EventArgs e)
        {
            clsGlobal.PermitType = "Mon-Thur Nights";
        }

        private void chkLocalReq_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLocalReq.Checked == true)
            {
                grpLocalReq.Enabled = true;
            }
            else if (chkLocalReq.Checked == false)
            {
                grpLocalReq.Enabled = false;
            }
        }

        private void txtATPNumber_Click(object sender, EventArgs e)
        {
            txtATPNumber.BackColor = Color.White;
            txtATPNumber.ForeColor = Color.Black;
        }

        private void txtMaximoNumber_Click(object sender, EventArgs e)
        {
            txtMaximoNumber.BackColor = Color.White;
            txtMaximoNumber.ForeColor = Color.Black;
        }

        private void txtMSNumber_Click(object sender, EventArgs e)
        {
            txtMSNumber.BackColor = Color.White;
            txtMSNumber.ForeColor = Color.Black;
        }

        private void txtDisComments_Click(object sender, EventArgs e)
        {
            txtDisComments.BackColor = Color.White;
            txtDisComments.ForeColor = Color.Black;
        }

        private void chkLikelyDis_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLikelyDis.Checked == true)
            {
                grpDisruption.Enabled = true;
            }
            else if (chkLikelyDis.Checked == false)
            {
                grpDisruption.Enabled = false;
            }
        }

        private void chkLowDis_CheckedChanged(object sender, EventArgs e)
        {
            clsGlobal.disLevel = "Low";
        }

        private void chkMedDis_CheckedChanged(object sender, EventArgs e)
        {
            clsGlobal.disLevel = "Med";
        }

        private void chkHighDis_CheckedChanged(object sender, EventArgs e)
        {
            clsGlobal.disLevel = "High";
        }
    }
}


        