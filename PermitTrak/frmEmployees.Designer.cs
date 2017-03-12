namespace PermitTrak
{
    partial class frmEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployees));
            this.label1 = new System.Windows.Forms.Label();
            this.grpAddEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAddIsoResPerson = new System.Windows.Forms.CheckBox();
            this.cmdAddEmployee = new System.Windows.Forms.Button();
            this.chkAddIsoAppoint = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAddConveyorAware = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAddPermitResPerson = new System.Windows.Forms.CheckBox();
            this.txtAddAccessLevel = new System.Windows.Forms.TextBox();
            this.txtAddContactNumber = new System.Windows.Forms.TextBox();
            this.chkAddPermitCoord = new System.Windows.Forms.CheckBox();
            this.cboAddCompany = new System.Windows.Forms.ComboBox();
            this.tblCompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTrak_DataSet = new PermitTrak.ProjectTrak_DataSet();
            this.txtAddEmployeeName = new System.Windows.Forms.TextBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCompaniesTableAdapter = new PermitTrak.ProjectTrak_DataSetTableAdapters.tblCompaniesTableAdapter();
            this.tblEmployeesTableAdapter = new PermitTrak.ProjectTrak_DataSetTableAdapters.tblEmployeesTableAdapter();
            this.grpEditEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkEditIsoResPerson = new System.Windows.Forms.CheckBox();
            this.cmdUpdateEmployee = new System.Windows.Forms.Button();
            this.chkEditIsoAppoint = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkEditConveyorAware = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkEditPermitResPerson = new System.Windows.Forms.CheckBox();
            this.txtEditAccessLevel = new System.Windows.Forms.TextBox();
            this.txtEditContactNumber = new System.Windows.Forms.TextBox();
            this.chkEditPermitCoord = new System.Windows.Forms.CheckBox();
            this.cboEditCompany = new System.Windows.Forms.ComboBox();
            this.tblCompaniesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtEditEmployeeName = new System.Windows.Forms.TextBox();
            this.grpAddEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrak_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).BeginInit();
            this.grpEditEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompaniesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Utilities";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpAddEmployeeInfo
            // 
            this.grpAddEmployeeInfo.Controls.Add(this.label5);
            this.grpAddEmployeeInfo.Controls.Add(this.label4);
            this.grpAddEmployeeInfo.Controls.Add(this.chkAddIsoResPerson);
            this.grpAddEmployeeInfo.Controls.Add(this.cmdAddEmployee);
            this.grpAddEmployeeInfo.Controls.Add(this.chkAddIsoAppoint);
            this.grpAddEmployeeInfo.Controls.Add(this.label3);
            this.grpAddEmployeeInfo.Controls.Add(this.chkAddConveyorAware);
            this.grpAddEmployeeInfo.Controls.Add(this.label2);
            this.grpAddEmployeeInfo.Controls.Add(this.chkAddPermitResPerson);
            this.grpAddEmployeeInfo.Controls.Add(this.txtAddAccessLevel);
            this.grpAddEmployeeInfo.Controls.Add(this.txtAddContactNumber);
            this.grpAddEmployeeInfo.Controls.Add(this.chkAddPermitCoord);
            this.grpAddEmployeeInfo.Controls.Add(this.cboAddCompany);
            this.grpAddEmployeeInfo.Controls.Add(this.txtAddEmployeeName);
            this.grpAddEmployeeInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddEmployeeInfo.Location = new System.Drawing.Point(12, 48);
            this.grpAddEmployeeInfo.Name = "grpAddEmployeeInfo";
            this.grpAddEmployeeInfo.Size = new System.Drawing.Size(307, 250);
            this.grpAddEmployeeInfo.TabIndex = 2;
            this.grpAddEmployeeInfo.TabStop = false;
            this.grpAddEmployeeInfo.Text = "Add Employee";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Access Level";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAddIsoResPerson
            // 
            this.chkAddIsoResPerson.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddIsoResPerson.Location = new System.Drawing.Point(14, 211);
            this.chkAddIsoResPerson.Name = "chkAddIsoResPerson";
            this.chkAddIsoResPerson.Size = new System.Drawing.Size(136, 21);
            this.chkAddIsoResPerson.TabIndex = 7;
            this.chkAddIsoResPerson.Text = "Isolation Responsible Person";
            this.chkAddIsoResPerson.UseVisualStyleBackColor = true;
            // 
            // cmdAddEmployee
            // 
            this.cmdAddEmployee.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddEmployee.Location = new System.Drawing.Point(193, 185);
            this.cmdAddEmployee.Name = "cmdAddEmployee";
            this.cmdAddEmployee.Size = new System.Drawing.Size(99, 42);
            this.cmdAddEmployee.TabIndex = 8;
            this.cmdAddEmployee.Text = "Add";
            this.cmdAddEmployee.UseVisualStyleBackColor = true;
            this.cmdAddEmployee.Click += new System.EventHandler(this.cmdAddEmployee_Click);
            // 
            // chkAddIsoAppoint
            // 
            this.chkAddIsoAppoint.AutoSize = true;
            this.chkAddIsoAppoint.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddIsoAppoint.Location = new System.Drawing.Point(14, 159);
            this.chkAddIsoAppoint.Name = "chkAddIsoAppoint";
            this.chkAddIsoAppoint.Size = new System.Drawing.Size(154, 18);
            this.chkAddIsoAppoint.TabIndex = 5;
            this.chkAddIsoAppoint.Text = "Isolation Appointed Person";
            this.chkAddIsoAppoint.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAddConveyorAware
            // 
            this.chkAddConveyorAware.AutoSize = true;
            this.chkAddConveyorAware.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddConveyorAware.Location = new System.Drawing.Point(14, 133);
            this.chkAddConveyorAware.Name = "chkAddConveyorAware";
            this.chkAddConveyorAware.Size = new System.Drawing.Size(134, 18);
            this.chkAddConveyorAware.TabIndex = 3;
            this.chkAddConveyorAware.Text = "Conveyor Awareness";
            this.chkAddConveyorAware.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAddPermitResPerson
            // 
            this.chkAddPermitResPerson.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddPermitResPerson.Location = new System.Drawing.Point(172, 125);
            this.chkAddPermitResPerson.Name = "chkAddPermitResPerson";
            this.chkAddPermitResPerson.Size = new System.Drawing.Size(120, 32);
            this.chkAddPermitResPerson.TabIndex = 6;
            this.chkAddPermitResPerson.Text = "Permit Responsible Person";
            this.chkAddPermitResPerson.UseVisualStyleBackColor = true;
            // 
            // txtAddAccessLevel
            // 
            this.txtAddAccessLevel.Location = new System.Drawing.Point(104, 103);
            this.txtAddAccessLevel.Name = "txtAddAccessLevel";
            this.txtAddAccessLevel.Size = new System.Drawing.Size(36, 20);
            this.txtAddAccessLevel.TabIndex = 3;
            // 
            // txtAddContactNumber
            // 
            this.txtAddContactNumber.Location = new System.Drawing.Point(103, 77);
            this.txtAddContactNumber.Name = "txtAddContactNumber";
            this.txtAddContactNumber.Size = new System.Drawing.Size(181, 20);
            this.txtAddContactNumber.TabIndex = 2;
            // 
            // chkAddPermitCoord
            // 
            this.chkAddPermitCoord.AutoSize = true;
            this.chkAddPermitCoord.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddPermitCoord.Location = new System.Drawing.Point(14, 185);
            this.chkAddPermitCoord.Name = "chkAddPermitCoord";
            this.chkAddPermitCoord.Size = new System.Drawing.Size(114, 18);
            this.chkAddPermitCoord.TabIndex = 4;
            this.chkAddPermitCoord.Text = "Permit Coordinator";
            this.chkAddPermitCoord.UseVisualStyleBackColor = true;
            // 
            // cboAddCompany
            // 
            this.cboAddCompany.DataSource = this.tblCompaniesBindingSource;
            this.cboAddCompany.DisplayMember = "CompanyName";
            this.cboAddCompany.FormattingEnabled = true;
            this.cboAddCompany.Location = new System.Drawing.Point(104, 50);
            this.cboAddCompany.Name = "cboAddCompany";
            this.cboAddCompany.Size = new System.Drawing.Size(180, 22);
            this.cboAddCompany.TabIndex = 1;
            this.cboAddCompany.ValueMember = "CompanyID";
            // 
            // tblCompaniesBindingSource
            // 
            this.tblCompaniesBindingSource.DataMember = "tblCompanies";
            this.tblCompaniesBindingSource.DataSource = this.projectTrak_DataSet;
            // 
            // projectTrak_DataSet
            // 
            this.projectTrak_DataSet.DataSetName = "ProjectTrak_DataSet";
            this.projectTrak_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAddEmployeeName
            // 
            this.txtAddEmployeeName.Location = new System.Drawing.Point(104, 24);
            this.txtAddEmployeeName.Name = "txtAddEmployeeName";
            this.txtAddEmployeeName.Size = new System.Drawing.Size(181, 20);
            this.txtAddEmployeeName.TabIndex = 0;
            // 
            // cmdExit
            // 
            this.cmdExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(676, 258);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(98, 42);
            this.cmdExit.TabIndex = 9;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.AutoGenerateColumns = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewEmployees.DataSource = this.tblEmployeesBindingSource;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 314);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(767, 231);
            this.dataGridViewEmployees.TabIndex = 10;
            this.dataGridViewEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ConveyorAware";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Conveyor Awareness";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "PermitCoordinator";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Permit Coordinator";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "PermitResPerson";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Permit Responsible Person";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "IsoResPerson";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Isolation Responsible Person";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "AppointedPerson";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Appointed Person";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AppContact";
            this.dataGridViewTextBoxColumn3.HeaderText = "Contact No.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tblEmployeesBindingSource
            // 
            this.tblEmployeesBindingSource.DataMember = "tblEmployees";
            this.tblEmployeesBindingSource.DataSource = this.projectTrak_DataSet;
            // 
            // tblCompaniesTableAdapter
            // 
            this.tblCompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // tblEmployeesTableAdapter
            // 
            this.tblEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // grpEditEmployeeInfo
            // 
            this.grpEditEmployeeInfo.Controls.Add(this.txtEmployeeID);
            this.grpEditEmployeeInfo.Controls.Add(this.cmdDelete);
            this.grpEditEmployeeInfo.Controls.Add(this.label6);
            this.grpEditEmployeeInfo.Controls.Add(this.label7);
            this.grpEditEmployeeInfo.Controls.Add(this.chkEditIsoResPerson);
            this.grpEditEmployeeInfo.Controls.Add(this.cmdUpdateEmployee);
            this.grpEditEmployeeInfo.Controls.Add(this.chkEditIsoAppoint);
            this.grpEditEmployeeInfo.Controls.Add(this.label8);
            this.grpEditEmployeeInfo.Controls.Add(this.chkEditConveyorAware);
            this.grpEditEmployeeInfo.Controls.Add(this.label9);
            this.grpEditEmployeeInfo.Controls.Add(this.chkEditPermitResPerson);
            this.grpEditEmployeeInfo.Controls.Add(this.txtEditAccessLevel);
            this.grpEditEmployeeInfo.Controls.Add(this.txtEditContactNumber);
            this.grpEditEmployeeInfo.Controls.Add(this.chkEditPermitCoord);
            this.grpEditEmployeeInfo.Controls.Add(this.cboEditCompany);
            this.grpEditEmployeeInfo.Controls.Add(this.txtEditEmployeeName);
            this.grpEditEmployeeInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditEmployeeInfo.Location = new System.Drawing.Point(339, 48);
            this.grpEditEmployeeInfo.Name = "grpEditEmployeeInfo";
            this.grpEditEmployeeInfo.Size = new System.Drawing.Size(307, 250);
            this.grpEditEmployeeInfo.TabIndex = 9;
            this.grpEditEmployeeInfo.TabStop = false;
            this.grpEditEmployeeInfo.Text = "Edit Employee";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(146, 103);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(36, 20);
            this.txtEmployeeID.TabIndex = 10;
            this.txtEmployeeID.Visible = false;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Location = new System.Drawing.Point(185, 206);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(99, 27);
            this.cmdDelete.TabIndex = 9;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Access Level";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contact Number";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkEditIsoResPerson
            // 
            this.chkEditIsoResPerson.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditIsoResPerson.Location = new System.Drawing.Point(14, 211);
            this.chkEditIsoResPerson.Name = "chkEditIsoResPerson";
            this.chkEditIsoResPerson.Size = new System.Drawing.Size(136, 18);
            this.chkEditIsoResPerson.TabIndex = 7;
            this.chkEditIsoResPerson.Text = "Isolation Responsible Person";
            this.chkEditIsoResPerson.UseVisualStyleBackColor = true;
            // 
            // cmdUpdateEmployee
            // 
            this.cmdUpdateEmployee.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdateEmployee.Location = new System.Drawing.Point(185, 163);
            this.cmdUpdateEmployee.Name = "cmdUpdateEmployee";
            this.cmdUpdateEmployee.Size = new System.Drawing.Size(99, 28);
            this.cmdUpdateEmployee.TabIndex = 8;
            this.cmdUpdateEmployee.Text = "Update";
            this.cmdUpdateEmployee.UseVisualStyleBackColor = true;
            this.cmdUpdateEmployee.Click += new System.EventHandler(this.cmdUpdateEmployee_Click);
            // 
            // chkEditIsoAppoint
            // 
            this.chkEditIsoAppoint.AutoSize = true;
            this.chkEditIsoAppoint.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditIsoAppoint.Location = new System.Drawing.Point(14, 159);
            this.chkEditIsoAppoint.Name = "chkEditIsoAppoint";
            this.chkEditIsoAppoint.Size = new System.Drawing.Size(154, 18);
            this.chkEditIsoAppoint.TabIndex = 5;
            this.chkEditIsoAppoint.Text = "Isolation Appointed Person";
            this.chkEditIsoAppoint.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Company";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkEditConveyorAware
            // 
            this.chkEditConveyorAware.AutoSize = true;
            this.chkEditConveyorAware.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditConveyorAware.Location = new System.Drawing.Point(14, 133);
            this.chkEditConveyorAware.Name = "chkEditConveyorAware";
            this.chkEditConveyorAware.Size = new System.Drawing.Size(134, 18);
            this.chkEditConveyorAware.TabIndex = 3;
            this.chkEditConveyorAware.Text = "Conveyor Awareness";
            this.chkEditConveyorAware.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Employee Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkEditPermitResPerson
            // 
            this.chkEditPermitResPerson.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditPermitResPerson.Location = new System.Drawing.Point(172, 125);
            this.chkEditPermitResPerson.Name = "chkEditPermitResPerson";
            this.chkEditPermitResPerson.Size = new System.Drawing.Size(120, 32);
            this.chkEditPermitResPerson.TabIndex = 6;
            this.chkEditPermitResPerson.Text = "Permit Responsible Person";
            this.chkEditPermitResPerson.UseVisualStyleBackColor = true;
            // 
            // txtEditAccessLevel
            // 
            this.txtEditAccessLevel.Location = new System.Drawing.Point(104, 103);
            this.txtEditAccessLevel.Name = "txtEditAccessLevel";
            this.txtEditAccessLevel.Size = new System.Drawing.Size(36, 20);
            this.txtEditAccessLevel.TabIndex = 3;
            // 
            // txtEditContactNumber
            // 
            this.txtEditContactNumber.Location = new System.Drawing.Point(103, 77);
            this.txtEditContactNumber.Name = "txtEditContactNumber";
            this.txtEditContactNumber.Size = new System.Drawing.Size(181, 20);
            this.txtEditContactNumber.TabIndex = 2;
            // 
            // chkEditPermitCoord
            // 
            this.chkEditPermitCoord.AutoSize = true;
            this.chkEditPermitCoord.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditPermitCoord.Location = new System.Drawing.Point(14, 185);
            this.chkEditPermitCoord.Name = "chkEditPermitCoord";
            this.chkEditPermitCoord.Size = new System.Drawing.Size(114, 18);
            this.chkEditPermitCoord.TabIndex = 4;
            this.chkEditPermitCoord.Text = "Permit Coordinator";
            this.chkEditPermitCoord.UseVisualStyleBackColor = true;
            // 
            // cboEditCompany
            // 
            this.cboEditCompany.DataSource = this.tblCompaniesBindingSource1;
            this.cboEditCompany.DisplayMember = "CompanyName";
            this.cboEditCompany.FormattingEnabled = true;
            this.cboEditCompany.Location = new System.Drawing.Point(104, 50);
            this.cboEditCompany.Name = "cboEditCompany";
            this.cboEditCompany.Size = new System.Drawing.Size(180, 22);
            this.cboEditCompany.TabIndex = 1;
            this.cboEditCompany.ValueMember = "CompanyID";
            // 
            // tblCompaniesBindingSource1
            // 
            this.tblCompaniesBindingSource1.DataMember = "tblCompanies";
            this.tblCompaniesBindingSource1.DataSource = this.projectTrak_DataSet;
            // 
            // txtEditEmployeeName
            // 
            this.txtEditEmployeeName.Location = new System.Drawing.Point(104, 24);
            this.txtEditEmployeeName.Name = "txtEditEmployeeName";
            this.txtEditEmployeeName.Size = new System.Drawing.Size(181, 20);
            this.txtEditEmployeeName.TabIndex = 0;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 565);
            this.Controls.Add(this.grpEditEmployeeInfo);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.grpAddEmployeeInfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEmployees";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.grpAddEmployeeInfo.ResumeLayout(false);
            this.grpAddEmployeeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrak_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).EndInit();
            this.grpEditEmployeeInfo.ResumeLayout(false);
            this.grpEditEmployeeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompaniesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAddEmployeeInfo;
        private System.Windows.Forms.TextBox txtAddAccessLevel;
        private System.Windows.Forms.TextBox txtAddContactNumber;
        private System.Windows.Forms.ComboBox cboAddCompany;
        private System.Windows.Forms.TextBox txtAddEmployeeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAddConveyorAware;
        private System.Windows.Forms.CheckBox chkAddPermitCoord;
        private System.Windows.Forms.CheckBox chkAddIsoAppoint;
        private System.Windows.Forms.CheckBox chkAddPermitResPerson;
        private System.Windows.Forms.CheckBox chkAddIsoResPerson;
        private System.Windows.Forms.Button cmdAddEmployee;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn conveyorAwareDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permitCoordinatorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permitResPersonDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isoResPersonDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn appointedPersonDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appContactDataGridViewTextBoxColumn;
        private ProjectTrak_DataSet projectTrak_DataSet;
        private System.Windows.Forms.BindingSource tblCompaniesBindingSource;
        private ProjectTrak_DataSetTableAdapters.tblCompaniesTableAdapter tblCompaniesTableAdapter;
        private System.Windows.Forms.BindingSource tblEmployeesBindingSource;
        private ProjectTrak_DataSetTableAdapters.tblEmployeesTableAdapter tblEmployeesTableAdapter;
        private System.Windows.Forms.GroupBox grpEditEmployeeInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkEditIsoResPerson;
        private System.Windows.Forms.Button cmdUpdateEmployee;
        private System.Windows.Forms.CheckBox chkEditIsoAppoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkEditConveyorAware;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkEditPermitResPerson;
        private System.Windows.Forms.TextBox txtEditAccessLevel;
        private System.Windows.Forms.TextBox txtEditContactNumber;
        private System.Windows.Forms.CheckBox chkEditPermitCoord;
        private System.Windows.Forms.ComboBox cboEditCompany;
        private System.Windows.Forms.TextBox txtEditEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.BindingSource tblCompaniesBindingSource1;
    }
}