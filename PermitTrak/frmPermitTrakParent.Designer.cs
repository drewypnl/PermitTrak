namespace PermitTrak
{
    partial class frmPermitTrakParent
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("New Permit", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Cancel", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Approval", 3, 3);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Issuing", 4, 4);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Acceptance", 5, 5);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("RP Cancel", 6, 6);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("VI Cancel", 7, 7);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Permits", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("new Isolation", 10, 10);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Cancel", 2, 2);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Issue Elec Isolation", 9, 9);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Issue Mech Isolation", 11, 11);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Receipt", 12, 12);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Clearence", 13, 13);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Cancellation", 14, 14);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Isolations", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Daily Sign On", 17, 17);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Edit Permit", 18, 18);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Search", 20, 20);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Print Reports", 19, 19);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Permit Utilities", 24, 24, new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Padlock Register", 21, 21);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Edit Isolation", 18, 18);
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Search", 20, 20);
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Print Reports", 19, 19);
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Isolation Utilities", 26, 26, new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Utilities", 16, 16, new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Employee", 22, 22);
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Companies", 23, 21);
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Tools", 25, 25, new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("PermitTrak", 15, 15, new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode16,
            treeNode27,
            treeNode30});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermitTrakParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilelogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPermits = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPermitsNewPermit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPermitsCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPermitsApproval = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPermitsIssuing = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPermitsAcceptance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPermitsRPCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPermitsVICancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsolations = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsolationsNewIsolation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsolationsCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsolationsIssueElec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsolationsIssueMech = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsolationsReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsolationsClearence = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsolationsCancellation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPermitUtilities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilitiesPermitDailySignOn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilitiesPermitEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilitiesPermitSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilitiesPermitReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIsolationUtilities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilitiesIsolationPadlock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilitiesIsolationEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilitiesIsolationSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilitiesIsolationReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsCompanies = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.treeParent = new System.Windows.Forms.TreeView();
            this.imageListParent = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.mdiStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuPermits,
            this.mnuIsolations,
            this.mnuUtilities,
            this.mnuTools,
            this.mnuWindow,
            this.mnuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.mnuWindow;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1140, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileLogin,
            this.mnuFilelogOff,
            this.toolStripSeparator3,
            this.mnuFileExit});
            this.mnuFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileLogin
            // 
            this.mnuFileLogin.Name = "mnuFileLogin";
            this.mnuFileLogin.Size = new System.Drawing.Size(110, 22);
            this.mnuFileLogin.Text = "Log In ";
            this.mnuFileLogin.ToolTipText = "Login to the system";
            this.mnuFileLogin.Click += new System.EventHandler(this.mnuFileLogin_Click);
            // 
            // mnuFilelogOff
            // 
            this.mnuFilelogOff.Name = "mnuFilelogOff";
            this.mnuFilelogOff.Size = new System.Drawing.Size(110, 22);
            this.mnuFilelogOff.Text = "Log Off";
            this.mnuFilelogOff.ToolTipText = "Log Off";
            this.mnuFilelogOff.Click += new System.EventHandler(this.mnuFilelogOff_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(107, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(110, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.ToolTipText = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuPermits
            // 
            this.mnuPermits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPermitsNewPermit,
            this.mnuPermitsCancel,
            this.mnuPermitsApproval,
            this.mnuPermitsIssuing,
            this.mnuPermitsAcceptance,
            this.mnuPermitsRPCancel,
            this.mnuPermitsVICancel});
            this.mnuPermits.Name = "mnuPermits";
            this.mnuPermits.Size = new System.Drawing.Size(54, 20);
            this.mnuPermits.Text = "Permits";
            this.mnuPermits.ToolTipText = "Permits";
            // 
            // mnuPermitsNewPermit
            // 
            this.mnuPermitsNewPermit.Name = "mnuPermitsNewPermit";
            this.mnuPermitsNewPermit.Size = new System.Drawing.Size(152, 22);
            this.mnuPermitsNewPermit.Text = "New Permit";
            this.mnuPermitsNewPermit.ToolTipText = "Complete sections 1, 2 and 3 of a new permit";
            this.mnuPermitsNewPermit.Click += new System.EventHandler(this.mnuPermitsNewPermit_Click);
            // 
            // mnuPermitsCancel
            // 
            this.mnuPermitsCancel.Name = "mnuPermitsCancel";
            this.mnuPermitsCancel.Size = new System.Drawing.Size(152, 22);
            this.mnuPermitsCancel.Text = "Cancel";
            this.mnuPermitsCancel.ToolTipText = "Cancel an un-issued permit";
            this.mnuPermitsCancel.Click += new System.EventHandler(this.mnuPermitsCancel_Click);
            // 
            // mnuPermitsApproval
            // 
            this.mnuPermitsApproval.Name = "mnuPermitsApproval";
            this.mnuPermitsApproval.Size = new System.Drawing.Size(152, 22);
            this.mnuPermitsApproval.Text = "Approval";
            this.mnuPermitsApproval.ToolTipText = "Approve a permit";
            // 
            // mnuPermitsIssuing
            // 
            this.mnuPermitsIssuing.Name = "mnuPermitsIssuing";
            this.mnuPermitsIssuing.Size = new System.Drawing.Size(152, 22);
            this.mnuPermitsIssuing.Text = "Issuing";
            this.mnuPermitsIssuing.ToolTipText = "Issue a permit";
            // 
            // mnuPermitsAcceptance
            // 
            this.mnuPermitsAcceptance.Name = "mnuPermitsAcceptance";
            this.mnuPermitsAcceptance.Size = new System.Drawing.Size(152, 22);
            this.mnuPermitsAcceptance.Text = "Acceptance";
            this.mnuPermitsAcceptance.ToolTipText = "Accept a permit";
            // 
            // mnuPermitsRPCancel
            // 
            this.mnuPermitsRPCancel.Name = "mnuPermitsRPCancel";
            this.mnuPermitsRPCancel.Size = new System.Drawing.Size(152, 22);
            this.mnuPermitsRPCancel.Text = "RP Cancel";
            this.mnuPermitsRPCancel.ToolTipText = "Responsible person cancellation";
            // 
            // mnuPermitsVICancel
            // 
            this.mnuPermitsVICancel.Name = "mnuPermitsVICancel";
            this.mnuPermitsVICancel.Size = new System.Drawing.Size(152, 22);
            this.mnuPermitsVICancel.Text = "VI Cancel";
            this.mnuPermitsVICancel.ToolTipText = "VI responsible person cancellation";
            // 
            // mnuIsolations
            // 
            this.mnuIsolations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIsolationsNewIsolation,
            this.mnuIsolationsCancel,
            this.mnuIsolationsIssueElec,
            this.mnuIsolationsIssueMech,
            this.mnuIsolationsReceipt,
            this.mnuIsolationsClearence,
            this.mnuIsolationsCancellation});
            this.mnuIsolations.Name = "mnuIsolations";
            this.mnuIsolations.Size = new System.Drawing.Size(65, 20);
            this.mnuIsolations.Text = "Isolations";
            this.mnuIsolations.ToolTipText = "Isolations";
            // 
            // mnuIsolationsNewIsolation
            // 
            this.mnuIsolationsNewIsolation.Name = "mnuIsolationsNewIsolation";
            this.mnuIsolationsNewIsolation.Size = new System.Drawing.Size(199, 22);
            this.mnuIsolationsNewIsolation.Text = "New Isolation";
            this.mnuIsolationsNewIsolation.ToolTipText = "Complete sections 1,2 and 3 of a new isolation";
            // 
            // mnuIsolationsCancel
            // 
            this.mnuIsolationsCancel.Name = "mnuIsolationsCancel";
            this.mnuIsolationsCancel.Size = new System.Drawing.Size(199, 22);
            this.mnuIsolationsCancel.Text = "Cancel";
            this.mnuIsolationsCancel.ToolTipText = "Cancel an un-issued isolation";
            // 
            // mnuIsolationsIssueElec
            // 
            this.mnuIsolationsIssueElec.Name = "mnuIsolationsIssueElec";
            this.mnuIsolationsIssueElec.Size = new System.Drawing.Size(199, 22);
            this.mnuIsolationsIssueElec.Text = "Issue Electrical Isolation";
            this.mnuIsolationsIssueElec.ToolTipText = "Issue an electrical isolation";
            // 
            // mnuIsolationsIssueMech
            // 
            this.mnuIsolationsIssueMech.Name = "mnuIsolationsIssueMech";
            this.mnuIsolationsIssueMech.Size = new System.Drawing.Size(199, 22);
            this.mnuIsolationsIssueMech.Text = "Issue Mechanical Isolation";
            this.mnuIsolationsIssueMech.ToolTipText = "Issue a mechanical isolation";
            // 
            // mnuIsolationsReceipt
            // 
            this.mnuIsolationsReceipt.Name = "mnuIsolationsReceipt";
            this.mnuIsolationsReceipt.Size = new System.Drawing.Size(199, 22);
            this.mnuIsolationsReceipt.Text = "Receipt";
            this.mnuIsolationsReceipt.ToolTipText = "Receipt an isolation";
            // 
            // mnuIsolationsClearence
            // 
            this.mnuIsolationsClearence.Name = "mnuIsolationsClearence";
            this.mnuIsolationsClearence.Size = new System.Drawing.Size(199, 22);
            this.mnuIsolationsClearence.Text = "Clearence";
            this.mnuIsolationsClearence.ToolTipText = "Isolation clearence";
            // 
            // mnuIsolationsCancellation
            // 
            this.mnuIsolationsCancellation.Name = "mnuIsolationsCancellation";
            this.mnuIsolationsCancellation.Size = new System.Drawing.Size(199, 22);
            this.mnuIsolationsCancellation.Text = "Cancellation";
            this.mnuIsolationsCancellation.ToolTipText = "Isolation Cancellation";
            // 
            // mnuUtilities
            // 
            this.mnuUtilities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPermitUtilities,
            this.mnuIsolationUtilities});
            this.mnuUtilities.Name = "mnuUtilities";
            this.mnuUtilities.Size = new System.Drawing.Size(53, 20);
            this.mnuUtilities.Text = "Utilities";
            this.mnuUtilities.ToolTipText = "Permit/isolation utilities";
            // 
            // mnuPermitUtilities
            // 
            this.mnuPermitUtilities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUtilitiesPermitDailySignOn,
            this.mnuUtilitiesPermitEdit,
            this.mnuUtilitiesPermitSearch,
            this.mnuUtilitiesPermitReports});
            this.mnuPermitUtilities.Name = "mnuPermitUtilities";
            this.mnuPermitUtilities.Size = new System.Drawing.Size(152, 22);
            this.mnuPermitUtilities.Text = "Permit Utilities";
            this.mnuPermitUtilities.ToolTipText = "Permit utilities";
            // 
            // mnuUtilitiesPermitDailySignOn
            // 
            this.mnuUtilitiesPermitDailySignOn.Name = "mnuUtilitiesPermitDailySignOn";
            this.mnuUtilitiesPermitDailySignOn.Size = new System.Drawing.Size(137, 22);
            this.mnuUtilitiesPermitDailySignOn.Text = "Daily Sign On";
            this.mnuUtilitiesPermitDailySignOn.ToolTipText = "Permit daily sign on";
            // 
            // mnuUtilitiesPermitEdit
            // 
            this.mnuUtilitiesPermitEdit.Name = "mnuUtilitiesPermitEdit";
            this.mnuUtilitiesPermitEdit.Size = new System.Drawing.Size(137, 22);
            this.mnuUtilitiesPermitEdit.Text = "Edit Permit";
            this.mnuUtilitiesPermitEdit.ToolTipText = "Edit permit (Sections 1, 2 and 3 only)";
            // 
            // mnuUtilitiesPermitSearch
            // 
            this.mnuUtilitiesPermitSearch.Name = "mnuUtilitiesPermitSearch";
            this.mnuUtilitiesPermitSearch.Size = new System.Drawing.Size(137, 22);
            this.mnuUtilitiesPermitSearch.Text = "Search";
            this.mnuUtilitiesPermitSearch.ToolTipText = "Permit Search";
            // 
            // mnuUtilitiesPermitReports
            // 
            this.mnuUtilitiesPermitReports.Name = "mnuUtilitiesPermitReports";
            this.mnuUtilitiesPermitReports.Size = new System.Drawing.Size(137, 22);
            this.mnuUtilitiesPermitReports.Text = "Print Reports";
            this.mnuUtilitiesPermitReports.ToolTipText = "Print permit reports";
            // 
            // mnuIsolationUtilities
            // 
            this.mnuIsolationUtilities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUtilitiesIsolationPadlock,
            this.mnuUtilitiesIsolationEdit,
            this.mnuUtilitiesIsolationSearch,
            this.mnuUtilitiesIsolationReports});
            this.mnuIsolationUtilities.Name = "mnuIsolationUtilities";
            this.mnuIsolationUtilities.Size = new System.Drawing.Size(152, 22);
            this.mnuIsolationUtilities.Text = "Isolation Utilities";
            this.mnuIsolationUtilities.ToolTipText = "Isolation utilities";
            // 
            // mnuUtilitiesIsolationPadlock
            // 
            this.mnuUtilitiesIsolationPadlock.Name = "mnuUtilitiesIsolationPadlock";
            this.mnuUtilitiesIsolationPadlock.Size = new System.Drawing.Size(153, 22);
            this.mnuUtilitiesIsolationPadlock.Text = "Padlock Register";
            this.mnuUtilitiesIsolationPadlock.ToolTipText = "Isolation padlock register";
            // 
            // mnuUtilitiesIsolationEdit
            // 
            this.mnuUtilitiesIsolationEdit.Name = "mnuUtilitiesIsolationEdit";
            this.mnuUtilitiesIsolationEdit.Size = new System.Drawing.Size(153, 22);
            this.mnuUtilitiesIsolationEdit.Text = "Edit Isolation";
            this.mnuUtilitiesIsolationEdit.ToolTipText = "Edit isolation (sections 1, 2 and 3 only)";
            // 
            // mnuUtilitiesIsolationSearch
            // 
            this.mnuUtilitiesIsolationSearch.Name = "mnuUtilitiesIsolationSearch";
            this.mnuUtilitiesIsolationSearch.Size = new System.Drawing.Size(153, 22);
            this.mnuUtilitiesIsolationSearch.Text = "Search";
            this.mnuUtilitiesIsolationSearch.ToolTipText = "Isolation search";
            // 
            // mnuUtilitiesIsolationReports
            // 
            this.mnuUtilitiesIsolationReports.Name = "mnuUtilitiesIsolationReports";
            this.mnuUtilitiesIsolationReports.Size = new System.Drawing.Size(153, 22);
            this.mnuUtilitiesIsolationReports.Text = "Print Reports";
            this.mnuUtilitiesIsolationReports.ToolTipText = "Isolation reports";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsAddEmployee,
            this.mnuToolsCompanies,
            this.mnuToolsPreferences});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(44, 20);
            this.mnuTools.Text = "Tools";
            this.mnuTools.ToolTipText = "Tools";
            // 
            // mnuToolsAddEmployee
            // 
            this.mnuToolsAddEmployee.Name = "mnuToolsAddEmployee";
            this.mnuToolsAddEmployee.Size = new System.Drawing.Size(142, 22);
            this.mnuToolsAddEmployee.Text = "Add Employee";
            this.mnuToolsAddEmployee.ToolTipText = "Add employees";
            this.mnuToolsAddEmployee.Click += new System.EventHandler(this.mnuToolsAddEmployee_Click);
            // 
            // mnuToolsCompanies
            // 
            this.mnuToolsCompanies.Name = "mnuToolsCompanies";
            this.mnuToolsCompanies.Size = new System.Drawing.Size(142, 22);
            this.mnuToolsCompanies.Text = "Companies";
            this.mnuToolsCompanies.ToolTipText = "Add/edit companies";
            // 
            // mnuToolsPreferences
            // 
            this.mnuToolsPreferences.Name = "mnuToolsPreferences";
            this.mnuToolsPreferences.Size = new System.Drawing.Size(142, 22);
            this.mnuToolsPreferences.Text = "Preferences";
            this.mnuToolsPreferences.Click += new System.EventHandler(this.mnuToolsPreferences_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(57, 20);
            this.mnuWindow.Text = "Window";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpIndex,
            this.toolStripSeparator8,
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(40, 20);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.ToolTipText = "Help";
            // 
            // mnuHelpIndex
            // 
            this.mnuHelpIndex.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuHelpIndex.Name = "mnuHelpIndex";
            this.mnuHelpIndex.Size = new System.Drawing.Size(115, 22);
            this.mnuHelpIndex.Text = "Index";
            this.mnuHelpIndex.ToolTipText = "Help index";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(112, 6);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(115, 22);
            this.mnuHelpAbout.Text = "About...";
            this.mnuHelpAbout.ToolTipText = "About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // treeParent
            // 
            this.treeParent.BackColor = System.Drawing.Color.White;
            this.treeParent.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeParent.ImageIndex = 0;
            this.treeParent.ImageList = this.imageListParent;
            this.treeParent.Indent = 21;
            this.treeParent.ItemHeight = 18;
            this.treeParent.Location = new System.Drawing.Point(0, 24);
            this.treeParent.Name = "treeParent";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "ndePermitsNewPermit";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "New Permit";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "ndePermitsCancel";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Cancel";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "ndePermitsApproval";
            treeNode3.SelectedImageIndex = 3;
            treeNode3.Text = "Approval";
            treeNode4.ImageIndex = 4;
            treeNode4.Name = "ndePermitsIssuing";
            treeNode4.SelectedImageIndex = 4;
            treeNode4.Text = "Issuing";
            treeNode5.ImageIndex = 5;
            treeNode5.Name = "ndePermitsAcceptance";
            treeNode5.SelectedImageIndex = 5;
            treeNode5.Text = "Acceptance";
            treeNode6.ImageIndex = 6;
            treeNode6.Name = "ndePermitsRPCancel";
            treeNode6.SelectedImageIndex = 6;
            treeNode6.Text = "RP Cancel";
            treeNode7.ImageIndex = 7;
            treeNode7.Name = "ndePermitsVICancel";
            treeNode7.SelectedImageIndex = 7;
            treeNode7.Text = "VI Cancel";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "ndePermits";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Text = "Permits";
            treeNode9.ImageIndex = 10;
            treeNode9.Name = "ndeIsolationsNewIsolation";
            treeNode9.SelectedImageIndex = 10;
            treeNode9.Text = "new Isolation";
            treeNode10.ImageIndex = 2;
            treeNode10.Name = "ndeIsolationsCancel";
            treeNode10.SelectedImageIndex = 2;
            treeNode10.Text = "Cancel";
            treeNode11.ImageIndex = 9;
            treeNode11.Name = "ndeIsolationsIssueElec";
            treeNode11.SelectedImageIndex = 9;
            treeNode11.Text = "Issue Elec Isolation";
            treeNode12.ImageIndex = 11;
            treeNode12.Name = "ndeIsolationsIssueMech";
            treeNode12.SelectedImageIndex = 11;
            treeNode12.Text = "Issue Mech Isolation";
            treeNode13.ImageIndex = 12;
            treeNode13.Name = "ndeIsolationsReceipt";
            treeNode13.SelectedImageIndex = 12;
            treeNode13.Text = "Receipt";
            treeNode14.ImageIndex = 13;
            treeNode14.Name = "ndeIsolationsClearence";
            treeNode14.SelectedImageIndex = 13;
            treeNode14.Text = "Clearence";
            treeNode15.ImageIndex = 14;
            treeNode15.Name = "ndeIsolationsCancellation";
            treeNode15.SelectedImageIndex = 14;
            treeNode15.Text = "Cancellation";
            treeNode16.ImageIndex = 8;
            treeNode16.Name = "ndeIsolations";
            treeNode16.SelectedImageIndex = 8;
            treeNode16.Text = "Isolations";
            treeNode17.ImageIndex = 17;
            treeNode17.Name = "ndePermitUtilsDailySign";
            treeNode17.SelectedImageIndex = 17;
            treeNode17.Text = "Daily Sign On";
            treeNode18.ImageIndex = 18;
            treeNode18.Name = "ndePermitUtilsEdit";
            treeNode18.SelectedImageIndex = 18;
            treeNode18.Text = "Edit Permit";
            treeNode19.ImageIndex = 20;
            treeNode19.Name = "ndePermitUtilsSearch";
            treeNode19.SelectedImageIndex = 20;
            treeNode19.Text = "Search";
            treeNode20.ImageIndex = 19;
            treeNode20.Name = "ndePermitUtilsPrintReports";
            treeNode20.SelectedImageIndex = 19;
            treeNode20.Text = "Print Reports";
            treeNode21.ImageIndex = 24;
            treeNode21.Name = "ndeUtilitiesPermit";
            treeNode21.SelectedImageIndex = 24;
            treeNode21.Text = "Permit Utilities";
            treeNode22.ImageIndex = 21;
            treeNode22.Name = "ndeIsolationUtilsPadlock";
            treeNode22.SelectedImageIndex = 21;
            treeNode22.Text = "Padlock Register";
            treeNode23.ImageIndex = 18;
            treeNode23.Name = "ndeIsolationUtilsEdit";
            treeNode23.SelectedImageIndex = 18;
            treeNode23.Text = "Edit Isolation";
            treeNode24.ImageIndex = 20;
            treeNode24.Name = "ndeIsolationUtilsSearch";
            treeNode24.SelectedImageIndex = 20;
            treeNode24.Text = "Search";
            treeNode25.ImageIndex = 19;
            treeNode25.Name = "ndeIsolationUtilsPrint";
            treeNode25.SelectedImageIndex = 19;
            treeNode25.Text = "Print Reports";
            treeNode26.ImageIndex = 26;
            treeNode26.Name = "ndeUtilitiesIsolationUtilities";
            treeNode26.SelectedImageIndex = 26;
            treeNode26.Text = "Isolation Utilities";
            treeNode27.ImageIndex = 16;
            treeNode27.Name = "ndeUtilities";
            treeNode27.SelectedImageIndex = 16;
            treeNode27.Text = "Utilities";
            treeNode28.ImageIndex = 22;
            treeNode28.Name = "ndeToolsAddEmployee";
            treeNode28.SelectedImageIndex = 22;
            treeNode28.Text = "Employee";
            treeNode29.ImageIndex = 23;
            treeNode29.Name = "ndeToolsCompanies";
            treeNode29.SelectedImageIndex = 21;
            treeNode29.Text = "Companies";
            treeNode30.ImageIndex = 25;
            treeNode30.Name = "ndeTools";
            treeNode30.SelectedImageIndex = 25;
            treeNode30.Text = "Tools";
            treeNode31.ImageIndex = 15;
            treeNode31.Name = "ndePermitTrak";
            treeNode31.SelectedImageIndex = 15;
            treeNode31.Text = "PermitTrak";
            this.treeParent.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode31});
            this.treeParent.SelectedImageIndex = 0;
            this.treeParent.ShowNodeToolTips = true;
            this.treeParent.Size = new System.Drawing.Size(193, 725);
            this.treeParent.TabIndex = 4;
            this.treeParent.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeParent_NodeMouseClick);
            // 
            // imageListParent
            // 
            this.imageListParent.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListParent.ImageStream")));
            this.imageListParent.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListParent.Images.SetKeyName(0, "calendar.png");
            this.imageListParent.Images.SetKeyName(1, "textfield_add.png");
            this.imageListParent.Images.SetKeyName(2, "cancel.png");
            this.imageListParent.Images.SetKeyName(3, "accept.png");
            this.imageListParent.Images.SetKeyName(4, "award_star_gold_3.png");
            this.imageListParent.Images.SetKeyName(5, "basket_put.png");
            this.imageListParent.Images.SetKeyName(6, "clock_delete.png");
            this.imageListParent.Images.SetKeyName(7, "computer_delete.png");
            this.imageListParent.Images.SetKeyName(8, "disconnect.png");
            this.imageListParent.Images.SetKeyName(9, "lightning_add.png");
            this.imageListParent.Images.SetKeyName(10, "lock_add.png");
            this.imageListParent.Images.SetKeyName(11, "link_add.png");
            this.imageListParent.Images.SetKeyName(12, "page_lightning.png");
            this.imageListParent.Images.SetKeyName(13, "door_open.png");
            this.imageListParent.Images.SetKeyName(14, "key_delete.png");
            this.imageListParent.Images.SetKeyName(15, "Custom-Icon-Design-Office-Application.ico");
            this.imageListParent.Images.SetKeyName(16, "cog.png");
            this.imageListParent.Images.SetKeyName(17, "pencil.png");
            this.imageListParent.Images.SetKeyName(18, "page_edit.png");
            this.imageListParent.Images.SetKeyName(19, "printer.png");
            this.imageListParent.Images.SetKeyName(20, "magnifier.png");
            this.imageListParent.Images.SetKeyName(21, "lock.png");
            this.imageListParent.Images.SetKeyName(22, "group.png");
            this.imageListParent.Images.SetKeyName(23, "telephone.png");
            this.imageListParent.Images.SetKeyName(24, "calendar_edit.png");
            this.imageListParent.Images.SetKeyName(25, "tool-edit-icon.png");
            this.imageListParent.Images.SetKeyName(26, "lightbulb_off.png");
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mdiStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(193, 727);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(947, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip";
            // 
            // mdiStatusLabel
            // 
            this.mdiStatusLabel.Name = "mdiStatusLabel";
            this.mdiStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.mdiStatusLabel.Text = "Status";
            // 
            // frmPermitTrakParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 749);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.treeParent);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPermitTrakParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PermitTrak";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPermitTrakParent_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        public System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        public System.Windows.Forms.ToolStripMenuItem mnuFile;
        public System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        public System.Windows.Forms.ToolStripMenuItem mnuTools;
        public System.Windows.Forms.ToolStripMenuItem mnuHelp;
        public System.Windows.Forms.ToolStripMenuItem mnuHelpIndex;
        public System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem mnuPermits;
        public System.Windows.Forms.ToolStripMenuItem mnuPermitsNewPermit;
        public System.Windows.Forms.ToolStripMenuItem mnuPermitsApproval;
        public System.Windows.Forms.ToolStripMenuItem mnuPermitsIssuing;
        public System.Windows.Forms.ToolStripMenuItem mnuPermitsAcceptance;
        public System.Windows.Forms.ToolStripMenuItem mnuPermitsRPCancel;
        public System.Windows.Forms.ToolStripMenuItem mnuPermitsVICancel;
        public System.Windows.Forms.ToolStripMenuItem mnuIsolations;
        public System.Windows.Forms.ToolStripMenuItem mnuIsolationsNewIsolation;
        public System.Windows.Forms.ToolStripMenuItem mnuFilelogOff;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem mnuIsolationsCancel;
        public System.Windows.Forms.ToolStripMenuItem mnuIsolationsIssueElec;
        public System.Windows.Forms.ToolStripMenuItem mnuIsolationsIssueMech;
        public System.Windows.Forms.ToolStripMenuItem mnuIsolationsReceipt;
        public System.Windows.Forms.ToolStripMenuItem mnuIsolationsClearence;
        public System.Windows.Forms.ToolStripMenuItem mnuIsolationsCancellation;
        public System.Windows.Forms.ToolStripMenuItem mnuUtilities;
        public System.Windows.Forms.ToolStripMenuItem mnuPermitUtilities;
        public System.Windows.Forms.ToolStripMenuItem mnuUtilitiesPermitDailySignOn;
        public System.Windows.Forms.ToolStripMenuItem mnuUtilitiesPermitEdit;
        public System.Windows.Forms.ToolStripMenuItem mnuUtilitiesPermitSearch;
        public System.Windows.Forms.ToolStripMenuItem mnuUtilitiesPermitReports;
        public System.Windows.Forms.ToolStripMenuItem mnuIsolationUtilities;
        public System.Windows.Forms.ToolStripMenuItem mnuUtilitiesIsolationPadlock;
        public System.Windows.Forms.ToolStripMenuItem mnuUtilitiesIsolationEdit;
        public System.Windows.Forms.ToolStripMenuItem mnuUtilitiesIsolationSearch;
        public System.Windows.Forms.ToolStripMenuItem mnuUtilitiesIsolationReports;
        public System.Windows.Forms.ToolStripMenuItem mnuToolsAddEmployee;
        public System.Windows.Forms.ToolStripMenuItem mnuToolsCompanies;
        public System.Windows.Forms.ToolStripMenuItem mnuPermitsCancel;
        public System.Windows.Forms.ToolStripMenuItem mnuToolsPreferences;
        public System.Windows.Forms.TreeView treeParent;
        public System.Windows.Forms.ToolStripMenuItem mnuFileLogin;
        public System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel mdiStatusLabel;
        private System.Windows.Forms.ImageList imageListParent;
        public System.Windows.Forms.ToolStripMenuItem mnuWindow;
    }
}



