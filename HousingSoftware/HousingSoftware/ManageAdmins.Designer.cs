namespace HousingSoftware
{
    partial class ManageAdmins
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
            this.gbxRegisterAdmins = new System.Windows.Forms.GroupBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gbxRemoveEditAdmins = new System.Windows.Forms.GroupBox();
            this.tbxUsernameRemoveEditAdmin = new System.Windows.Forms.TextBox();
            this.lbUsernameRemoveEditAdmin = new System.Windows.Forms.Label();
            this.btnRemoveAdmin = new System.Windows.Forms.Button();
            this.gbxEditAdmin = new System.Windows.Forms.GroupBox();
            this.btnEditAdmin = new System.Windows.Forms.Button();
            this.tbxLNameEditAdmin = new System.Windows.Forms.TextBox();
            this.lbLNameEditAdmin = new System.Windows.Forms.Label();
            this.tbxFNameEditAdmin = new System.Windows.Forms.TextBox();
            this.lbFNameEditAdmin = new System.Windows.Forms.Label();
            this.tbxPasswordEditAdmin = new System.Windows.Forms.TextBox();
            this.lbPasswordEditAdmin = new System.Windows.Forms.Label();
            this.btnSaveChangesAdminProfile = new System.Windows.Forms.Button();
            this.btnLogOutSuperuser = new System.Windows.Forms.Button();
            this.gbxRegisterAdmins.SuspendLayout();
            this.gbxRemoveEditAdmins.SuspendLayout();
            this.gbxEditAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRegisterAdmins
            // 
            this.gbxRegisterAdmins.Controls.Add(this.btnRegister);
            this.gbxRegisterAdmins.Controls.Add(this.tbxPassword);
            this.gbxRegisterAdmins.Controls.Add(this.lbPassword);
            this.gbxRegisterAdmins.Controls.Add(this.tbxUsername);
            this.gbxRegisterAdmins.Controls.Add(this.lbUsername);
            this.gbxRegisterAdmins.Controls.Add(this.tbxLastName);
            this.gbxRegisterAdmins.Controls.Add(this.lbLastName);
            this.gbxRegisterAdmins.Controls.Add(this.tbxFirstName);
            this.gbxRegisterAdmins.Controls.Add(this.lbFirstName);
            this.gbxRegisterAdmins.Location = new System.Drawing.Point(29, 31);
            this.gbxRegisterAdmins.Name = "gbxRegisterAdmins";
            this.gbxRegisterAdmins.Size = new System.Drawing.Size(370, 338);
            this.gbxRegisterAdmins.TabIndex = 0;
            this.gbxRegisterAdmins.TabStop = false;
            this.gbxRegisterAdmins.Text = "Register admins";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(19, 53);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(88, 20);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First name:";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(132, 50);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(170, 26);
            this.tbxFirstName.TabIndex = 1;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(132, 97);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(170, 26);
            this.tbxLastName.TabIndex = 3;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(21, 100);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(86, 20);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "LastName:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(132, 148);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(170, 26);
            this.tbxUsername.TabIndex = 5;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(19, 151);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(87, 20);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Username:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(132, 195);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(170, 26);
            this.tbxPassword.TabIndex = 7;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(25, 198);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(82, 20);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(132, 250);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(170, 41);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // gbxRemoveEditAdmins
            // 
            this.gbxRemoveEditAdmins.Controls.Add(this.btnEditAdmin);
            this.gbxRemoveEditAdmins.Controls.Add(this.btnRemoveAdmin);
            this.gbxRemoveEditAdmins.Controls.Add(this.tbxUsernameRemoveEditAdmin);
            this.gbxRemoveEditAdmins.Controls.Add(this.lbUsernameRemoveEditAdmin);
            this.gbxRemoveEditAdmins.Location = new System.Drawing.Point(434, 31);
            this.gbxRemoveEditAdmins.Name = "gbxRemoveEditAdmins";
            this.gbxRemoveEditAdmins.Size = new System.Drawing.Size(396, 157);
            this.gbxRemoveEditAdmins.TabIndex = 1;
            this.gbxRemoveEditAdmins.TabStop = false;
            this.gbxRemoveEditAdmins.Text = "Remove/Edit admin profile";
            // 
            // tbxUsernameRemoveEditAdmin
            // 
            this.tbxUsernameRemoveEditAdmin.Location = new System.Drawing.Point(152, 36);
            this.tbxUsernameRemoveEditAdmin.Name = "tbxUsernameRemoveEditAdmin";
            this.tbxUsernameRemoveEditAdmin.Size = new System.Drawing.Size(212, 26);
            this.tbxUsernameRemoveEditAdmin.TabIndex = 9;
            // 
            // lbUsernameRemoveEditAdmin
            // 
            this.lbUsernameRemoveEditAdmin.AutoSize = true;
            this.lbUsernameRemoveEditAdmin.Location = new System.Drawing.Point(39, 39);
            this.lbUsernameRemoveEditAdmin.Name = "lbUsernameRemoveEditAdmin";
            this.lbUsernameRemoveEditAdmin.Size = new System.Drawing.Size(87, 20);
            this.lbUsernameRemoveEditAdmin.TabIndex = 8;
            this.lbUsernameRemoveEditAdmin.Text = "Username:";
            // 
            // btnRemoveAdmin
            // 
            this.btnRemoveAdmin.Location = new System.Drawing.Point(19, 90);
            this.btnRemoveAdmin.Name = "btnRemoveAdmin";
            this.btnRemoveAdmin.Size = new System.Drawing.Size(170, 41);
            this.btnRemoveAdmin.TabIndex = 10;
            this.btnRemoveAdmin.Text = "Remove";
            this.btnRemoveAdmin.UseVisualStyleBackColor = true;
            this.btnRemoveAdmin.Click += new System.EventHandler(this.btnRemoveAdmin_Click);
            // 
            // gbxEditAdmin
            // 
            this.gbxEditAdmin.Controls.Add(this.btnSaveChangesAdminProfile);
            this.gbxEditAdmin.Controls.Add(this.tbxPasswordEditAdmin);
            this.gbxEditAdmin.Controls.Add(this.lbPasswordEditAdmin);
            this.gbxEditAdmin.Controls.Add(this.tbxLNameEditAdmin);
            this.gbxEditAdmin.Controls.Add(this.lbLNameEditAdmin);
            this.gbxEditAdmin.Controls.Add(this.tbxFNameEditAdmin);
            this.gbxEditAdmin.Controls.Add(this.lbFNameEditAdmin);
            this.gbxEditAdmin.Location = new System.Drawing.Point(434, 207);
            this.gbxEditAdmin.Name = "gbxEditAdmin";
            this.gbxEditAdmin.Size = new System.Drawing.Size(396, 231);
            this.gbxEditAdmin.TabIndex = 2;
            this.gbxEditAdmin.TabStop = false;
            this.gbxEditAdmin.Text = "Edit admin profile";
            // 
            // btnEditAdmin
            // 
            this.btnEditAdmin.Location = new System.Drawing.Point(204, 90);
            this.btnEditAdmin.Name = "btnEditAdmin";
            this.btnEditAdmin.Size = new System.Drawing.Size(170, 41);
            this.btnEditAdmin.TabIndex = 11;
            this.btnEditAdmin.Text = "Edit";
            this.btnEditAdmin.UseVisualStyleBackColor = true;
            this.btnEditAdmin.Click += new System.EventHandler(this.btnEditAdmin_Click);
            // 
            // tbxLNameEditAdmin
            // 
            this.tbxLNameEditAdmin.Location = new System.Drawing.Point(152, 81);
            this.tbxLNameEditAdmin.Name = "tbxLNameEditAdmin";
            this.tbxLNameEditAdmin.Size = new System.Drawing.Size(170, 26);
            this.tbxLNameEditAdmin.TabIndex = 7;
            // 
            // lbLNameEditAdmin
            // 
            this.lbLNameEditAdmin.AutoSize = true;
            this.lbLNameEditAdmin.Location = new System.Drawing.Point(41, 84);
            this.lbLNameEditAdmin.Name = "lbLNameEditAdmin";
            this.lbLNameEditAdmin.Size = new System.Drawing.Size(86, 20);
            this.lbLNameEditAdmin.TabIndex = 6;
            this.lbLNameEditAdmin.Text = "LastName:";
            // 
            // tbxFNameEditAdmin
            // 
            this.tbxFNameEditAdmin.Location = new System.Drawing.Point(152, 34);
            this.tbxFNameEditAdmin.Name = "tbxFNameEditAdmin";
            this.tbxFNameEditAdmin.Size = new System.Drawing.Size(170, 26);
            this.tbxFNameEditAdmin.TabIndex = 5;
            // 
            // lbFNameEditAdmin
            // 
            this.lbFNameEditAdmin.AutoSize = true;
            this.lbFNameEditAdmin.Location = new System.Drawing.Point(39, 37);
            this.lbFNameEditAdmin.Name = "lbFNameEditAdmin";
            this.lbFNameEditAdmin.Size = new System.Drawing.Size(88, 20);
            this.lbFNameEditAdmin.TabIndex = 4;
            this.lbFNameEditAdmin.Text = "First name:";
            // 
            // tbxPasswordEditAdmin
            // 
            this.tbxPasswordEditAdmin.Location = new System.Drawing.Point(151, 126);
            this.tbxPasswordEditAdmin.Name = "tbxPasswordEditAdmin";
            this.tbxPasswordEditAdmin.Size = new System.Drawing.Size(170, 26);
            this.tbxPasswordEditAdmin.TabIndex = 9;
            // 
            // lbPasswordEditAdmin
            // 
            this.lbPasswordEditAdmin.AutoSize = true;
            this.lbPasswordEditAdmin.Location = new System.Drawing.Point(44, 129);
            this.lbPasswordEditAdmin.Name = "lbPasswordEditAdmin";
            this.lbPasswordEditAdmin.Size = new System.Drawing.Size(82, 20);
            this.lbPasswordEditAdmin.TabIndex = 8;
            this.lbPasswordEditAdmin.Text = "Password:";
            // 
            // btnSaveChangesAdminProfile
            // 
            this.btnSaveChangesAdminProfile.Location = new System.Drawing.Point(151, 175);
            this.btnSaveChangesAdminProfile.Name = "btnSaveChangesAdminProfile";
            this.btnSaveChangesAdminProfile.Size = new System.Drawing.Size(170, 41);
            this.btnSaveChangesAdminProfile.TabIndex = 10;
            this.btnSaveChangesAdminProfile.Text = "Save changes";
            this.btnSaveChangesAdminProfile.UseVisualStyleBackColor = true;
            this.btnSaveChangesAdminProfile.Click += new System.EventHandler(this.btnSaveChangesAdminProfile_Click);
            // 
            // btnLogOutSuperuser
            // 
            this.btnLogOutSuperuser.Location = new System.Drawing.Point(95, 382);
            this.btnLogOutSuperuser.Name = "btnLogOutSuperuser";
            this.btnLogOutSuperuser.Size = new System.Drawing.Size(197, 54);
            this.btnLogOutSuperuser.TabIndex = 3;
            this.btnLogOutSuperuser.Text = "Log out";
            this.btnLogOutSuperuser.UseVisualStyleBackColor = true;
            this.btnLogOutSuperuser.Click += new System.EventHandler(this.btnLogOutSuperuser_Click);
            // 
            // ManageAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.btnLogOutSuperuser);
            this.Controls.Add(this.gbxEditAdmin);
            this.Controls.Add(this.gbxRemoveEditAdmins);
            this.Controls.Add(this.gbxRegisterAdmins);
            this.Name = "ManageAdmins";
            this.Text = "ManageAdmins";
            this.Load += new System.EventHandler(this.ManageAdmins_Load);
            this.gbxRegisterAdmins.ResumeLayout(false);
            this.gbxRegisterAdmins.PerformLayout();
            this.gbxRemoveEditAdmins.ResumeLayout(false);
            this.gbxRemoveEditAdmins.PerformLayout();
            this.gbxEditAdmin.ResumeLayout(false);
            this.gbxEditAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRegisterAdmins;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.GroupBox gbxRemoveEditAdmins;
        private System.Windows.Forms.Button btnEditAdmin;
        private System.Windows.Forms.Button btnRemoveAdmin;
        private System.Windows.Forms.TextBox tbxUsernameRemoveEditAdmin;
        private System.Windows.Forms.Label lbUsernameRemoveEditAdmin;
        private System.Windows.Forms.GroupBox gbxEditAdmin;
        private System.Windows.Forms.Button btnSaveChangesAdminProfile;
        private System.Windows.Forms.TextBox tbxPasswordEditAdmin;
        private System.Windows.Forms.Label lbPasswordEditAdmin;
        private System.Windows.Forms.TextBox tbxLNameEditAdmin;
        private System.Windows.Forms.Label lbLNameEditAdmin;
        private System.Windows.Forms.TextBox tbxFNameEditAdmin;
        private System.Windows.Forms.Label lbFNameEditAdmin;
        private System.Windows.Forms.Button btnLogOutSuperuser;
    }
}