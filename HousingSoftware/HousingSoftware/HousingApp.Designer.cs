namespace HousingSoftware
{
    partial class HousingApp
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
            this.MenuAdmin = new System.Windows.Forms.TabControl();
            this.tabHomeAdmin = new System.Windows.Forms.TabPage();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbWelcomeMsgAdmin = new System.Windows.Forms.Label();
            this.btnLogOutAdmin = new System.Windows.Forms.Button();
            this.tabGroceriesAdmin = new System.Windows.Forms.TabPage();
            this.gbxPayListGroceries = new System.Windows.Forms.GroupBox();
            this.btnClsSelectLinePayListGroceries = new System.Windows.Forms.Button();
            this.btnMarkAllAsPaid = new System.Windows.Forms.Button();
            this.btnMarkSelectedAsPaid = new System.Windows.Forms.Button();
            this.lbxUnpaidGroceriesPerStudent = new System.Windows.Forms.ListBox();
            this.tbxStudNumUnpaidItems = new System.Windows.Forms.TextBox();
            this.btnShowToPayList = new System.Windows.Forms.Button();
            this.lbStudNumUnpaidItems = new System.Windows.Forms.Label();
            this.gbxAddGrocery = new System.Windows.Forms.GroupBox();
            this.tbxGroceryPrice = new System.Windows.Forms.TextBox();
            this.lbGroceryPrice = new System.Windows.Forms.Label();
            this.btnAddGrocery = new System.Windows.Forms.Button();
            this.tbxGroceryName = new System.Windows.Forms.TextBox();
            this.lbGroceryName = new System.Windows.Forms.Label();
            this.gbxGroceriesAdmin = new System.Windows.Forms.GroupBox();
            this.btnClsSelectedLineRecentGroceries = new System.Windows.Forms.Button();
            this.btnRemoveAllGroceries = new System.Windows.Forms.Button();
            this.btnRemoveSelectedGrocery = new System.Windows.Forms.Button();
            this.lbxRecentGroceries = new System.Windows.Forms.ListBox();
            this.lbRecentGroceries = new System.Windows.Forms.Label();
            this.tabAnnouncementsAdmin = new System.Windows.Forms.TabPage();
            this.gbxPostAnnouncements = new System.Windows.Forms.GroupBox();
            this.btnPostAnnouncement = new System.Windows.Forms.Button();
            this.tbxPostAnnouncement = new System.Windows.Forms.TextBox();
            this.lbWriteMessage = new System.Windows.Forms.Label();
            this.gbxNewsFeed = new System.Windows.Forms.GroupBox();
            this.btndeleteAnnouncement = new System.Windows.Forms.Button();
            this.lbxAllAnnouncements = new System.Windows.Forms.ListBox();
            this.lbAllAnnouncements = new System.Windows.Forms.Label();
            this.tabAgreementsAdmin = new System.Windows.Forms.TabPage();
            this.lbxAllAgreementsAdmin = new System.Windows.Forms.ListBox();
            this.lbAllAgreementsAdmin = new System.Windows.Forms.Label();
            this.tabHouseRulesAdmin = new System.Windows.Forms.TabPage();
            this.gbxRule = new System.Windows.Forms.GroupBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.tbxAddRule = new System.Windows.Forms.TextBox();
            this.lbWriteRule = new System.Windows.Forms.Label();
            this.gbxRules = new System.Windows.Forms.GroupBox();
            this.lbxRulesAdmin = new System.Windows.Forms.ListBox();
            this.tabComplaintsAdmin = new System.Windows.Forms.TabPage();
            this.btnMarkAsDone = new System.Windows.Forms.Button();
            this.gbxAllComplaints = new System.Windows.Forms.GroupBox();
            this.lbxAllComplaints = new System.Windows.Forms.ListBox();
            this.tabManageTenants = new System.Windows.Forms.TabPage();
            this.gbxEditTenant = new System.Windows.Forms.GroupBox();
            this.tbxEditPasswordTenant = new System.Windows.Forms.TextBox();
            this.btnSaveChangesEditTenantProfile = new System.Windows.Forms.Button();
            this.lbEditFNameTenant = new System.Windows.Forms.Label();
            this.lbEditPasswordTenant = new System.Windows.Forms.Label();
            this.tbxEditFNameTenant = new System.Windows.Forms.TextBox();
            this.gbxSearchTenantEdit = new System.Windows.Forms.GroupBox();
            this.btnShowTenantProfileEdit = new System.Windows.Forms.Button();
            this.tbxStudNumSearchTenantEdit = new System.Windows.Forms.TextBox();
            this.lbStudNumSearchTenantEdit = new System.Windows.Forms.Label();
            this.gbxRemoveTenant = new System.Windows.Forms.GroupBox();
            this.btnRemoveTenant = new System.Windows.Forms.Button();
            this.tbxStudentNumRemove = new System.Windows.Forms.TextBox();
            this.lbStudentNumRemove = new System.Windows.Forms.Label();
            this.gbxRegisterTenants = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbxPasswordRegister = new System.Windows.Forms.TextBox();
            this.tbxFirstNameRegister = new System.Windows.Forms.TextBox();
            this.tbxStudentNumRegister = new System.Windows.Forms.TextBox();
            this.lbPasswordRegister = new System.Windows.Forms.Label();
            this.lbFirstNameRegister = new System.Windows.Forms.Label();
            this.lbStudentNumRegister = new System.Windows.Forms.Label();
            this.MenuTenant = new System.Windows.Forms.TabControl();
            this.tabHomeTenant = new System.Windows.Forms.TabPage();
            this.btnLogOutTenant = new System.Windows.Forms.Button();
            this.lbWelcomeMsgTenant = new System.Windows.Forms.Label();
            this.tabGroceriesTenant = new System.Windows.Forms.TabPage();
            this.gbxPayListGroceriesTenant = new System.Windows.Forms.GroupBox();
            this.lbxUnpaidGroceries = new System.Windows.Forms.ListBox();
            this.tabAnnouncementsTenant = new System.Windows.Forms.TabPage();
            this.gbxNewsFeedTenant = new System.Windows.Forms.GroupBox();
            this.lbxUserAllAnnouncements = new System.Windows.Forms.ListBox();
            this.lblAllAnnouncementTenant = new System.Windows.Forms.Label();
            this.tabAgreementsTenant = new System.Windows.Forms.TabPage();
            this.gbxAllAgreements = new System.Windows.Forms.GroupBox();
            this.btnDisagree = new System.Windows.Forms.Button();
            this.btnAgree = new System.Windows.Forms.Button();
            this.lbxAllAgreementsTenant = new System.Windows.Forms.ListBox();
            this.lblAllAgreementsTenant = new System.Windows.Forms.Label();
            this.gbxAddAgreement = new System.Windows.Forms.GroupBox();
            this.btnAddAgreement = new System.Windows.Forms.Button();
            this.tbxAddAgreement = new System.Windows.Forms.TextBox();
            this.lbWriteAgreement = new System.Windows.Forms.Label();
            this.tabHouseRulesTenant = new System.Windows.Forms.TabPage();
            this.gbxHouseRulseTenant = new System.Windows.Forms.GroupBox();
            this.lbxRulesTenant = new System.Windows.Forms.ListBox();
            this.tabComplaintsTenant = new System.Windows.Forms.TabPage();
            this.btnComplaint = new System.Windows.Forms.Button();
            this.tbxWriteComplaint = new System.Windows.Forms.TextBox();
            this.lbWriteComplaint = new System.Windows.Forms.Label();
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxPasswordLogin = new System.Windows.Forms.TextBox();
            this.tbxUsernameLogin = new System.Windows.Forms.TextBox();
            this.lbPasswordLogin = new System.Windows.Forms.Label();
            this.lbUsernameLogin = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.MenuAdmin.SuspendLayout();
            this.tabHomeAdmin.SuspendLayout();
            this.tabGroceriesAdmin.SuspendLayout();
            this.gbxPayListGroceries.SuspendLayout();
            this.gbxAddGrocery.SuspendLayout();
            this.gbxGroceriesAdmin.SuspendLayout();
            this.tabAnnouncementsAdmin.SuspendLayout();
            this.gbxPostAnnouncements.SuspendLayout();
            this.gbxNewsFeed.SuspendLayout();
            this.tabAgreementsAdmin.SuspendLayout();
            this.tabHouseRulesAdmin.SuspendLayout();
            this.gbxRule.SuspendLayout();
            this.gbxRules.SuspendLayout();
            this.tabComplaintsAdmin.SuspendLayout();
            this.gbxAllComplaints.SuspendLayout();
            this.tabManageTenants.SuspendLayout();
            this.gbxEditTenant.SuspendLayout();
            this.gbxSearchTenantEdit.SuspendLayout();
            this.gbxRemoveTenant.SuspendLayout();
            this.gbxRegisterTenants.SuspendLayout();
            this.MenuTenant.SuspendLayout();
            this.tabHomeTenant.SuspendLayout();
            this.tabGroceriesTenant.SuspendLayout();
            this.gbxPayListGroceriesTenant.SuspendLayout();
            this.tabAnnouncementsTenant.SuspendLayout();
            this.gbxNewsFeedTenant.SuspendLayout();
            this.tabAgreementsTenant.SuspendLayout();
            this.gbxAllAgreements.SuspendLayout();
            this.gbxAddAgreement.SuspendLayout();
            this.tabHouseRulesTenant.SuspendLayout();
            this.gbxHouseRulseTenant.SuspendLayout();
            this.tabComplaintsTenant.SuspendLayout();
            this.gbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuAdmin
            // 
            this.MenuAdmin.Controls.Add(this.tabHomeAdmin);
            this.MenuAdmin.Controls.Add(this.tabGroceriesAdmin);
            this.MenuAdmin.Controls.Add(this.tabAnnouncementsAdmin);
            this.MenuAdmin.Controls.Add(this.tabAgreementsAdmin);
            this.MenuAdmin.Controls.Add(this.tabHouseRulesAdmin);
            this.MenuAdmin.Controls.Add(this.tabComplaintsAdmin);
            this.MenuAdmin.Controls.Add(this.tabManageTenants);
            this.MenuAdmin.Location = new System.Drawing.Point(11, 199);
            this.MenuAdmin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MenuAdmin.Name = "MenuAdmin";
            this.MenuAdmin.SelectedIndex = 0;
            this.MenuAdmin.Size = new System.Drawing.Size(687, 486);
            this.MenuAdmin.TabIndex = 0;
            // 
            // tabHomeAdmin
            // 
            this.tabHomeAdmin.Controls.Add(this.lblDate);
            this.tabHomeAdmin.Controls.Add(this.lbTime);
            this.tabHomeAdmin.Controls.Add(this.lbWelcomeMsgAdmin);
            this.tabHomeAdmin.Controls.Add(this.btnLogOutAdmin);
            this.tabHomeAdmin.ImageKey = "(none)";
            this.tabHomeAdmin.Location = new System.Drawing.Point(4, 26);
            this.tabHomeAdmin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabHomeAdmin.Name = "tabHomeAdmin";
            this.tabHomeAdmin.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabHomeAdmin.Size = new System.Drawing.Size(679, 456);
            this.tabHomeAdmin.TabIndex = 0;
            this.tabHomeAdmin.Text = "Home";
            this.tabHomeAdmin.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(79, 150);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(75, 130);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(60, 25);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Time";
            // 
            // lbWelcomeMsgAdmin
            // 
            this.lbWelcomeMsgAdmin.AutoSize = true;
            this.lbWelcomeMsgAdmin.Location = new System.Drawing.Point(67, 68);
            this.lbWelcomeMsgAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcomeMsgAdmin.Name = "lbWelcomeMsgAdmin";
            this.lbWelcomeMsgAdmin.Size = new System.Drawing.Size(74, 17);
            this.lbWelcomeMsgAdmin.TabIndex = 0;
            this.lbWelcomeMsgAdmin.Text = "Welcome, ";
            // 
            // btnLogOutAdmin
            // 
            this.btnLogOutAdmin.Location = new System.Drawing.Point(5, 397);
            this.btnLogOutAdmin.Name = "btnLogOutAdmin";
            this.btnLogOutAdmin.Size = new System.Drawing.Size(78, 31);
            this.btnLogOutAdmin.TabIndex = 3;
            this.btnLogOutAdmin.Text = "Log out";
            this.btnLogOutAdmin.UseVisualStyleBackColor = true;
            this.btnLogOutAdmin.Click += new System.EventHandler(this.btnLogOutAdmin_Click);
            // 
            // tabGroceriesAdmin
            // 
            this.tabGroceriesAdmin.Controls.Add(this.gbxPayListGroceries);
            this.tabGroceriesAdmin.Controls.Add(this.gbxAddGrocery);
            this.tabGroceriesAdmin.Controls.Add(this.gbxGroceriesAdmin);
            this.tabGroceriesAdmin.Location = new System.Drawing.Point(4, 26);
            this.tabGroceriesAdmin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabGroceriesAdmin.Name = "tabGroceriesAdmin";
            this.tabGroceriesAdmin.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabGroceriesAdmin.Size = new System.Drawing.Size(679, 456);
            this.tabGroceriesAdmin.TabIndex = 1;
            this.tabGroceriesAdmin.Text = "Groceries";
            this.tabGroceriesAdmin.UseVisualStyleBackColor = true;
            // 
            // gbxPayListGroceries
            // 
            this.gbxPayListGroceries.Controls.Add(this.btnClsSelectLinePayListGroceries);
            this.gbxPayListGroceries.Controls.Add(this.btnMarkAllAsPaid);
            this.gbxPayListGroceries.Controls.Add(this.btnMarkSelectedAsPaid);
            this.gbxPayListGroceries.Controls.Add(this.lbxUnpaidGroceriesPerStudent);
            this.gbxPayListGroceries.Controls.Add(this.tbxStudNumUnpaidItems);
            this.gbxPayListGroceries.Controls.Add(this.btnShowToPayList);
            this.gbxPayListGroceries.Controls.Add(this.lbStudNumUnpaidItems);
            this.gbxPayListGroceries.Location = new System.Drawing.Point(313, 13);
            this.gbxPayListGroceries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxPayListGroceries.Name = "gbxPayListGroceries";
            this.gbxPayListGroceries.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxPayListGroceries.Size = new System.Drawing.Size(343, 428);
            this.gbxPayListGroceries.TabIndex = 4;
            this.gbxPayListGroceries.TabStop = false;
            this.gbxPayListGroceries.Text = "Pay list groceries";
            // 
            // btnClsSelectLinePayListGroceries
            // 
            this.btnClsSelectLinePayListGroceries.Location = new System.Drawing.Point(128, 328);
            this.btnClsSelectLinePayListGroceries.Name = "btnClsSelectLinePayListGroceries";
            this.btnClsSelectLinePayListGroceries.Size = new System.Drawing.Size(107, 26);
            this.btnClsSelectLinePayListGroceries.TabIndex = 5;
            this.btnClsSelectLinePayListGroceries.Text = "Clear selected";
            this.btnClsSelectLinePayListGroceries.UseVisualStyleBackColor = true;
            this.btnClsSelectLinePayListGroceries.Click += new System.EventHandler(this.btnClsSelectLinePayListGroceries_Click);
            // 
            // btnMarkAllAsPaid
            // 
            this.btnMarkAllAsPaid.Location = new System.Drawing.Point(201, 384);
            this.btnMarkAllAsPaid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMarkAllAsPaid.Name = "btnMarkAllAsPaid";
            this.btnMarkAllAsPaid.Size = new System.Drawing.Size(113, 26);
            this.btnMarkAllAsPaid.TabIndex = 4;
            this.btnMarkAllAsPaid.Text = "Mark all as paid";
            this.btnMarkAllAsPaid.UseVisualStyleBackColor = true;
            this.btnMarkAllAsPaid.Click += new System.EventHandler(this.btnMarkAllAsPaid_Click);
            // 
            // btnMarkSelectedAsPaid
            // 
            this.btnMarkSelectedAsPaid.Location = new System.Drawing.Point(27, 384);
            this.btnMarkSelectedAsPaid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMarkSelectedAsPaid.Name = "btnMarkSelectedAsPaid";
            this.btnMarkSelectedAsPaid.Size = new System.Drawing.Size(135, 26);
            this.btnMarkSelectedAsPaid.TabIndex = 4;
            this.btnMarkSelectedAsPaid.Text = "Mark selected as paid";
            this.btnMarkSelectedAsPaid.UseVisualStyleBackColor = true;
            this.btnMarkSelectedAsPaid.Click += new System.EventHandler(this.btnMarkSelectedAsPaid_Click);
            // 
            // lbxUnpaidGroceriesPerStudent
            // 
            this.lbxUnpaidGroceriesPerStudent.FormattingEnabled = true;
            this.lbxUnpaidGroceriesPerStudent.ItemHeight = 17;
            this.lbxUnpaidGroceriesPerStudent.Location = new System.Drawing.Point(27, 90);
            this.lbxUnpaidGroceriesPerStudent.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbxUnpaidGroceriesPerStudent.Name = "lbxUnpaidGroceriesPerStudent";
            this.lbxUnpaidGroceriesPerStudent.Size = new System.Drawing.Size(289, 225);
            this.lbxUnpaidGroceriesPerStudent.TabIndex = 3;
            // 
            // tbxStudNumUnpaidItems
            // 
            this.tbxStudNumUnpaidItems.Location = new System.Drawing.Point(109, 43);
            this.tbxStudNumUnpaidItems.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxStudNumUnpaidItems.Name = "tbxStudNumUnpaidItems";
            this.tbxStudNumUnpaidItems.Size = new System.Drawing.Size(96, 23);
            this.tbxStudNumUnpaidItems.TabIndex = 2;
            // 
            // btnShowToPayList
            // 
            this.btnShowToPayList.Location = new System.Drawing.Point(216, 39);
            this.btnShowToPayList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnShowToPayList.Name = "btnShowToPayList";
            this.btnShowToPayList.Size = new System.Drawing.Size(115, 25);
            this.btnShowToPayList.TabIndex = 1;
            this.btnShowToPayList.Text = "Show to-pay list";
            this.btnShowToPayList.UseVisualStyleBackColor = true;
            this.btnShowToPayList.Click += new System.EventHandler(this.btnShowToPayList_Click);
            // 
            // lbStudNumUnpaidItems
            // 
            this.lbStudNumUnpaidItems.AutoSize = true;
            this.lbStudNumUnpaidItems.Location = new System.Drawing.Point(11, 43);
            this.lbStudNumUnpaidItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudNumUnpaidItems.Name = "lbStudNumUnpaidItems";
            this.lbStudNumUnpaidItems.Size = new System.Drawing.Size(113, 17);
            this.lbStudNumUnpaidItems.TabIndex = 0;
            this.lbStudNumUnpaidItems.Text = "Student number:";
            // 
            // gbxAddGrocery
            // 
            this.gbxAddGrocery.Controls.Add(this.tbxGroceryPrice);
            this.gbxAddGrocery.Controls.Add(this.lbGroceryPrice);
            this.gbxAddGrocery.Controls.Add(this.btnAddGrocery);
            this.gbxAddGrocery.Controls.Add(this.tbxGroceryName);
            this.gbxAddGrocery.Controls.Add(this.lbGroceryName);
            this.gbxAddGrocery.Location = new System.Drawing.Point(24, 13);
            this.gbxAddGrocery.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxAddGrocery.Name = "gbxAddGrocery";
            this.gbxAddGrocery.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxAddGrocery.Size = new System.Drawing.Size(231, 124);
            this.gbxAddGrocery.TabIndex = 3;
            this.gbxAddGrocery.TabStop = false;
            this.gbxAddGrocery.Text = "Add groceries";
            // 
            // tbxGroceryPrice
            // 
            this.tbxGroceryPrice.Location = new System.Drawing.Point(83, 52);
            this.tbxGroceryPrice.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxGroceryPrice.Name = "tbxGroceryPrice";
            this.tbxGroceryPrice.Size = new System.Drawing.Size(90, 23);
            this.tbxGroceryPrice.TabIndex = 4;
            // 
            // lbGroceryPrice
            // 
            this.lbGroceryPrice.AutoSize = true;
            this.lbGroceryPrice.Location = new System.Drawing.Point(29, 54);
            this.lbGroceryPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGroceryPrice.Name = "lbGroceryPrice";
            this.lbGroceryPrice.Size = new System.Drawing.Size(44, 17);
            this.lbGroceryPrice.TabIndex = 3;
            this.lbGroceryPrice.Text = "Price:";
            // 
            // btnAddGrocery
            // 
            this.btnAddGrocery.Location = new System.Drawing.Point(83, 90);
            this.btnAddGrocery.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddGrocery.Name = "btnAddGrocery";
            this.btnAddGrocery.Size = new System.Drawing.Size(90, 23);
            this.btnAddGrocery.TabIndex = 2;
            this.btnAddGrocery.Text = "Add grocery";
            this.btnAddGrocery.UseVisualStyleBackColor = true;
            this.btnAddGrocery.Click += new System.EventHandler(this.btnAddGrocery_Click);
            // 
            // tbxGroceryName
            // 
            this.tbxGroceryName.Location = new System.Drawing.Point(83, 25);
            this.tbxGroceryName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxGroceryName.Name = "tbxGroceryName";
            this.tbxGroceryName.Size = new System.Drawing.Size(90, 23);
            this.tbxGroceryName.TabIndex = 1;
            // 
            // lbGroceryName
            // 
            this.lbGroceryName.AutoSize = true;
            this.lbGroceryName.Location = new System.Drawing.Point(29, 25);
            this.lbGroceryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGroceryName.Name = "lbGroceryName";
            this.lbGroceryName.Size = new System.Drawing.Size(49, 17);
            this.lbGroceryName.TabIndex = 0;
            this.lbGroceryName.Text = "Name:";
            // 
            // gbxGroceriesAdmin
            // 
            this.gbxGroceriesAdmin.Controls.Add(this.btnClsSelectedLineRecentGroceries);
            this.gbxGroceriesAdmin.Controls.Add(this.btnRemoveAllGroceries);
            this.gbxGroceriesAdmin.Controls.Add(this.btnRemoveSelectedGrocery);
            this.gbxGroceriesAdmin.Controls.Add(this.lbxRecentGroceries);
            this.gbxGroceriesAdmin.Controls.Add(this.lbRecentGroceries);
            this.gbxGroceriesAdmin.Location = new System.Drawing.Point(24, 139);
            this.gbxGroceriesAdmin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxGroceriesAdmin.Name = "gbxGroceriesAdmin";
            this.gbxGroceriesAdmin.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxGroceriesAdmin.Size = new System.Drawing.Size(231, 312);
            this.gbxGroceriesAdmin.TabIndex = 2;
            this.gbxGroceriesAdmin.TabStop = false;
            // 
            // btnClsSelectedLineRecentGroceries
            // 
            this.btnClsSelectedLineRecentGroceries.Location = new System.Drawing.Point(66, 228);
            this.btnClsSelectedLineRecentGroceries.Name = "btnClsSelectedLineRecentGroceries";
            this.btnClsSelectedLineRecentGroceries.Size = new System.Drawing.Size(107, 26);
            this.btnClsSelectedLineRecentGroceries.TabIndex = 6;
            this.btnClsSelectedLineRecentGroceries.Text = "Clear selected";
            this.btnClsSelectedLineRecentGroceries.UseVisualStyleBackColor = true;
            this.btnClsSelectedLineRecentGroceries.Click += new System.EventHandler(this.btnClsSelectedLineRecentGroceries_Click);
            // 
            // btnRemoveAllGroceries
            // 
            this.btnRemoveAllGroceries.Location = new System.Drawing.Point(130, 276);
            this.btnRemoveAllGroceries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRemoveAllGroceries.Name = "btnRemoveAllGroceries";
            this.btnRemoveAllGroceries.Size = new System.Drawing.Size(97, 26);
            this.btnRemoveAllGroceries.TabIndex = 3;
            this.btnRemoveAllGroceries.Text = "Remove all";
            this.btnRemoveAllGroceries.UseVisualStyleBackColor = true;
            this.btnRemoveAllGroceries.Click += new System.EventHandler(this.btnRemoveAllGroceries_Click);
            // 
            // btnRemoveSelectedGrocery
            // 
            this.btnRemoveSelectedGrocery.Location = new System.Drawing.Point(4, 276);
            this.btnRemoveSelectedGrocery.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRemoveSelectedGrocery.Name = "btnRemoveSelectedGrocery";
            this.btnRemoveSelectedGrocery.Size = new System.Drawing.Size(105, 26);
            this.btnRemoveSelectedGrocery.TabIndex = 2;
            this.btnRemoveSelectedGrocery.Text = "Remove selected";
            this.btnRemoveSelectedGrocery.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedGrocery.Click += new System.EventHandler(this.btnRemoveSelectedGrocery_Click);
            // 
            // lbxRecentGroceries
            // 
            this.lbxRecentGroceries.FormattingEnabled = true;
            this.lbxRecentGroceries.ItemHeight = 17;
            this.lbxRecentGroceries.Location = new System.Drawing.Point(41, 40);
            this.lbxRecentGroceries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbxRecentGroceries.Name = "lbxRecentGroceries";
            this.lbxRecentGroceries.Size = new System.Drawing.Size(156, 157);
            this.lbxRecentGroceries.TabIndex = 0;
            // 
            // lbRecentGroceries
            // 
            this.lbRecentGroceries.AutoSize = true;
            this.lbRecentGroceries.Location = new System.Drawing.Point(71, 16);
            this.lbRecentGroceries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecentGroceries.Name = "lbRecentGroceries";
            this.lbRecentGroceries.Size = new System.Drawing.Size(116, 17);
            this.lbRecentGroceries.TabIndex = 1;
            this.lbRecentGroceries.Text = "Recent groceries";
            // 
            // tabAnnouncementsAdmin
            // 
            this.tabAnnouncementsAdmin.Controls.Add(this.gbxPostAnnouncements);
            this.tabAnnouncementsAdmin.Controls.Add(this.gbxNewsFeed);
            this.tabAnnouncementsAdmin.Location = new System.Drawing.Point(4, 26);
            this.tabAnnouncementsAdmin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabAnnouncementsAdmin.Name = "tabAnnouncementsAdmin";
            this.tabAnnouncementsAdmin.Size = new System.Drawing.Size(679, 456);
            this.tabAnnouncementsAdmin.TabIndex = 2;
            this.tabAnnouncementsAdmin.Text = "Announcements";
            this.tabAnnouncementsAdmin.UseVisualStyleBackColor = true;
            // 
            // gbxPostAnnouncements
            // 
            this.gbxPostAnnouncements.Controls.Add(this.btnPostAnnouncement);
            this.gbxPostAnnouncements.Controls.Add(this.tbxPostAnnouncement);
            this.gbxPostAnnouncements.Controls.Add(this.lbWriteMessage);
            this.gbxPostAnnouncements.Location = new System.Drawing.Point(351, 38);
            this.gbxPostAnnouncements.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxPostAnnouncements.Name = "gbxPostAnnouncements";
            this.gbxPostAnnouncements.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxPostAnnouncements.Size = new System.Drawing.Size(286, 279);
            this.gbxPostAnnouncements.TabIndex = 3;
            this.gbxPostAnnouncements.TabStop = false;
            this.gbxPostAnnouncements.Text = "Post an announcement";
            // 
            // btnPostAnnouncement
            // 
            this.btnPostAnnouncement.Location = new System.Drawing.Point(85, 227);
            this.btnPostAnnouncement.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPostAnnouncement.Name = "btnPostAnnouncement";
            this.btnPostAnnouncement.Size = new System.Drawing.Size(121, 32);
            this.btnPostAnnouncement.TabIndex = 2;
            this.btnPostAnnouncement.Text = "Post";
            this.btnPostAnnouncement.UseVisualStyleBackColor = true;
            this.btnPostAnnouncement.Click += new System.EventHandler(this.btnPostAnnouncement_Click);
            // 
            // tbxPostAnnouncement
            // 
            this.tbxPostAnnouncement.Location = new System.Drawing.Point(33, 66);
            this.tbxPostAnnouncement.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxPostAnnouncement.Multiline = true;
            this.tbxPostAnnouncement.Name = "tbxPostAnnouncement";
            this.tbxPostAnnouncement.Size = new System.Drawing.Size(228, 146);
            this.tbxPostAnnouncement.TabIndex = 1;
            // 
            // lbWriteMessage
            // 
            this.lbWriteMessage.AutoSize = true;
            this.lbWriteMessage.Location = new System.Drawing.Point(79, 38);
            this.lbWriteMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWriteMessage.Name = "lbWriteMessage";
            this.lbWriteMessage.Size = new System.Drawing.Size(171, 17);
            this.lbWriteMessage.TabIndex = 0;
            this.lbWriteMessage.Text = "Write down your message";
            // 
            // gbxNewsFeed
            // 
            this.gbxNewsFeed.Controls.Add(this.btndeleteAnnouncement);
            this.gbxNewsFeed.Controls.Add(this.lbxAllAnnouncements);
            this.gbxNewsFeed.Controls.Add(this.lbAllAnnouncements);
            this.gbxNewsFeed.Location = new System.Drawing.Point(25, 20);
            this.gbxNewsFeed.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxNewsFeed.Name = "gbxNewsFeed";
            this.gbxNewsFeed.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxNewsFeed.Size = new System.Drawing.Size(283, 417);
            this.gbxNewsFeed.TabIndex = 2;
            this.gbxNewsFeed.TabStop = false;
            this.gbxNewsFeed.Text = "News feed";
            // 
            // btndeleteAnnouncement
            // 
            this.btndeleteAnnouncement.Location = new System.Drawing.Point(111, 388);
            this.btndeleteAnnouncement.Margin = new System.Windows.Forms.Padding(2);
            this.btndeleteAnnouncement.Name = "btndeleteAnnouncement";
            this.btndeleteAnnouncement.Size = new System.Drawing.Size(56, 19);
            this.btndeleteAnnouncement.TabIndex = 2;
            this.btndeleteAnnouncement.Text = "Delete";
            this.btndeleteAnnouncement.UseVisualStyleBackColor = true;
            this.btndeleteAnnouncement.Click += new System.EventHandler(this.btndeleteAnnouncement_Click);
            // 
            // lbxAllAnnouncements
            // 
            this.lbxAllAnnouncements.FormattingEnabled = true;
            this.lbxAllAnnouncements.ItemHeight = 17;
            this.lbxAllAnnouncements.Location = new System.Drawing.Point(29, 68);
            this.lbxAllAnnouncements.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbxAllAnnouncements.Name = "lbxAllAnnouncements";
            this.lbxAllAnnouncements.Size = new System.Drawing.Size(231, 310);
            this.lbxAllAnnouncements.TabIndex = 0;
            // 
            // lbAllAnnouncements
            // 
            this.lbAllAnnouncements.AutoSize = true;
            this.lbAllAnnouncements.Location = new System.Drawing.Point(92, 40);
            this.lbAllAnnouncements.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAllAnnouncements.Name = "lbAllAnnouncements";
            this.lbAllAnnouncements.Size = new System.Drawing.Size(128, 17);
            this.lbAllAnnouncements.TabIndex = 1;
            this.lbAllAnnouncements.Text = "All announcements";
            // 
            // tabAgreementsAdmin
            // 
            this.tabAgreementsAdmin.Controls.Add(this.lbxAllAgreementsAdmin);
            this.tabAgreementsAdmin.Controls.Add(this.lbAllAgreementsAdmin);
            this.tabAgreementsAdmin.Location = new System.Drawing.Point(4, 26);
            this.tabAgreementsAdmin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabAgreementsAdmin.Name = "tabAgreementsAdmin";
            this.tabAgreementsAdmin.Size = new System.Drawing.Size(679, 456);
            this.tabAgreementsAdmin.TabIndex = 3;
            this.tabAgreementsAdmin.Text = "Agreements";
            this.tabAgreementsAdmin.UseVisualStyleBackColor = true;
            // 
            // lbxAllAgreementsAdmin
            // 
            this.lbxAllAgreementsAdmin.FormattingEnabled = true;
            this.lbxAllAgreementsAdmin.HorizontalScrollbar = true;
            this.lbxAllAgreementsAdmin.ItemHeight = 17;
            this.lbxAllAgreementsAdmin.Location = new System.Drawing.Point(203, 87);
            this.lbxAllAgreementsAdmin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbxAllAgreementsAdmin.Name = "lbxAllAgreementsAdmin";
            this.lbxAllAgreementsAdmin.Size = new System.Drawing.Size(231, 310);
            this.lbxAllAgreementsAdmin.TabIndex = 0;
            // 
            // lbAllAgreementsAdmin
            // 
            this.lbAllAgreementsAdmin.AutoSize = true;
            this.lbAllAgreementsAdmin.Location = new System.Drawing.Point(266, 60);
            this.lbAllAgreementsAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAllAgreementsAdmin.Name = "lbAllAgreementsAdmin";
            this.lbAllAgreementsAdmin.Size = new System.Drawing.Size(102, 17);
            this.lbAllAgreementsAdmin.TabIndex = 1;
            this.lbAllAgreementsAdmin.Text = "All agreements";
            // 
            // tabHouseRulesAdmin
            // 
            this.tabHouseRulesAdmin.Controls.Add(this.btnEditRule);
            this.tabHouseRulesAdmin.Controls.Add(this.btnDeleteRule);
            this.tabHouseRulesAdmin.Controls.Add(this.gbxRule);
            this.tabHouseRulesAdmin.Controls.Add(this.gbxRules);
            this.tabHouseRulesAdmin.Location = new System.Drawing.Point(4, 26);
            this.tabHouseRulesAdmin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabHouseRulesAdmin.Name = "tabHouseRulesAdmin";
            this.tabHouseRulesAdmin.Size = new System.Drawing.Size(679, 456);
            this.tabHouseRulesAdmin.TabIndex = 4;
            this.tabHouseRulesAdmin.Text = "House Rules";
            this.tabHouseRulesAdmin.UseVisualStyleBackColor = true;
            // 
            // gbxRule
            // 
            this.gbxRule.Controls.Add(this.btnAddRule);
            this.gbxRule.Controls.Add(this.tbxAddRule);
            this.gbxRule.Controls.Add(this.lbWriteRule);
            this.gbxRule.Location = new System.Drawing.Point(308, 6);
            this.gbxRule.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxRule.Name = "gbxRule";
            this.gbxRule.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxRule.Size = new System.Drawing.Size(265, 240);
            this.gbxRule.TabIndex = 5;
            this.gbxRule.TabStop = false;
            this.gbxRule.Text = "Add rule";
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(83, 204);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(121, 32);
            this.btnAddRule.TabIndex = 2;
            this.btnAddRule.Text = "Add";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // tbxAddRule
            // 
            this.tbxAddRule.Location = new System.Drawing.Point(64, 37);
            this.tbxAddRule.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxAddRule.Multiline = true;
            this.tbxAddRule.Name = "tbxAddRule";
            this.tbxAddRule.Size = new System.Drawing.Size(165, 146);
            this.tbxAddRule.TabIndex = 1;
            // 
            // lbWriteRule
            // 
            this.lbWriteRule.AutoSize = true;
            this.lbWriteRule.Location = new System.Drawing.Point(77, 15);
            this.lbWriteRule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWriteRule.Name = "lbWriteRule";
            this.lbWriteRule.Size = new System.Drawing.Size(147, 17);
            this.lbWriteRule.TabIndex = 0;
            this.lbWriteRule.Text = "Write down a new rule";
            // 
            // gbxRules
            // 
            this.gbxRules.Controls.Add(this.lbxRulesAdmin);
            this.gbxRules.Location = new System.Drawing.Point(24, 70);
            this.gbxRules.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxRules.Name = "gbxRules";
            this.gbxRules.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxRules.Size = new System.Drawing.Size(268, 342);
            this.gbxRules.TabIndex = 4;
            this.gbxRules.TabStop = false;
            this.gbxRules.Text = "House rules";
            // 
            // lbxRulesAdmin
            // 
            this.lbxRulesAdmin.FormattingEnabled = true;
            this.lbxRulesAdmin.ItemHeight = 17;
            this.lbxRulesAdmin.Location = new System.Drawing.Point(19, 40);
            this.lbxRulesAdmin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbxRulesAdmin.Name = "lbxRulesAdmin";
            this.lbxRulesAdmin.Size = new System.Drawing.Size(231, 276);
            this.lbxRulesAdmin.TabIndex = 0;
            // 
            // tabComplaintsAdmin
            // 
            this.tabComplaintsAdmin.Controls.Add(this.btnMarkAsDone);
            this.tabComplaintsAdmin.Controls.Add(this.gbxAllComplaints);
            this.tabComplaintsAdmin.Location = new System.Drawing.Point(4, 26);
            this.tabComplaintsAdmin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabComplaintsAdmin.Name = "tabComplaintsAdmin";
            this.tabComplaintsAdmin.Size = new System.Drawing.Size(679, 456);
            this.tabComplaintsAdmin.TabIndex = 5;
            this.tabComplaintsAdmin.Text = "Complaints";
            this.tabComplaintsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnMarkAsDone
            // 
            this.btnMarkAsDone.Location = new System.Drawing.Point(194, 407);
            this.btnMarkAsDone.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMarkAsDone.Name = "btnMarkAsDone";
            this.btnMarkAsDone.Size = new System.Drawing.Size(277, 19);
            this.btnMarkAsDone.TabIndex = 4;
            this.btnMarkAsDone.Text = "Mark the selected complaint as done";
            this.btnMarkAsDone.UseVisualStyleBackColor = true;
            this.btnMarkAsDone.Click += new System.EventHandler(this.btnMarkAsDone_Click);
            // 
            // gbxAllComplaints
            // 
            this.gbxAllComplaints.Controls.Add(this.lbxAllComplaints);
            this.gbxAllComplaints.Location = new System.Drawing.Point(194, 53);
            this.gbxAllComplaints.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxAllComplaints.Name = "gbxAllComplaints";
            this.gbxAllComplaints.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxAllComplaints.Size = new System.Drawing.Size(277, 350);
            this.gbxAllComplaints.TabIndex = 3;
            this.gbxAllComplaints.TabStop = false;
            this.gbxAllComplaints.Text = "All complaints";
            // 
            // lbxAllComplaints
            // 
            this.lbxAllComplaints.FormattingEnabled = true;
            this.lbxAllComplaints.HorizontalScrollbar = true;
            this.lbxAllComplaints.ItemHeight = 17;
            this.lbxAllComplaints.Location = new System.Drawing.Point(21, 49);
            this.lbxAllComplaints.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbxAllComplaints.Name = "lbxAllComplaints";
            this.lbxAllComplaints.Size = new System.Drawing.Size(231, 225);
            this.lbxAllComplaints.TabIndex = 0;
            // 
            // tabManageTenants
            // 
            this.tabManageTenants.Controls.Add(this.gbxEditTenant);
            this.tabManageTenants.Controls.Add(this.gbxSearchTenantEdit);
            this.tabManageTenants.Controls.Add(this.gbxRemoveTenant);
            this.tabManageTenants.Controls.Add(this.gbxRegisterTenants);
            this.tabManageTenants.Location = new System.Drawing.Point(4, 26);
            this.tabManageTenants.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabManageTenants.Name = "tabManageTenants";
            this.tabManageTenants.Size = new System.Drawing.Size(679, 456);
            this.tabManageTenants.TabIndex = 6;
            this.tabManageTenants.Text = "Manage Tenants";
            this.tabManageTenants.UseVisualStyleBackColor = true;
            // 
            // gbxEditTenant
            // 
            this.gbxEditTenant.Controls.Add(this.tbxEditPasswordTenant);
            this.gbxEditTenant.Controls.Add(this.btnSaveChangesEditTenantProfile);
            this.gbxEditTenant.Controls.Add(this.lbEditFNameTenant);
            this.gbxEditTenant.Controls.Add(this.lbEditPasswordTenant);
            this.gbxEditTenant.Controls.Add(this.tbxEditFNameTenant);
            this.gbxEditTenant.Location = new System.Drawing.Point(346, 307);
            this.gbxEditTenant.Name = "gbxEditTenant";
            this.gbxEditTenant.Size = new System.Drawing.Size(301, 142);
            this.gbxEditTenant.TabIndex = 14;
            this.gbxEditTenant.TabStop = false;
            this.gbxEditTenant.Text = "Edit profile";
            // 
            // tbxEditPasswordTenant
            // 
            this.tbxEditPasswordTenant.Location = new System.Drawing.Point(124, 56);
            this.tbxEditPasswordTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxEditPasswordTenant.Name = "tbxEditPasswordTenant";
            this.tbxEditPasswordTenant.Size = new System.Drawing.Size(115, 23);
            this.tbxEditPasswordTenant.TabIndex = 8;
            // 
            // btnSaveChangesEditTenantProfile
            // 
            this.btnSaveChangesEditTenantProfile.Location = new System.Drawing.Point(124, 93);
            this.btnSaveChangesEditTenantProfile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSaveChangesEditTenantProfile.Name = "btnSaveChangesEditTenantProfile";
            this.btnSaveChangesEditTenantProfile.Size = new System.Drawing.Size(114, 26);
            this.btnSaveChangesEditTenantProfile.TabIndex = 13;
            this.btnSaveChangesEditTenantProfile.Text = "Save changes";
            this.btnSaveChangesEditTenantProfile.UseVisualStyleBackColor = true;
            this.btnSaveChangesEditTenantProfile.Click += new System.EventHandler(this.btnSaveChangesEditTenantProfile_Click);
            // 
            // lbEditFNameTenant
            // 
            this.lbEditFNameTenant.AutoSize = true;
            this.lbEditFNameTenant.Location = new System.Drawing.Point(49, 22);
            this.lbEditFNameTenant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEditFNameTenant.Name = "lbEditFNameTenant";
            this.lbEditFNameTenant.Size = new System.Drawing.Size(78, 17);
            this.lbEditFNameTenant.TabIndex = 11;
            this.lbEditFNameTenant.Text = "First name:";
            // 
            // lbEditPasswordTenant
            // 
            this.lbEditPasswordTenant.AutoSize = true;
            this.lbEditPasswordTenant.Location = new System.Drawing.Point(51, 61);
            this.lbEditPasswordTenant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEditPasswordTenant.Name = "lbEditPasswordTenant";
            this.lbEditPasswordTenant.Size = new System.Drawing.Size(73, 17);
            this.lbEditPasswordTenant.TabIndex = 7;
            this.lbEditPasswordTenant.Text = "Password:";
            // 
            // tbxEditFNameTenant
            // 
            this.tbxEditFNameTenant.Location = new System.Drawing.Point(124, 19);
            this.tbxEditFNameTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxEditFNameTenant.Name = "tbxEditFNameTenant";
            this.tbxEditFNameTenant.Size = new System.Drawing.Size(115, 23);
            this.tbxEditFNameTenant.TabIndex = 12;
            // 
            // gbxSearchTenantEdit
            // 
            this.gbxSearchTenantEdit.Controls.Add(this.btnShowTenantProfileEdit);
            this.gbxSearchTenantEdit.Controls.Add(this.tbxStudNumSearchTenantEdit);
            this.gbxSearchTenantEdit.Controls.Add(this.lbStudNumSearchTenantEdit);
            this.gbxSearchTenantEdit.Location = new System.Drawing.Point(346, 176);
            this.gbxSearchTenantEdit.Name = "gbxSearchTenantEdit";
            this.gbxSearchTenantEdit.Size = new System.Drawing.Size(301, 111);
            this.gbxSearchTenantEdit.TabIndex = 2;
            this.gbxSearchTenantEdit.TabStop = false;
            this.gbxSearchTenantEdit.Text = "Find a profile to edit";
            // 
            // btnShowTenantProfileEdit
            // 
            this.btnShowTenantProfileEdit.Location = new System.Drawing.Point(112, 65);
            this.btnShowTenantProfileEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnShowTenantProfileEdit.Name = "btnShowTenantProfileEdit";
            this.btnShowTenantProfileEdit.Size = new System.Drawing.Size(114, 26);
            this.btnShowTenantProfileEdit.TabIndex = 10;
            this.btnShowTenantProfileEdit.Text = "Show profile to edit";
            this.btnShowTenantProfileEdit.UseVisualStyleBackColor = true;
            this.btnShowTenantProfileEdit.Click += new System.EventHandler(this.btnShowTenantProfileEdit_Click);
            // 
            // tbxStudNumSearchTenantEdit
            // 
            this.tbxStudNumSearchTenantEdit.Location = new System.Drawing.Point(112, 29);
            this.tbxStudNumSearchTenantEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxStudNumSearchTenantEdit.Name = "tbxStudNumSearchTenantEdit";
            this.tbxStudNumSearchTenantEdit.Size = new System.Drawing.Size(115, 23);
            this.tbxStudNumSearchTenantEdit.TabIndex = 9;
            // 
            // lbStudNumSearchTenantEdit
            // 
            this.lbStudNumSearchTenantEdit.AutoSize = true;
            this.lbStudNumSearchTenantEdit.Location = new System.Drawing.Point(15, 31);
            this.lbStudNumSearchTenantEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudNumSearchTenantEdit.Name = "lbStudNumSearchTenantEdit";
            this.lbStudNumSearchTenantEdit.Size = new System.Drawing.Size(113, 17);
            this.lbStudNumSearchTenantEdit.TabIndex = 8;
            this.lbStudNumSearchTenantEdit.Text = "Student number:";
            // 
            // gbxRemoveTenant
            // 
            this.gbxRemoveTenant.Controls.Add(this.btnRemoveTenant);
            this.gbxRemoveTenant.Controls.Add(this.tbxStudentNumRemove);
            this.gbxRemoveTenant.Controls.Add(this.lbStudentNumRemove);
            this.gbxRemoveTenant.Location = new System.Drawing.Point(346, 24);
            this.gbxRemoveTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxRemoveTenant.Name = "gbxRemoveTenant";
            this.gbxRemoveTenant.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxRemoveTenant.Size = new System.Drawing.Size(301, 148);
            this.gbxRemoveTenant.TabIndex = 1;
            this.gbxRemoveTenant.TabStop = false;
            this.gbxRemoveTenant.Text = "Remove tenant";
            // 
            // btnRemoveTenant
            // 
            this.btnRemoveTenant.Location = new System.Drawing.Point(147, 87);
            this.btnRemoveTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRemoveTenant.Name = "btnRemoveTenant";
            this.btnRemoveTenant.Size = new System.Drawing.Size(114, 26);
            this.btnRemoveTenant.TabIndex = 7;
            this.btnRemoveTenant.Text = "Remove";
            this.btnRemoveTenant.UseVisualStyleBackColor = true;
            this.btnRemoveTenant.Click += new System.EventHandler(this.btnRemoveTenant_Click);
            // 
            // tbxStudentNumRemove
            // 
            this.tbxStudentNumRemove.Location = new System.Drawing.Point(147, 44);
            this.tbxStudentNumRemove.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxStudentNumRemove.Name = "tbxStudentNumRemove";
            this.tbxStudentNumRemove.Size = new System.Drawing.Size(115, 23);
            this.tbxStudentNumRemove.TabIndex = 5;
            // 
            // lbStudentNumRemove
            // 
            this.lbStudentNumRemove.AutoSize = true;
            this.lbStudentNumRemove.Location = new System.Drawing.Point(30, 48);
            this.lbStudentNumRemove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudentNumRemove.Name = "lbStudentNumRemove";
            this.lbStudentNumRemove.Size = new System.Drawing.Size(113, 17);
            this.lbStudentNumRemove.TabIndex = 4;
            this.lbStudentNumRemove.Text = "Student number:";
            // 
            // gbxRegisterTenants
            // 
            this.gbxRegisterTenants.Controls.Add(this.btnRegister);
            this.gbxRegisterTenants.Controls.Add(this.tbxPasswordRegister);
            this.gbxRegisterTenants.Controls.Add(this.tbxFirstNameRegister);
            this.gbxRegisterTenants.Controls.Add(this.tbxStudentNumRegister);
            this.gbxRegisterTenants.Controls.Add(this.lbPasswordRegister);
            this.gbxRegisterTenants.Controls.Add(this.lbFirstNameRegister);
            this.gbxRegisterTenants.Controls.Add(this.lbStudentNumRegister);
            this.gbxRegisterTenants.Location = new System.Drawing.Point(13, 24);
            this.gbxRegisterTenants.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxRegisterTenants.Name = "gbxRegisterTenants";
            this.gbxRegisterTenants.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxRegisterTenants.Size = new System.Drawing.Size(309, 322);
            this.gbxRegisterTenants.TabIndex = 0;
            this.gbxRegisterTenants.TabStop = false;
            this.gbxRegisterTenants.Text = "Register tenants";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(135, 250);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(114, 26);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbxPasswordRegister
            // 
            this.tbxPasswordRegister.Location = new System.Drawing.Point(134, 189);
            this.tbxPasswordRegister.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxPasswordRegister.Name = "tbxPasswordRegister";
            this.tbxPasswordRegister.Size = new System.Drawing.Size(115, 23);
            this.tbxPasswordRegister.TabIndex = 5;
            // 
            // tbxFirstNameRegister
            // 
            this.tbxFirstNameRegister.Location = new System.Drawing.Point(134, 135);
            this.tbxFirstNameRegister.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxFirstNameRegister.Name = "tbxFirstNameRegister";
            this.tbxFirstNameRegister.Size = new System.Drawing.Size(115, 23);
            this.tbxFirstNameRegister.TabIndex = 4;
            // 
            // tbxStudentNumRegister
            // 
            this.tbxStudentNumRegister.Location = new System.Drawing.Point(134, 77);
            this.tbxStudentNumRegister.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxStudentNumRegister.Name = "tbxStudentNumRegister";
            this.tbxStudentNumRegister.Size = new System.Drawing.Size(115, 23);
            this.tbxStudentNumRegister.TabIndex = 3;
            // 
            // lbPasswordRegister
            // 
            this.lbPasswordRegister.AutoSize = true;
            this.lbPasswordRegister.Location = new System.Drawing.Point(61, 194);
            this.lbPasswordRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPasswordRegister.Name = "lbPasswordRegister";
            this.lbPasswordRegister.Size = new System.Drawing.Size(73, 17);
            this.lbPasswordRegister.TabIndex = 2;
            this.lbPasswordRegister.Text = "Password:";
            // 
            // lbFirstNameRegister
            // 
            this.lbFirstNameRegister.AutoSize = true;
            this.lbFirstNameRegister.Location = new System.Drawing.Point(56, 138);
            this.lbFirstNameRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstNameRegister.Name = "lbFirstNameRegister";
            this.lbFirstNameRegister.Size = new System.Drawing.Size(78, 17);
            this.lbFirstNameRegister.TabIndex = 1;
            this.lbFirstNameRegister.Text = "First name:";
            // 
            // lbStudentNumRegister
            // 
            this.lbStudentNumRegister.AutoSize = true;
            this.lbStudentNumRegister.Location = new System.Drawing.Point(29, 77);
            this.lbStudentNumRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudentNumRegister.Name = "lbStudentNumRegister";
            this.lbStudentNumRegister.Size = new System.Drawing.Size(113, 17);
            this.lbStudentNumRegister.TabIndex = 0;
            this.lbStudentNumRegister.Text = "Student number:";
            // 
            // MenuTenant
            // 
            this.MenuTenant.Controls.Add(this.tabHomeTenant);
            this.MenuTenant.Controls.Add(this.tabGroceriesTenant);
            this.MenuTenant.Controls.Add(this.tabAnnouncementsTenant);
            this.MenuTenant.Controls.Add(this.tabAgreementsTenant);
            this.MenuTenant.Controls.Add(this.tabHouseRulesTenant);
            this.MenuTenant.Controls.Add(this.tabComplaintsTenant);
            this.MenuTenant.Location = new System.Drawing.Point(702, 199);
            this.MenuTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MenuTenant.Name = "MenuTenant";
            this.MenuTenant.SelectedIndex = 0;
            this.MenuTenant.Size = new System.Drawing.Size(570, 477);
            this.MenuTenant.TabIndex = 2;
            // 
            // tabHomeTenant
            // 
            this.tabHomeTenant.Controls.Add(this.btnLogOutTenant);
            this.tabHomeTenant.Controls.Add(this.lbWelcomeMsgTenant);
            this.tabHomeTenant.ImageKey = "(none)";
            this.tabHomeTenant.Location = new System.Drawing.Point(4, 26);
            this.tabHomeTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabHomeTenant.Name = "tabHomeTenant";
            this.tabHomeTenant.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabHomeTenant.Size = new System.Drawing.Size(562, 447);
            this.tabHomeTenant.TabIndex = 0;
            this.tabHomeTenant.Text = "Home";
            this.tabHomeTenant.UseVisualStyleBackColor = true;
            // 
            // btnLogOutTenant
            // 
            this.btnLogOutTenant.Location = new System.Drawing.Point(24, 397);
            this.btnLogOutTenant.Name = "btnLogOutTenant";
            this.btnLogOutTenant.Size = new System.Drawing.Size(78, 31);
            this.btnLogOutTenant.TabIndex = 4;
            this.btnLogOutTenant.Text = "Log out";
            this.btnLogOutTenant.UseVisualStyleBackColor = true;
            this.btnLogOutTenant.Click += new System.EventHandler(this.btnLogOutTenant_Click);
            // 
            // lbWelcomeMsgTenant
            // 
            this.lbWelcomeMsgTenant.AutoSize = true;
            this.lbWelcomeMsgTenant.Location = new System.Drawing.Point(67, 68);
            this.lbWelcomeMsgTenant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcomeMsgTenant.Name = "lbWelcomeMsgTenant";
            this.lbWelcomeMsgTenant.Size = new System.Drawing.Size(74, 17);
            this.lbWelcomeMsgTenant.TabIndex = 0;
            this.lbWelcomeMsgTenant.Text = "Welcome, ";
            // 
            // tabGroceriesTenant
            // 
            this.tabGroceriesTenant.Controls.Add(this.gbxPayListGroceriesTenant);
            this.tabGroceriesTenant.Location = new System.Drawing.Point(4, 26);
            this.tabGroceriesTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabGroceriesTenant.Name = "tabGroceriesTenant";
            this.tabGroceriesTenant.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabGroceriesTenant.Size = new System.Drawing.Size(562, 447);
            this.tabGroceriesTenant.TabIndex = 1;
            this.tabGroceriesTenant.Text = "Groceries";
            this.tabGroceriesTenant.UseVisualStyleBackColor = true;
            // 
            // gbxPayListGroceriesTenant
            // 
            this.gbxPayListGroceriesTenant.Controls.Add(this.lbxUnpaidGroceries);
            this.gbxPayListGroceriesTenant.Location = new System.Drawing.Point(170, 45);
            this.gbxPayListGroceriesTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxPayListGroceriesTenant.Name = "gbxPayListGroceriesTenant";
            this.gbxPayListGroceriesTenant.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxPayListGroceriesTenant.Size = new System.Drawing.Size(302, 376);
            this.gbxPayListGroceriesTenant.TabIndex = 4;
            this.gbxPayListGroceriesTenant.TabStop = false;
            this.gbxPayListGroceriesTenant.Text = "Pay list groceries";
            // 
            // lbxUnpaidGroceries
            // 
            this.lbxUnpaidGroceries.FormattingEnabled = true;
            this.lbxUnpaidGroceries.ItemHeight = 17;
            this.lbxUnpaidGroceries.Location = new System.Drawing.Point(27, 52);
            this.lbxUnpaidGroceries.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbxUnpaidGroceries.Name = "lbxUnpaidGroceries";
            this.lbxUnpaidGroceries.Size = new System.Drawing.Size(244, 276);
            this.lbxUnpaidGroceries.TabIndex = 3;
            // 
            // tabAnnouncementsTenant
            // 
            this.tabAnnouncementsTenant.Controls.Add(this.gbxNewsFeedTenant);
            this.tabAnnouncementsTenant.Location = new System.Drawing.Point(4, 26);
            this.tabAnnouncementsTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabAnnouncementsTenant.Name = "tabAnnouncementsTenant";
            this.tabAnnouncementsTenant.Size = new System.Drawing.Size(562, 447);
            this.tabAnnouncementsTenant.TabIndex = 2;
            this.tabAnnouncementsTenant.Text = "Announcements";
            this.tabAnnouncementsTenant.UseVisualStyleBackColor = true;
            // 
            // gbxNewsFeedTenant
            // 
            this.gbxNewsFeedTenant.Controls.Add(this.lbxUserAllAnnouncements);
            this.gbxNewsFeedTenant.Controls.Add(this.lblAllAnnouncementTenant);
            this.gbxNewsFeedTenant.Location = new System.Drawing.Point(16, 23);
            this.gbxNewsFeedTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxNewsFeedTenant.Name = "gbxNewsFeedTenant";
            this.gbxNewsFeedTenant.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxNewsFeedTenant.Size = new System.Drawing.Size(283, 397);
            this.gbxNewsFeedTenant.TabIndex = 2;
            this.gbxNewsFeedTenant.TabStop = false;
            this.gbxNewsFeedTenant.Text = "News feed";
            // 
            // lbxUserAllAnnouncements
            // 
            this.lbxUserAllAnnouncements.FormattingEnabled = true;
            this.lbxUserAllAnnouncements.ItemHeight = 17;
            this.lbxUserAllAnnouncements.Location = new System.Drawing.Point(28, 52);
            this.lbxUserAllAnnouncements.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbxUserAllAnnouncements.Name = "lbxUserAllAnnouncements";
            this.lbxUserAllAnnouncements.Size = new System.Drawing.Size(231, 310);
            this.lbxUserAllAnnouncements.TabIndex = 0;
            // 
            // lblAllAnnouncementTenant
            // 
            this.lblAllAnnouncementTenant.AutoSize = true;
            this.lblAllAnnouncementTenant.Location = new System.Drawing.Point(94, 22);
            this.lblAllAnnouncementTenant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllAnnouncementTenant.Name = "lblAllAnnouncementTenant";
            this.lblAllAnnouncementTenant.Size = new System.Drawing.Size(128, 17);
            this.lblAllAnnouncementTenant.TabIndex = 1;
            this.lblAllAnnouncementTenant.Text = "All announcements";
            // 
            // tabAgreementsTenant
            // 
            this.tabAgreementsTenant.Controls.Add(this.gbxAllAgreements);
            this.tabAgreementsTenant.Controls.Add(this.gbxAddAgreement);
            this.tabAgreementsTenant.Location = new System.Drawing.Point(4, 26);
            this.tabAgreementsTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabAgreementsTenant.Name = "tabAgreementsTenant";
            this.tabAgreementsTenant.Size = new System.Drawing.Size(562, 447);
            this.tabAgreementsTenant.TabIndex = 3;
            this.tabAgreementsTenant.Text = "Agreements";
            this.tabAgreementsTenant.UseVisualStyleBackColor = true;
            // 
            // gbxAllAgreements
            // 
            this.gbxAllAgreements.Controls.Add(this.btnDisagree);
            this.gbxAllAgreements.Controls.Add(this.btnAgree);
            this.gbxAllAgreements.Controls.Add(this.lbxAllAgreementsTenant);
            this.gbxAllAgreements.Controls.Add(this.lblAllAgreementsTenant);
            this.gbxAllAgreements.Location = new System.Drawing.Point(335, 26);
            this.gbxAllAgreements.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxAllAgreements.Name = "gbxAllAgreements";
            this.gbxAllAgreements.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxAllAgreements.Size = new System.Drawing.Size(244, 406);
            this.gbxAllAgreements.TabIndex = 5;
            this.gbxAllAgreements.TabStop = false;
            // 
            // btnDisagree
            // 
            this.btnDisagree.Location = new System.Drawing.Point(28, 361);
            this.btnDisagree.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDisagree.Name = "btnDisagree";
            this.btnDisagree.Size = new System.Drawing.Size(192, 23);
            this.btnDisagree.TabIndex = 3;
            this.btnDisagree.Text = "Disagree with selected";
            this.btnDisagree.UseVisualStyleBackColor = true;
            this.btnDisagree.Click += new System.EventHandler(this.btnDisagree_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.Location = new System.Drawing.Point(28, 337);
            this.btnAgree.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(192, 23);
            this.btnAgree.TabIndex = 2;
            this.btnAgree.Text = "Agree with selected";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // lbxAllAgreementsTenant
            // 
            this.lbxAllAgreementsTenant.FormattingEnabled = true;
            this.lbxAllAgreementsTenant.HorizontalScrollbar = true;
            this.lbxAllAgreementsTenant.ItemHeight = 17;
            this.lbxAllAgreementsTenant.Location = new System.Drawing.Point(28, 57);
            this.lbxAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbxAllAgreementsTenant.Name = "lbxAllAgreementsTenant";
            this.lbxAllAgreementsTenant.Size = new System.Drawing.Size(193, 276);
            this.lbxAllAgreementsTenant.TabIndex = 0;
            // 
            // lblAllAgreementsTenant
            // 
            this.lblAllAgreementsTenant.AutoSize = true;
            this.lblAllAgreementsTenant.Location = new System.Drawing.Point(85, 26);
            this.lblAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllAgreementsTenant.Name = "lblAllAgreementsTenant";
            this.lblAllAgreementsTenant.Size = new System.Drawing.Size(102, 17);
            this.lblAllAgreementsTenant.TabIndex = 1;
            this.lblAllAgreementsTenant.Text = "All agreements";
            // 
            // gbxAddAgreement
            // 
            this.gbxAddAgreement.Controls.Add(this.btnAddAgreement);
            this.gbxAddAgreement.Controls.Add(this.tbxAddAgreement);
            this.gbxAddAgreement.Controls.Add(this.lbWriteAgreement);
            this.gbxAddAgreement.Location = new System.Drawing.Point(13, 52);
            this.gbxAddAgreement.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxAddAgreement.Name = "gbxAddAgreement";
            this.gbxAddAgreement.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxAddAgreement.Size = new System.Drawing.Size(286, 279);
            this.gbxAddAgreement.TabIndex = 4;
            this.gbxAddAgreement.TabStop = false;
            // 
            // btnAddAgreement
            // 
            this.btnAddAgreement.Location = new System.Drawing.Point(85, 227);
            this.btnAddAgreement.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddAgreement.Name = "btnAddAgreement";
            this.btnAddAgreement.Size = new System.Drawing.Size(121, 32);
            this.btnAddAgreement.TabIndex = 2;
            this.btnAddAgreement.Text = "Add";
            this.btnAddAgreement.UseVisualStyleBackColor = true;
            this.btnAddAgreement.Click += new System.EventHandler(this.btnAddAgreement_Click);
            // 
            // tbxAddAgreement
            // 
            this.tbxAddAgreement.Location = new System.Drawing.Point(33, 66);
            this.tbxAddAgreement.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxAddAgreement.Multiline = true;
            this.tbxAddAgreement.Name = "tbxAddAgreement";
            this.tbxAddAgreement.Size = new System.Drawing.Size(228, 146);
            this.tbxAddAgreement.TabIndex = 1;
            // 
            // lbWriteAgreement
            // 
            this.lbWriteAgreement.AutoSize = true;
            this.lbWriteAgreement.Location = new System.Drawing.Point(79, 38);
            this.lbWriteAgreement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWriteAgreement.Name = "lbWriteAgreement";
            this.lbWriteAgreement.Size = new System.Drawing.Size(171, 17);
            this.lbWriteAgreement.TabIndex = 0;
            this.lbWriteAgreement.Text = "Write down your message";
            // 
            // tabHouseRulesTenant
            // 
            this.tabHouseRulesTenant.Controls.Add(this.gbxHouseRulseTenant);
            this.tabHouseRulesTenant.Location = new System.Drawing.Point(4, 26);
            this.tabHouseRulesTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabHouseRulesTenant.Name = "tabHouseRulesTenant";
            this.tabHouseRulesTenant.Size = new System.Drawing.Size(562, 447);
            this.tabHouseRulesTenant.TabIndex = 4;
            this.tabHouseRulesTenant.Text = "House Rules";
            this.tabHouseRulesTenant.UseVisualStyleBackColor = true;
            // 
            // gbxHouseRulseTenant
            // 
            this.gbxHouseRulseTenant.Controls.Add(this.lbxRulesTenant);
            this.gbxHouseRulseTenant.Location = new System.Drawing.Point(181, 19);
            this.gbxHouseRulseTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxHouseRulseTenant.Name = "gbxHouseRulseTenant";
            this.gbxHouseRulseTenant.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxHouseRulseTenant.Size = new System.Drawing.Size(283, 400);
            this.gbxHouseRulseTenant.TabIndex = 4;
            this.gbxHouseRulseTenant.TabStop = false;
            this.gbxHouseRulseTenant.Text = "House rules";
            // 
            // lbxRulesTenant
            // 
            this.lbxRulesTenant.FormattingEnabled = true;
            this.lbxRulesTenant.ItemHeight = 17;
            this.lbxRulesTenant.Location = new System.Drawing.Point(32, 39);
            this.lbxRulesTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbxRulesTenant.Name = "lbxRulesTenant";
            this.lbxRulesTenant.Size = new System.Drawing.Size(231, 327);
            this.lbxRulesTenant.TabIndex = 0;
            // 
            // tabComplaintsTenant
            // 
            this.tabComplaintsTenant.Controls.Add(this.btnComplaint);
            this.tabComplaintsTenant.Controls.Add(this.tbxWriteComplaint);
            this.tabComplaintsTenant.Controls.Add(this.lbWriteComplaint);
            this.tabComplaintsTenant.Location = new System.Drawing.Point(4, 26);
            this.tabComplaintsTenant.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabComplaintsTenant.Name = "tabComplaintsTenant";
            this.tabComplaintsTenant.Size = new System.Drawing.Size(562, 447);
            this.tabComplaintsTenant.TabIndex = 5;
            this.tabComplaintsTenant.Text = "Complaints";
            this.tabComplaintsTenant.UseVisualStyleBackColor = true;
            // 
            // btnComplaint
            // 
            this.btnComplaint.Location = new System.Drawing.Point(273, 279);
            this.btnComplaint.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnComplaint.Name = "btnComplaint";
            this.btnComplaint.Size = new System.Drawing.Size(121, 32);
            this.btnComplaint.TabIndex = 2;
            this.btnComplaint.Text = "Send";
            this.btnComplaint.UseVisualStyleBackColor = true;
            this.btnComplaint.Click += new System.EventHandler(this.btnComplaint_Click);
            // 
            // tbxWriteComplaint
            // 
            this.tbxWriteComplaint.Location = new System.Drawing.Point(221, 118);
            this.tbxWriteComplaint.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxWriteComplaint.Multiline = true;
            this.tbxWriteComplaint.Name = "tbxWriteComplaint";
            this.tbxWriteComplaint.Size = new System.Drawing.Size(228, 146);
            this.tbxWriteComplaint.TabIndex = 1;
            // 
            // lbWriteComplaint
            // 
            this.lbWriteComplaint.AutoSize = true;
            this.lbWriteComplaint.Location = new System.Drawing.Point(268, 92);
            this.lbWriteComplaint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWriteComplaint.Name = "lbWriteComplaint";
            this.lbWriteComplaint.Size = new System.Drawing.Size(178, 17);
            this.lbWriteComplaint.TabIndex = 0;
            this.lbWriteComplaint.Text = "Write down your complaint:";
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.btnLogin);
            this.gbxLogin.Controls.Add(this.tbxPasswordLogin);
            this.gbxLogin.Controls.Add(this.tbxUsernameLogin);
            this.gbxLogin.Controls.Add(this.lbPasswordLogin);
            this.gbxLogin.Controls.Add(this.lbUsernameLogin);
            this.gbxLogin.Location = new System.Drawing.Point(572, 12);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(235, 183);
            this.gbxLogin.TabIndex = 1;
            this.gbxLogin.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(94, 130);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 27);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPasswordLogin
            // 
            this.tbxPasswordLogin.Location = new System.Drawing.Point(94, 86);
            this.tbxPasswordLogin.Name = "tbxPasswordLogin";
            this.tbxPasswordLogin.Size = new System.Drawing.Size(107, 23);
            this.tbxPasswordLogin.TabIndex = 3;
            this.tbxPasswordLogin.UseSystemPasswordChar = true;
            // 
            // tbxUsernameLogin
            // 
            this.tbxUsernameLogin.Location = new System.Drawing.Point(94, 49);
            this.tbxUsernameLogin.Name = "tbxUsernameLogin";
            this.tbxUsernameLogin.Size = new System.Drawing.Size(107, 23);
            this.tbxUsernameLogin.TabIndex = 2;
            // 
            // lbPasswordLogin
            // 
            this.lbPasswordLogin.AutoSize = true;
            this.lbPasswordLogin.Location = new System.Drawing.Point(18, 88);
            this.lbPasswordLogin.Name = "lbPasswordLogin";
            this.lbPasswordLogin.Size = new System.Drawing.Size(73, 17);
            this.lbPasswordLogin.TabIndex = 1;
            this.lbPasswordLogin.Text = "Password:";
            // 
            // lbUsernameLogin
            // 
            this.lbUsernameLogin.AutoSize = true;
            this.lbUsernameLogin.Location = new System.Drawing.Point(18, 49);
            this.lbUsernameLogin.Name = "lbUsernameLogin";
            this.lbUsernameLogin.Size = new System.Drawing.Size(77, 17);
            this.lbUsernameLogin.TabIndex = 0;
            this.lbUsernameLogin.Text = "Username:";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 60000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Location = new System.Drawing.Point(43, 422);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteRule.TabIndex = 6;
            this.btnDeleteRule.Text = "Delete";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            // 
            // btnEditRule
            // 
            this.btnEditRule.Location = new System.Drawing.Point(171, 422);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(91, 23);
            this.btnEditRule.TabIndex = 7;
            this.btnEditRule.Text = "Edit";
            this.btnEditRule.UseVisualStyleBackColor = true;
            // 
            // HousingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 682);
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.MenuTenant);
            this.Controls.Add(this.MenuAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HousingApp";
            this.Text = "Housing App";
            this.Load += new System.EventHandler(this.HousingApp_Load);
            this.MenuAdmin.ResumeLayout(false);
            this.tabHomeAdmin.ResumeLayout(false);
            this.tabHomeAdmin.PerformLayout();
            this.tabGroceriesAdmin.ResumeLayout(false);
            this.gbxPayListGroceries.ResumeLayout(false);
            this.gbxPayListGroceries.PerformLayout();
            this.gbxAddGrocery.ResumeLayout(false);
            this.gbxAddGrocery.PerformLayout();
            this.gbxGroceriesAdmin.ResumeLayout(false);
            this.gbxGroceriesAdmin.PerformLayout();
            this.tabAnnouncementsAdmin.ResumeLayout(false);
            this.gbxPostAnnouncements.ResumeLayout(false);
            this.gbxPostAnnouncements.PerformLayout();
            this.gbxNewsFeed.ResumeLayout(false);
            this.gbxNewsFeed.PerformLayout();
            this.tabAgreementsAdmin.ResumeLayout(false);
            this.tabAgreementsAdmin.PerformLayout();
            this.tabHouseRulesAdmin.ResumeLayout(false);
            this.gbxRule.ResumeLayout(false);
            this.gbxRule.PerformLayout();
            this.gbxRules.ResumeLayout(false);
            this.tabComplaintsAdmin.ResumeLayout(false);
            this.gbxAllComplaints.ResumeLayout(false);
            this.tabManageTenants.ResumeLayout(false);
            this.gbxEditTenant.ResumeLayout(false);
            this.gbxEditTenant.PerformLayout();
            this.gbxSearchTenantEdit.ResumeLayout(false);
            this.gbxSearchTenantEdit.PerformLayout();
            this.gbxRemoveTenant.ResumeLayout(false);
            this.gbxRemoveTenant.PerformLayout();
            this.gbxRegisterTenants.ResumeLayout(false);
            this.gbxRegisterTenants.PerformLayout();
            this.MenuTenant.ResumeLayout(false);
            this.tabHomeTenant.ResumeLayout(false);
            this.tabHomeTenant.PerformLayout();
            this.tabGroceriesTenant.ResumeLayout(false);
            this.gbxPayListGroceriesTenant.ResumeLayout(false);
            this.tabAnnouncementsTenant.ResumeLayout(false);
            this.gbxNewsFeedTenant.ResumeLayout(false);
            this.gbxNewsFeedTenant.PerformLayout();
            this.tabAgreementsTenant.ResumeLayout(false);
            this.gbxAllAgreements.ResumeLayout(false);
            this.gbxAllAgreements.PerformLayout();
            this.gbxAddAgreement.ResumeLayout(false);
            this.gbxAddAgreement.PerformLayout();
            this.tabHouseRulesTenant.ResumeLayout(false);
            this.gbxHouseRulseTenant.ResumeLayout(false);
            this.tabComplaintsTenant.ResumeLayout(false);
            this.tabComplaintsTenant.PerformLayout();
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MenuAdmin;
        private System.Windows.Forms.TabPage tabHomeAdmin;
        private System.Windows.Forms.TabPage tabGroceriesAdmin;
        private System.Windows.Forms.Label lbWelcomeMsgAdmin;
        private System.Windows.Forms.TabPage tabAnnouncementsAdmin;
        private System.Windows.Forms.TabPage tabAgreementsAdmin;
        private System.Windows.Forms.TabPage tabHouseRulesAdmin;
        private System.Windows.Forms.TabPage tabComplaintsAdmin;
        private System.Windows.Forms.TabPage tabManageTenants;
        private System.Windows.Forms.GroupBox gbxAddGrocery;
        private System.Windows.Forms.Button btnAddGrocery;
        private System.Windows.Forms.TextBox tbxGroceryName;
        private System.Windows.Forms.Label lbGroceryName;
        private System.Windows.Forms.GroupBox gbxGroceriesAdmin;
        private System.Windows.Forms.Button btnRemoveAllGroceries;
        private System.Windows.Forms.Button btnRemoveSelectedGrocery;
        private System.Windows.Forms.ListBox lbxRecentGroceries;
        private System.Windows.Forms.Label lbRecentGroceries;
        private System.Windows.Forms.GroupBox gbxPayListGroceries;
        private System.Windows.Forms.Button btnMarkAllAsPaid;
        private System.Windows.Forms.Button btnMarkSelectedAsPaid;
        private System.Windows.Forms.ListBox lbxUnpaidGroceriesPerStudent;
        private System.Windows.Forms.TextBox tbxStudNumUnpaidItems;
        private System.Windows.Forms.Button btnShowToPayList;
        private System.Windows.Forms.Label lbStudNumUnpaidItems;
        private System.Windows.Forms.GroupBox gbxPostAnnouncements;
        private System.Windows.Forms.Button btnPostAnnouncement;
        private System.Windows.Forms.TextBox tbxPostAnnouncement;
        private System.Windows.Forms.Label lbWriteMessage;
        private System.Windows.Forms.GroupBox gbxNewsFeed;
        private System.Windows.Forms.ListBox lbxAllAnnouncements;
        private System.Windows.Forms.Label lbAllAnnouncements;
        private System.Windows.Forms.ListBox lbxAllAgreementsAdmin;
        private System.Windows.Forms.Label lbAllAgreementsAdmin;
        private System.Windows.Forms.GroupBox gbxRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.TextBox tbxAddRule;
        private System.Windows.Forms.Label lbWriteRule;
        private System.Windows.Forms.GroupBox gbxRules;
        private System.Windows.Forms.ListBox lbxRulesAdmin;
        private System.Windows.Forms.GroupBox gbxAllComplaints;
        private System.Windows.Forms.ListBox lbxAllComplaints;
        private System.Windows.Forms.GroupBox gbxRegisterTenants;
        private System.Windows.Forms.GroupBox gbxRemoveTenant;
        private System.Windows.Forms.Button btnRemoveTenant;
        private System.Windows.Forms.TextBox tbxStudentNumRemove;
        private System.Windows.Forms.Label lbStudentNumRemove;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbxPasswordRegister;
        private System.Windows.Forms.TextBox tbxFirstNameRegister;
        private System.Windows.Forms.TextBox tbxStudentNumRegister;
        private System.Windows.Forms.Label lbPasswordRegister;
        private System.Windows.Forms.Label lbFirstNameRegister;
        private System.Windows.Forms.Label lbStudentNumRegister;
        private System.Windows.Forms.TabControl MenuTenant;
        private System.Windows.Forms.TabPage tabHomeTenant;
        private System.Windows.Forms.Label lbWelcomeMsgTenant;
        private System.Windows.Forms.TabPage tabGroceriesTenant;
        private System.Windows.Forms.GroupBox gbxPayListGroceriesTenant;
        private System.Windows.Forms.ListBox lbxUnpaidGroceries;
        private System.Windows.Forms.TabPage tabAnnouncementsTenant;
        private System.Windows.Forms.GroupBox gbxNewsFeedTenant;
        private System.Windows.Forms.ListBox lbxUserAllAnnouncements;
        private System.Windows.Forms.Label lblAllAnnouncementTenant;
        private System.Windows.Forms.TabPage tabAgreementsTenant;
        private System.Windows.Forms.GroupBox gbxAllAgreements;
        private System.Windows.Forms.ListBox lbxAllAgreementsTenant;
        private System.Windows.Forms.Label lblAllAgreementsTenant;
        private System.Windows.Forms.GroupBox gbxAddAgreement;
        private System.Windows.Forms.Button btnAddAgreement;
        private System.Windows.Forms.TextBox tbxAddAgreement;
        private System.Windows.Forms.Label lbWriteAgreement;
        private System.Windows.Forms.TabPage tabHouseRulesTenant;
        private System.Windows.Forms.GroupBox gbxHouseRulseTenant;
        private System.Windows.Forms.ListBox lbxRulesTenant;
        private System.Windows.Forms.TabPage tabComplaintsTenant;
        private System.Windows.Forms.Button btnComplaint;
        private System.Windows.Forms.TextBox tbxWriteComplaint;
        private System.Windows.Forms.Label lbWriteComplaint;
        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxPasswordLogin;
        private System.Windows.Forms.TextBox tbxUsernameLogin;
        private System.Windows.Forms.Label lbPasswordLogin;
        private System.Windows.Forms.Label lbUsernameLogin;
        private System.Windows.Forms.Button btnLogOutAdmin;
        private System.Windows.Forms.Button btnLogOutTenant;
        private System.Windows.Forms.Button btnMarkAsDone;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnDisagree;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.TextBox tbxGroceryPrice;
        private System.Windows.Forms.Label lbGroceryPrice;
        private System.Windows.Forms.Button btnClsSelectLinePayListGroceries;
        private System.Windows.Forms.Button btnClsSelectedLineRecentGroceries;
        private System.Windows.Forms.Button btndeleteAnnouncement;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gbxSearchTenantEdit;
        private System.Windows.Forms.TextBox tbxEditFNameTenant;
        private System.Windows.Forms.Label lbEditFNameTenant;
        private System.Windows.Forms.Button btnShowTenantProfileEdit;
        private System.Windows.Forms.TextBox tbxStudNumSearchTenantEdit;
        private System.Windows.Forms.Label lbStudNumSearchTenantEdit;
        private System.Windows.Forms.Button btnSaveChangesEditTenantProfile;
        private System.Windows.Forms.TextBox tbxEditPasswordTenant;
        private System.Windows.Forms.Label lbEditPasswordTenant;
        private System.Windows.Forms.GroupBox gbxEditTenant;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.Button btnDeleteRule;
    }
}