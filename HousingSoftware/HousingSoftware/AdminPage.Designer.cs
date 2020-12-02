namespace HousingSoftware
{
    partial class AdminPage
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
            this.Menu = new System.Windows.Forms.TabControl();
            this.tabHomeAdmin = new System.Windows.Forms.TabPage();
            this.lbWelcomeMsgAdmin = new System.Windows.Forms.Label();
            this.tabGroceriesAdmin = new System.Windows.Forms.TabPage();
            this.gbxPayListGroceries = new System.Windows.Forms.GroupBox();
            this.btnMarkAllAsPaid = new System.Windows.Forms.Button();
            this.btnMarkSelectedAsPaid = new System.Windows.Forms.Button();
            this.lbxUnpaidGroceriesPerStudent = new System.Windows.Forms.ListBox();
            this.tbxStudNumUnpaidItems = new System.Windows.Forms.TextBox();
            this.btnShowToPayList = new System.Windows.Forms.Button();
            this.lbStudNumUnpaidItems = new System.Windows.Forms.Label();
            this.gbxAddGrocery = new System.Windows.Forms.GroupBox();
            this.btnAddGrocery = new System.Windows.Forms.Button();
            this.tbxGroceryName = new System.Windows.Forms.TextBox();
            this.lbGroceryName = new System.Windows.Forms.Label();
            this.gbxGroceriesAdmin = new System.Windows.Forms.GroupBox();
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
            this.lbxAllAnnouncements = new System.Windows.Forms.ListBox();
            this.lbAllAnnouncements = new System.Windows.Forms.Label();
            this.tabAgreementsAdmin = new System.Windows.Forms.TabPage();
            this.lbxAllAgreementsAdmin = new System.Windows.Forms.ListBox();
            this.lbAllAgreementsAdmin = new System.Windows.Forms.Label();
            this.tabHouseRules = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchRule = new System.Windows.Forms.Button();
            this.tbxRuleNum = new System.Windows.Forms.TextBox();
            this.lbRuleNum = new System.Windows.Forms.Label();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.tbxEditRule = new System.Windows.Forms.TextBox();
            this.lbEditRule = new System.Windows.Forms.Label();
            this.gbxRule = new System.Windows.Forms.GroupBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.tbxAddRule = new System.Windows.Forms.TextBox();
            this.lbWriteRule = new System.Windows.Forms.Label();
            this.gbxRules = new System.Windows.Forms.GroupBox();
            this.lbxRules = new System.Windows.Forms.ListBox();
            this.tabComplaintsAdmin = new System.Windows.Forms.TabPage();
            this.gbxAllComplaints = new System.Windows.Forms.GroupBox();
            this.lbxAllComplaints = new System.Windows.Forms.ListBox();
            this.tabManageTenants = new System.Windows.Forms.TabPage();
            this.gbxRemoveTenant = new System.Windows.Forms.GroupBox();
            this.btnRemoveTenant = new System.Windows.Forms.Button();
            this.tbxStudentNumRemove = new System.Windows.Forms.TextBox();
            this.lbStudentNumRemove = new System.Windows.Forms.Label();
            this.gbxRegisterTenants = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxStudentNum = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbStudentNum = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.tabHomeAdmin.SuspendLayout();
            this.tabGroceriesAdmin.SuspendLayout();
            this.gbxPayListGroceries.SuspendLayout();
            this.gbxAddGrocery.SuspendLayout();
            this.gbxGroceriesAdmin.SuspendLayout();
            this.tabAnnouncementsAdmin.SuspendLayout();
            this.gbxPostAnnouncements.SuspendLayout();
            this.gbxNewsFeed.SuspendLayout();
            this.tabAgreementsAdmin.SuspendLayout();
            this.tabHouseRules.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxRule.SuspendLayout();
            this.gbxRules.SuspendLayout();
            this.tabComplaintsAdmin.SuspendLayout();
            this.gbxAllComplaints.SuspendLayout();
            this.tabManageTenants.SuspendLayout();
            this.gbxRemoveTenant.SuspendLayout();
            this.gbxRegisterTenants.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.tabHomeAdmin);
            this.Menu.Controls.Add(this.tabGroceriesAdmin);
            this.Menu.Controls.Add(this.tabAnnouncementsAdmin);
            this.Menu.Controls.Add(this.tabAgreementsAdmin);
            this.Menu.Controls.Add(this.tabHouseRules);
            this.Menu.Controls.Add(this.tabComplaintsAdmin);
            this.Menu.Controls.Add(this.tabManageTenants);
            this.Menu.Location = new System.Drawing.Point(11, 17);
            this.Menu.Margin = new System.Windows.Forms.Padding(2);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(1245, 642);
            this.Menu.TabIndex = 0;
            // 
            // tabHomeAdmin
            // 
            this.tabHomeAdmin.Controls.Add(this.lbWelcomeMsgAdmin);
            this.tabHomeAdmin.ImageKey = "(none)";
            this.tabHomeAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabHomeAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tabHomeAdmin.Name = "tabHomeAdmin";
            this.tabHomeAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.tabHomeAdmin.Size = new System.Drawing.Size(1237, 616);
            this.tabHomeAdmin.TabIndex = 0;
            this.tabHomeAdmin.Text = "Home";
            this.tabHomeAdmin.UseVisualStyleBackColor = true;
            // 
            // lbWelcomeMsgAdmin
            // 
            this.lbWelcomeMsgAdmin.AutoSize = true;
            this.lbWelcomeMsgAdmin.Location = new System.Drawing.Point(67, 70);
            this.lbWelcomeMsgAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcomeMsgAdmin.Name = "lbWelcomeMsgAdmin";
            this.lbWelcomeMsgAdmin.Size = new System.Drawing.Size(58, 13);
            this.lbWelcomeMsgAdmin.TabIndex = 0;
            this.lbWelcomeMsgAdmin.Text = "Welcome, ";
            // 
            // tabGroceriesAdmin
            // 
            this.tabGroceriesAdmin.Controls.Add(this.gbxPayListGroceries);
            this.tabGroceriesAdmin.Controls.Add(this.gbxAddGrocery);
            this.tabGroceriesAdmin.Controls.Add(this.gbxGroceriesAdmin);
            this.tabGroceriesAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabGroceriesAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tabGroceriesAdmin.Name = "tabGroceriesAdmin";
            this.tabGroceriesAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.tabGroceriesAdmin.Size = new System.Drawing.Size(1237, 616);
            this.tabGroceriesAdmin.TabIndex = 1;
            this.tabGroceriesAdmin.Text = "Groceries";
            this.tabGroceriesAdmin.UseVisualStyleBackColor = true;
            // 
            // gbxPayListGroceries
            // 
            this.gbxPayListGroceries.Controls.Add(this.btnMarkAllAsPaid);
            this.gbxPayListGroceries.Controls.Add(this.btnMarkSelectedAsPaid);
            this.gbxPayListGroceries.Controls.Add(this.lbxUnpaidGroceriesPerStudent);
            this.gbxPayListGroceries.Controls.Add(this.tbxStudNumUnpaidItems);
            this.gbxPayListGroceries.Controls.Add(this.btnShowToPayList);
            this.gbxPayListGroceries.Controls.Add(this.lbStudNumUnpaidItems);
            this.gbxPayListGroceries.Location = new System.Drawing.Point(313, 13);
            this.gbxPayListGroceries.Margin = new System.Windows.Forms.Padding(2);
            this.gbxPayListGroceries.Name = "gbxPayListGroceries";
            this.gbxPayListGroceries.Padding = new System.Windows.Forms.Padding(2);
            this.gbxPayListGroceries.Size = new System.Drawing.Size(343, 408);
            this.gbxPayListGroceries.TabIndex = 4;
            this.gbxPayListGroceries.TabStop = false;
            this.gbxPayListGroceries.Text = "Pay list groceries";
            // 
            // btnMarkAllAsPaid
            // 
            this.btnMarkAllAsPaid.Location = new System.Drawing.Point(201, 355);
            this.btnMarkAllAsPaid.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarkAllAsPaid.Name = "btnMarkAllAsPaid";
            this.btnMarkAllAsPaid.Size = new System.Drawing.Size(113, 27);
            this.btnMarkAllAsPaid.TabIndex = 4;
            this.btnMarkAllAsPaid.Text = "Mark all as paid";
            this.btnMarkAllAsPaid.UseVisualStyleBackColor = true;
            // 
            // btnMarkSelectedAsPaid
            // 
            this.btnMarkSelectedAsPaid.Location = new System.Drawing.Point(27, 355);
            this.btnMarkSelectedAsPaid.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarkSelectedAsPaid.Name = "btnMarkSelectedAsPaid";
            this.btnMarkSelectedAsPaid.Size = new System.Drawing.Size(135, 27);
            this.btnMarkSelectedAsPaid.TabIndex = 4;
            this.btnMarkSelectedAsPaid.Text = "Mark selected as paid";
            this.btnMarkSelectedAsPaid.UseVisualStyleBackColor = true;
            // 
            // lbxUnpaidGroceriesPerStudent
            // 
            this.lbxUnpaidGroceriesPerStudent.FormattingEnabled = true;
            this.lbxUnpaidGroceriesPerStudent.Location = new System.Drawing.Point(27, 92);
            this.lbxUnpaidGroceriesPerStudent.Margin = new System.Windows.Forms.Padding(2);
            this.lbxUnpaidGroceriesPerStudent.Name = "lbxUnpaidGroceriesPerStudent";
            this.lbxUnpaidGroceriesPerStudent.Size = new System.Drawing.Size(289, 238);
            this.lbxUnpaidGroceriesPerStudent.TabIndex = 3;
            // 
            // tbxStudNumUnpaidItems
            // 
            this.tbxStudNumUnpaidItems.Location = new System.Drawing.Point(109, 44);
            this.tbxStudNumUnpaidItems.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStudNumUnpaidItems.Name = "tbxStudNumUnpaidItems";
            this.tbxStudNumUnpaidItems.Size = new System.Drawing.Size(96, 20);
            this.tbxStudNumUnpaidItems.TabIndex = 2;
            // 
            // btnShowToPayList
            // 
            this.btnShowToPayList.Location = new System.Drawing.Point(216, 40);
            this.btnShowToPayList.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowToPayList.Name = "btnShowToPayList";
            this.btnShowToPayList.Size = new System.Drawing.Size(115, 26);
            this.btnShowToPayList.TabIndex = 1;
            this.btnShowToPayList.Text = "Show to-pay list";
            this.btnShowToPayList.UseVisualStyleBackColor = true;
            // 
            // lbStudNumUnpaidItems
            // 
            this.lbStudNumUnpaidItems.AutoSize = true;
            this.lbStudNumUnpaidItems.Location = new System.Drawing.Point(11, 44);
            this.lbStudNumUnpaidItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudNumUnpaidItems.Name = "lbStudNumUnpaidItems";
            this.lbStudNumUnpaidItems.Size = new System.Drawing.Size(85, 13);
            this.lbStudNumUnpaidItems.TabIndex = 0;
            this.lbStudNumUnpaidItems.Text = "Student number:";
            // 
            // gbxAddGrocery
            // 
            this.gbxAddGrocery.Controls.Add(this.btnAddGrocery);
            this.gbxAddGrocery.Controls.Add(this.tbxGroceryName);
            this.gbxAddGrocery.Controls.Add(this.lbGroceryName);
            this.gbxAddGrocery.Location = new System.Drawing.Point(24, 13);
            this.gbxAddGrocery.Margin = new System.Windows.Forms.Padding(2);
            this.gbxAddGrocery.Name = "gbxAddGrocery";
            this.gbxAddGrocery.Padding = new System.Windows.Forms.Padding(2);
            this.gbxAddGrocery.Size = new System.Drawing.Size(231, 112);
            this.gbxAddGrocery.TabIndex = 3;
            this.gbxAddGrocery.TabStop = false;
            this.gbxAddGrocery.Text = "Add groceries";
            // 
            // btnAddGrocery
            // 
            this.btnAddGrocery.Location = new System.Drawing.Point(85, 75);
            this.btnAddGrocery.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddGrocery.Name = "btnAddGrocery";
            this.btnAddGrocery.Size = new System.Drawing.Size(89, 20);
            this.btnAddGrocery.TabIndex = 2;
            this.btnAddGrocery.Text = "Add grocery";
            this.btnAddGrocery.UseVisualStyleBackColor = true;
            // 
            // tbxGroceryName
            // 
            this.tbxGroceryName.Location = new System.Drawing.Point(85, 41);
            this.tbxGroceryName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGroceryName.Name = "tbxGroceryName";
            this.tbxGroceryName.Size = new System.Drawing.Size(90, 20);
            this.tbxGroceryName.TabIndex = 1;
            // 
            // lbGroceryName
            // 
            this.lbGroceryName.AutoSize = true;
            this.lbGroceryName.Location = new System.Drawing.Point(31, 42);
            this.lbGroceryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGroceryName.Name = "lbGroceryName";
            this.lbGroceryName.Size = new System.Drawing.Size(38, 13);
            this.lbGroceryName.TabIndex = 0;
            this.lbGroceryName.Text = "Name:";
            // 
            // gbxGroceriesAdmin
            // 
            this.gbxGroceriesAdmin.Controls.Add(this.btnRemoveAllGroceries);
            this.gbxGroceriesAdmin.Controls.Add(this.btnRemoveSelectedGrocery);
            this.gbxGroceriesAdmin.Controls.Add(this.lbxRecentGroceries);
            this.gbxGroceriesAdmin.Controls.Add(this.lbRecentGroceries);
            this.gbxGroceriesAdmin.Location = new System.Drawing.Point(24, 129);
            this.gbxGroceriesAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.gbxGroceriesAdmin.Name = "gbxGroceriesAdmin";
            this.gbxGroceriesAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.gbxGroceriesAdmin.Size = new System.Drawing.Size(231, 278);
            this.gbxGroceriesAdmin.TabIndex = 2;
            this.gbxGroceriesAdmin.TabStop = false;
            // 
            // btnRemoveAllGroceries
            // 
            this.btnRemoveAllGroceries.Location = new System.Drawing.Point(127, 239);
            this.btnRemoveAllGroceries.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAllGroceries.Name = "btnRemoveAllGroceries";
            this.btnRemoveAllGroceries.Size = new System.Drawing.Size(97, 27);
            this.btnRemoveAllGroceries.TabIndex = 3;
            this.btnRemoveAllGroceries.Text = "Remove all";
            this.btnRemoveAllGroceries.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelectedGrocery
            // 
            this.btnRemoveSelectedGrocery.Location = new System.Drawing.Point(4, 239);
            this.btnRemoveSelectedGrocery.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveSelectedGrocery.Name = "btnRemoveSelectedGrocery";
            this.btnRemoveSelectedGrocery.Size = new System.Drawing.Size(105, 27);
            this.btnRemoveSelectedGrocery.TabIndex = 2;
            this.btnRemoveSelectedGrocery.Text = "Remove selected";
            this.btnRemoveSelectedGrocery.UseVisualStyleBackColor = true;
            // 
            // lbxRecentGroceries
            // 
            this.lbxRecentGroceries.FormattingEnabled = true;
            this.lbxRecentGroceries.Location = new System.Drawing.Point(41, 42);
            this.lbxRecentGroceries.Margin = new System.Windows.Forms.Padding(2);
            this.lbxRecentGroceries.Name = "lbxRecentGroceries";
            this.lbxRecentGroceries.Size = new System.Drawing.Size(156, 186);
            this.lbxRecentGroceries.TabIndex = 0;
            // 
            // lbRecentGroceries
            // 
            this.lbRecentGroceries.AutoSize = true;
            this.lbRecentGroceries.Location = new System.Drawing.Point(71, 16);
            this.lbRecentGroceries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecentGroceries.Name = "lbRecentGroceries";
            this.lbRecentGroceries.Size = new System.Drawing.Size(88, 13);
            this.lbRecentGroceries.TabIndex = 1;
            this.lbRecentGroceries.Text = "Recent groceries";
            // 
            // tabAnnouncementsAdmin
            // 
            this.tabAnnouncementsAdmin.Controls.Add(this.gbxPostAnnouncements);
            this.tabAnnouncementsAdmin.Controls.Add(this.gbxNewsFeed);
            this.tabAnnouncementsAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAnnouncementsAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tabAnnouncementsAdmin.Name = "tabAnnouncementsAdmin";
            this.tabAnnouncementsAdmin.Size = new System.Drawing.Size(1237, 616);
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
            this.gbxPostAnnouncements.Margin = new System.Windows.Forms.Padding(2);
            this.gbxPostAnnouncements.Name = "gbxPostAnnouncements";
            this.gbxPostAnnouncements.Padding = new System.Windows.Forms.Padding(2);
            this.gbxPostAnnouncements.Size = new System.Drawing.Size(286, 287);
            this.gbxPostAnnouncements.TabIndex = 3;
            this.gbxPostAnnouncements.TabStop = false;
            this.gbxPostAnnouncements.Text = "Post an announcement";
            // 
            // btnPostAnnouncement
            // 
            this.btnPostAnnouncement.Location = new System.Drawing.Point(85, 233);
            this.btnPostAnnouncement.Margin = new System.Windows.Forms.Padding(2);
            this.btnPostAnnouncement.Name = "btnPostAnnouncement";
            this.btnPostAnnouncement.Size = new System.Drawing.Size(121, 33);
            this.btnPostAnnouncement.TabIndex = 2;
            this.btnPostAnnouncement.Text = "Post";
            this.btnPostAnnouncement.UseVisualStyleBackColor = true;
            // 
            // tbxPostAnnouncement
            // 
            this.tbxPostAnnouncement.Location = new System.Drawing.Point(33, 68);
            this.tbxPostAnnouncement.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPostAnnouncement.Multiline = true;
            this.tbxPostAnnouncement.Name = "tbxPostAnnouncement";
            this.tbxPostAnnouncement.Size = new System.Drawing.Size(228, 150);
            this.tbxPostAnnouncement.TabIndex = 1;
            // 
            // lbWriteMessage
            // 
            this.lbWriteMessage.AutoSize = true;
            this.lbWriteMessage.Location = new System.Drawing.Point(79, 39);
            this.lbWriteMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWriteMessage.Name = "lbWriteMessage";
            this.lbWriteMessage.Size = new System.Drawing.Size(129, 13);
            this.lbWriteMessage.TabIndex = 0;
            this.lbWriteMessage.Text = "Write down your message";
            // 
            // gbxNewsFeed
            // 
            this.gbxNewsFeed.Controls.Add(this.lbxAllAnnouncements);
            this.gbxNewsFeed.Controls.Add(this.lbAllAnnouncements);
            this.gbxNewsFeed.Location = new System.Drawing.Point(35, 38);
            this.gbxNewsFeed.Margin = new System.Windows.Forms.Padding(2);
            this.gbxNewsFeed.Name = "gbxNewsFeed";
            this.gbxNewsFeed.Padding = new System.Windows.Forms.Padding(2);
            this.gbxNewsFeed.Size = new System.Drawing.Size(283, 428);
            this.gbxNewsFeed.TabIndex = 2;
            this.gbxNewsFeed.TabStop = false;
            this.gbxNewsFeed.Text = "News feed";
            // 
            // lbxAllAnnouncements
            // 
            this.lbxAllAnnouncements.FormattingEnabled = true;
            this.lbxAllAnnouncements.Location = new System.Drawing.Point(29, 70);
            this.lbxAllAnnouncements.Margin = new System.Windows.Forms.Padding(2);
            this.lbxAllAnnouncements.Name = "lbxAllAnnouncements";
            this.lbxAllAnnouncements.Size = new System.Drawing.Size(231, 329);
            this.lbxAllAnnouncements.TabIndex = 0;
            // 
            // lbAllAnnouncements
            // 
            this.lbAllAnnouncements.AutoSize = true;
            this.lbAllAnnouncements.Location = new System.Drawing.Point(92, 42);
            this.lbAllAnnouncements.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAllAnnouncements.Name = "lbAllAnnouncements";
            this.lbAllAnnouncements.Size = new System.Drawing.Size(97, 13);
            this.lbAllAnnouncements.TabIndex = 1;
            this.lbAllAnnouncements.Text = "All announcements";
            // 
            // tabAgreementsAdmin
            // 
            this.tabAgreementsAdmin.Controls.Add(this.lbxAllAgreementsAdmin);
            this.tabAgreementsAdmin.Controls.Add(this.lbAllAgreementsAdmin);
            this.tabAgreementsAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAgreementsAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tabAgreementsAdmin.Name = "tabAgreementsAdmin";
            this.tabAgreementsAdmin.Size = new System.Drawing.Size(1237, 616);
            this.tabAgreementsAdmin.TabIndex = 3;
            this.tabAgreementsAdmin.Text = "Agreements";
            this.tabAgreementsAdmin.UseVisualStyleBackColor = true;
            // 
            // lbxAllAgreementsAdmin
            // 
            this.lbxAllAgreementsAdmin.FormattingEnabled = true;
            this.lbxAllAgreementsAdmin.Location = new System.Drawing.Point(480, 120);
            this.lbxAllAgreementsAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.lbxAllAgreementsAdmin.Name = "lbxAllAgreementsAdmin";
            this.lbxAllAgreementsAdmin.Size = new System.Drawing.Size(231, 329);
            this.lbxAllAgreementsAdmin.TabIndex = 0;
            // 
            // lbAllAgreementsAdmin
            // 
            this.lbAllAgreementsAdmin.AutoSize = true;
            this.lbAllAgreementsAdmin.Location = new System.Drawing.Point(543, 92);
            this.lbAllAgreementsAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAllAgreementsAdmin.Name = "lbAllAgreementsAdmin";
            this.lbAllAgreementsAdmin.Size = new System.Drawing.Size(76, 13);
            this.lbAllAgreementsAdmin.TabIndex = 1;
            this.lbAllAgreementsAdmin.Text = "All agreements";
            // 
            // tabHouseRules
            // 
            this.tabHouseRules.Controls.Add(this.groupBox1);
            this.tabHouseRules.Controls.Add(this.gbxRule);
            this.tabHouseRules.Controls.Add(this.gbxRules);
            this.tabHouseRules.Location = new System.Drawing.Point(4, 22);
            this.tabHouseRules.Margin = new System.Windows.Forms.Padding(2);
            this.tabHouseRules.Name = "tabHouseRules";
            this.tabHouseRules.Size = new System.Drawing.Size(1237, 616);
            this.tabHouseRules.TabIndex = 4;
            this.tabHouseRules.Text = "House Rules";
            this.tabHouseRules.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchRule);
            this.groupBox1.Controls.Add(this.tbxRuleNum);
            this.groupBox1.Controls.Add(this.lbRuleNum);
            this.groupBox1.Controls.Add(this.btnEditRule);
            this.groupBox1.Controls.Add(this.tbxEditRule);
            this.groupBox1.Controls.Add(this.lbEditRule);
            this.groupBox1.Location = new System.Drawing.Point(719, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(357, 331);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit rule";
            // 
            // btnSearchRule
            // 
            this.btnSearchRule.Location = new System.Drawing.Point(223, 57);
            this.btnSearchRule.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchRule.Name = "btnSearchRule";
            this.btnSearchRule.Size = new System.Drawing.Size(114, 25);
            this.btnSearchRule.TabIndex = 5;
            this.btnSearchRule.Text = "Search";
            this.btnSearchRule.UseVisualStyleBackColor = true;
            // 
            // tbxRuleNum
            // 
            this.tbxRuleNum.Location = new System.Drawing.Point(96, 61);
            this.tbxRuleNum.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRuleNum.Name = "tbxRuleNum";
            this.tbxRuleNum.Size = new System.Drawing.Size(102, 20);
            this.tbxRuleNum.TabIndex = 4;
            // 
            // lbRuleNum
            // 
            this.lbRuleNum.AutoSize = true;
            this.lbRuleNum.Location = new System.Drawing.Point(23, 66);
            this.lbRuleNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRuleNum.Name = "lbRuleNum";
            this.lbRuleNum.Size = new System.Drawing.Size(70, 13);
            this.lbRuleNum.TabIndex = 3;
            this.lbRuleNum.Text = "Rule number:";
            // 
            // btnEditRule
            // 
            this.btnEditRule.Location = new System.Drawing.Point(128, 279);
            this.btnEditRule.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(121, 33);
            this.btnEditRule.TabIndex = 2;
            this.btnEditRule.Text = "Edit";
            this.btnEditRule.UseVisualStyleBackColor = true;
            // 
            // tbxEditRule
            // 
            this.tbxEditRule.Location = new System.Drawing.Point(24, 149);
            this.tbxEditRule.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEditRule.Multiline = true;
            this.tbxEditRule.Name = "tbxEditRule";
            this.tbxEditRule.Size = new System.Drawing.Size(329, 106);
            this.tbxEditRule.TabIndex = 1;
            // 
            // lbEditRule
            // 
            this.lbEditRule.AutoSize = true;
            this.lbEditRule.Location = new System.Drawing.Point(159, 119);
            this.lbEditRule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEditRule.Name = "lbEditRule";
            this.lbEditRule.Size = new System.Drawing.Size(45, 13);
            this.lbEditRule.TabIndex = 0;
            this.lbEditRule.Text = "Edit rule";
            // 
            // gbxRule
            // 
            this.gbxRule.Controls.Add(this.btnAddRule);
            this.gbxRule.Controls.Add(this.tbxAddRule);
            this.gbxRule.Controls.Add(this.lbWriteRule);
            this.gbxRule.Location = new System.Drawing.Point(371, 57);
            this.gbxRule.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRule.Name = "gbxRule";
            this.gbxRule.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRule.Size = new System.Drawing.Size(288, 287);
            this.gbxRule.TabIndex = 5;
            this.gbxRule.TabStop = false;
            this.gbxRule.Text = "Add rule";
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(85, 233);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(121, 33);
            this.btnAddRule.TabIndex = 2;
            this.btnAddRule.Text = "Add";
            this.btnAddRule.UseVisualStyleBackColor = true;
            // 
            // tbxAddRule
            // 
            this.tbxAddRule.Location = new System.Drawing.Point(66, 62);
            this.tbxAddRule.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAddRule.Multiline = true;
            this.tbxAddRule.Name = "tbxAddRule";
            this.tbxAddRule.Size = new System.Drawing.Size(165, 150);
            this.tbxAddRule.TabIndex = 1;
            // 
            // lbWriteRule
            // 
            this.lbWriteRule.AutoSize = true;
            this.lbWriteRule.Location = new System.Drawing.Point(79, 39);
            this.lbWriteRule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWriteRule.Name = "lbWriteRule";
            this.lbWriteRule.Size = new System.Drawing.Size(113, 13);
            this.lbWriteRule.TabIndex = 0;
            this.lbWriteRule.Text = "Write down a new rule";
            // 
            // gbxRules
            // 
            this.gbxRules.Controls.Add(this.lbxRules);
            this.gbxRules.Location = new System.Drawing.Point(23, 37);
            this.gbxRules.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRules.Name = "gbxRules";
            this.gbxRules.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRules.Size = new System.Drawing.Size(283, 428);
            this.gbxRules.TabIndex = 4;
            this.gbxRules.TabStop = false;
            this.gbxRules.Text = "House rules";
            // 
            // lbxRules
            // 
            this.lbxRules.FormattingEnabled = true;
            this.lbxRules.Location = new System.Drawing.Point(30, 58);
            this.lbxRules.Margin = new System.Windows.Forms.Padding(2);
            this.lbxRules.Name = "lbxRules";
            this.lbxRules.Size = new System.Drawing.Size(231, 342);
            this.lbxRules.TabIndex = 0;
            // 
            // tabComplaintsAdmin
            // 
            this.tabComplaintsAdmin.Controls.Add(this.gbxAllComplaints);
            this.tabComplaintsAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabComplaintsAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tabComplaintsAdmin.Name = "tabComplaintsAdmin";
            this.tabComplaintsAdmin.Size = new System.Drawing.Size(1237, 616);
            this.tabComplaintsAdmin.TabIndex = 5;
            this.tabComplaintsAdmin.Text = "Complaints";
            this.tabComplaintsAdmin.UseVisualStyleBackColor = true;
            // 
            // gbxAllComplaints
            // 
            this.gbxAllComplaints.Controls.Add(this.lbxAllComplaints);
            this.gbxAllComplaints.Location = new System.Drawing.Point(405, 82);
            this.gbxAllComplaints.Margin = new System.Windows.Forms.Padding(2);
            this.gbxAllComplaints.Name = "gbxAllComplaints";
            this.gbxAllComplaints.Padding = new System.Windows.Forms.Padding(2);
            this.gbxAllComplaints.Size = new System.Drawing.Size(283, 428);
            this.gbxAllComplaints.TabIndex = 3;
            this.gbxAllComplaints.TabStop = false;
            this.gbxAllComplaints.Text = "All complaints";
            // 
            // lbxAllComplaints
            // 
            this.lbxAllComplaints.FormattingEnabled = true;
            this.lbxAllComplaints.Location = new System.Drawing.Point(25, 54);
            this.lbxAllComplaints.Margin = new System.Windows.Forms.Padding(2);
            this.lbxAllComplaints.Name = "lbxAllComplaints";
            this.lbxAllComplaints.Size = new System.Drawing.Size(231, 329);
            this.lbxAllComplaints.TabIndex = 0;
            // 
            // tabManageTenants
            // 
            this.tabManageTenants.Controls.Add(this.gbxRemoveTenant);
            this.tabManageTenants.Controls.Add(this.gbxRegisterTenants);
            this.tabManageTenants.Location = new System.Drawing.Point(4, 22);
            this.tabManageTenants.Margin = new System.Windows.Forms.Padding(2);
            this.tabManageTenants.Name = "tabManageTenants";
            this.tabManageTenants.Size = new System.Drawing.Size(1237, 616);
            this.tabManageTenants.TabIndex = 6;
            this.tabManageTenants.Text = "Manage Tenants";
            this.tabManageTenants.UseVisualStyleBackColor = true;
            // 
            // gbxRemoveTenant
            // 
            this.gbxRemoveTenant.Controls.Add(this.btnRemoveTenant);
            this.gbxRemoveTenant.Controls.Add(this.tbxStudentNumRemove);
            this.gbxRemoveTenant.Controls.Add(this.lbStudentNumRemove);
            this.gbxRemoveTenant.Location = new System.Drawing.Point(468, 47);
            this.gbxRemoveTenant.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRemoveTenant.Name = "gbxRemoveTenant";
            this.gbxRemoveTenant.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRemoveTenant.Size = new System.Drawing.Size(301, 152);
            this.gbxRemoveTenant.TabIndex = 1;
            this.gbxRemoveTenant.TabStop = false;
            this.gbxRemoveTenant.Text = "Remove tenant";
            // 
            // btnRemoveTenant
            // 
            this.btnRemoveTenant.Location = new System.Drawing.Point(147, 89);
            this.btnRemoveTenant.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveTenant.Name = "btnRemoveTenant";
            this.btnRemoveTenant.Size = new System.Drawing.Size(114, 27);
            this.btnRemoveTenant.TabIndex = 7;
            this.btnRemoveTenant.Text = "Remove";
            this.btnRemoveTenant.UseVisualStyleBackColor = true;
            // 
            // tbxStudentNumRemove
            // 
            this.tbxStudentNumRemove.Location = new System.Drawing.Point(147, 45);
            this.tbxStudentNumRemove.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStudentNumRemove.Name = "tbxStudentNumRemove";
            this.tbxStudentNumRemove.Size = new System.Drawing.Size(115, 20);
            this.tbxStudentNumRemove.TabIndex = 5;
            // 
            // lbStudentNumRemove
            // 
            this.lbStudentNumRemove.AutoSize = true;
            this.lbStudentNumRemove.Location = new System.Drawing.Point(30, 49);
            this.lbStudentNumRemove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudentNumRemove.Name = "lbStudentNumRemove";
            this.lbStudentNumRemove.Size = new System.Drawing.Size(85, 13);
            this.lbStudentNumRemove.TabIndex = 4;
            this.lbStudentNumRemove.Text = "Student number:";
            // 
            // gbxRegisterTenants
            // 
            this.gbxRegisterTenants.Controls.Add(this.btnRegister);
            this.gbxRegisterTenants.Controls.Add(this.tbxPassword);
            this.gbxRegisterTenants.Controls.Add(this.tbxFirstName);
            this.gbxRegisterTenants.Controls.Add(this.tbxStudentNum);
            this.gbxRegisterTenants.Controls.Add(this.lbPassword);
            this.gbxRegisterTenants.Controls.Add(this.lbFirstName);
            this.gbxRegisterTenants.Controls.Add(this.lbStudentNum);
            this.gbxRegisterTenants.Location = new System.Drawing.Point(70, 47);
            this.gbxRegisterTenants.Margin = new System.Windows.Forms.Padding(2);
            this.gbxRegisterTenants.Name = "gbxRegisterTenants";
            this.gbxRegisterTenants.Padding = new System.Windows.Forms.Padding(2);
            this.gbxRegisterTenants.Size = new System.Drawing.Size(309, 331);
            this.gbxRegisterTenants.TabIndex = 0;
            this.gbxRegisterTenants.TabStop = false;
            this.gbxRegisterTenants.Text = "Register tenants";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(135, 256);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(114, 27);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(135, 198);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(115, 20);
            this.tbxPassword.TabIndex = 5;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(135, 135);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(115, 20);
            this.tbxFirstName.TabIndex = 4;
            // 
            // tbxStudentNum
            // 
            this.tbxStudentNum.Location = new System.Drawing.Point(135, 72);
            this.tbxStudentNum.Margin = new System.Windows.Forms.Padding(2);
            this.tbxStudentNum.Name = "tbxStudentNum";
            this.tbxStudentNum.Size = new System.Drawing.Size(115, 20);
            this.tbxStudentNum.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(61, 198);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(47, 133);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(58, 13);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "First name:";
            // 
            // lbStudentNum
            // 
            this.lbStudentNum.AutoSize = true;
            this.lbStudentNum.Location = new System.Drawing.Point(18, 76);
            this.lbStudentNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudentNum.Name = "lbStudentNum";
            this.lbStudentNum.Size = new System.Drawing.Size(85, 13);
            this.lbStudentNum.TabIndex = 0;
            this.lbStudentNum.Text = "Student number:";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 667);
            this.Controls.Add(this.Menu);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.Menu.ResumeLayout(false);
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
            this.tabHouseRules.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxRule.ResumeLayout(false);
            this.gbxRule.PerformLayout();
            this.gbxRules.ResumeLayout(false);
            this.tabComplaintsAdmin.ResumeLayout(false);
            this.gbxAllComplaints.ResumeLayout(false);
            this.tabManageTenants.ResumeLayout(false);
            this.gbxRemoveTenant.ResumeLayout(false);
            this.gbxRemoveTenant.PerformLayout();
            this.gbxRegisterTenants.ResumeLayout(false);
            this.gbxRegisterTenants.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabHomeAdmin;
        private System.Windows.Forms.TabPage tabGroceriesAdmin;
        private System.Windows.Forms.Label lbWelcomeMsgAdmin;
        private System.Windows.Forms.TabPage tabAnnouncementsAdmin;
        private System.Windows.Forms.TabPage tabAgreementsAdmin;
        private System.Windows.Forms.TabPage tabHouseRules;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchRule;
        private System.Windows.Forms.TextBox tbxRuleNum;
        private System.Windows.Forms.Label lbRuleNum;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.TextBox tbxEditRule;
        private System.Windows.Forms.Label lbEditRule;
        private System.Windows.Forms.GroupBox gbxRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.TextBox tbxAddRule;
        private System.Windows.Forms.Label lbWriteRule;
        private System.Windows.Forms.GroupBox gbxRules;
        private System.Windows.Forms.ListBox lbxRules;
        private System.Windows.Forms.GroupBox gbxAllComplaints;
        private System.Windows.Forms.ListBox lbxAllComplaints;
        private System.Windows.Forms.GroupBox gbxRegisterTenants;
        private System.Windows.Forms.GroupBox gbxRemoveTenant;
        private System.Windows.Forms.Button btnRemoveTenant;
        private System.Windows.Forms.TextBox tbxStudentNumRemove;
        private System.Windows.Forms.Label lbStudentNumRemove;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxStudentNum;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbStudentNum;
    }
}