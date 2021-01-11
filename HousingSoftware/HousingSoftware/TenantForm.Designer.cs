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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TenantForm));
            this.MenuTenant = new System.Windows.Forms.TabControl();
            this.tabHomeTenant = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateTenant = new System.Windows.Forms.Label();
            this.lbTimeTenant = new System.Windows.Forms.Label();
            this.lblUnpaidGroceriesNotification = new System.Windows.Forms.Label();
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
            this.timerTenant = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.MenuTenant.SuspendLayout();
            this.tabHomeTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.MenuTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTenant.Location = new System.Drawing.Point(17, 12);
            this.MenuTenant.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.MenuTenant.Name = "MenuTenant";
            this.MenuTenant.SelectedIndex = 0;
            this.MenuTenant.Size = new System.Drawing.Size(1236, 619);
            this.MenuTenant.TabIndex = 2;
            // 
            // tabHomeTenant
            // 
            this.tabHomeTenant.BackColor = System.Drawing.Color.Teal;
            this.tabHomeTenant.Controls.Add(this.pictureBox1);
            this.tabHomeTenant.Controls.Add(this.lblDateTenant);
            this.tabHomeTenant.Controls.Add(this.lbTimeTenant);
            this.tabHomeTenant.Controls.Add(this.lblUnpaidGroceriesNotification);
            this.tabHomeTenant.Controls.Add(this.btnLogOutTenant);
            this.tabHomeTenant.Controls.Add(this.lbWelcomeMsgTenant);
            this.tabHomeTenant.ImageKey = "(none)";
            this.tabHomeTenant.Location = new System.Drawing.Point(4, 29);
            this.tabHomeTenant.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.tabHomeTenant.Name = "tabHomeTenant";
            this.tabHomeTenant.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.tabHomeTenant.Size = new System.Drawing.Size(1228, 586);
            this.tabHomeTenant.TabIndex = 0;
            this.tabHomeTenant.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(374, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 326);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblDateTenant
            // 
            this.lblDateTenant.AutoSize = true;
            this.lblDateTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDateTenant.Location = new System.Drawing.Point(72, 336);
            this.lblDateTenant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateTenant.Name = "lblDateTenant";
            this.lblDateTenant.Size = new System.Drawing.Size(45, 20);
            this.lblDateTenant.TabIndex = 7;
            this.lblDateTenant.Text = "Date";
            // 
            // lbTimeTenant
            // 
            this.lbTimeTenant.AutoSize = true;
            this.lbTimeTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTimeTenant.Location = new System.Drawing.Point(71, 249);
            this.lbTimeTenant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTimeTenant.Name = "lbTimeTenant";
            this.lbTimeTenant.Size = new System.Drawing.Size(73, 29);
            this.lbTimeTenant.TabIndex = 6;
            this.lbTimeTenant.Text = "Time";
            // 
            // lblUnpaidGroceriesNotification
            // 
            this.lblUnpaidGroceriesNotification.AutoSize = true;
            this.lblUnpaidGroceriesNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnpaidGroceriesNotification.Location = new System.Drawing.Point(906, 57);
            this.lblUnpaidGroceriesNotification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnpaidGroceriesNotification.Name = "lblUnpaidGroceriesNotification";
            this.lblUnpaidGroceriesNotification.Size = new System.Drawing.Size(249, 25);
            this.lblUnpaidGroceriesNotification.TabIndex = 5;
            this.lblUnpaidGroceriesNotification.Text = "Groceries notifications";
            this.lblUnpaidGroceriesNotification.Click += new System.EventHandler(this.lblUnpaidGroceriesNotification_Click);
            // 
            // btnLogOutTenant
            // 
            this.btnLogOutTenant.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogOutTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOutTenant.Location = new System.Drawing.Point(76, 474);
            this.btnLogOutTenant.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLogOutTenant.Name = "btnLogOutTenant";
            this.btnLogOutTenant.Size = new System.Drawing.Size(117, 45);
            this.btnLogOutTenant.TabIndex = 4;
            this.btnLogOutTenant.Text = "Log out";
            this.btnLogOutTenant.UseVisualStyleBackColor = false;
            this.btnLogOutTenant.Click += new System.EventHandler(this.btnLogOutTenant_Click);
            // 
            // lbWelcomeMsgTenant
            // 
            this.lbWelcomeMsgTenant.AutoSize = true;
            this.lbWelcomeMsgTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbWelcomeMsgTenant.Location = new System.Drawing.Point(72, 173);
            this.lbWelcomeMsgTenant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbWelcomeMsgTenant.Name = "lbWelcomeMsgTenant";
            this.lbWelcomeMsgTenant.Size = new System.Drawing.Size(88, 20);
            this.lbWelcomeMsgTenant.TabIndex = 0;
            this.lbWelcomeMsgTenant.Text = "Welcome, ";
            // 
            // tabGroceriesTenant
            // 
            this.tabGroceriesTenant.BackColor = System.Drawing.Color.Teal;
            this.tabGroceriesTenant.Controls.Add(this.gbxPayListGroceriesTenant);
            this.tabGroceriesTenant.Location = new System.Drawing.Point(4, 29);
            this.tabGroceriesTenant.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.tabGroceriesTenant.Name = "tabGroceriesTenant";
            this.tabGroceriesTenant.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.tabGroceriesTenant.Size = new System.Drawing.Size(1228, 586);
            this.tabGroceriesTenant.TabIndex = 1;
            this.tabGroceriesTenant.Text = "Groceries";
            // 
            // gbxPayListGroceriesTenant
            // 
            this.gbxPayListGroceriesTenant.Controls.Add(this.lbxUnpaidGroceries);
            this.gbxPayListGroceriesTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxPayListGroceriesTenant.Location = new System.Drawing.Point(43, 31);
            this.gbxPayListGroceriesTenant.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.gbxPayListGroceriesTenant.Name = "gbxPayListGroceriesTenant";
            this.gbxPayListGroceriesTenant.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.gbxPayListGroceriesTenant.Size = new System.Drawing.Size(371, 394);
            this.gbxPayListGroceriesTenant.TabIndex = 4;
            this.gbxPayListGroceriesTenant.TabStop = false;
            this.gbxPayListGroceriesTenant.Text = "Pay list groceries";
            // 
            // lbxUnpaidGroceries
            // 
            this.lbxUnpaidGroceries.FormattingEnabled = true;
            this.lbxUnpaidGroceries.ItemHeight = 20;
            this.lbxUnpaidGroceries.Location = new System.Drawing.Point(11, 34);
            this.lbxUnpaidGroceries.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.lbxUnpaidGroceries.Name = "lbxUnpaidGroceries";
            this.lbxUnpaidGroceries.Size = new System.Drawing.Size(344, 324);
            this.lbxUnpaidGroceries.TabIndex = 3;
            // 
            // tabAnnouncementsTenant
            // 
            this.tabAnnouncementsTenant.BackColor = System.Drawing.Color.Teal;
            this.tabAnnouncementsTenant.Controls.Add(this.gbxNewsFeedTenant);
            this.tabAnnouncementsTenant.Location = new System.Drawing.Point(4, 29);
            this.tabAnnouncementsTenant.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.tabAnnouncementsTenant.Name = "tabAnnouncementsTenant";
            this.tabAnnouncementsTenant.Size = new System.Drawing.Size(1228, 586);
            this.tabAnnouncementsTenant.TabIndex = 2;
            this.tabAnnouncementsTenant.Text = "Announcements";
            // 
            // gbxNewsFeedTenant
            // 
            this.gbxNewsFeedTenant.Controls.Add(this.lbxUserAllAnnouncements);
            this.gbxNewsFeedTenant.Controls.Add(this.lblAllAnnouncementTenant);
            this.gbxNewsFeedTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxNewsFeedTenant.Location = new System.Drawing.Point(32, 32);
            this.gbxNewsFeedTenant.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.gbxNewsFeedTenant.Name = "gbxNewsFeedTenant";
            this.gbxNewsFeedTenant.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.gbxNewsFeedTenant.Size = new System.Drawing.Size(513, 423);
            this.gbxNewsFeedTenant.TabIndex = 2;
            this.gbxNewsFeedTenant.TabStop = false;
            this.gbxNewsFeedTenant.Text = "News feed";
            // 
            // lbxUserAllAnnouncements
            // 
            this.lbxUserAllAnnouncements.FormattingEnabled = true;
            this.lbxUserAllAnnouncements.ItemHeight = 20;
            this.lbxUserAllAnnouncements.Location = new System.Drawing.Point(11, 60);
            this.lbxUserAllAnnouncements.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.lbxUserAllAnnouncements.Name = "lbxUserAllAnnouncements";
            this.lbxUserAllAnnouncements.Size = new System.Drawing.Size(484, 324);
            this.lbxUserAllAnnouncements.TabIndex = 0;
            // 
            // lblAllAnnouncementTenant
            // 
            this.lblAllAnnouncementTenant.AutoSize = true;
            this.lblAllAnnouncementTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAllAnnouncementTenant.Location = new System.Drawing.Point(192, 28);
            this.lblAllAnnouncementTenant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAllAnnouncementTenant.Name = "lblAllAnnouncementTenant";
            this.lblAllAnnouncementTenant.Size = new System.Drawing.Size(151, 20);
            this.lblAllAnnouncementTenant.TabIndex = 1;
            this.lblAllAnnouncementTenant.Text = "All announcements";
            // 
            // tabAgreementsTenant
            // 
            this.tabAgreementsTenant.BackColor = System.Drawing.Color.Teal;
            this.tabAgreementsTenant.Controls.Add(this.gbxSearchAgreementTenant);
            this.tabAgreementsTenant.Controls.Add(this.gbxAllAgreements);
            this.tabAgreementsTenant.Controls.Add(this.gbxAddAgreement);
            this.tabAgreementsTenant.Location = new System.Drawing.Point(4, 29);
            this.tabAgreementsTenant.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.tabAgreementsTenant.Name = "tabAgreementsTenant";
            this.tabAgreementsTenant.Size = new System.Drawing.Size(1228, 586);
            this.tabAgreementsTenant.TabIndex = 3;
            this.tabAgreementsTenant.Text = "Agreements";
            // 
            // gbxSearchAgreementTenant
            // 
            this.gbxSearchAgreementTenant.Controls.Add(this.btnShowAllAgreementsTenant);
            this.gbxSearchAgreementTenant.Controls.Add(this.btnSearchAgreementTenant);
            this.gbxSearchAgreementTenant.Controls.Add(this.tbxSearchAgreementsTenant);
            this.gbxSearchAgreementTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxSearchAgreementTenant.Location = new System.Drawing.Point(29, 324);
            this.gbxSearchAgreementTenant.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbxSearchAgreementTenant.Name = "gbxSearchAgreementTenant";
            this.gbxSearchAgreementTenant.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbxSearchAgreementTenant.Size = new System.Drawing.Size(608, 239);
            this.gbxSearchAgreementTenant.TabIndex = 6;
            this.gbxSearchAgreementTenant.TabStop = false;
            this.gbxSearchAgreementTenant.Text = "Search for an agreement";
            // 
            // btnShowAllAgreementsTenant
            // 
            this.btnShowAllAgreementsTenant.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShowAllAgreementsTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowAllAgreementsTenant.Location = new System.Drawing.Point(222, 173);
            this.btnShowAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnShowAllAgreementsTenant.Name = "btnShowAllAgreementsTenant";
            this.btnShowAllAgreementsTenant.Size = new System.Drawing.Size(169, 54);
            this.btnShowAllAgreementsTenant.TabIndex = 2;
            this.btnShowAllAgreementsTenant.Text = "Show all agreements";
            this.btnShowAllAgreementsTenant.UseVisualStyleBackColor = false;
            this.btnShowAllAgreementsTenant.Click += new System.EventHandler(this.btnShowAllAgreements_Click);
            // 
            // btnSearchAgreementTenant
            // 
            this.btnSearchAgreementTenant.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearchAgreementTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchAgreementTenant.Location = new System.Drawing.Point(222, 114);
            this.btnSearchAgreementTenant.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSearchAgreementTenant.Name = "btnSearchAgreementTenant";
            this.btnSearchAgreementTenant.Size = new System.Drawing.Size(169, 47);
            this.btnSearchAgreementTenant.TabIndex = 1;
            this.btnSearchAgreementTenant.Text = "Search";
            this.btnSearchAgreementTenant.UseVisualStyleBackColor = false;
            this.btnSearchAgreementTenant.Click += new System.EventHandler(this.btnSearchAgreement_Click);
            // 
            // tbxSearchAgreementsTenant
            // 
            this.tbxSearchAgreementsTenant.Location = new System.Drawing.Point(15, 60);
            this.tbxSearchAgreementsTenant.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbxSearchAgreementsTenant.Name = "tbxSearchAgreementsTenant";
            this.tbxSearchAgreementsTenant.Size = new System.Drawing.Size(573, 26);
            this.tbxSearchAgreementsTenant.TabIndex = 0;
            // 
            // gbxAllAgreements
            // 
            this.gbxAllAgreements.Controls.Add(this.btnDisagree);
            this.gbxAllAgreements.Controls.Add(this.btnAgree);
            this.gbxAllAgreements.Controls.Add(this.lbxAllAgreementsTenant);
            this.gbxAllAgreements.Controls.Add(this.lblAllAgreementsTenant);
            this.gbxAllAgreements.Location = new System.Drawing.Point(689, 21);
            this.gbxAllAgreements.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.gbxAllAgreements.Name = "gbxAllAgreements";
            this.gbxAllAgreements.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.gbxAllAgreements.Size = new System.Drawing.Size(473, 490);
            this.gbxAllAgreements.TabIndex = 5;
            this.gbxAllAgreements.TabStop = false;
            // 
            // btnDisagree
            // 
            this.btnDisagree.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDisagree.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDisagree.Location = new System.Drawing.Point(163, 417);
            this.btnDisagree.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.btnDisagree.Name = "btnDisagree";
            this.btnDisagree.Size = new System.Drawing.Size(168, 54);
            this.btnDisagree.TabIndex = 3;
            this.btnDisagree.Text = "Disagree with selected";
            this.btnDisagree.UseVisualStyleBackColor = false;
            this.btnDisagree.Click += new System.EventHandler(this.btnDisagree_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAgree.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgree.Location = new System.Drawing.Point(163, 361);
            this.btnAgree.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(168, 41);
            this.btnAgree.TabIndex = 2;
            this.btnAgree.Text = "Agree with selected";
            this.btnAgree.UseVisualStyleBackColor = false;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // lbxAllAgreementsTenant
            // 
            this.lbxAllAgreementsTenant.FormattingEnabled = true;
            this.lbxAllAgreementsTenant.HorizontalScrollbar = true;
            this.lbxAllAgreementsTenant.ItemHeight = 20;
            this.lbxAllAgreementsTenant.Location = new System.Drawing.Point(11, 64);
            this.lbxAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.lbxAllAgreementsTenant.Name = "lbxAllAgreementsTenant";
            this.lbxAllAgreementsTenant.Size = new System.Drawing.Size(452, 264);
            this.lbxAllAgreementsTenant.TabIndex = 0;
            // 
            // lblAllAgreementsTenant
            // 
            this.lblAllAgreementsTenant.AutoSize = true;
            this.lblAllAgreementsTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAllAgreementsTenant.Location = new System.Drawing.Point(192, 27);
            this.lblAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAllAgreementsTenant.Name = "lblAllAgreementsTenant";
            this.lblAllAgreementsTenant.Size = new System.Drawing.Size(121, 20);
            this.lblAllAgreementsTenant.TabIndex = 1;
            this.lblAllAgreementsTenant.Text = "All agreements";
            // 
            // gbxAddAgreement
            // 
            this.gbxAddAgreement.Controls.Add(this.btnAddAgreement);
            this.gbxAddAgreement.Controls.Add(this.tbxAddAgreement);
            this.gbxAddAgreement.Controls.Add(this.lbWriteAgreement);
            this.gbxAddAgreement.Location = new System.Drawing.Point(29, 21);
            this.gbxAddAgreement.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.gbxAddAgreement.Name = "gbxAddAgreement";
            this.gbxAddAgreement.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.gbxAddAgreement.Size = new System.Drawing.Size(608, 272);
            this.gbxAddAgreement.TabIndex = 4;
            this.gbxAddAgreement.TabStop = false;
            // 
            // btnAddAgreement
            // 
            this.btnAddAgreement.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddAgreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAgreement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddAgreement.Location = new System.Drawing.Point(222, 208);
            this.btnAddAgreement.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.btnAddAgreement.Name = "btnAddAgreement";
            this.btnAddAgreement.Size = new System.Drawing.Size(168, 41);
            this.btnAddAgreement.TabIndex = 2;
            this.btnAddAgreement.Text = "Add";
            this.btnAddAgreement.UseVisualStyleBackColor = false;
            this.btnAddAgreement.Click += new System.EventHandler(this.btnAddAgreement_Click);
            // 
            // tbxAddAgreement
            // 
            this.tbxAddAgreement.Location = new System.Drawing.Point(11, 64);
            this.tbxAddAgreement.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.tbxAddAgreement.Multiline = true;
            this.tbxAddAgreement.Name = "tbxAddAgreement";
            this.tbxAddAgreement.Size = new System.Drawing.Size(577, 122);
            this.tbxAddAgreement.TabIndex = 1;
            // 
            // lbWriteAgreement
            // 
            this.lbWriteAgreement.AutoSize = true;
            this.lbWriteAgreement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbWriteAgreement.Location = new System.Drawing.Point(219, 25);
            this.lbWriteAgreement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbWriteAgreement.Name = "lbWriteAgreement";
            this.lbWriteAgreement.Size = new System.Drawing.Size(203, 20);
            this.lbWriteAgreement.TabIndex = 0;
            this.lbWriteAgreement.Text = "Write down your message";
            // 
            // tabHouseRulesTenant
            // 
            this.tabHouseRulesTenant.BackColor = System.Drawing.Color.Teal;
            this.tabHouseRulesTenant.Controls.Add(this.gbxHouseRulseTenant);
            this.tabHouseRulesTenant.Location = new System.Drawing.Point(4, 29);
            this.tabHouseRulesTenant.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.tabHouseRulesTenant.Name = "tabHouseRulesTenant";
            this.tabHouseRulesTenant.Size = new System.Drawing.Size(1228, 586);
            this.tabHouseRulesTenant.TabIndex = 4;
            this.tabHouseRulesTenant.Text = "House Rules";
            // 
            // gbxHouseRulseTenant
            // 
            this.gbxHouseRulseTenant.Controls.Add(this.lbxRulesTenant);
            this.gbxHouseRulseTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxHouseRulseTenant.Location = new System.Drawing.Point(439, 52);
            this.gbxHouseRulseTenant.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.gbxHouseRulseTenant.Name = "gbxHouseRulseTenant";
            this.gbxHouseRulseTenant.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.gbxHouseRulseTenant.Size = new System.Drawing.Size(509, 411);
            this.gbxHouseRulseTenant.TabIndex = 4;
            this.gbxHouseRulseTenant.TabStop = false;
            this.gbxHouseRulseTenant.Text = "House rules";
            // 
            // lbxRulesTenant
            // 
            this.lbxRulesTenant.FormattingEnabled = true;
            this.lbxRulesTenant.ItemHeight = 20;
            this.lbxRulesTenant.Location = new System.Drawing.Point(23, 33);
            this.lbxRulesTenant.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.lbxRulesTenant.Name = "lbxRulesTenant";
            this.lbxRulesTenant.Size = new System.Drawing.Size(464, 344);
            this.lbxRulesTenant.TabIndex = 0;
            // 
            // tabComplaintsTenant
            // 
            this.tabComplaintsTenant.BackColor = System.Drawing.Color.Teal;
            this.tabComplaintsTenant.Controls.Add(this.btnComplaint);
            this.tabComplaintsTenant.Controls.Add(this.tbxWriteComplaint);
            this.tabComplaintsTenant.Controls.Add(this.lbWriteComplaint);
            this.tabComplaintsTenant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabComplaintsTenant.Location = new System.Drawing.Point(4, 29);
            this.tabComplaintsTenant.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.tabComplaintsTenant.Name = "tabComplaintsTenant";
            this.tabComplaintsTenant.Size = new System.Drawing.Size(1228, 586);
            this.tabComplaintsTenant.TabIndex = 5;
            this.tabComplaintsTenant.Text = "Complaints";
            // 
            // btnComplaint
            // 
            this.btnComplaint.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnComplaint.Location = new System.Drawing.Point(563, 276);
            this.btnComplaint.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.btnComplaint.Name = "btnComplaint";
            this.btnComplaint.Size = new System.Drawing.Size(176, 46);
            this.btnComplaint.TabIndex = 2;
            this.btnComplaint.Text = "Send";
            this.btnComplaint.UseVisualStyleBackColor = false;
            this.btnComplaint.Click += new System.EventHandler(this.btnComplaint_Click);
            // 
            // tbxWriteComplaint
            // 
            this.tbxWriteComplaint.Location = new System.Drawing.Point(392, 165);
            this.tbxWriteComplaint.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.tbxWriteComplaint.Multiline = true;
            this.tbxWriteComplaint.Name = "tbxWriteComplaint";
            this.tbxWriteComplaint.Size = new System.Drawing.Size(497, 91);
            this.tbxWriteComplaint.TabIndex = 1;
            // 
            // lbWriteComplaint
            // 
            this.lbWriteComplaint.AutoSize = true;
            this.lbWriteComplaint.Location = new System.Drawing.Point(559, 130);
            this.lbWriteComplaint.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbWriteComplaint.Name = "lbWriteComplaint";
            this.lbWriteComplaint.Size = new System.Drawing.Size(212, 20);
            this.lbWriteComplaint.TabIndex = 0;
            this.lbWriteComplaint.Text = "Write down your complaint:";
            // 
            // timerTenant
            // 
            this.timerTenant.Interval = 1000;
            this.timerTenant.Tick += new System.EventHandler(this.timerTenant_Tick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // TenantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1283, 662);
            this.Controls.Add(this.MenuTenant);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "TenantForm";
            this.Text = "Tenant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TenantForm_FormClosed);
            this.Load += new System.EventHandler(this.TenantForm_Load);
            this.MenuTenant.ResumeLayout(false);
            this.tabHomeTenant.ResumeLayout(false);
            this.tabHomeTenant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Timer timerTenant;
        private System.Windows.Forms.Button btnDisagree;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.GroupBox gbxSearchAgreementTenant;
        private System.Windows.Forms.Button btnShowAllAgreementsTenant;
        private System.Windows.Forms.Button btnSearchAgreementTenant;
        private System.Windows.Forms.TextBox tbxSearchAgreementsTenant;
        private System.Windows.Forms.Label lblUnpaidGroceriesNotification;
        private System.Windows.Forms.Label lblDateTenant;
        private System.Windows.Forms.Label lbTimeTenant;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}