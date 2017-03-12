namespace PermitTrak
{
    partial class frmAddPermit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPermit));
            this.tabPermitSections = new System.Windows.Forms.TabControl();
            this.pgeSection1 = new System.Windows.Forms.TabPage();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dataEmployeeReqAccess = new System.Windows.Forms.DataGridView();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.fraEmployee = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboAddEmployee = new System.Windows.Forms.ComboBox();
            this.tblEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTrak_DataSet = new PermitTrak.ProjectTrak_DataSet();
            this.chkWithin1Metre = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstLocation = new System.Windows.Forms.ListBox();
            this.tblLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstLevel = new System.Windows.Forms.ListBox();
            this.tblLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fraPermitType = new System.Windows.Forms.GroupBox();
            this.optDaysWeekend = new System.Windows.Forms.RadioButton();
            this.optNightsMonThur = new System.Windows.Forms.RadioButton();
            this.optDayMonFri = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtFinishTime = new System.Windows.Forms.MaskedTextBox();
            this.txtStartTime = new System.Windows.Forms.MaskedTextBox();
            this.Company = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLineManager = new System.Windows.Forms.ComboBox();
            this.tblLineManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboResPerson = new System.Windows.Forms.ComboBox();
            this.tblResPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.tblCompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtPermitNumber = new System.Windows.Forms.TextBox();
            this.pgeSection2 = new System.Windows.Forms.TabPage();
            this.grpLocalReq = new System.Windows.Forms.GroupBox();
            this.chkSurveyOnly = new System.Windows.Forms.CheckBox();
            this.chkPlannersApproval = new System.Windows.Forms.CheckBox();
            this.txtMSNumber = new System.Windows.Forms.TextBox();
            this.txtMaximoNumber = new System.Windows.Forms.TextBox();
            this.txtATPNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkLocalReq = new System.Windows.Forms.CheckBox();
            this.pgeSection3 = new System.Windows.Forms.TabPage();
            this.chkLikelyDis = new System.Windows.Forms.CheckBox();
            this.grpDisruption = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDisComments = new System.Windows.Forms.RichTextBox();
            this.chkHighDis = new System.Windows.Forms.CheckBox();
            this.chkMedDis = new System.Windows.Forms.CheckBox();
            this.chkLowDis = new System.Windows.Forms.CheckBox();
            this.grpElecMechIso = new System.Windows.Forms.GroupBox();
            this.chkElecMeckIso = new System.Windows.Forms.CheckBox();
            this.grpDrawingAtt = new System.Windows.Forms.GroupBox();
            this.chkDrawingAtt = new System.Windows.Forms.CheckBox();
            this.grpAreaInsp = new System.Windows.Forms.GroupBox();
            this.chkAreaInsp = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblCompaniesTableAdapter = new PermitTrak.ProjectTrak_DataSetTableAdapters.tblCompaniesTableAdapter();
            this.tblEmployeesTableAdapter = new PermitTrak.ProjectTrak_DataSetTableAdapters.tblEmployeesTableAdapter();
            this.tblLevelTableAdapter = new PermitTrak.ProjectTrak_DataSetTableAdapters.tblLevelTableAdapter();
            this.tblLocationTableAdapter = new PermitTrak.ProjectTrak_DataSetTableAdapters.tblLocationTableAdapter();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdNext = new System.Windows.Forms.Button();
            this.txtPermitID = new System.Windows.Forms.TextBox();
            this.tabPermitSections.SuspendLayout();
            this.pgeSection1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeeReqAccess)).BeginInit();
            this.fraEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrak_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLevelBindingSource)).BeginInit();
            this.fraPermitType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLineManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblResPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompaniesBindingSource)).BeginInit();
            this.pgeSection2.SuspendLayout();
            this.grpLocalReq.SuspendLayout();
            this.pgeSection3.SuspendLayout();
            this.grpDisruption.SuspendLayout();
            this.grpElecMechIso.SuspendLayout();
            this.grpDrawingAtt.SuspendLayout();
            this.grpAreaInsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPermitSections
            // 
            this.tabPermitSections.Controls.Add(this.pgeSection1);
            this.tabPermitSections.Controls.Add(this.pgeSection2);
            this.tabPermitSections.Controls.Add(this.pgeSection3);
            this.tabPermitSections.Location = new System.Drawing.Point(12, 57);
            this.tabPermitSections.Name = "tabPermitSections";
            this.tabPermitSections.SelectedIndex = 0;
            this.tabPermitSections.Size = new System.Drawing.Size(632, 470);
            this.tabPermitSections.TabIndex = 0;
            // 
            // pgeSection1
            // 
            this.pgeSection1.AutoScroll = true;
            this.pgeSection1.Controls.Add(this.txtStartDate);
            this.pgeSection1.Controls.Add(this.dataEmployeeReqAccess);
            this.pgeSection1.Controls.Add(this.cmdAdd);
            this.pgeSection1.Controls.Add(this.fraEmployee);
            this.pgeSection1.Controls.Add(this.chkWithin1Metre);
            this.pgeSection1.Controls.Add(this.txtDescription);
            this.pgeSection1.Controls.Add(this.label11);
            this.pgeSection1.Controls.Add(this.label10);
            this.pgeSection1.Controls.Add(this.label9);
            this.pgeSection1.Controls.Add(this.lstLocation);
            this.pgeSection1.Controls.Add(this.lstLevel);
            this.pgeSection1.Controls.Add(this.fraPermitType);
            this.pgeSection1.Controls.Add(this.label8);
            this.pgeSection1.Controls.Add(this.label7);
            this.pgeSection1.Controls.Add(this.label6);
            this.pgeSection1.Controls.Add(this.label5);
            this.pgeSection1.Controls.Add(this.txtDuration);
            this.pgeSection1.Controls.Add(this.txtFinishTime);
            this.pgeSection1.Controls.Add(this.txtStartTime);
            this.pgeSection1.Controls.Add(this.Company);
            this.pgeSection1.Controls.Add(this.label4);
            this.pgeSection1.Controls.Add(this.label3);
            this.pgeSection1.Controls.Add(this.cboLineManager);
            this.pgeSection1.Controls.Add(this.cboResPerson);
            this.pgeSection1.Controls.Add(this.cboCompany);
            this.pgeSection1.Controls.Add(this.label2);
            this.pgeSection1.Controls.Add(this.txtPermitNumber);
            this.pgeSection1.Location = new System.Drawing.Point(4, 22);
            this.pgeSection1.Name = "pgeSection1";
            this.pgeSection1.Padding = new System.Windows.Forms.Padding(3);
            this.pgeSection1.Size = new System.Drawing.Size(624, 444);
            this.pgeSection1.TabIndex = 0;
            this.pgeSection1.Text = "Section 1";
            this.pgeSection1.UseVisualStyleBackColor = true;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStartDate.Location = new System.Drawing.Point(122, 163);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(84, 20);
            this.txtStartDate.TabIndex = 5;
            // 
            // dataEmployeeReqAccess
            // 
            this.dataEmployeeReqAccess.AllowUserToAddRows = false;
            this.dataEmployeeReqAccess.AllowUserToDeleteRows = false;
            this.dataEmployeeReqAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployeeReqAccess.Location = new System.Drawing.Point(421, 148);
            this.dataEmployeeReqAccess.Name = "dataEmployeeReqAccess";
            this.dataEmployeeReqAccess.ReadOnly = true;
            this.dataEmployeeReqAccess.Size = new System.Drawing.Size(151, 162);
            this.dataEmployeeReqAccess.TabIndex = 23;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(395, 105);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(86, 33);
            this.cmdAdd.TabIndex = 12;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // fraEmployee
            // 
            this.fraEmployee.Controls.Add(this.label12);
            this.fraEmployee.Controls.Add(this.cboAddEmployee);
            this.fraEmployee.Location = new System.Drawing.Point(395, 28);
            this.fraEmployee.Name = "fraEmployee";
            this.fraEmployee.Size = new System.Drawing.Size(208, 61);
            this.fraEmployee.TabIndex = 22;
            this.fraEmployee.TabStop = false;
            this.fraEmployee.Text = "Employee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Employee";
            // 
            // cboAddEmployee
            // 
            this.cboAddEmployee.DataSource = this.tblEmployeesBindingSource;
            this.cboAddEmployee.DisplayMember = "EmployeeName";
            this.cboAddEmployee.FormattingEnabled = true;
            this.cboAddEmployee.Location = new System.Drawing.Point(68, 23);
            this.cboAddEmployee.Name = "cboAddEmployee";
            this.cboAddEmployee.Size = new System.Drawing.Size(128, 21);
            this.cboAddEmployee.TabIndex = 0;
            this.cboAddEmployee.ValueMember = "EmployeeID";
            // 
            // tblEmployeesBindingSource
            // 
            this.tblEmployeesBindingSource.DataMember = "tblEmployees";
            this.tblEmployeesBindingSource.DataSource = this.projectTrak_DataSet;
            // 
            // projectTrak_DataSet
            // 
            this.projectTrak_DataSet.DataSetName = "ProjectTrak_DataSet";
            this.projectTrak_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkWithin1Metre
            // 
            this.chkWithin1Metre.AutoSize = true;
            this.chkWithin1Metre.Location = new System.Drawing.Point(224, 411);
            this.chkWithin1Metre.Name = "chkWithin1Metre";
            this.chkWithin1Metre.Size = new System.Drawing.Size(367, 17);
            this.chkWithin1Metre.TabIndex = 21;
            this.chkWithin1Metre.Text = "Is access required within 1 metre, above or below any of the equipment?";
            this.chkWithin1Metre.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(223, 332);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(380, 61);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = "";
            this.txtDescription.Click += new System.EventHandler(this.txtDescription_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(220, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Level";
            // 
            // lstLocation
            // 
            this.lstLocation.DataSource = this.tblLocationBindingSource;
            this.lstLocation.DisplayMember = "Area";
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.Location = new System.Drawing.Point(115, 333);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLocation.Size = new System.Drawing.Size(84, 95);
            this.lstLocation.TabIndex = 10;
            this.lstLocation.ValueMember = "LocationID";
            this.lstLocation.Click += new System.EventHandler(this.lstLocation_Click);
            // 
            // tblLocationBindingSource
            // 
            this.tblLocationBindingSource.DataMember = "tblLocation";
            this.tblLocationBindingSource.DataSource = this.projectTrak_DataSet;
            // 
            // lstLevel
            // 
            this.lstLevel.DataSource = this.tblLevelBindingSource;
            this.lstLevel.DisplayMember = "Level";
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.Location = new System.Drawing.Point(22, 333);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLevel.Size = new System.Drawing.Size(69, 95);
            this.lstLevel.TabIndex = 9;
            this.lstLevel.ValueMember = "LevelID";
            this.lstLevel.Click += new System.EventHandler(this.lstLevel_Click);
            // 
            // tblLevelBindingSource
            // 
            this.tblLevelBindingSource.DataMember = "tblLevel";
            this.tblLevelBindingSource.DataSource = this.projectTrak_DataSet;
            // 
            // fraPermitType
            // 
            this.fraPermitType.Controls.Add(this.optDaysWeekend);
            this.fraPermitType.Controls.Add(this.optNightsMonThur);
            this.fraPermitType.Controls.Add(this.optDayMonFri);
            this.fraPermitType.Location = new System.Drawing.Point(223, 166);
            this.fraPermitType.Name = "fraPermitType";
            this.fraPermitType.Size = new System.Drawing.Size(131, 100);
            this.fraPermitType.TabIndex = 13;
            this.fraPermitType.TabStop = false;
            this.fraPermitType.Text = "Permit Type";
            // 
            // optDaysWeekend
            // 
            this.optDaysWeekend.AutoSize = true;
            this.optDaysWeekend.Location = new System.Drawing.Point(11, 67);
            this.optDaysWeekend.Name = "optDaysWeekend";
            this.optDaysWeekend.Size = new System.Drawing.Size(102, 17);
            this.optDaysWeekend.TabIndex = 2;
            this.optDaysWeekend.Text = "Days, Weekend";
            this.optDaysWeekend.UseVisualStyleBackColor = true;
            // 
            // optNightsMonThur
            // 
            this.optNightsMonThur.AutoSize = true;
            this.optNightsMonThur.Location = new System.Drawing.Point(11, 44);
            this.optNightsMonThur.Name = "optNightsMonThur";
            this.optNightsMonThur.Size = new System.Drawing.Size(107, 17);
            this.optNightsMonThur.TabIndex = 1;
            this.optNightsMonThur.Text = "Nights, Mon-Thur";
            this.optNightsMonThur.UseVisualStyleBackColor = true;
            // 
            // optDayMonFri
            // 
            this.optDayMonFri.AutoSize = true;
            this.optDayMonFri.Checked = true;
            this.optDayMonFri.Location = new System.Drawing.Point(11, 19);
            this.optDayMonFri.Name = "optDayMonFri";
            this.optDayMonFri.Size = new System.Drawing.Size(90, 17);
            this.optDayMonFri.TabIndex = 0;
            this.optDayMonFri.TabStop = true;
            this.optDayMonFri.Text = "Days, Mon-Fri";
            this.optDayMonFri.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "FinishTime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Duration";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(122, 274);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(30, 20);
            this.txtDuration.TabIndex = 8;
            this.txtDuration.Click += new System.EventHandler(this.txtDuration_Click);
            // 
            // txtFinishTime
            // 
            this.txtFinishTime.Location = new System.Drawing.Point(122, 237);
            this.txtFinishTime.Mask = "00:00";
            this.txtFinishTime.Name = "txtFinishTime";
            this.txtFinishTime.Size = new System.Drawing.Size(37, 20);
            this.txtFinishTime.TabIndex = 7;
            this.txtFinishTime.ValidatingType = typeof(System.DateTime);
            this.txtFinishTime.Click += new System.EventHandler(this.txtFinishTime_Click);
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(122, 200);
            this.txtStartTime.Mask = "00:00";
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(37, 20);
            this.txtStartTime.TabIndex = 6;
            this.txtStartTime.ValidatingType = typeof(System.DateTime);
            this.txtStartTime.Click += new System.EventHandler(this.txtStartTime_Click);
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Location = new System.Drawing.Point(15, 53);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(51, 13);
            this.Company.TabIndex = 7;
            this.Company.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Line Manager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Responsible Person";
            // 
            // cboLineManager
            // 
            this.cboLineManager.DataSource = this.tblLineManagerBindingSource;
            this.cboLineManager.DisplayMember = "EmployeeName";
            this.cboLineManager.FormattingEnabled = true;
            this.cboLineManager.Location = new System.Drawing.Point(122, 87);
            this.cboLineManager.Name = "cboLineManager";
            this.cboLineManager.Size = new System.Drawing.Size(162, 21);
            this.cboLineManager.TabIndex = 3;
            this.cboLineManager.ValueMember = "EmployeeID";
            // 
            // tblLineManagerBindingSource
            // 
            this.tblLineManagerBindingSource.DataMember = "tblEmployees";
            this.tblLineManagerBindingSource.DataSource = this.projectTrak_DataSet;
            // 
            // cboResPerson
            // 
            this.cboResPerson.DataSource = this.tblResPersonBindingSource;
            this.cboResPerson.DisplayMember = "EmployeeName";
            this.cboResPerson.FormattingEnabled = true;
            this.cboResPerson.Location = new System.Drawing.Point(122, 125);
            this.cboResPerson.Name = "cboResPerson";
            this.cboResPerson.Size = new System.Drawing.Size(162, 21);
            this.cboResPerson.TabIndex = 4;
            this.cboResPerson.ValueMember = "EmployeeID";
            // 
            // tblResPersonBindingSource
            // 
            this.tblResPersonBindingSource.DataMember = "tblEmployees";
            this.tblResPersonBindingSource.DataSource = this.projectTrak_DataSet;
            // 
            // cboCompany
            // 
            this.cboCompany.DataSource = this.tblCompaniesBindingSource;
            this.cboCompany.DisplayMember = "CompanyName";
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(122, 49);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(162, 21);
            this.cboCompany.TabIndex = 2;
            this.cboCompany.ValueMember = "CompanyID";
            // 
            // tblCompaniesBindingSource
            // 
            this.tblCompaniesBindingSource.DataMember = "tblCompanies";
            this.tblCompaniesBindingSource.DataSource = this.projectTrak_DataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Permit Number";
            // 
            // txtPermitNumber
            // 
            this.txtPermitNumber.Location = new System.Drawing.Point(122, 12);
            this.txtPermitNumber.Name = "txtPermitNumber";
            this.txtPermitNumber.ReadOnly = true;
            this.txtPermitNumber.Size = new System.Drawing.Size(65, 20);
            this.txtPermitNumber.TabIndex = 1;
            // 
            // pgeSection2
            // 
            this.pgeSection2.Controls.Add(this.grpLocalReq);
            this.pgeSection2.Controls.Add(this.chkLocalReq);
            this.pgeSection2.Location = new System.Drawing.Point(4, 22);
            this.pgeSection2.Name = "pgeSection2";
            this.pgeSection2.Padding = new System.Windows.Forms.Padding(3);
            this.pgeSection2.Size = new System.Drawing.Size(624, 444);
            this.pgeSection2.TabIndex = 1;
            this.pgeSection2.Text = "Section 2";
            this.pgeSection2.UseVisualStyleBackColor = true;
            // 
            // grpLocalReq
            // 
            this.grpLocalReq.Controls.Add(this.chkSurveyOnly);
            this.grpLocalReq.Controls.Add(this.chkPlannersApproval);
            this.grpLocalReq.Controls.Add(this.txtMSNumber);
            this.grpLocalReq.Controls.Add(this.txtMaximoNumber);
            this.grpLocalReq.Controls.Add(this.txtATPNumber);
            this.grpLocalReq.Controls.Add(this.label15);
            this.grpLocalReq.Controls.Add(this.label14);
            this.grpLocalReq.Controls.Add(this.label13);
            this.grpLocalReq.Location = new System.Drawing.Point(18, 52);
            this.grpLocalReq.Name = "grpLocalReq";
            this.grpLocalReq.Size = new System.Drawing.Size(349, 195);
            this.grpLocalReq.TabIndex = 1;
            this.grpLocalReq.TabStop = false;
            this.grpLocalReq.Text = "Local Requirements";
            // 
            // chkSurveyOnly
            // 
            this.chkSurveyOnly.AutoSize = true;
            this.chkSurveyOnly.Location = new System.Drawing.Point(23, 164);
            this.chkSurveyOnly.Name = "chkSurveyOnly";
            this.chkSurveyOnly.Size = new System.Drawing.Size(83, 17);
            this.chkSurveyOnly.TabIndex = 7;
            this.chkSurveyOnly.Text = "Survey Only";
            this.chkSurveyOnly.UseVisualStyleBackColor = true;
            // 
            // chkPlannersApproval
            // 
            this.chkPlannersApproval.AutoSize = true;
            this.chkPlannersApproval.Location = new System.Drawing.Point(23, 132);
            this.chkPlannersApproval.Name = "chkPlannersApproval";
            this.chkPlannersApproval.Size = new System.Drawing.Size(112, 17);
            this.chkPlannersApproval.TabIndex = 6;
            this.chkPlannersApproval.Text = "Planners Approval";
            this.chkPlannersApproval.UseVisualStyleBackColor = true;
            // 
            // txtMSNumber
            // 
            this.txtMSNumber.Location = new System.Drawing.Point(109, 93);
            this.txtMSNumber.Name = "txtMSNumber";
            this.txtMSNumber.Size = new System.Drawing.Size(216, 20);
            this.txtMSNumber.TabIndex = 5;
            this.txtMSNumber.Click += new System.EventHandler(this.txtMSNumber_Click);
            // 
            // txtMaximoNumber
            // 
            this.txtMaximoNumber.Location = new System.Drawing.Point(109, 61);
            this.txtMaximoNumber.Name = "txtMaximoNumber";
            this.txtMaximoNumber.Size = new System.Drawing.Size(216, 20);
            this.txtMaximoNumber.TabIndex = 4;
            this.txtMaximoNumber.Click += new System.EventHandler(this.txtMaximoNumber_Click);
            // 
            // txtATPNumber
            // 
            this.txtATPNumber.Location = new System.Drawing.Point(109, 29);
            this.txtATPNumber.Name = "txtATPNumber";
            this.txtATPNumber.Size = new System.Drawing.Size(216, 20);
            this.txtATPNumber.TabIndex = 3;
            this.txtATPNumber.Click += new System.EventHandler(this.txtATPNumber_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "MS Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Maximo Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "ATP Number";
            // 
            // chkLocalReq
            // 
            this.chkLocalReq.AutoSize = true;
            this.chkLocalReq.Location = new System.Drawing.Point(18, 20);
            this.chkLocalReq.Name = "chkLocalReq";
            this.chkLocalReq.Size = new System.Drawing.Size(267, 17);
            this.chkLocalReq.TabIndex = 0;
            this.chkLocalReq.Text = "Are Local Requirements to be taken in to account?";
            this.chkLocalReq.UseVisualStyleBackColor = true;
            this.chkLocalReq.CheckedChanged += new System.EventHandler(this.chkLocalReq_CheckedChanged);
            // 
            // pgeSection3
            // 
            this.pgeSection3.Controls.Add(this.chkLikelyDis);
            this.pgeSection3.Controls.Add(this.grpDisruption);
            this.pgeSection3.Controls.Add(this.grpElecMechIso);
            this.pgeSection3.Controls.Add(this.grpDrawingAtt);
            this.pgeSection3.Controls.Add(this.grpAreaInsp);
            this.pgeSection3.Controls.Add(this.label16);
            this.pgeSection3.Location = new System.Drawing.Point(4, 22);
            this.pgeSection3.Name = "pgeSection3";
            this.pgeSection3.Padding = new System.Windows.Forms.Padding(3);
            this.pgeSection3.Size = new System.Drawing.Size(624, 444);
            this.pgeSection3.TabIndex = 2;
            this.pgeSection3.Text = "Section 3";
            this.pgeSection3.UseVisualStyleBackColor = true;
            // 
            // chkLikelyDis
            // 
            this.chkLikelyDis.AutoSize = true;
            this.chkLikelyDis.Location = new System.Drawing.Point(28, 225);
            this.chkLikelyDis.Name = "chkLikelyDis";
            this.chkLikelyDis.Size = new System.Drawing.Size(226, 17);
            this.chkLikelyDis.TabIndex = 0;
            this.chkLikelyDis.Text = "Likely Disruption To Vanderlande Progress";
            this.chkLikelyDis.UseVisualStyleBackColor = true;
            this.chkLikelyDis.CheckedChanged += new System.EventHandler(this.chkLikelyDis_CheckedChanged);
            // 
            // grpDisruption
            // 
            this.grpDisruption.Controls.Add(this.label17);
            this.grpDisruption.Controls.Add(this.txtDisComments);
            this.grpDisruption.Controls.Add(this.chkHighDis);
            this.grpDisruption.Controls.Add(this.chkMedDis);
            this.grpDisruption.Controls.Add(this.chkLowDis);
            this.grpDisruption.Location = new System.Drawing.Point(28, 248);
            this.grpDisruption.Name = "grpDisruption";
            this.grpDisruption.Size = new System.Drawing.Size(467, 108);
            this.grpDisruption.TabIndex = 4;
            this.grpDisruption.TabStop = false;
            this.grpDisruption.Text = "Site Disruption";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(90, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Comments";
            // 
            // txtDisComments
            // 
            this.txtDisComments.Location = new System.Drawing.Point(147, 22);
            this.txtDisComments.Name = "txtDisComments";
            this.txtDisComments.Size = new System.Drawing.Size(301, 71);
            this.txtDisComments.TabIndex = 3;
            this.txtDisComments.Text = "";
            this.txtDisComments.Click += new System.EventHandler(this.txtDisComments_Click);
            // 
            // chkHighDis
            // 
            this.chkHighDis.AutoSize = true;
            this.chkHighDis.Location = new System.Drawing.Point(11, 74);
            this.chkHighDis.Name = "chkHighDis";
            this.chkHighDis.Size = new System.Drawing.Size(48, 17);
            this.chkHighDis.TabIndex = 2;
            this.chkHighDis.Text = "High";
            this.chkHighDis.UseVisualStyleBackColor = true;
            this.chkHighDis.CheckedChanged += new System.EventHandler(this.chkHighDis_CheckedChanged);
            // 
            // chkMedDis
            // 
            this.chkMedDis.AutoSize = true;
            this.chkMedDis.Location = new System.Drawing.Point(11, 49);
            this.chkMedDis.Name = "chkMedDis";
            this.chkMedDis.Size = new System.Drawing.Size(63, 17);
            this.chkMedDis.TabIndex = 1;
            this.chkMedDis.Text = "Medium";
            this.chkMedDis.UseVisualStyleBackColor = true;
            this.chkMedDis.CheckedChanged += new System.EventHandler(this.chkMedDis_CheckedChanged);
            // 
            // chkLowDis
            // 
            this.chkLowDis.AutoSize = true;
            this.chkLowDis.Checked = true;
            this.chkLowDis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowDis.Location = new System.Drawing.Point(11, 24);
            this.chkLowDis.Name = "chkLowDis";
            this.chkLowDis.Size = new System.Drawing.Size(46, 17);
            this.chkLowDis.TabIndex = 0;
            this.chkLowDis.Text = "Low";
            this.chkLowDis.UseVisualStyleBackColor = true;
            this.chkLowDis.CheckedChanged += new System.EventHandler(this.chkLowDis_CheckedChanged);
            // 
            // grpElecMechIso
            // 
            this.grpElecMechIso.Controls.Add(this.chkElecMeckIso);
            this.grpElecMechIso.Location = new System.Drawing.Point(28, 165);
            this.grpElecMechIso.Name = "grpElecMechIso";
            this.grpElecMechIso.Size = new System.Drawing.Size(246, 45);
            this.grpElecMechIso.TabIndex = 3;
            this.grpElecMechIso.TabStop = false;
            this.grpElecMechIso.Text = "Elec/Mech Isolation";
            // 
            // chkElecMeckIso
            // 
            this.chkElecMeckIso.AutoSize = true;
            this.chkElecMeckIso.Location = new System.Drawing.Point(8, 19);
            this.chkElecMeckIso.Name = "chkElecMeckIso";
            this.chkElecMeckIso.Size = new System.Drawing.Size(157, 17);
            this.chkElecMeckIso.TabIndex = 0;
            this.chkElecMeckIso.Text = "Isolation of Requested Area";
            this.chkElecMeckIso.UseVisualStyleBackColor = true;
            // 
            // grpDrawingAtt
            // 
            this.grpDrawingAtt.Controls.Add(this.chkDrawingAtt);
            this.grpDrawingAtt.Location = new System.Drawing.Point(28, 103);
            this.grpDrawingAtt.Name = "grpDrawingAtt";
            this.grpDrawingAtt.Size = new System.Drawing.Size(246, 45);
            this.grpDrawingAtt.TabIndex = 2;
            this.grpDrawingAtt.TabStop = false;
            this.grpDrawingAtt.Text = "Drawing Attached";
            // 
            // chkDrawingAtt
            // 
            this.chkDrawingAtt.AutoSize = true;
            this.chkDrawingAtt.Location = new System.Drawing.Point(8, 19);
            this.chkDrawingAtt.Name = "chkDrawingAtt";
            this.chkDrawingAtt.Size = new System.Drawing.Size(215, 17);
            this.chkDrawingAtt.TabIndex = 0;
            this.chkDrawingAtt.Text = "A Location Drawing Has Been Attached";
            this.chkDrawingAtt.UseVisualStyleBackColor = true;
            // 
            // grpAreaInsp
            // 
            this.grpAreaInsp.Controls.Add(this.chkAreaInsp);
            this.grpAreaInsp.Location = new System.Drawing.Point(28, 41);
            this.grpAreaInsp.Name = "grpAreaInsp";
            this.grpAreaInsp.Size = new System.Drawing.Size(246, 45);
            this.grpAreaInsp.TabIndex = 1;
            this.grpAreaInsp.TabStop = false;
            this.grpAreaInsp.Text = "Area Inspected";
            // 
            // chkAreaInsp
            // 
            this.chkAreaInsp.AutoSize = true;
            this.chkAreaInsp.Location = new System.Drawing.Point(8, 19);
            this.chkAreaInsp.Name = "chkAreaInsp";
            this.chkAreaInsp.Size = new System.Drawing.Size(186, 17);
            this.chkAreaInsp.TabIndex = 0;
            this.chkAreaInsp.Text = "Work Area Inspected and Viewed";
            this.chkAreaInsp.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(229, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "System Access - Request risk review check list";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Permit, Complete Sections 1, 2 and 3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblCompaniesTableAdapter
            // 
            this.tblCompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // tblEmployeesTableAdapter
            // 
            this.tblEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // tblLevelTableAdapter
            // 
            this.tblLevelTableAdapter.ClearBeforeFill = true;
            // 
            // tblLocationTableAdapter
            // 
            this.tblLocationTableAdapter.ClearBeforeFill = true;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(508, 542);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(111, 41);
            this.cmdExit.TabIndex = 1;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdNext
            // 
            this.cmdNext.Location = new System.Drawing.Point(361, 542);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(111, 41);
            this.cmdNext.TabIndex = 0;
            this.cmdNext.Text = "Next";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // txtPermitID
            // 
            this.txtPermitID.Location = new System.Drawing.Point(18, 17);
            this.txtPermitID.Name = "txtPermitID";
            this.txtPermitID.Size = new System.Drawing.Size(38, 20);
            this.txtPermitID.TabIndex = 4;
            this.txtPermitID.Visible = false;
            // 
            // frmAddPermit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 593);
            this.Controls.Add(this.txtPermitID);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.tabPermitSections);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddPermit";
            this.Text = "frmAddPermit";
            this.Load += new System.EventHandler(this.frmAddPermit_Load);
            this.tabPermitSections.ResumeLayout(false);
            this.pgeSection1.ResumeLayout(false);
            this.pgeSection1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeeReqAccess)).EndInit();
            this.fraEmployee.ResumeLayout(false);
            this.fraEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrak_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLevelBindingSource)).EndInit();
            this.fraPermitType.ResumeLayout(false);
            this.fraPermitType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLineManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblResPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompaniesBindingSource)).EndInit();
            this.pgeSection2.ResumeLayout(false);
            this.pgeSection2.PerformLayout();
            this.grpLocalReq.ResumeLayout(false);
            this.grpLocalReq.PerformLayout();
            this.pgeSection3.ResumeLayout(false);
            this.pgeSection3.PerformLayout();
            this.grpDisruption.ResumeLayout(false);
            this.grpDisruption.PerformLayout();
            this.grpElecMechIso.ResumeLayout(false);
            this.grpElecMechIso.PerformLayout();
            this.grpDrawingAtt.ResumeLayout(false);
            this.grpDrawingAtt.PerformLayout();
            this.grpAreaInsp.ResumeLayout(false);
            this.grpAreaInsp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPermitSections;
        private System.Windows.Forms.TabPage pgeSection1;
        private System.Windows.Forms.TabPage pgeSection2;
        private System.Windows.Forms.TabPage pgeSection3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Company;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLineManager;
        private System.Windows.Forms.ComboBox cboResPerson;
        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPermitNumber;
        private ProjectTrak_DataSet projectTrak_DataSet;
        private System.Windows.Forms.BindingSource tblCompaniesBindingSource;
        private ProjectTrak_DataSetTableAdapters.tblCompaniesTableAdapter tblCompaniesTableAdapter;
        private System.Windows.Forms.BindingSource tblLineManagerBindingSource;
        private ProjectTrak_DataSetTableAdapters.tblEmployeesTableAdapter tblEmployeesTableAdapter;
        private System.Windows.Forms.BindingSource tblResPersonBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.MaskedTextBox txtFinishTime;
        private System.Windows.Forms.MaskedTextBox txtStartTime;
        private System.Windows.Forms.GroupBox fraPermitType;
        private System.Windows.Forms.RadioButton optDaysWeekend;
        private System.Windows.Forms.RadioButton optNightsMonThur;
        private System.Windows.Forms.RadioButton optDayMonFri;
        private System.Windows.Forms.ListBox lstLocation;
        private System.Windows.Forms.ListBox lstLevel;
        private System.Windows.Forms.BindingSource tblLevelBindingSource;
        private ProjectTrak_DataSetTableAdapters.tblLevelTableAdapter tblLevelTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource tblLocationBindingSource;
        private ProjectTrak_DataSetTableAdapters.tblLocationTableAdapter tblLocationTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.CheckBox chkWithin1Metre;
        private System.Windows.Forms.DataGridView dataEmployeeReqAccess;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.GroupBox fraEmployee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboAddEmployee;
        private System.Windows.Forms.BindingSource tblEmployeesBindingSource;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdNext;
        public System.Windows.Forms.TextBox txtPermitID;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.GroupBox grpLocalReq;
        private System.Windows.Forms.CheckBox chkSurveyOnly;
        private System.Windows.Forms.CheckBox chkPlannersApproval;
        private System.Windows.Forms.TextBox txtMSNumber;
        private System.Windows.Forms.TextBox txtMaximoNumber;
        private System.Windows.Forms.TextBox txtATPNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkLocalReq;
        private System.Windows.Forms.GroupBox grpElecMechIso;
        private System.Windows.Forms.CheckBox chkElecMeckIso;
        private System.Windows.Forms.GroupBox grpDrawingAtt;
        private System.Windows.Forms.CheckBox chkDrawingAtt;
        private System.Windows.Forms.GroupBox grpAreaInsp;
        private System.Windows.Forms.CheckBox chkAreaInsp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkLikelyDis;
        private System.Windows.Forms.GroupBox grpDisruption;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox txtDisComments;
        private System.Windows.Forms.CheckBox chkHighDis;
        private System.Windows.Forms.CheckBox chkMedDis;
        private System.Windows.Forms.CheckBox chkLowDis;
    }
}