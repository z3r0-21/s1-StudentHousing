namespace HousingSoftware
{
    partial class TenantForm
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
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTenant
            // 
            this.MenuTenant.Controls.Add(this.tabHomeTenant);
            this.MenuTenant.Controls.Add(this.tabGroceriesTenant);
            this.MenuTenant.Controls.Add(this.tabAnnouncementsTenant);
            this.MenuTenant.Controls.Add(this.tabAgreementsTenant);
            this.MenuTenant.Controls.Add(this.tabHouseRulesTenant);
            this.MenuTenant.Controls.Add(this.tabComplaintsTenant);
            this.MenuTenant.Location = new System.Drawing.Point(63, 12);
            this.MenuTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.MenuTenant.Name = "MenuTenant";
            this.MenuTenant.SelectedIndex = 0;
            this.MenuTenant.Size = new System.Drawing.Size(1013, 681);
            this.MenuTenant.TabIndex = 2;
            // 
            // tabHomeTenant
            // 
            this.tabHomeTenant.Controls.Add(this.btnLogOutTenant);
            this.tabHomeTenant.Controls.Add(this.lbWelcomeMsgTenant);
            this.tabHomeTenant.ImageKey = "(none)";
            this.tabHomeTenant.Location = new System.Drawing.Point(4, 25);
            this.tabHomeTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabHomeTenant.Name = "tabHomeTenant";
            this.tabHomeTenant.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabHomeTenant.Size = new System.Drawing.Size(1005, 652);
            this.tabHomeTenant.TabIndex = 0;
            this.tabHomeTenant.Text = "Home";
            this.tabHomeTenant.UseVisualStyleBackColor = true;
            // 
            // btnLogOutTenant
            // 
            this.btnLogOutTenant.Location = new System.Drawing.Point(43, 566);
            this.btnLogOutTenant.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLogOutTenant.Name = "btnLogOutTenant";
            this.btnLogOutTenant.Size = new System.Drawing.Size(139, 44);
            this.btnLogOutTenant.TabIndex = 4;
            this.btnLogOutTenant.Text = "Log out";
            this.btnLogOutTenant.UseVisualStyleBackColor = true;
            this.btnLogOutTenant.Click += new System.EventHandler(this.btnLogOutTenant_Click);
            // 
            // lbWelcomeMsgTenant
            // 
            this.lbWelcomeMsgTenant.AutoSize = true;
            this.lbWelcomeMsgTenant.Location = new System.Drawing.Point(119, 97);
            this.lbWelcomeMsgTenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWelcomeMsgTenant.Name = "lbWelcomeMsgTenant";
            this.lbWelcomeMsgTenant.Size = new System.Drawing.Size(74, 17);
            this.lbWelcomeMsgTenant.TabIndex = 0;
            this.lbWelcomeMsgTenant.Text = "Welcome, ";
            // 
            // tabGroceriesTenant
            // 
            this.tabGroceriesTenant.Controls.Add(this.gbxPayListGroceriesTenant);
            this.tabGroceriesTenant.Location = new System.Drawing.Point(4, 25);
            this.tabGroceriesTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabGroceriesTenant.Name = "tabGroceriesTenant";
            this.tabGroceriesTenant.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabGroceriesTenant.Size = new System.Drawing.Size(1005, 652);
            this.tabGroceriesTenant.TabIndex = 1;
            this.tabGroceriesTenant.Text = "Groceries";
            this.tabGroceriesTenant.UseVisualStyleBackColor = true;
            // 
            // gbxPayListGroceriesTenant
            // 
            this.gbxPayListGroceriesTenant.Controls.Add(this.lbxUnpaidGroceries);
            this.gbxPayListGroceriesTenant.Location = new System.Drawing.Point(303, 64);
            this.gbxPayListGroceriesTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxPayListGroceriesTenant.Name = "gbxPayListGroceriesTenant";
            this.gbxPayListGroceriesTenant.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxPayListGroceriesTenant.Size = new System.Drawing.Size(537, 537);
            this.gbxPayListGroceriesTenant.TabIndex = 4;
            this.gbxPayListGroceriesTenant.TabStop = false;
            this.gbxPayListGroceriesTenant.Text = "Pay list groceries";
            // 
            // lbxUnpaidGroceries
            // 
            this.lbxUnpaidGroceries.FormattingEnabled = true;
            this.lbxUnpaidGroceries.ItemHeight = 16;
            this.lbxUnpaidGroceries.Location = new System.Drawing.Point(48, 74);
            this.lbxUnpaidGroceries.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lbxUnpaidGroceries.Name = "lbxUnpaidGroceries";
            this.lbxUnpaidGroceries.Size = new System.Drawing.Size(431, 372);
            this.lbxUnpaidGroceries.TabIndex = 3;
            // 
            // tabAnnouncementsTenant
            // 
            this.tabAnnouncementsTenant.Controls.Add(this.gbxNewsFeedTenant);
            this.tabAnnouncementsTenant.Location = new System.Drawing.Point(4, 25);
            this.tabAnnouncementsTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabAnnouncementsTenant.Name = "tabAnnouncementsTenant";
            this.tabAnnouncementsTenant.Size = new System.Drawing.Size(1005, 652);
            this.tabAnnouncementsTenant.TabIndex = 2;
            this.tabAnnouncementsTenant.Text = "Announcements";
            this.tabAnnouncementsTenant.UseVisualStyleBackColor = true;
            // 
            // gbxNewsFeedTenant
            // 
            this.gbxNewsFeedTenant.Controls.Add(this.lbxUserAllAnnouncements);
            this.gbxNewsFeedTenant.Controls.Add(this.lblAllAnnouncementTenant);
            this.gbxNewsFeedTenant.Location = new System.Drawing.Point(28, 33);
            this.gbxNewsFeedTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxNewsFeedTenant.Name = "gbxNewsFeedTenant";
            this.gbxNewsFeedTenant.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxNewsFeedTenant.Size = new System.Drawing.Size(503, 566);
            this.gbxNewsFeedTenant.TabIndex = 2;
            this.gbxNewsFeedTenant.TabStop = false;
            this.gbxNewsFeedTenant.Text = "News feed";
            // 
            // lbxUserAllAnnouncements
            // 
            this.lbxUserAllAnnouncements.FormattingEnabled = true;
            this.lbxUserAllAnnouncements.ItemHeight = 16;
            this.lbxUserAllAnnouncements.Location = new System.Drawing.Point(49, 74);
            this.lbxUserAllAnnouncements.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lbxUserAllAnnouncements.Name = "lbxUserAllAnnouncements";
            this.lbxUserAllAnnouncements.Size = new System.Drawing.Size(408, 436);
            this.lbxUserAllAnnouncements.TabIndex = 0;
            // 
            // lblAllAnnouncementTenant
            // 
            this.lblAllAnnouncementTenant.AutoSize = true;
            this.lblAllAnnouncementTenant.Location = new System.Drawing.Point(167, 32);
            this.lblAllAnnouncementTenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.tabAgreementsTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabAgreementsTenant.Name = "tabAgreementsTenant";
            this.tabAgreementsTenant.Size = new System.Drawing.Size(1005, 652);
            this.tabAgreementsTenant.TabIndex = 3;
            this.tabAgreementsTenant.Text = "Agreements";
            this.tabAgreementsTenant.UseVisualStyleBackColor = true;
            // 
            // gbxSearchAgreementTenant
            // 
            this.gbxSearchAgreementTenant.Controls.Add(this.btnShowAllAgreementsTenant);
            this.gbxSearchAgreementTenant.Controls.Add(this.btnSearchAgreementTenant);
            this.gbxSearchAgreementTenant.Controls.Add(this.tbxSearchAgreementsTenant);
            this.gbxSearchAgreementTenant.Location = new System.Drawing.Point(25, 407);
            this.gbxSearchAgreementTenant.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxSearchAgreementTenant.Name = "gbxSearchAgreementTenant";
            this.gbxSearchAgreementTenant.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxSearchAgreementTenant.Size = new System.Drawing.Size(508, 208);
            this.gbxSearchAgreementTenant.TabIndex = 6;
            this.gbxSearchAgreementTenant.TabStop = false;
            this.gbxSearchAgreementTenant.Text = "Search for an agreement";
            // 
            // btnShowAllAgreementsTenant
            // 
            this.btnShowAllAgreementsTenant.Location = new System.Drawing.Point(108, 144);
            this.btnShowAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnShowAllAgreementsTenant.Name = "btnShowAllAgreementsTenant";
            this.btnShowAllAgreementsTenant.Size = new System.Drawing.Size(276, 33);
            this.btnShowAllAgreementsTenant.TabIndex = 2;
            this.btnShowAllAgreementsTenant.Text = "Show all agreements";
            this.btnShowAllAgreementsTenant.UseVisualStyleBackColor = true;
            this.btnShowAllAgreementsTenant.Click += new System.EventHandler(this.btnShowAllAgreements_Click);
            // 
            // btnSearchAgreementTenant
            // 
            this.btnSearchAgreementTenant.Location = new System.Drawing.Point(108, 96);
            this.btnSearchAgreementTenant.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSearchAgreementTenant.Name = "btnSearchAgreementTenant";
            this.btnSearchAgreementTenant.Size = new System.Drawing.Size(276, 33);
            this.btnSearchAgreementTenant.TabIndex = 1;
            this.btnSearchAgreementTenant.Text = "Search";
            this.btnSearchAgreementTenant.UseVisualStyleBackColor = true;
            this.btnSearchAgreementTenant.Click += new System.EventHandler(this.btnSearchAgreement_Click);
            // 
            // tbxSearchAgreementsTenant
            // 
            this.tbxSearchAgreementsTenant.Location = new System.Drawing.Point(31, 54);
            this.tbxSearchAgreementsTenant.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxSearchAgreementsTenant.Name = "tbxSearchAgreementsTenant";
            this.tbxSearchAgreementsTenant.Size = new System.Drawing.Size(431, 22);
            this.tbxSearchAgreementsTenant.TabIndex = 0;
            // 
            // gbxAllAgreements
            // 
            this.gbxAllAgreements.Controls.Add(this.btnDisagree);
            this.gbxAllAgreements.Controls.Add(this.btnAgree);
            this.gbxAllAgreements.Controls.Add(this.lbxAllAgreementsTenant);
            this.gbxAllAgreements.Controls.Add(this.lblAllAgreementsTenant);
            this.gbxAllAgreements.Location = new System.Drawing.Point(596, 37);
            this.gbxAllAgreements.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxAllAgreements.Name = "gbxAllAgreements";
            this.gbxAllAgreements.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxAllAgreements.Size = new System.Drawing.Size(433, 578);
            this.gbxAllAgreements.TabIndex = 5;
            this.gbxAllAgreements.TabStop = false;
            // 
            // btnDisagree
            // 
            this.btnDisagree.Location = new System.Drawing.Point(49, 514);
            this.btnDisagree.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btnDisagree.Name = "btnDisagree";
            this.btnDisagree.Size = new System.Drawing.Size(341, 33);
            this.btnDisagree.TabIndex = 3;
            this.btnDisagree.Text = "Disagree with selected";
            this.btnDisagree.UseVisualStyleBackColor = true;
            this.btnDisagree.Click += new System.EventHandler(this.btnDisagree_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.Location = new System.Drawing.Point(49, 480);
            this.btnAgree.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(341, 33);
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
            this.lbxAllAgreementsTenant.Location = new System.Drawing.Point(49, 81);
            this.lbxAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lbxAllAgreementsTenant.Name = "lbxAllAgreementsTenant";
            this.lbxAllAgreementsTenant.Size = new System.Drawing.Size(340, 372);
            this.lbxAllAgreementsTenant.TabIndex = 0;
            // 
            // lblAllAgreementsTenant
            // 
            this.lblAllAgreementsTenant.AutoSize = true;
            this.lblAllAgreementsTenant.Location = new System.Drawing.Point(151, 37);
            this.lblAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.gbxAddAgreement.Location = new System.Drawing.Point(25, 1);
            this.gbxAddAgreement.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxAddAgreement.Name = "gbxAddAgreement";
            this.gbxAddAgreement.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxAddAgreement.Size = new System.Drawing.Size(508, 399);
            this.gbxAddAgreement.TabIndex = 4;
            this.gbxAddAgreement.TabStop = false;
            // 
            // btnAddAgreement
            // 
            this.btnAddAgreement.Location = new System.Drawing.Point(151, 324);
            this.btnAddAgreement.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btnAddAgreement.Name = "btnAddAgreement";
            this.btnAddAgreement.Size = new System.Drawing.Size(215, 46);
            this.btnAddAgreement.TabIndex = 2;
            this.btnAddAgreement.Text = "Add";
            this.btnAddAgreement.UseVisualStyleBackColor = true;
            this.btnAddAgreement.Click += new System.EventHandler(this.btnAddAgreement_Click);
            // 
            // tbxAddAgreement
            // 
            this.tbxAddAgreement.Location = new System.Drawing.Point(59, 94);
            this.tbxAddAgreement.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tbxAddAgreement.Multiline = true;
            this.tbxAddAgreement.Name = "tbxAddAgreement";
            this.tbxAddAgreement.Size = new System.Drawing.Size(403, 207);
            this.tbxAddAgreement.TabIndex = 1;
            // 
            // lbWriteAgreement
            // 
            this.lbWriteAgreement.AutoSize = true;
            this.lbWriteAgreement.Location = new System.Drawing.Point(140, 54);
            this.lbWriteAgreement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWriteAgreement.Name = "lbWriteAgreement";
            this.lbWriteAgreement.Size = new System.Drawing.Size(171, 17);
            this.lbWriteAgreement.TabIndex = 0;
            this.lbWriteAgreement.Text = "Write down your message";
            // 
            // tabHouseRulesTenant
            // 
            this.tabHouseRulesTenant.Controls.Add(this.gbxHouseRulseTenant);
            this.tabHouseRulesTenant.Location = new System.Drawing.Point(4, 25);
            this.tabHouseRulesTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabHouseRulesTenant.Name = "tabHouseRulesTenant";
            this.tabHouseRulesTenant.Size = new System.Drawing.Size(1005, 652);
            this.tabHouseRulesTenant.TabIndex = 4;
            this.tabHouseRulesTenant.Text = "House Rules";
            this.tabHouseRulesTenant.UseVisualStyleBackColor = true;
            // 
            // gbxHouseRulseTenant
            // 
            this.gbxHouseRulseTenant.Controls.Add(this.lbxRulesTenant);
            this.gbxHouseRulseTenant.Location = new System.Drawing.Point(321, 27);
            this.gbxHouseRulseTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxHouseRulseTenant.Name = "gbxHouseRulseTenant";
            this.gbxHouseRulseTenant.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxHouseRulseTenant.Size = new System.Drawing.Size(503, 570);
            this.gbxHouseRulseTenant.TabIndex = 4;
            this.gbxHouseRulseTenant.TabStop = false;
            this.gbxHouseRulseTenant.Text = "House rules";
            // 
            // lbxRulesTenant
            // 
            this.lbxRulesTenant.FormattingEnabled = true;
            this.lbxRulesTenant.ItemHeight = 16;
            this.lbxRulesTenant.Location = new System.Drawing.Point(57, 57);
            this.lbxRulesTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lbxRulesTenant.Name = "lbxRulesTenant";
            this.lbxRulesTenant.Size = new System.Drawing.Size(408, 452);
            this.lbxRulesTenant.TabIndex = 0;
            // 
            // tabComplaintsTenant
            // 
            this.tabComplaintsTenant.Controls.Add(this.btnComplaint);
            this.tabComplaintsTenant.Controls.Add(this.tbxWriteComplaint);
            this.tabComplaintsTenant.Controls.Add(this.lbWriteComplaint);
            this.tabComplaintsTenant.Location = new System.Drawing.Point(4, 25);
            this.tabComplaintsTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabComplaintsTenant.Name = "tabComplaintsTenant";
            this.tabComplaintsTenant.Size = new System.Drawing.Size(1005, 652);
            this.tabComplaintsTenant.TabIndex = 5;
            this.tabComplaintsTenant.Text = "Complaints";
            this.tabComplaintsTenant.UseVisualStyleBackColor = true;
            // 
            // btnComplaint
            // 
            this.btnComplaint.Location = new System.Drawing.Point(485, 399);
            this.btnComplaint.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btnComplaint.Name = "btnComplaint";
            this.btnComplaint.Size = new System.Drawing.Size(215, 46);
            this.btnComplaint.TabIndex = 2;
            this.btnComplaint.Text = "Send";
            this.btnComplaint.UseVisualStyleBackColor = true;
            this.btnComplaint.Click += new System.EventHandler(this.btnComplaint_Click);
            // 
            // tbxWriteComplaint
            // 
            this.tbxWriteComplaint.Location = new System.Drawing.Point(393, 169);
            this.tbxWriteComplaint.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tbxWriteComplaint.Multiline = true;
            this.tbxWriteComplaint.Name = "tbxWriteComplaint";
            this.tbxWriteComplaint.Size = new System.Drawing.Size(403, 207);
            this.tbxWriteComplaint.TabIndex = 1;
            // 
            // lbWriteComplaint
            // 
            this.lbWriteComplaint.AutoSize = true;
            this.lbWriteComplaint.Location = new System.Drawing.Point(476, 132);
            this.lbWriteComplaint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWriteComplaint.Name = "lbWriteComplaint";
            this.lbWriteComplaint.Size = new System.Drawing.Size(178, 17);
            this.lbWriteComplaint.TabIndex = 0;
            this.lbWriteComplaint.Text = "Write down your complaint:";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 60000;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // TenantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 724);
            this.Controls.Add(this.MenuTenant);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TenantForm";
            this.Text = "Tenant";
            this.Load += new System.EventHandler(this.TenantForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnLogOutTenant;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Button btnDisagree;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.GroupBox gbxSearchAgreementTenant;
        private System.Windows.Forms.Button btnShowAllAgreementsTenant;
        private System.Windows.Forms.Button btnSearchAgreementTenant;
        private System.Windows.Forms.TextBox tbxSearchAgreementsTenant;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}