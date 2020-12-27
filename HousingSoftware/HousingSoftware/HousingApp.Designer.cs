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
            this.gbxSearchAgreementAdmin = new System.Windows.Forms.GroupBox();
            this.btnShowAllAgreementsAdmin = new System.Windows.Forms.Button();
            this.btnSearchAgreementAdmin = new System.Windows.Forms.Button();
            this.tbxSearchAgreementsAdmin = new System.Windows.Forms.TextBox();
            this.lbxAllAgreementsAdmin = new System.Windows.Forms.ListBox();
            this.lbAllAgreementsAdmin = new System.Windows.Forms.Label();
            this.tabHouseRulesAdmin = new System.Windows.Forms.TabPage();
            this.btnSaveEditedRule = new System.Windows.Forms.Button();
            this.editBoxRule = new System.Windows.Forms.TextBox();
            this.gbxRule = new System.Windows.Forms.GroupBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.tbxAddRule = new System.Windows.Forms.TextBox();
            this.lbWriteRule = new System.Windows.Forms.Label();
            this.gbxRules = new System.Windows.Forms.GroupBox();
            this.lbxRulesAdmin = new System.Windows.Forms.ListBox();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.tabComplaintsAdmin = new System.Windows.Forms.TabPage();
            this.gbxSearchComplaints = new System.Windows.Forms.GroupBox();
            this.btnShowAllComplaints = new System.Windows.Forms.Button();
            this.btnSearchComplaint = new System.Windows.Forms.Button();
            this.tbxSearchComplaint = new System.Windows.Forms.TextBox();
            this.gbxAllComplaints = new System.Windows.Forms.GroupBox();
            this.btnMarkAsDone = new System.Windows.Forms.Button();
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
            this.gbxSearchAgreementTenant = new System.Windows.Forms.GroupBox();
            this.btnShowAllAgreementsTenant = new System.Windows.Forms.Button();
            this.btnSearchAgreementTenant = new System.Windows.Forms.Button();
            this.tbxSearchAgreementsTenant = new System.Windows.Forms.TextBox();
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
            this.gbxSearchAgreementAdmin.SuspendLayout();
            this.tabHouseRulesAdmin.SuspendLayout();
            this.gbxRule.SuspendLayout();
            this.gbxRules.SuspendLayout();
            this.tabComplaintsAdmin.SuspendLayout();
            this.gbxSearchComplaints.SuspendLayout();
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
            this.gbxSearchAgreementTenant.SuspendLayout();
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
            this.MenuAdmin.Location = new System.Drawing.Point(15, 231);
            this.MenuAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MenuAdmin.Name = "MenuAdmin";
            this.MenuAdmin.SelectedIndex = 0;
            this.MenuAdmin.Size = new System.Drawing.Size(916, 562);
            this.MenuAdmin.TabIndex = 0;
            // 
            // tabHomeAdmin
            // 
            this.tabHomeAdmin.Controls.Add(this.lblDate);
            this.tabHomeAdmin.Controls.Add(this.lbTime);
            this.tabHomeAdmin.Controls.Add(this.lbWelcomeMsgAdmin);
            this.tabHomeAdmin.Controls.Add(this.btnLogOutAdmin);
            this.tabHomeAdmin.ImageKey = "(none)";
            this.tabHomeAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabHomeAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabHomeAdmin.Name = "tabHomeAdmin";
            this.tabHomeAdmin.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabHomeAdmin.Size = new System.Drawing.Size(908, 533);
            this.tabHomeAdmin.TabIndex = 0;
            this.tabHomeAdmin.Text = "Home";
            this.tabHomeAdmin.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(105, 174);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(100, 150);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(60, 25);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Time";
            // 
            // lbWelcomeMsgAdmin
            // 
            this.lbWelcomeMsgAdmin.AutoSize = true;
            this.lbWelcomeMsgAdmin.Location = new System.Drawing.Point(89, 79);
            this.lbWelcomeMsgAdmin.Name = "lbWelcomeMsgAdmin";
            this.lbWelcomeMsgAdmin.Size = new System.Drawing.Size(74, 17);
            this.lbWelcomeMsgAdmin.TabIndex = 0;
            this.lbWelcomeMsgAdmin.Text = "Welcome, ";
            // 
            // btnLogOutAdmin
            // 
            this.btnLogOutAdmin.Location = new System.Drawing.Point(27, 459);
            this.btnLogOutAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOutAdmin.Name = "btnLogOutAdmin";
            this.btnLogOutAdmin.Size = new System.Drawing.Size(104, 36);
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
            this.tabGroceriesAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabGroceriesAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabGroceriesAdmin.Name = "tabGroceriesAdmin";
            this.tabGroceriesAdmin.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabGroceriesAdmin.Size = new System.Drawing.Size(908, 533);
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
            this.gbxPayListGroceries.Location = new System.Drawing.Point(417, 15);
            this.gbxPayListGroceries.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxPayListGroceries.Name = "gbxPayListGroceries";
            this.gbxPayListGroceries.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxPayListGroceries.Size = new System.Drawing.Size(457, 496);
            this.gbxPayListGroceries.TabIndex = 4;
            this.gbxPayListGroceries.TabStop = false;
            this.gbxPayListGroceries.Text = "Pay list groceries";
            // 
            // btnClsSelectLinePayListGroceries
            // 
            this.btnClsSelectLinePayListGroceries.Location = new System.Drawing.Point(171, 380);
            this.btnClsSelectLinePayListGroceries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClsSelectLinePayListGroceries.Name = "btnClsSelectLinePayListGroceries";
            this.btnClsSelectLinePayListGroceries.Size = new System.Drawing.Size(143, 30);
            this.btnClsSelectLinePayListGroceries.TabIndex = 5;
            this.btnClsSelectLinePayListGroceries.Text = "Clear selected";
            this.btnClsSelectLinePayListGroceries.UseVisualStyleBackColor = true;
            this.btnClsSelectLinePayListGroceries.Click += new System.EventHandler(this.btnClsSelectLinePayListGroceries_Click);
            // 
            // btnMarkAllAsPaid
            // 
            this.btnMarkAllAsPaid.Location = new System.Drawing.Point(268, 444);
            this.btnMarkAllAsPaid.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMarkAllAsPaid.Name = "btnMarkAllAsPaid";
            this.btnMarkAllAsPaid.Size = new System.Drawing.Size(151, 30);
            this.btnMarkAllAsPaid.TabIndex = 4;
            this.btnMarkAllAsPaid.Text = "Mark all as paid";
            this.btnMarkAllAsPaid.UseVisualStyleBackColor = true;
            this.btnMarkAllAsPaid.Click += new System.EventHandler(this.btnMarkAllAsPaid_Click);
            // 
            // btnMarkSelectedAsPaid
            // 
            this.btnMarkSelectedAsPaid.Location = new System.Drawing.Point(36, 444);
            this.btnMarkSelectedAsPaid.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMarkSelectedAsPaid.Name = "btnMarkSelectedAsPaid";
            this.btnMarkSelectedAsPaid.Size = new System.Drawing.Size(180, 30);
            this.btnMarkSelectedAsPaid.TabIndex = 4;
            this.btnMarkSelectedAsPaid.Text = "Mark selected as paid";
            this.btnMarkSelectedAsPaid.UseVisualStyleBackColor = true;
            this.btnMarkSelectedAsPaid.Click += new System.EventHandler(this.btnMarkSelectedAsPaid_Click);
            // 
            // lbxUnpaidGroceriesPerStudent
            // 
            this.lbxUnpaidGroceriesPerStudent.FormattingEnabled = true;
            this.lbxUnpaidGroceriesPerStudent.ItemHeight = 16;
            this.lbxUnpaidGroceriesPerStudent.Location = new System.Drawing.Point(36, 105);
            this.lbxUnpaidGroceriesPerStudent.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbxUnpaidGroceriesPerStudent.Name = "lbxUnpaidGroceriesPerStudent";
            this.lbxUnpaidGroceriesPerStudent.Size = new System.Drawing.Size(384, 260);
            this.lbxUnpaidGroceriesPerStudent.TabIndex = 3;
            // 
            // tbxStudNumUnpaidItems
            // 
            this.tbxStudNumUnpaidItems.Location = new System.Drawing.Point(145, 49);
            this.tbxStudNumUnpaidItems.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxStudNumUnpaidItems.Name = "tbxStudNumUnpaidItems";
            this.tbxStudNumUnpaidItems.Size = new System.Drawing.Size(127, 22);
            this.tbxStudNumUnpaidItems.TabIndex = 2;
            // 
            // btnShowToPayList
            // 
            this.btnShowToPayList.Location = new System.Drawing.Point(288, 46);
            this.btnShowToPayList.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnShowToPayList.Name = "btnShowToPayList";
            this.btnShowToPayList.Size = new System.Drawing.Size(153, 30);
            this.btnShowToPayList.TabIndex = 1;
            this.btnShowToPayList.Text = "Show to-pay list";
            this.btnShowToPayList.UseVisualStyleBackColor = true;
            this.btnShowToPayList.Click += new System.EventHandler(this.btnShowToPayList_Click);
            // 
            // lbStudNumUnpaidItems
            // 
            this.lbStudNumUnpaidItems.AutoSize = true;
            this.lbStudNumUnpaidItems.Location = new System.Drawing.Point(15, 49);
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
            this.gbxAddGrocery.Location = new System.Drawing.Point(32, 15);
            this.gbxAddGrocery.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxAddGrocery.Name = "gbxAddGrocery";
            this.gbxAddGrocery.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxAddGrocery.Size = new System.Drawing.Size(308, 144);
            this.gbxAddGrocery.TabIndex = 3;
            this.gbxAddGrocery.TabStop = false;
            this.gbxAddGrocery.Text = "Add groceries";
            // 
            // tbxGroceryPrice
            // 
            this.tbxGroceryPrice.Location = new System.Drawing.Point(111, 60);
            this.tbxGroceryPrice.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxGroceryPrice.Name = "tbxGroceryPrice";
            this.tbxGroceryPrice.Size = new System.Drawing.Size(119, 22);
            this.tbxGroceryPrice.TabIndex = 4;
            // 
            // lbGroceryPrice
            // 
            this.lbGroceryPrice.AutoSize = true;
            this.lbGroceryPrice.Location = new System.Drawing.Point(39, 63);
            this.lbGroceryPrice.Name = "lbGroceryPrice";
            this.lbGroceryPrice.Size = new System.Drawing.Size(44, 17);
            this.lbGroceryPrice.TabIndex = 3;
            this.lbGroceryPrice.Text = "Price:";
            // 
            // btnAddGrocery
            // 
            this.btnAddGrocery.Location = new System.Drawing.Point(111, 105);
            this.btnAddGrocery.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAddGrocery.Name = "btnAddGrocery";
            this.btnAddGrocery.Size = new System.Drawing.Size(120, 27);
            this.btnAddGrocery.TabIndex = 2;
            this.btnAddGrocery.Text = "Add grocery";
            this.btnAddGrocery.UseVisualStyleBackColor = true;
            this.btnAddGrocery.Click += new System.EventHandler(this.btnAddGrocery_Click);
            // 
            // tbxGroceryName
            // 
            this.tbxGroceryName.Location = new System.Drawing.Point(111, 30);
            this.tbxGroceryName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxGroceryName.Name = "tbxGroceryName";
            this.tbxGroceryName.Size = new System.Drawing.Size(119, 22);
            this.tbxGroceryName.TabIndex = 1;
            // 
            // lbGroceryName
            // 
            this.lbGroceryName.AutoSize = true;
            this.lbGroceryName.Location = new System.Drawing.Point(39, 30);
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
            this.gbxGroceriesAdmin.Location = new System.Drawing.Point(32, 161);
            this.gbxGroceriesAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxGroceriesAdmin.Name = "gbxGroceriesAdmin";
            this.gbxGroceriesAdmin.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxGroceriesAdmin.Size = new System.Drawing.Size(308, 362);
            this.gbxGroceriesAdmin.TabIndex = 2;
            this.gbxGroceriesAdmin.TabStop = false;
            // 
            // btnClsSelectedLineRecentGroceries
            // 
            this.btnClsSelectedLineRecentGroceries.Location = new System.Drawing.Point(88, 265);
            this.btnClsSelectedLineRecentGroceries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClsSelectedLineRecentGroceries.Name = "btnClsSelectedLineRecentGroceries";
            this.btnClsSelectedLineRecentGroceries.Size = new System.Drawing.Size(143, 30);
            this.btnClsSelectedLineRecentGroceries.TabIndex = 6;
            this.btnClsSelectedLineRecentGroceries.Text = "Clear selected";
            this.btnClsSelectedLineRecentGroceries.UseVisualStyleBackColor = true;
            this.btnClsSelectedLineRecentGroceries.Click += new System.EventHandler(this.btnClsSelectedLineRecentGroceries_Click);
            // 
            // btnRemoveAllGroceries
            // 
            this.btnRemoveAllGroceries.Location = new System.Drawing.Point(173, 320);
            this.btnRemoveAllGroceries.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnRemoveAllGroceries.Name = "btnRemoveAllGroceries";
            this.btnRemoveAllGroceries.Size = new System.Drawing.Size(129, 30);
            this.btnRemoveAllGroceries.TabIndex = 3;
            this.btnRemoveAllGroceries.Text = "Remove all";
            this.btnRemoveAllGroceries.UseVisualStyleBackColor = true;
            this.btnRemoveAllGroceries.Click += new System.EventHandler(this.btnRemoveAllGroceries_Click);
            // 
            // btnRemoveSelectedGrocery
            // 
            this.btnRemoveSelectedGrocery.Location = new System.Drawing.Point(5, 320);
            this.btnRemoveSelectedGrocery.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnRemoveSelectedGrocery.Name = "btnRemoveSelectedGrocery";
            this.btnRemoveSelectedGrocery.Size = new System.Drawing.Size(140, 30);
            this.btnRemoveSelectedGrocery.TabIndex = 2;
            this.btnRemoveSelectedGrocery.Text = "Remove selected";
            this.btnRemoveSelectedGrocery.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedGrocery.Click += new System.EventHandler(this.btnRemoveSelectedGrocery_Click);
            // 
            // lbxRecentGroceries
            // 
            this.lbxRecentGroceries.FormattingEnabled = true;
            this.lbxRecentGroceries.ItemHeight = 16;
            this.lbxRecentGroceries.Location = new System.Drawing.Point(55, 47);
            this.lbxRecentGroceries.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbxRecentGroceries.Name = "lbxRecentGroceries";
            this.lbxRecentGroceries.Size = new System.Drawing.Size(207, 180);
            this.lbxRecentGroceries.TabIndex = 0;
            // 
            // lbRecentGroceries
            // 
            this.lbRecentGroceries.AutoSize = true;
            this.lbRecentGroceries.Location = new System.Drawing.Point(95, 18);
            this.lbRecentGroceries.Name = "lbRecentGroceries";
            this.lbRecentGroceries.Size = new System.Drawing.Size(116, 17);
            this.lbRecentGroceries.TabIndex = 1;
            this.lbRecentGroceries.Text = "Recent groceries";
            // 
            // tabAnnouncementsAdmin
            // 
            this.tabAnnouncementsAdmin.Controls.Add(this.gbxPostAnnouncements);
            this.tabAnnouncementsAdmin.Controls.Add(this.gbxNewsFeed);
            this.tabAnnouncementsAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabAnnouncementsAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabAnnouncementsAdmin.Name = "tabAnnouncementsAdmin";
            this.tabAnnouncementsAdmin.Size = new System.Drawing.Size(908, 533);
            this.tabAnnouncementsAdmin.TabIndex = 2;
            this.tabAnnouncementsAdmin.Text = "Announcements";
            this.tabAnnouncementsAdmin.UseVisualStyleBackColor = true;
            // 
            // gbxPostAnnouncements
            // 
            this.gbxPostAnnouncements.Controls.Add(this.btnPostAnnouncement);
            this.gbxPostAnnouncements.Controls.Add(this.tbxPostAnnouncement);
            this.gbxPostAnnouncements.Controls.Add(this.lbWriteMessage);
            this.gbxPostAnnouncements.Location = new System.Drawing.Point(468, 44);
            this.gbxPostAnnouncements.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxPostAnnouncements.Name = "gbxPostAnnouncements";
            this.gbxPostAnnouncements.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxPostAnnouncements.Size = new System.Drawing.Size(381, 324);
            this.gbxPostAnnouncements.TabIndex = 3;
            this.gbxPostAnnouncements.TabStop = false;
            this.gbxPostAnnouncements.Text = "Post an announcement";
            // 
            // btnPostAnnouncement
            // 
            this.btnPostAnnouncement.Location = new System.Drawing.Point(113, 263);
            this.btnPostAnnouncement.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnPostAnnouncement.Name = "btnPostAnnouncement";
            this.btnPostAnnouncement.Size = new System.Drawing.Size(161, 37);
            this.btnPostAnnouncement.TabIndex = 2;
            this.btnPostAnnouncement.Text = "Post";
            this.btnPostAnnouncement.UseVisualStyleBackColor = true;
            this.btnPostAnnouncement.Click += new System.EventHandler(this.btnPostAnnouncement_Click);
            // 
            // tbxPostAnnouncement
            // 
            this.tbxPostAnnouncement.Location = new System.Drawing.Point(44, 76);
            this.tbxPostAnnouncement.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxPostAnnouncement.Multiline = true;
            this.tbxPostAnnouncement.Name = "tbxPostAnnouncement";
            this.tbxPostAnnouncement.Size = new System.Drawing.Size(303, 169);
            this.tbxPostAnnouncement.TabIndex = 1;
            // 
            // lbWriteMessage
            // 
            this.lbWriteMessage.AutoSize = true;
            this.lbWriteMessage.Location = new System.Drawing.Point(105, 44);
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
            this.gbxNewsFeed.Location = new System.Drawing.Point(33, 23);
            this.gbxNewsFeed.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxNewsFeed.Name = "gbxNewsFeed";
            this.gbxNewsFeed.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxNewsFeed.Size = new System.Drawing.Size(377, 496);
            this.gbxNewsFeed.TabIndex = 2;
            this.gbxNewsFeed.TabStop = false;
            this.gbxNewsFeed.Text = "News feed";
            // 
            // btndeleteAnnouncement
            // 
            this.btndeleteAnnouncement.Location = new System.Drawing.Point(149, 439);
            this.btndeleteAnnouncement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndeleteAnnouncement.Name = "btndeleteAnnouncement";
            this.btndeleteAnnouncement.Size = new System.Drawing.Size(75, 32);
            this.btndeleteAnnouncement.TabIndex = 2;
            this.btndeleteAnnouncement.Text = "Delete";
            this.btndeleteAnnouncement.UseVisualStyleBackColor = true;
            this.btndeleteAnnouncement.Click += new System.EventHandler(this.btndeleteAnnouncement_Click);
            // 
            // lbxAllAnnouncements
            // 
            this.lbxAllAnnouncements.FormattingEnabled = true;
            this.lbxAllAnnouncements.ItemHeight = 16;
            this.lbxAllAnnouncements.Location = new System.Drawing.Point(39, 65);
            this.lbxAllAnnouncements.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbxAllAnnouncements.Name = "lbxAllAnnouncements";
            this.lbxAllAnnouncements.Size = new System.Drawing.Size(307, 356);
            this.lbxAllAnnouncements.TabIndex = 0;
            // 
            // lbAllAnnouncements
            // 
            this.lbAllAnnouncements.AutoSize = true;
            this.lbAllAnnouncements.Location = new System.Drawing.Point(124, 34);
            this.lbAllAnnouncements.Name = "lbAllAnnouncements";
            this.lbAllAnnouncements.Size = new System.Drawing.Size(128, 17);
            this.lbAllAnnouncements.TabIndex = 1;
            this.lbAllAnnouncements.Text = "All announcements";
            // 
            // tabAgreementsAdmin
            // 
            this.tabAgreementsAdmin.Controls.Add(this.gbxSearchAgreementAdmin);
            this.tabAgreementsAdmin.Controls.Add(this.lbxAllAgreementsAdmin);
            this.tabAgreementsAdmin.Controls.Add(this.lbAllAgreementsAdmin);
            this.tabAgreementsAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabAgreementsAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabAgreementsAdmin.Name = "tabAgreementsAdmin";
            this.tabAgreementsAdmin.Size = new System.Drawing.Size(908, 533);
            this.tabAgreementsAdmin.TabIndex = 3;
            this.tabAgreementsAdmin.Text = "Agreements";
            this.tabAgreementsAdmin.UseVisualStyleBackColor = true;
            // 
            // gbxSearchAgreementAdmin
            // 
            this.gbxSearchAgreementAdmin.Controls.Add(this.btnShowAllAgreementsAdmin);
            this.gbxSearchAgreementAdmin.Controls.Add(this.btnSearchAgreementAdmin);
            this.gbxSearchAgreementAdmin.Controls.Add(this.tbxSearchAgreementsAdmin);
            this.gbxSearchAgreementAdmin.Location = new System.Drawing.Point(436, 190);
            this.gbxSearchAgreementAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearchAgreementAdmin.Name = "gbxSearchAgreementAdmin";
            this.gbxSearchAgreementAdmin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearchAgreementAdmin.Size = new System.Drawing.Size(381, 169);
            this.gbxSearchAgreementAdmin.TabIndex = 7;
            this.gbxSearchAgreementAdmin.TabStop = false;
            this.gbxSearchAgreementAdmin.Text = "Search for an agreement";
            // 
            // btnShowAllAgreementsAdmin
            // 
            this.btnShowAllAgreementsAdmin.Location = new System.Drawing.Point(81, 117);
            this.btnShowAllAgreementsAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAllAgreementsAdmin.Name = "btnShowAllAgreementsAdmin";
            this.btnShowAllAgreementsAdmin.Size = new System.Drawing.Size(207, 27);
            this.btnShowAllAgreementsAdmin.TabIndex = 2;
            this.btnShowAllAgreementsAdmin.Text = "Show all agreements";
            this.btnShowAllAgreementsAdmin.UseVisualStyleBackColor = true;
            this.btnShowAllAgreementsAdmin.Click += new System.EventHandler(this.btnShowAllAgreementsAdmin_Click);
            // 
            // btnSearchAgreementAdmin
            // 
            this.btnSearchAgreementAdmin.Location = new System.Drawing.Point(81, 78);
            this.btnSearchAgreementAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchAgreementAdmin.Name = "btnSearchAgreementAdmin";
            this.btnSearchAgreementAdmin.Size = new System.Drawing.Size(207, 27);
            this.btnSearchAgreementAdmin.TabIndex = 1;
            this.btnSearchAgreementAdmin.Text = "Search";
            this.btnSearchAgreementAdmin.UseVisualStyleBackColor = true;
            this.btnSearchAgreementAdmin.Click += new System.EventHandler(this.btnSearchAgreementAdmin_Click);
            // 
            // tbxSearchAgreementsAdmin
            // 
            this.tbxSearchAgreementsAdmin.Location = new System.Drawing.Point(23, 44);
            this.tbxSearchAgreementsAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSearchAgreementsAdmin.Name = "tbxSearchAgreementsAdmin";
            this.tbxSearchAgreementsAdmin.Size = new System.Drawing.Size(324, 22);
            this.tbxSearchAgreementsAdmin.TabIndex = 0;
            // 
            // lbxAllAgreementsAdmin
            // 
            this.lbxAllAgreementsAdmin.FormattingEnabled = true;
            this.lbxAllAgreementsAdmin.HorizontalScrollbar = true;
            this.lbxAllAgreementsAdmin.ItemHeight = 16;
            this.lbxAllAgreementsAdmin.Location = new System.Drawing.Point(59, 91);
            this.lbxAllAgreementsAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbxAllAgreementsAdmin.Name = "lbxAllAgreementsAdmin";
            this.lbxAllAgreementsAdmin.Size = new System.Drawing.Size(307, 356);
            this.lbxAllAgreementsAdmin.TabIndex = 0;
            // 
            // lbAllAgreementsAdmin
            // 
            this.lbAllAgreementsAdmin.AutoSize = true;
            this.lbAllAgreementsAdmin.Location = new System.Drawing.Point(143, 60);
            this.lbAllAgreementsAdmin.Name = "lbAllAgreementsAdmin";
            this.lbAllAgreementsAdmin.Size = new System.Drawing.Size(102, 17);
            this.lbAllAgreementsAdmin.TabIndex = 1;
            this.lbAllAgreementsAdmin.Text = "All agreements";
            // 
            // tabHouseRulesAdmin
            // 
            this.tabHouseRulesAdmin.Controls.Add(this.btnSaveEditedRule);
            this.tabHouseRulesAdmin.Controls.Add(this.editBoxRule);
            this.tabHouseRulesAdmin.Controls.Add(this.gbxRule);
            this.tabHouseRulesAdmin.Controls.Add(this.gbxRules);
            this.tabHouseRulesAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabHouseRulesAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabHouseRulesAdmin.Name = "tabHouseRulesAdmin";
            this.tabHouseRulesAdmin.Size = new System.Drawing.Size(908, 533);
            this.tabHouseRulesAdmin.TabIndex = 4;
            this.tabHouseRulesAdmin.Text = "House Rules";
            this.tabHouseRulesAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSaveEditedRule
            // 
            this.btnSaveEditedRule.Location = new System.Drawing.Point(496, 459);
            this.btnSaveEditedRule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveEditedRule.Name = "btnSaveEditedRule";
            this.btnSaveEditedRule.Size = new System.Drawing.Size(100, 36);
            this.btnSaveEditedRule.TabIndex = 9;
            this.btnSaveEditedRule.Text = "Save";
            this.btnSaveEditedRule.UseVisualStyleBackColor = true;
            this.btnSaveEditedRule.Visible = false;
            this.btnSaveEditedRule.Click += new System.EventHandler(this.btnSaveEditedRule_Click);
            // 
            // editBoxRule
            // 
            this.editBoxRule.Location = new System.Drawing.Point(411, 338);
            this.editBoxRule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editBoxRule.Multiline = true;
            this.editBoxRule.Name = "editBoxRule";
            this.editBoxRule.Size = new System.Drawing.Size(225, 109);
            this.editBoxRule.TabIndex = 8;
            this.editBoxRule.Visible = false;
            // 
            // gbxRule
            // 
            this.gbxRule.Controls.Add(this.btnAddRule);
            this.gbxRule.Controls.Add(this.tbxAddRule);
            this.gbxRule.Controls.Add(this.lbWriteRule);
            this.gbxRule.Location = new System.Drawing.Point(411, 7);
            this.gbxRule.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxRule.Name = "gbxRule";
            this.gbxRule.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxRule.Size = new System.Drawing.Size(353, 278);
            this.gbxRule.TabIndex = 5;
            this.gbxRule.TabStop = false;
            this.gbxRule.Text = "Add rule";
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(111, 236);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(161, 37);
            this.btnAddRule.TabIndex = 2;
            this.btnAddRule.Text = "Add";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // tbxAddRule
            // 
            this.tbxAddRule.Location = new System.Drawing.Point(85, 43);
            this.tbxAddRule.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxAddRule.Multiline = true;
            this.tbxAddRule.Name = "tbxAddRule";
            this.tbxAddRule.Size = new System.Drawing.Size(219, 169);
            this.tbxAddRule.TabIndex = 1;
            // 
            // lbWriteRule
            // 
            this.lbWriteRule.AutoSize = true;
            this.lbWriteRule.Location = new System.Drawing.Point(103, 17);
            this.lbWriteRule.Name = "lbWriteRule";
            this.lbWriteRule.Size = new System.Drawing.Size(147, 17);
            this.lbWriteRule.TabIndex = 0;
            this.lbWriteRule.Text = "Write down a new rule";
            // 
            // gbxRules
            // 
            this.gbxRules.Controls.Add(this.lbxRulesAdmin);
            this.gbxRules.Controls.Add(this.btnDeleteRule);
            this.gbxRules.Controls.Add(this.btnEditRule);
            this.gbxRules.Location = new System.Drawing.Point(32, 81);
            this.gbxRules.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxRules.Name = "gbxRules";
            this.gbxRules.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxRules.Size = new System.Drawing.Size(357, 423);
            this.gbxRules.TabIndex = 4;
            this.gbxRules.TabStop = false;
            this.gbxRules.Text = "House rules";
            // 
            // lbxRulesAdmin
            // 
            this.lbxRulesAdmin.FormattingEnabled = true;
            this.lbxRulesAdmin.ItemHeight = 16;
            this.lbxRulesAdmin.Location = new System.Drawing.Point(25, 47);
            this.lbxRulesAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbxRulesAdmin.Name = "lbxRulesAdmin";
            this.lbxRulesAdmin.Size = new System.Drawing.Size(307, 308);
            this.lbxRulesAdmin.TabIndex = 0;
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Location = new System.Drawing.Point(43, 378);
            this.btnDeleteRule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteRule.TabIndex = 6;
            this.btnDeleteRule.Text = "Delete";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnEditRule
            // 
            this.btnEditRule.Location = new System.Drawing.Point(207, 378);
            this.btnEditRule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(100, 28);
            this.btnEditRule.TabIndex = 7;
            this.btnEditRule.Text = "Edit";
            this.btnEditRule.UseVisualStyleBackColor = true;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // tabComplaintsAdmin
            // 
            this.tabComplaintsAdmin.Controls.Add(this.gbxSearchComplaints);
            this.tabComplaintsAdmin.Controls.Add(this.gbxAllComplaints);
            this.tabComplaintsAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabComplaintsAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabComplaintsAdmin.Name = "tabComplaintsAdmin";
            this.tabComplaintsAdmin.Size = new System.Drawing.Size(908, 533);
            this.tabComplaintsAdmin.TabIndex = 5;
            this.tabComplaintsAdmin.Text = "Complaints";
            this.tabComplaintsAdmin.UseVisualStyleBackColor = true;
            // 
            // gbxSearchComplaints
            // 
            this.gbxSearchComplaints.Controls.Add(this.btnShowAllComplaints);
            this.gbxSearchComplaints.Controls.Add(this.btnSearchComplaint);
            this.gbxSearchComplaints.Controls.Add(this.tbxSearchComplaint);
            this.gbxSearchComplaints.Location = new System.Drawing.Point(483, 175);
            this.gbxSearchComplaints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearchComplaints.Name = "gbxSearchComplaints";
            this.gbxSearchComplaints.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearchComplaints.Size = new System.Drawing.Size(381, 169);
            this.gbxSearchComplaints.TabIndex = 8;
            this.gbxSearchComplaints.TabStop = false;
            this.gbxSearchComplaints.Text = "Search for a complaint";
            // 
            // btnShowAllComplaints
            // 
            this.btnShowAllComplaints.Location = new System.Drawing.Point(81, 117);
            this.btnShowAllComplaints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAllComplaints.Name = "btnShowAllComplaints";
            this.btnShowAllComplaints.Size = new System.Drawing.Size(207, 32);
            this.btnShowAllComplaints.TabIndex = 2;
            this.btnShowAllComplaints.Text = "Show all complaints";
            this.btnShowAllComplaints.UseVisualStyleBackColor = true;
            this.btnShowAllComplaints.Click += new System.EventHandler(this.btnShowAllComplaints_Click);
            // 
            // btnSearchComplaint
            // 
            this.btnSearchComplaint.Location = new System.Drawing.Point(81, 78);
            this.btnSearchComplaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchComplaint.Name = "btnSearchComplaint";
            this.btnSearchComplaint.Size = new System.Drawing.Size(207, 27);
            this.btnSearchComplaint.TabIndex = 1;
            this.btnSearchComplaint.Text = "Search";
            this.btnSearchComplaint.UseVisualStyleBackColor = true;
            this.btnSearchComplaint.Click += new System.EventHandler(this.btnSearchComplaint_Click);
            // 
            // tbxSearchComplaint
            // 
            this.tbxSearchComplaint.Location = new System.Drawing.Point(23, 44);
            this.tbxSearchComplaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSearchComplaint.Name = "tbxSearchComplaint";
            this.tbxSearchComplaint.Size = new System.Drawing.Size(324, 22);
            this.tbxSearchComplaint.TabIndex = 0;
            // 
            // gbxAllComplaints
            // 
            this.gbxAllComplaints.Controls.Add(this.btnMarkAsDone);
            this.gbxAllComplaints.Controls.Add(this.lbxAllComplaints);
            this.gbxAllComplaints.Location = new System.Drawing.Point(83, 65);
            this.gbxAllComplaints.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxAllComplaints.Name = "gbxAllComplaints";
            this.gbxAllComplaints.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxAllComplaints.Size = new System.Drawing.Size(369, 405);
            this.gbxAllComplaints.TabIndex = 3;
            this.gbxAllComplaints.TabStop = false;
            this.gbxAllComplaints.Text = "All complaints";
            // 
            // btnMarkAsDone
            // 
            this.btnMarkAsDone.Location = new System.Drawing.Point(28, 332);
            this.btnMarkAsDone.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMarkAsDone.Name = "btnMarkAsDone";
            this.btnMarkAsDone.Size = new System.Drawing.Size(308, 43);
            this.btnMarkAsDone.TabIndex = 4;
            this.btnMarkAsDone.Text = "Mark the selected complaint as done";
            this.btnMarkAsDone.UseVisualStyleBackColor = true;
            this.btnMarkAsDone.Click += new System.EventHandler(this.btnMarkAsDone_Click);
            // 
            // lbxAllComplaints
            // 
            this.lbxAllComplaints.FormattingEnabled = true;
            this.lbxAllComplaints.HorizontalScrollbar = true;
            this.lbxAllComplaints.ItemHeight = 16;
            this.lbxAllComplaints.Location = new System.Drawing.Point(28, 57);
            this.lbxAllComplaints.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbxAllComplaints.Name = "lbxAllComplaints";
            this.lbxAllComplaints.Size = new System.Drawing.Size(307, 260);
            this.lbxAllComplaints.TabIndex = 0;
            // 
            // tabManageTenants
            // 
            this.tabManageTenants.Controls.Add(this.gbxEditTenant);
            this.tabManageTenants.Controls.Add(this.gbxSearchTenantEdit);
            this.tabManageTenants.Controls.Add(this.gbxRemoveTenant);
            this.tabManageTenants.Controls.Add(this.gbxRegisterTenants);
            this.tabManageTenants.Location = new System.Drawing.Point(4, 25);
            this.tabManageTenants.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabManageTenants.Name = "tabManageTenants";
            this.tabManageTenants.Size = new System.Drawing.Size(908, 533);
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
            this.gbxEditTenant.Location = new System.Drawing.Point(461, 356);
            this.gbxEditTenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxEditTenant.Name = "gbxEditTenant";
            this.gbxEditTenant.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxEditTenant.Size = new System.Drawing.Size(401, 165);
            this.gbxEditTenant.TabIndex = 14;
            this.gbxEditTenant.TabStop = false;
            this.gbxEditTenant.Text = "Edit profile";
            // 
            // tbxEditPasswordTenant
            // 
            this.tbxEditPasswordTenant.Location = new System.Drawing.Point(175, 66);
            this.tbxEditPasswordTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxEditPasswordTenant.Name = "tbxEditPasswordTenant";
            this.tbxEditPasswordTenant.Size = new System.Drawing.Size(152, 22);
            this.tbxEditPasswordTenant.TabIndex = 8;
            // 
            // btnSaveChangesEditTenantProfile
            // 
            this.btnSaveChangesEditTenantProfile.Location = new System.Drawing.Point(176, 107);
            this.btnSaveChangesEditTenantProfile.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSaveChangesEditTenantProfile.Name = "btnSaveChangesEditTenantProfile";
            this.btnSaveChangesEditTenantProfile.Size = new System.Drawing.Size(152, 30);
            this.btnSaveChangesEditTenantProfile.TabIndex = 13;
            this.btnSaveChangesEditTenantProfile.Text = "Save changes";
            this.btnSaveChangesEditTenantProfile.UseVisualStyleBackColor = true;
            this.btnSaveChangesEditTenantProfile.Click += new System.EventHandler(this.btnSaveChangesEditTenantProfile_Click);
            // 
            // lbEditFNameTenant
            // 
            this.lbEditFNameTenant.AutoSize = true;
            this.lbEditFNameTenant.Location = new System.Drawing.Point(65, 26);
            this.lbEditFNameTenant.Name = "lbEditFNameTenant";
            this.lbEditFNameTenant.Size = new System.Drawing.Size(78, 17);
            this.lbEditFNameTenant.TabIndex = 11;
            this.lbEditFNameTenant.Text = "First name:";
            // 
            // lbEditPasswordTenant
            // 
            this.lbEditPasswordTenant.AutoSize = true;
            this.lbEditPasswordTenant.Location = new System.Drawing.Point(68, 70);
            this.lbEditPasswordTenant.Name = "lbEditPasswordTenant";
            this.lbEditPasswordTenant.Size = new System.Drawing.Size(73, 17);
            this.lbEditPasswordTenant.TabIndex = 7;
            this.lbEditPasswordTenant.Text = "Password:";
            // 
            // tbxEditFNameTenant
            // 
            this.tbxEditFNameTenant.Location = new System.Drawing.Point(175, 23);
            this.tbxEditFNameTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxEditFNameTenant.Name = "tbxEditFNameTenant";
            this.tbxEditFNameTenant.Size = new System.Drawing.Size(152, 22);
            this.tbxEditFNameTenant.TabIndex = 12;
            // 
            // gbxSearchTenantEdit
            // 
            this.gbxSearchTenantEdit.Controls.Add(this.btnShowTenantProfileEdit);
            this.gbxSearchTenantEdit.Controls.Add(this.tbxStudNumSearchTenantEdit);
            this.gbxSearchTenantEdit.Controls.Add(this.lbStudNumSearchTenantEdit);
            this.gbxSearchTenantEdit.Location = new System.Drawing.Point(461, 204);
            this.gbxSearchTenantEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearchTenantEdit.Name = "gbxSearchTenantEdit";
            this.gbxSearchTenantEdit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearchTenantEdit.Size = new System.Drawing.Size(401, 128);
            this.gbxSearchTenantEdit.TabIndex = 2;
            this.gbxSearchTenantEdit.TabStop = false;
            this.gbxSearchTenantEdit.Text = "Find a profile to edit";
            // 
            // btnShowTenantProfileEdit
            // 
            this.btnShowTenantProfileEdit.Location = new System.Drawing.Point(175, 78);
            this.btnShowTenantProfileEdit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnShowTenantProfileEdit.Name = "btnShowTenantProfileEdit";
            this.btnShowTenantProfileEdit.Size = new System.Drawing.Size(152, 30);
            this.btnShowTenantProfileEdit.TabIndex = 10;
            this.btnShowTenantProfileEdit.Text = "Show profile to edit";
            this.btnShowTenantProfileEdit.UseVisualStyleBackColor = true;
            this.btnShowTenantProfileEdit.Click += new System.EventHandler(this.btnShowTenantProfileEdit_Click);
            // 
            // tbxStudNumSearchTenantEdit
            // 
            this.tbxStudNumSearchTenantEdit.Location = new System.Drawing.Point(175, 36);
            this.tbxStudNumSearchTenantEdit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxStudNumSearchTenantEdit.Name = "tbxStudNumSearchTenantEdit";
            this.tbxStudNumSearchTenantEdit.Size = new System.Drawing.Size(152, 22);
            this.tbxStudNumSearchTenantEdit.TabIndex = 9;
            // 
            // lbStudNumSearchTenantEdit
            // 
            this.lbStudNumSearchTenantEdit.AutoSize = true;
            this.lbStudNumSearchTenantEdit.Location = new System.Drawing.Point(20, 36);
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
            this.gbxRemoveTenant.Location = new System.Drawing.Point(461, 28);
            this.gbxRemoveTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxRemoveTenant.Name = "gbxRemoveTenant";
            this.gbxRemoveTenant.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxRemoveTenant.Size = new System.Drawing.Size(401, 171);
            this.gbxRemoveTenant.TabIndex = 1;
            this.gbxRemoveTenant.TabStop = false;
            this.gbxRemoveTenant.Text = "Remove tenant";
            // 
            // btnRemoveTenant
            // 
            this.btnRemoveTenant.Location = new System.Drawing.Point(196, 101);
            this.btnRemoveTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnRemoveTenant.Name = "btnRemoveTenant";
            this.btnRemoveTenant.Size = new System.Drawing.Size(152, 30);
            this.btnRemoveTenant.TabIndex = 7;
            this.btnRemoveTenant.Text = "Remove";
            this.btnRemoveTenant.UseVisualStyleBackColor = true;
            this.btnRemoveTenant.Click += new System.EventHandler(this.btnRemoveTenant_Click);
            // 
            // tbxStudentNumRemove
            // 
            this.tbxStudentNumRemove.Location = new System.Drawing.Point(196, 50);
            this.tbxStudentNumRemove.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxStudentNumRemove.Name = "tbxStudentNumRemove";
            this.tbxStudentNumRemove.Size = new System.Drawing.Size(152, 22);
            this.tbxStudentNumRemove.TabIndex = 5;
            // 
            // lbStudentNumRemove
            // 
            this.lbStudentNumRemove.AutoSize = true;
            this.lbStudentNumRemove.Location = new System.Drawing.Point(40, 55);
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
            this.gbxRegisterTenants.Location = new System.Drawing.Point(17, 28);
            this.gbxRegisterTenants.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxRegisterTenants.Name = "gbxRegisterTenants";
            this.gbxRegisterTenants.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxRegisterTenants.Size = new System.Drawing.Size(412, 373);
            this.gbxRegisterTenants.TabIndex = 0;
            this.gbxRegisterTenants.TabStop = false;
            this.gbxRegisterTenants.Text = "Register tenants";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(180, 289);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(152, 36);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbxPasswordRegister
            // 
            this.tbxPasswordRegister.Location = new System.Drawing.Point(179, 219);
            this.tbxPasswordRegister.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxPasswordRegister.Name = "tbxPasswordRegister";
            this.tbxPasswordRegister.Size = new System.Drawing.Size(152, 22);
            this.tbxPasswordRegister.TabIndex = 5;
            // 
            // tbxFirstNameRegister
            // 
            this.tbxFirstNameRegister.Location = new System.Drawing.Point(179, 156);
            this.tbxFirstNameRegister.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxFirstNameRegister.Name = "tbxFirstNameRegister";
            this.tbxFirstNameRegister.Size = new System.Drawing.Size(152, 22);
            this.tbxFirstNameRegister.TabIndex = 4;
            // 
            // tbxStudentNumRegister
            // 
            this.tbxStudentNumRegister.Location = new System.Drawing.Point(179, 89);
            this.tbxStudentNumRegister.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxStudentNumRegister.Name = "tbxStudentNumRegister";
            this.tbxStudentNumRegister.Size = new System.Drawing.Size(152, 22);
            this.tbxStudentNumRegister.TabIndex = 3;
            // 
            // lbPasswordRegister
            // 
            this.lbPasswordRegister.AutoSize = true;
            this.lbPasswordRegister.Location = new System.Drawing.Point(81, 225);
            this.lbPasswordRegister.Name = "lbPasswordRegister";
            this.lbPasswordRegister.Size = new System.Drawing.Size(73, 17);
            this.lbPasswordRegister.TabIndex = 2;
            this.lbPasswordRegister.Text = "Password:";
            // 
            // lbFirstNameRegister
            // 
            this.lbFirstNameRegister.AutoSize = true;
            this.lbFirstNameRegister.Location = new System.Drawing.Point(75, 160);
            this.lbFirstNameRegister.Name = "lbFirstNameRegister";
            this.lbFirstNameRegister.Size = new System.Drawing.Size(78, 17);
            this.lbFirstNameRegister.TabIndex = 1;
            this.lbFirstNameRegister.Text = "First name:";
            // 
            // lbStudentNumRegister
            // 
            this.lbStudentNumRegister.AutoSize = true;
            this.lbStudentNumRegister.Location = new System.Drawing.Point(39, 89);
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
            this.MenuTenant.Location = new System.Drawing.Point(936, 230);
            this.MenuTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MenuTenant.Name = "MenuTenant";
            this.MenuTenant.SelectedIndex = 0;
            this.MenuTenant.Size = new System.Drawing.Size(760, 553);
            this.MenuTenant.TabIndex = 2;
            // 
            // tabHomeTenant
            // 
            this.tabHomeTenant.Controls.Add(this.btnLogOutTenant);
            this.tabHomeTenant.Controls.Add(this.lbWelcomeMsgTenant);
            this.tabHomeTenant.ImageKey = "(none)";
            this.tabHomeTenant.Location = new System.Drawing.Point(4, 25);
            this.tabHomeTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabHomeTenant.Name = "tabHomeTenant";
            this.tabHomeTenant.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabHomeTenant.Size = new System.Drawing.Size(752, 524);
            this.tabHomeTenant.TabIndex = 0;
            this.tabHomeTenant.Text = "Home";
            this.tabHomeTenant.UseVisualStyleBackColor = true;
            // 
            // btnLogOutTenant
            // 
            this.btnLogOutTenant.Location = new System.Drawing.Point(32, 460);
            this.btnLogOutTenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOutTenant.Name = "btnLogOutTenant";
            this.btnLogOutTenant.Size = new System.Drawing.Size(104, 36);
            this.btnLogOutTenant.TabIndex = 4;
            this.btnLogOutTenant.Text = "Log out";
            this.btnLogOutTenant.UseVisualStyleBackColor = true;
            this.btnLogOutTenant.Click += new System.EventHandler(this.btnLogOutTenant_Click);
            // 
            // lbWelcomeMsgTenant
            // 
            this.lbWelcomeMsgTenant.AutoSize = true;
            this.lbWelcomeMsgTenant.Location = new System.Drawing.Point(89, 79);
            this.lbWelcomeMsgTenant.Name = "lbWelcomeMsgTenant";
            this.lbWelcomeMsgTenant.Size = new System.Drawing.Size(74, 17);
            this.lbWelcomeMsgTenant.TabIndex = 0;
            this.lbWelcomeMsgTenant.Text = "Welcome, ";
            // 
            // tabGroceriesTenant
            // 
            this.tabGroceriesTenant.Controls.Add(this.gbxPayListGroceriesTenant);
            this.tabGroceriesTenant.Location = new System.Drawing.Point(4, 25);
            this.tabGroceriesTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabGroceriesTenant.Name = "tabGroceriesTenant";
            this.tabGroceriesTenant.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabGroceriesTenant.Size = new System.Drawing.Size(752, 524);
            this.tabGroceriesTenant.TabIndex = 1;
            this.tabGroceriesTenant.Text = "Groceries";
            this.tabGroceriesTenant.UseVisualStyleBackColor = true;
            // 
            // gbxPayListGroceriesTenant
            // 
            this.gbxPayListGroceriesTenant.Controls.Add(this.lbxUnpaidGroceries);
            this.gbxPayListGroceriesTenant.Location = new System.Drawing.Point(227, 52);
            this.gbxPayListGroceriesTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxPayListGroceriesTenant.Name = "gbxPayListGroceriesTenant";
            this.gbxPayListGroceriesTenant.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxPayListGroceriesTenant.Size = new System.Drawing.Size(403, 436);
            this.gbxPayListGroceriesTenant.TabIndex = 4;
            this.gbxPayListGroceriesTenant.TabStop = false;
            this.gbxPayListGroceriesTenant.Text = "Pay list groceries";
            // 
            // lbxUnpaidGroceries
            // 
            this.lbxUnpaidGroceries.FormattingEnabled = true;
            this.lbxUnpaidGroceries.ItemHeight = 16;
            this.lbxUnpaidGroceries.Location = new System.Drawing.Point(36, 60);
            this.lbxUnpaidGroceries.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbxUnpaidGroceries.Name = "lbxUnpaidGroceries";
            this.lbxUnpaidGroceries.Size = new System.Drawing.Size(324, 308);
            this.lbxUnpaidGroceries.TabIndex = 3;
            // 
            // tabAnnouncementsTenant
            // 
            this.tabAnnouncementsTenant.Controls.Add(this.gbxNewsFeedTenant);
            this.tabAnnouncementsTenant.Location = new System.Drawing.Point(4, 25);
            this.tabAnnouncementsTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabAnnouncementsTenant.Name = "tabAnnouncementsTenant";
            this.tabAnnouncementsTenant.Size = new System.Drawing.Size(752, 524);
            this.tabAnnouncementsTenant.TabIndex = 2;
            this.tabAnnouncementsTenant.Text = "Announcements";
            this.tabAnnouncementsTenant.UseVisualStyleBackColor = true;
            // 
            // gbxNewsFeedTenant
            // 
            this.gbxNewsFeedTenant.Controls.Add(this.lbxUserAllAnnouncements);
            this.gbxNewsFeedTenant.Controls.Add(this.lblAllAnnouncementTenant);
            this.gbxNewsFeedTenant.Location = new System.Drawing.Point(21, 27);
            this.gbxNewsFeedTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxNewsFeedTenant.Name = "gbxNewsFeedTenant";
            this.gbxNewsFeedTenant.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxNewsFeedTenant.Size = new System.Drawing.Size(377, 460);
            this.gbxNewsFeedTenant.TabIndex = 2;
            this.gbxNewsFeedTenant.TabStop = false;
            this.gbxNewsFeedTenant.Text = "News feed";
            // 
            // lbxUserAllAnnouncements
            // 
            this.lbxUserAllAnnouncements.FormattingEnabled = true;
            this.lbxUserAllAnnouncements.ItemHeight = 16;
            this.lbxUserAllAnnouncements.Location = new System.Drawing.Point(37, 60);
            this.lbxUserAllAnnouncements.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbxUserAllAnnouncements.Name = "lbxUserAllAnnouncements";
            this.lbxUserAllAnnouncements.Size = new System.Drawing.Size(307, 356);
            this.lbxUserAllAnnouncements.TabIndex = 0;
            // 
            // lblAllAnnouncementTenant
            // 
            this.lblAllAnnouncementTenant.AutoSize = true;
            this.lblAllAnnouncementTenant.Location = new System.Drawing.Point(125, 26);
            this.lblAllAnnouncementTenant.Name = "lblAllAnnouncementTenant";
            this.lblAllAnnouncementTenant.Size = new System.Drawing.Size(128, 17);
            this.lblAllAnnouncementTenant.TabIndex = 1;
            this.lblAllAnnouncementTenant.Text = "All announcements";
            // 
            // tabAgreementsTenant
            // 
            this.tabAgreementsTenant.Controls.Add(this.gbxSearchAgreementTenant);
            this.tabAgreementsTenant.Controls.Add(this.gbxAllAgreements);
            this.tabAgreementsTenant.Controls.Add(this.gbxAddAgreement);
            this.tabAgreementsTenant.Location = new System.Drawing.Point(4, 25);
            this.tabAgreementsTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabAgreementsTenant.Name = "tabAgreementsTenant";
            this.tabAgreementsTenant.Size = new System.Drawing.Size(752, 524);
            this.tabAgreementsTenant.TabIndex = 3;
            this.tabAgreementsTenant.Text = "Agreements";
            this.tabAgreementsTenant.UseVisualStyleBackColor = true;
            // 
            // gbxSearchAgreementTenant
            // 
            this.gbxSearchAgreementTenant.Controls.Add(this.btnShowAllAgreementsTenant);
            this.gbxSearchAgreementTenant.Controls.Add(this.btnSearchAgreementTenant);
            this.gbxSearchAgreementTenant.Controls.Add(this.tbxSearchAgreementsTenant);
            this.gbxSearchAgreementTenant.Location = new System.Drawing.Point(19, 331);
            this.gbxSearchAgreementTenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearchAgreementTenant.Name = "gbxSearchAgreementTenant";
            this.gbxSearchAgreementTenant.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSearchAgreementTenant.Size = new System.Drawing.Size(381, 169);
            this.gbxSearchAgreementTenant.TabIndex = 6;
            this.gbxSearchAgreementTenant.TabStop = false;
            this.gbxSearchAgreementTenant.Text = "Search for an agreement";
            // 
            // btnShowAllAgreementsTenant
            // 
            this.btnShowAllAgreementsTenant.Location = new System.Drawing.Point(81, 117);
            this.btnShowAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAllAgreementsTenant.Name = "btnShowAllAgreementsTenant";
            this.btnShowAllAgreementsTenant.Size = new System.Drawing.Size(207, 27);
            this.btnShowAllAgreementsTenant.TabIndex = 2;
            this.btnShowAllAgreementsTenant.Text = "Show all agreements";
            this.btnShowAllAgreementsTenant.UseVisualStyleBackColor = true;
            this.btnShowAllAgreementsTenant.Click += new System.EventHandler(this.btnShowAllAgreements_Click);
            // 
            // btnSearchAgreementTenant
            // 
            this.btnSearchAgreementTenant.Location = new System.Drawing.Point(81, 78);
            this.btnSearchAgreementTenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchAgreementTenant.Name = "btnSearchAgreementTenant";
            this.btnSearchAgreementTenant.Size = new System.Drawing.Size(207, 27);
            this.btnSearchAgreementTenant.TabIndex = 1;
            this.btnSearchAgreementTenant.Text = "Search";
            this.btnSearchAgreementTenant.UseVisualStyleBackColor = true;
            this.btnSearchAgreementTenant.Click += new System.EventHandler(this.btnSearchAgreement_Click);
            // 
            // tbxSearchAgreementsTenant
            // 
            this.tbxSearchAgreementsTenant.Location = new System.Drawing.Point(23, 44);
            this.tbxSearchAgreementsTenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSearchAgreementsTenant.Name = "tbxSearchAgreementsTenant";
            this.tbxSearchAgreementsTenant.Size = new System.Drawing.Size(324, 22);
            this.tbxSearchAgreementsTenant.TabIndex = 0;
            // 
            // gbxAllAgreements
            // 
            this.gbxAllAgreements.Controls.Add(this.btnDisagree);
            this.gbxAllAgreements.Controls.Add(this.btnAgree);
            this.gbxAllAgreements.Controls.Add(this.lbxAllAgreementsTenant);
            this.gbxAllAgreements.Controls.Add(this.lblAllAgreementsTenant);
            this.gbxAllAgreements.Location = new System.Drawing.Point(447, 30);
            this.gbxAllAgreements.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxAllAgreements.Name = "gbxAllAgreements";
            this.gbxAllAgreements.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxAllAgreements.Size = new System.Drawing.Size(325, 470);
            this.gbxAllAgreements.TabIndex = 5;
            this.gbxAllAgreements.TabStop = false;
            // 
            // btnDisagree
            // 
            this.btnDisagree.Location = new System.Drawing.Point(37, 418);
            this.btnDisagree.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDisagree.Name = "btnDisagree";
            this.btnDisagree.Size = new System.Drawing.Size(256, 27);
            this.btnDisagree.TabIndex = 3;
            this.btnDisagree.Text = "Disagree with selected";
            this.btnDisagree.UseVisualStyleBackColor = true;
            this.btnDisagree.Click += new System.EventHandler(this.btnDisagree_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.Location = new System.Drawing.Point(37, 390);
            this.btnAgree.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(256, 27);
            this.btnAgree.TabIndex = 2;
            this.btnAgree.Text = "Agree with selected";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // lbxAllAgreementsTenant
            // 
            this.lbxAllAgreementsTenant.FormattingEnabled = true;
            this.lbxAllAgreementsTenant.HorizontalScrollbar = true;
            this.lbxAllAgreementsTenant.ItemHeight = 16;
            this.lbxAllAgreementsTenant.Location = new System.Drawing.Point(37, 66);
            this.lbxAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbxAllAgreementsTenant.Name = "lbxAllAgreementsTenant";
            this.lbxAllAgreementsTenant.Size = new System.Drawing.Size(256, 308);
            this.lbxAllAgreementsTenant.TabIndex = 0;
            // 
            // lblAllAgreementsTenant
            // 
            this.lblAllAgreementsTenant.AutoSize = true;
            this.lblAllAgreementsTenant.Location = new System.Drawing.Point(113, 30);
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
            this.gbxAddAgreement.Location = new System.Drawing.Point(19, 1);
            this.gbxAddAgreement.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxAddAgreement.Name = "gbxAddAgreement";
            this.gbxAddAgreement.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxAddAgreement.Size = new System.Drawing.Size(381, 324);
            this.gbxAddAgreement.TabIndex = 4;
            this.gbxAddAgreement.TabStop = false;
            // 
            // btnAddAgreement
            // 
            this.btnAddAgreement.Location = new System.Drawing.Point(113, 263);
            this.btnAddAgreement.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAddAgreement.Name = "btnAddAgreement";
            this.btnAddAgreement.Size = new System.Drawing.Size(161, 37);
            this.btnAddAgreement.TabIndex = 2;
            this.btnAddAgreement.Text = "Add";
            this.btnAddAgreement.UseVisualStyleBackColor = true;
            this.btnAddAgreement.Click += new System.EventHandler(this.btnAddAgreement_Click);
            // 
            // tbxAddAgreement
            // 
            this.tbxAddAgreement.Location = new System.Drawing.Point(44, 76);
            this.tbxAddAgreement.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxAddAgreement.Multiline = true;
            this.tbxAddAgreement.Name = "tbxAddAgreement";
            this.tbxAddAgreement.Size = new System.Drawing.Size(303, 169);
            this.tbxAddAgreement.TabIndex = 1;
            // 
            // lbWriteAgreement
            // 
            this.lbWriteAgreement.AutoSize = true;
            this.lbWriteAgreement.Location = new System.Drawing.Point(105, 44);
            this.lbWriteAgreement.Name = "lbWriteAgreement";
            this.lbWriteAgreement.Size = new System.Drawing.Size(171, 17);
            this.lbWriteAgreement.TabIndex = 0;
            this.lbWriteAgreement.Text = "Write down your message";
            // 
            // tabHouseRulesTenant
            // 
            this.tabHouseRulesTenant.Controls.Add(this.gbxHouseRulseTenant);
            this.tabHouseRulesTenant.Location = new System.Drawing.Point(4, 25);
            this.tabHouseRulesTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabHouseRulesTenant.Name = "tabHouseRulesTenant";
            this.tabHouseRulesTenant.Size = new System.Drawing.Size(752, 524);
            this.tabHouseRulesTenant.TabIndex = 4;
            this.tabHouseRulesTenant.Text = "House Rules";
            this.tabHouseRulesTenant.UseVisualStyleBackColor = true;
            // 
            // gbxHouseRulseTenant
            // 
            this.gbxHouseRulseTenant.Controls.Add(this.lbxRulesTenant);
            this.gbxHouseRulseTenant.Location = new System.Drawing.Point(241, 22);
            this.gbxHouseRulseTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxHouseRulseTenant.Name = "gbxHouseRulseTenant";
            this.gbxHouseRulseTenant.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbxHouseRulseTenant.Size = new System.Drawing.Size(377, 463);
            this.gbxHouseRulseTenant.TabIndex = 4;
            this.gbxHouseRulseTenant.TabStop = false;
            this.gbxHouseRulseTenant.Text = "House rules";
            // 
            // lbxRulesTenant
            // 
            this.lbxRulesTenant.FormattingEnabled = true;
            this.lbxRulesTenant.ItemHeight = 16;
            this.lbxRulesTenant.Location = new System.Drawing.Point(43, 46);
            this.lbxRulesTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbxRulesTenant.Name = "lbxRulesTenant";
            this.lbxRulesTenant.Size = new System.Drawing.Size(307, 372);
            this.lbxRulesTenant.TabIndex = 0;
            // 
            // tabComplaintsTenant
            // 
            this.tabComplaintsTenant.Controls.Add(this.btnComplaint);
            this.tabComplaintsTenant.Controls.Add(this.tbxWriteComplaint);
            this.tabComplaintsTenant.Controls.Add(this.lbWriteComplaint);
            this.tabComplaintsTenant.Location = new System.Drawing.Point(4, 25);
            this.tabComplaintsTenant.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabComplaintsTenant.Name = "tabComplaintsTenant";
            this.tabComplaintsTenant.Size = new System.Drawing.Size(752, 524);
            this.tabComplaintsTenant.TabIndex = 5;
            this.tabComplaintsTenant.Text = "Complaints";
            this.tabComplaintsTenant.UseVisualStyleBackColor = true;
            // 
            // btnComplaint
            // 
            this.btnComplaint.Location = new System.Drawing.Point(364, 324);
            this.btnComplaint.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnComplaint.Name = "btnComplaint";
            this.btnComplaint.Size = new System.Drawing.Size(161, 37);
            this.btnComplaint.TabIndex = 2;
            this.btnComplaint.Text = "Send";
            this.btnComplaint.UseVisualStyleBackColor = true;
            this.btnComplaint.Click += new System.EventHandler(this.btnComplaint_Click);
            // 
            // tbxWriteComplaint
            // 
            this.tbxWriteComplaint.Location = new System.Drawing.Point(295, 137);
            this.tbxWriteComplaint.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxWriteComplaint.Multiline = true;
            this.tbxWriteComplaint.Name = "tbxWriteComplaint";
            this.tbxWriteComplaint.Size = new System.Drawing.Size(303, 169);
            this.tbxWriteComplaint.TabIndex = 1;
            // 
            // lbWriteComplaint
            // 
            this.lbWriteComplaint.AutoSize = true;
            this.lbWriteComplaint.Location = new System.Drawing.Point(357, 107);
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
            this.gbxLogin.Location = new System.Drawing.Point(579, 14);
            this.gbxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxLogin.Size = new System.Drawing.Size(685, 212);
            this.gbxLogin.TabIndex = 1;
            this.gbxLogin.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(356, 153);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 31);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPasswordLogin
            // 
            this.tbxPasswordLogin.Location = new System.Drawing.Point(356, 102);
            this.tbxPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPasswordLogin.Name = "tbxPasswordLogin";
            this.tbxPasswordLogin.Size = new System.Drawing.Size(141, 22);
            this.tbxPasswordLogin.TabIndex = 3;
            this.tbxPasswordLogin.UseSystemPasswordChar = true;
            // 
            // tbxUsernameLogin
            // 
            this.tbxUsernameLogin.Location = new System.Drawing.Point(356, 59);
            this.tbxUsernameLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxUsernameLogin.Name = "tbxUsernameLogin";
            this.tbxUsernameLogin.Size = new System.Drawing.Size(141, 22);
            this.tbxUsernameLogin.TabIndex = 2;
            // 
            // lbPasswordLogin
            // 
            this.lbPasswordLogin.AutoSize = true;
            this.lbPasswordLogin.Location = new System.Drawing.Point(241, 102);
            this.lbPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPasswordLogin.Name = "lbPasswordLogin";
            this.lbPasswordLogin.Size = new System.Drawing.Size(73, 17);
            this.lbPasswordLogin.TabIndex = 1;
            this.lbPasswordLogin.Text = "Password:";
            // 
            // lbUsernameLogin
            // 
            this.lbUsernameLogin.AutoSize = true;
            this.lbUsernameLogin.Location = new System.Drawing.Point(124, 66);
            this.lbUsernameLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsernameLogin.Name = "lbUsernameLogin";
            this.lbUsernameLogin.Size = new System.Drawing.Size(190, 17);
            this.lbUsernameLogin.TabIndex = 0;
            this.lbUsernameLogin.Text = "Username / Student number:";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 60000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // HousingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 790);
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.MenuTenant);
            this.Controls.Add(this.MenuAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.gbxSearchAgreementAdmin.ResumeLayout(false);
            this.gbxSearchAgreementAdmin.PerformLayout();
            this.tabHouseRulesAdmin.ResumeLayout(false);
            this.tabHouseRulesAdmin.PerformLayout();
            this.gbxRule.ResumeLayout(false);
            this.gbxRule.PerformLayout();
            this.gbxRules.ResumeLayout(false);
            this.tabComplaintsAdmin.ResumeLayout(false);
            this.gbxSearchComplaints.ResumeLayout(false);
            this.gbxSearchComplaints.PerformLayout();
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
            this.gbxSearchAgreementTenant.ResumeLayout(false);
            this.gbxSearchAgreementTenant.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxSearchAgreementTenant;
        private System.Windows.Forms.Button btnShowAllAgreementsTenant;
        private System.Windows.Forms.Button btnSearchAgreementTenant;
        private System.Windows.Forms.TextBox tbxSearchAgreementsTenant;
        private System.Windows.Forms.GroupBox gbxSearchAgreementAdmin;
        private System.Windows.Forms.Button btnShowAllAgreementsAdmin;
        private System.Windows.Forms.Button btnSearchAgreementAdmin;
        private System.Windows.Forms.TextBox tbxSearchAgreementsAdmin;
        private System.Windows.Forms.GroupBox gbxSearchComplaints;
        private System.Windows.Forms.Button btnShowAllComplaints;
        private System.Windows.Forms.Button btnSearchComplaint;
        private System.Windows.Forms.TextBox tbxSearchComplaint;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.TextBox editBoxRule;
        private System.Windows.Forms.Button btnSaveEditedRule;
    }
}