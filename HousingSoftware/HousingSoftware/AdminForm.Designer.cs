﻿
namespace HousingSoftware
{
    partial class AdminForm
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
            this.lblDateAdmin = new System.Windows.Forms.Label();
            this.lbTimeAdmin = new System.Windows.Forms.Label();
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
            this.editBox = new System.Windows.Forms.TextBox();
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
            this.lblNewComplaintsNotifications = new System.Windows.Forms.Label();
            this.timerAdmin = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.MenuAdmin.Location = new System.Drawing.Point(80, 58);
            this.MenuAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MenuAdmin.Name = "MenuAdmin";
            this.MenuAdmin.SelectedIndex = 0;
            this.MenuAdmin.Size = new System.Drawing.Size(916, 561);
            this.MenuAdmin.TabIndex = 1;
            // 
            // tabHomeAdmin
            // 
            this.tabHomeAdmin.Controls.Add(this.lblNewComplaintsNotifications);
            this.tabHomeAdmin.Controls.Add(this.lblDateAdmin);
            this.tabHomeAdmin.Controls.Add(this.lbTimeAdmin);
            this.tabHomeAdmin.Controls.Add(this.lbWelcomeMsgAdmin);
            this.tabHomeAdmin.Controls.Add(this.btnLogOutAdmin);
            this.tabHomeAdmin.ImageKey = "(none)";
            this.tabHomeAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabHomeAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabHomeAdmin.Name = "tabHomeAdmin";
            this.tabHomeAdmin.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabHomeAdmin.Size = new System.Drawing.Size(908, 532);
            this.tabHomeAdmin.TabIndex = 0;
            this.tabHomeAdmin.Text = "Home";
            this.tabHomeAdmin.UseVisualStyleBackColor = true;
            // 
            // lblDateAdmin
            // 
            this.lblDateAdmin.AutoSize = true;
            this.lblDateAdmin.Location = new System.Drawing.Point(105, 175);
            this.lblDateAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateAdmin.Name = "lblDateAdmin";
            this.lblDateAdmin.Size = new System.Drawing.Size(38, 17);
            this.lblDateAdmin.TabIndex = 5;
            this.lblDateAdmin.Text = "Date";
            // 
            // lbTimeAdmin
            // 
            this.lbTimeAdmin.AutoSize = true;
            this.lbTimeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeAdmin.Location = new System.Drawing.Point(100, 150);
            this.lbTimeAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeAdmin.Name = "lbTimeAdmin";
            this.lbTimeAdmin.Size = new System.Drawing.Size(60, 25);
            this.lbTimeAdmin.TabIndex = 4;
            this.lbTimeAdmin.Text = "Time";
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
            this.btnLogOutAdmin.Margin = new System.Windows.Forms.Padding(4);
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
            this.tabGroceriesAdmin.Size = new System.Drawing.Size(908, 532);
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
            this.btnClsSelectLinePayListGroceries.Margin = new System.Windows.Forms.Padding(4);
            this.btnClsSelectLinePayListGroceries.Name = "btnClsSelectLinePayListGroceries";
            this.btnClsSelectLinePayListGroceries.Size = new System.Drawing.Size(143, 31);
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
            this.btnMarkAllAsPaid.Size = new System.Drawing.Size(151, 31);
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
            this.btnMarkSelectedAsPaid.Size = new System.Drawing.Size(180, 31);
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
            this.btnShowToPayList.Location = new System.Drawing.Point(288, 47);
            this.btnShowToPayList.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnShowToPayList.Name = "btnShowToPayList";
            this.btnShowToPayList.Size = new System.Drawing.Size(153, 31);
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
            this.tbxGroceryName.Location = new System.Drawing.Point(111, 31);
            this.tbxGroceryName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbxGroceryName.Name = "tbxGroceryName";
            this.tbxGroceryName.Size = new System.Drawing.Size(119, 22);
            this.tbxGroceryName.TabIndex = 1;
            // 
            // lbGroceryName
            // 
            this.lbGroceryName.AutoSize = true;
            this.lbGroceryName.Location = new System.Drawing.Point(39, 31);
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
            this.btnClsSelectedLineRecentGroceries.Margin = new System.Windows.Forms.Padding(4);
            this.btnClsSelectedLineRecentGroceries.Name = "btnClsSelectedLineRecentGroceries";
            this.btnClsSelectedLineRecentGroceries.Size = new System.Drawing.Size(143, 31);
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
            this.btnRemoveAllGroceries.Size = new System.Drawing.Size(129, 31);
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
            this.btnRemoveSelectedGrocery.Size = new System.Drawing.Size(140, 31);
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
            this.lbRecentGroceries.Location = new System.Drawing.Point(95, 17);
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
            this.tabAnnouncementsAdmin.Size = new System.Drawing.Size(908, 532);
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
            this.btndeleteAnnouncement.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btndeleteAnnouncement.Name = "btndeleteAnnouncement";
            this.btndeleteAnnouncement.Size = new System.Drawing.Size(75, 32);
            this.btndeleteAnnouncement.TabIndex = 2;
            this.btndeleteAnnouncement.Text = "Delete";
            this.btndeleteAnnouncement.UseVisualStyleBackColor = true;
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
            this.lbAllAnnouncements.Location = new System.Drawing.Point(124, 33);
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
            this.tabAgreementsAdmin.Size = new System.Drawing.Size(908, 532);
            this.tabAgreementsAdmin.TabIndex = 3;
            this.tabAgreementsAdmin.Text = "Agreements";
            this.tabAgreementsAdmin.UseVisualStyleBackColor = true;
            // 
            // gbxSearchAgreementAdmin
            // 
            this.gbxSearchAgreementAdmin.Controls.Add(this.btnShowAllAgreementsAdmin);
            this.gbxSearchAgreementAdmin.Controls.Add(this.btnSearchAgreementAdmin);
            this.gbxSearchAgreementAdmin.Controls.Add(this.tbxSearchAgreementsAdmin);
            this.gbxSearchAgreementAdmin.Location = new System.Drawing.Point(436, 191);
            this.gbxSearchAgreementAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSearchAgreementAdmin.Name = "gbxSearchAgreementAdmin";
            this.gbxSearchAgreementAdmin.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSearchAgreementAdmin.Size = new System.Drawing.Size(381, 169);
            this.gbxSearchAgreementAdmin.TabIndex = 7;
            this.gbxSearchAgreementAdmin.TabStop = false;
            this.gbxSearchAgreementAdmin.Text = "Search for an agreement";
            // 
            // btnShowAllAgreementsAdmin
            // 
            this.btnShowAllAgreementsAdmin.Location = new System.Drawing.Point(81, 117);
            this.btnShowAllAgreementsAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAllAgreementsAdmin.Name = "btnShowAllAgreementsAdmin";
            this.btnShowAllAgreementsAdmin.Size = new System.Drawing.Size(207, 27);
            this.btnShowAllAgreementsAdmin.TabIndex = 2;
            this.btnShowAllAgreementsAdmin.Text = "Show all agreements";
            this.btnShowAllAgreementsAdmin.UseVisualStyleBackColor = true;
            this.btnShowAllAgreementsAdmin.Click += new System.EventHandler(this.btnShowAllAgreementsAdmin_Click);
            // 
            // btnSearchAgreementAdmin
            // 
            this.btnSearchAgreementAdmin.Location = new System.Drawing.Point(81, 79);
            this.btnSearchAgreementAdmin.Margin = new System.Windows.Forms.Padding(4);
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
            this.tbxSearchAgreementsAdmin.Margin = new System.Windows.Forms.Padding(4);
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
            this.tabHouseRulesAdmin.Controls.Add(this.editBox);
            this.tabHouseRulesAdmin.Controls.Add(this.gbxRule);
            this.tabHouseRulesAdmin.Controls.Add(this.gbxRules);
            this.tabHouseRulesAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabHouseRulesAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabHouseRulesAdmin.Name = "tabHouseRulesAdmin";
            this.tabHouseRulesAdmin.Size = new System.Drawing.Size(908, 532);
            this.tabHouseRulesAdmin.TabIndex = 4;
            this.tabHouseRulesAdmin.Text = "House Rules";
            this.tabHouseRulesAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSaveEditedRule
            // 
            this.btnSaveEditedRule.Location = new System.Drawing.Point(496, 459);
            this.btnSaveEditedRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEditedRule.Name = "btnSaveEditedRule";
            this.btnSaveEditedRule.Size = new System.Drawing.Size(100, 36);
            this.btnSaveEditedRule.TabIndex = 9;
            this.btnSaveEditedRule.Text = "Save";
            this.btnSaveEditedRule.UseVisualStyleBackColor = true;
            this.btnSaveEditedRule.Visible = false;
            // 
            // editBox
            // 
            this.editBox.Location = new System.Drawing.Point(411, 337);
            this.editBox.Margin = new System.Windows.Forms.Padding(4);
            this.editBox.Multiline = true;
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(225, 109);
            this.editBox.TabIndex = 8;
            this.editBox.Visible = false;
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
            this.btnDeleteRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteRule.TabIndex = 6;
            this.btnDeleteRule.Text = "Delete";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            // 
            // btnEditRule
            // 
            this.btnEditRule.Location = new System.Drawing.Point(207, 378);
            this.btnEditRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(100, 28);
            this.btnEditRule.TabIndex = 7;
            this.btnEditRule.Text = "Edit";
            this.btnEditRule.UseVisualStyleBackColor = true;
            // 
            // tabComplaintsAdmin
            // 
            this.tabComplaintsAdmin.Controls.Add(this.gbxSearchComplaints);
            this.tabComplaintsAdmin.Controls.Add(this.gbxAllComplaints);
            this.tabComplaintsAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabComplaintsAdmin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabComplaintsAdmin.Name = "tabComplaintsAdmin";
            this.tabComplaintsAdmin.Size = new System.Drawing.Size(908, 532);
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
            this.gbxSearchComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSearchComplaints.Name = "gbxSearchComplaints";
            this.gbxSearchComplaints.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSearchComplaints.Size = new System.Drawing.Size(381, 169);
            this.gbxSearchComplaints.TabIndex = 8;
            this.gbxSearchComplaints.TabStop = false;
            this.gbxSearchComplaints.Text = "Search for a complaint";
            // 
            // btnShowAllComplaints
            // 
            this.btnShowAllComplaints.Location = new System.Drawing.Point(81, 117);
            this.btnShowAllComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAllComplaints.Name = "btnShowAllComplaints";
            this.btnShowAllComplaints.Size = new System.Drawing.Size(207, 32);
            this.btnShowAllComplaints.TabIndex = 2;
            this.btnShowAllComplaints.Text = "Show all complaints";
            this.btnShowAllComplaints.UseVisualStyleBackColor = true;
            this.btnShowAllComplaints.Click += new System.EventHandler(this.btnShowAllComplaints_Click);
            // 
            // btnSearchComplaint
            // 
            this.btnSearchComplaint.Location = new System.Drawing.Point(81, 79);
            this.btnSearchComplaint.Margin = new System.Windows.Forms.Padding(4);
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
            this.tbxSearchComplaint.Margin = new System.Windows.Forms.Padding(4);
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
            this.tabManageTenants.Size = new System.Drawing.Size(908, 532);
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
            this.gbxEditTenant.Margin = new System.Windows.Forms.Padding(4);
            this.gbxEditTenant.Name = "gbxEditTenant";
            this.gbxEditTenant.Padding = new System.Windows.Forms.Padding(4);
            this.gbxEditTenant.Size = new System.Drawing.Size(401, 165);
            this.gbxEditTenant.TabIndex = 14;
            this.gbxEditTenant.TabStop = false;
            this.gbxEditTenant.Text = "Edit profile";
            // 
            // tbxEditPasswordTenant
            // 
            this.tbxEditPasswordTenant.Location = new System.Drawing.Point(175, 65);
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
            this.btnSaveChangesEditTenantProfile.Size = new System.Drawing.Size(152, 31);
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
            this.gbxSearchTenantEdit.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSearchTenantEdit.Name = "gbxSearchTenantEdit";
            this.gbxSearchTenantEdit.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSearchTenantEdit.Size = new System.Drawing.Size(401, 128);
            this.gbxSearchTenantEdit.TabIndex = 2;
            this.gbxSearchTenantEdit.TabStop = false;
            this.gbxSearchTenantEdit.Text = "Find a profile to edit";
            // 
            // btnShowTenantProfileEdit
            // 
            this.btnShowTenantProfileEdit.Location = new System.Drawing.Point(175, 79);
            this.btnShowTenantProfileEdit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnShowTenantProfileEdit.Name = "btnShowTenantProfileEdit";
            this.btnShowTenantProfileEdit.Size = new System.Drawing.Size(152, 31);
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
            this.btnRemoveTenant.Size = new System.Drawing.Size(152, 31);
            this.btnRemoveTenant.TabIndex = 7;
            this.btnRemoveTenant.Text = "Remove";
            this.btnRemoveTenant.UseVisualStyleBackColor = true;
            this.btnRemoveTenant.Click += new System.EventHandler(this.btnRemoveTenant_Click);
            // 
            // tbxStudentNumRemove
            // 
            this.tbxStudentNumRemove.Location = new System.Drawing.Point(196, 49);
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
            // lblNewComplaintsNotifications
            // 
            this.lblNewComplaintsNotifications.AutoSize = true;
            this.lblNewComplaintsNotifications.BackColor = System.Drawing.Color.Transparent;
            this.lblNewComplaintsNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewComplaintsNotifications.Location = new System.Drawing.Point(89, 33);
            this.lblNewComplaintsNotifications.Name = "lblNewComplaintsNotifications";
            this.lblNewComplaintsNotifications.Size = new System.Drawing.Size(0, 20);
            this.lblNewComplaintsNotifications.TabIndex = 6;
            this.lblNewComplaintsNotifications.Click += new System.EventHandler(this.lblNewComplaintsNotifications_Click);
            // 
            // timerAdmin
            // 
            this.timerAdmin.Interval = 1000;
            this.timerAdmin.Tick += new System.EventHandler(this.timerAdmin_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1084, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 679);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MenuAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MenuAdmin;
        private System.Windows.Forms.TabPage tabHomeAdmin;
        private System.Windows.Forms.Label lblDateAdmin;
        private System.Windows.Forms.Label lbTimeAdmin;
        private System.Windows.Forms.Label lbWelcomeMsgAdmin;
        private System.Windows.Forms.Button btnLogOutAdmin;
        private System.Windows.Forms.TabPage tabGroceriesAdmin;
        private System.Windows.Forms.GroupBox gbxPayListGroceries;
        private System.Windows.Forms.Button btnClsSelectLinePayListGroceries;
        private System.Windows.Forms.Button btnMarkAllAsPaid;
        private System.Windows.Forms.Button btnMarkSelectedAsPaid;
        private System.Windows.Forms.ListBox lbxUnpaidGroceriesPerStudent;
        private System.Windows.Forms.TextBox tbxStudNumUnpaidItems;
        private System.Windows.Forms.Button btnShowToPayList;
        private System.Windows.Forms.Label lbStudNumUnpaidItems;
        private System.Windows.Forms.GroupBox gbxAddGrocery;
        private System.Windows.Forms.TextBox tbxGroceryPrice;
        private System.Windows.Forms.Label lbGroceryPrice;
        private System.Windows.Forms.Button btnAddGrocery;
        private System.Windows.Forms.TextBox tbxGroceryName;
        private System.Windows.Forms.Label lbGroceryName;
        private System.Windows.Forms.GroupBox gbxGroceriesAdmin;
        private System.Windows.Forms.Button btnClsSelectedLineRecentGroceries;
        private System.Windows.Forms.Button btnRemoveAllGroceries;
        private System.Windows.Forms.Button btnRemoveSelectedGrocery;
        private System.Windows.Forms.ListBox lbxRecentGroceries;
        private System.Windows.Forms.Label lbRecentGroceries;
        private System.Windows.Forms.TabPage tabAnnouncementsAdmin;
        private System.Windows.Forms.GroupBox gbxPostAnnouncements;
        private System.Windows.Forms.Button btnPostAnnouncement;
        private System.Windows.Forms.TextBox tbxPostAnnouncement;
        private System.Windows.Forms.Label lbWriteMessage;
        private System.Windows.Forms.GroupBox gbxNewsFeed;
        private System.Windows.Forms.Button btndeleteAnnouncement;
        private System.Windows.Forms.ListBox lbxAllAnnouncements;
        private System.Windows.Forms.Label lbAllAnnouncements;
        private System.Windows.Forms.TabPage tabAgreementsAdmin;
        private System.Windows.Forms.GroupBox gbxSearchAgreementAdmin;
        private System.Windows.Forms.Button btnShowAllAgreementsAdmin;
        private System.Windows.Forms.Button btnSearchAgreementAdmin;
        private System.Windows.Forms.TextBox tbxSearchAgreementsAdmin;
        private System.Windows.Forms.ListBox lbxAllAgreementsAdmin;
        private System.Windows.Forms.Label lbAllAgreementsAdmin;
        private System.Windows.Forms.TabPage tabHouseRulesAdmin;
        private System.Windows.Forms.Button btnSaveEditedRule;
        private System.Windows.Forms.TextBox editBox;
        private System.Windows.Forms.GroupBox gbxRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.TextBox tbxAddRule;
        private System.Windows.Forms.Label lbWriteRule;
        private System.Windows.Forms.GroupBox gbxRules;
        private System.Windows.Forms.ListBox lbxRulesAdmin;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.TabPage tabComplaintsAdmin;
        private System.Windows.Forms.GroupBox gbxSearchComplaints;
        private System.Windows.Forms.Button btnShowAllComplaints;
        private System.Windows.Forms.Button btnSearchComplaint;
        private System.Windows.Forms.TextBox tbxSearchComplaint;
        private System.Windows.Forms.GroupBox gbxAllComplaints;
        private System.Windows.Forms.Button btnMarkAsDone;
        private System.Windows.Forms.ListBox lbxAllComplaints;
        private System.Windows.Forms.TabPage tabManageTenants;
        private System.Windows.Forms.GroupBox gbxEditTenant;
        private System.Windows.Forms.TextBox tbxEditPasswordTenant;
        private System.Windows.Forms.Button btnSaveChangesEditTenantProfile;
        private System.Windows.Forms.Label lbEditFNameTenant;
        private System.Windows.Forms.Label lbEditPasswordTenant;
        private System.Windows.Forms.TextBox tbxEditFNameTenant;
        private System.Windows.Forms.GroupBox gbxSearchTenantEdit;
        private System.Windows.Forms.Button btnShowTenantProfileEdit;
        private System.Windows.Forms.TextBox tbxStudNumSearchTenantEdit;
        private System.Windows.Forms.Label lbStudNumSearchTenantEdit;
        private System.Windows.Forms.GroupBox gbxRemoveTenant;
        private System.Windows.Forms.Button btnRemoveTenant;
        private System.Windows.Forms.TextBox tbxStudentNumRemove;
        private System.Windows.Forms.Label lbStudentNumRemove;
        private System.Windows.Forms.GroupBox gbxRegisterTenants;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbxPasswordRegister;
        private System.Windows.Forms.TextBox tbxFirstNameRegister;
        private System.Windows.Forms.TextBox tbxStudentNumRegister;
        private System.Windows.Forms.Label lbPasswordRegister;
        private System.Windows.Forms.Label lbFirstNameRegister;
        private System.Windows.Forms.Label lbStudentNumRegister;
        private System.Windows.Forms.Label lblNewComplaintsNotifications;
        private System.Windows.Forms.Timer timerAdmin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}