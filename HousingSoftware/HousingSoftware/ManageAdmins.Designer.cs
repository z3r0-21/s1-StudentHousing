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
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.gbxRemoveEditAdmins = new System.Windows.Forms.GroupBox();
            this.btnEditAdmin = new System.Windows.Forms.Button();
            this.btnRemoveAdmin = new System.Windows.Forms.Button();
            this.tbxUsernameRemoveEditAdmin = new System.Windows.Forms.TextBox();
            this.lbUsernameRemoveEditAdmin = new System.Windows.Forms.Label();
            this.gbxEditAdmin = new System.Windows.Forms.GroupBox();
            this.btnSaveChangesAdminProfile = new System.Windows.Forms.Button();
            this.tbxPasswordEditAdmin = new System.Windows.Forms.TextBox();
            this.lbPasswordEditAdmin = new System.Windows.Forms.Label();
            this.tbxLNameEditAdmin = new System.Windows.Forms.TextBox();
            this.lbLNameEditAdmin = new System.Windows.Forms.Label();
            this.tbxFNameEditAdmin = new System.Windows.Forms.TextBox();
            this.lbFNameEditAdmin = new System.Windows.Forms.Label();
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
            this.gbxRegisterAdmins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxRegisterAdmins.Location = new System.Drawing.Point(26, 25);
            this.gbxRegisterAdmins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxRegisterAdmins.Name = "gbxRegisterAdmins";
            this.gbxRegisterAdmins.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxRegisterAdmins.Size = new System.Drawing.Size(329, 270);
            this.gbxRegisterAdmins.TabIndex = 0;
            this.gbxRegisterAdmins.TabStop = false;
            this.gbxRegisterAdmins.Text = "Register admins";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister.Location = new System.Drawing.Point(117, 200);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(151, 33);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(117, 156);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(152, 22);
            this.tbxPassword.TabIndex = 7;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPassword.Location = new System.Drawing.Point(22, 158);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(73, 17);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(117, 118);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(152, 22);
            this.tbxUsername.TabIndex = 5;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbUsername.Location = new System.Drawing.Point(17, 121);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(77, 17);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Username:";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(117, 78);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(152, 22);
            this.tbxLastName.TabIndex = 3;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLastName.Location = new System.Drawing.Point(19, 80);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(76, 17);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "LastName:";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(117, 40);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(152, 22);
            this.tbxFirstName.TabIndex = 1;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFirstName.Location = new System.Drawing.Point(17, 42);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(78, 17);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First name:";
            // 
            // gbxRemoveEditAdmins
            // 
            this.gbxRemoveEditAdmins.Controls.Add(this.btnEditAdmin);
            this.gbxRemoveEditAdmins.Controls.Add(this.btnRemoveAdmin);
            this.gbxRemoveEditAdmins.Controls.Add(this.tbxUsernameRemoveEditAdmin);
            this.gbxRemoveEditAdmins.Controls.Add(this.lbUsernameRemoveEditAdmin);
            this.gbxRemoveEditAdmins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxRemoveEditAdmins.Location = new System.Drawing.Point(386, 25);
            this.gbxRemoveEditAdmins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxRemoveEditAdmins.Name = "gbxRemoveEditAdmins";
            this.gbxRemoveEditAdmins.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxRemoveEditAdmins.Size = new System.Drawing.Size(352, 126);
            this.gbxRemoveEditAdmins.TabIndex = 1;
            this.gbxRemoveEditAdmins.TabStop = false;
            this.gbxRemoveEditAdmins.Text = "Remove/Edit admin profile";
            // 
            // btnEditAdmin
            // 
            this.btnEditAdmin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditAdmin.Location = new System.Drawing.Point(181, 72);
            this.btnEditAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditAdmin.Name = "btnEditAdmin";
            this.btnEditAdmin.Size = new System.Drawing.Size(151, 33);
            this.btnEditAdmin.TabIndex = 11;
            this.btnEditAdmin.Text = "Edit";
            this.btnEditAdmin.UseVisualStyleBackColor = false;
            this.btnEditAdmin.Click += new System.EventHandler(this.btnEditAdmin_Click);
            // 
            // btnRemoveAdmin
            // 
            this.btnRemoveAdmin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRemoveAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveAdmin.Location = new System.Drawing.Point(17, 72);
            this.btnRemoveAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveAdmin.Name = "btnRemoveAdmin";
            this.btnRemoveAdmin.Size = new System.Drawing.Size(151, 33);
            this.btnRemoveAdmin.TabIndex = 10;
            this.btnRemoveAdmin.Text = "Remove";
            this.btnRemoveAdmin.UseVisualStyleBackColor = false;
            this.btnRemoveAdmin.Click += new System.EventHandler(this.btnRemoveAdmin_Click);
            // 
            // tbxUsernameRemoveEditAdmin
            // 
            this.tbxUsernameRemoveEditAdmin.Location = new System.Drawing.Point(135, 29);
            this.tbxUsernameRemoveEditAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUsernameRemoveEditAdmin.Name = "tbxUsernameRemoveEditAdmin";
            this.tbxUsernameRemoveEditAdmin.Size = new System.Drawing.Size(189, 22);
            this.tbxUsernameRemoveEditAdmin.TabIndex = 9;
            // 
            // lbUsernameRemoveEditAdmin
            // 
            this.lbUsernameRemoveEditAdmin.AutoSize = true;
            this.lbUsernameRemoveEditAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbUsernameRemoveEditAdmin.Location = new System.Drawing.Point(35, 31);
            this.lbUsernameRemoveEditAdmin.Name = "lbUsernameRemoveEditAdmin";
            this.lbUsernameRemoveEditAdmin.Size = new System.Drawing.Size(77, 17);
            this.lbUsernameRemoveEditAdmin.TabIndex = 8;
            this.lbUsernameRemoveEditAdmin.Text = "Username:";
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
            this.gbxEditAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxEditAdmin.Location = new System.Drawing.Point(386, 166);
            this.gbxEditAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxEditAdmin.Name = "gbxEditAdmin";
            this.gbxEditAdmin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxEditAdmin.Size = new System.Drawing.Size(352, 185);
            this.gbxEditAdmin.TabIndex = 2;
            this.gbxEditAdmin.TabStop = false;
            this.gbxEditAdmin.Text = "Edit admin profile";
            // 
            // btnSaveChangesAdminProfile
            // 
            this.btnSaveChangesAdminProfile.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSaveChangesAdminProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveChangesAdminProfile.Location = new System.Drawing.Point(134, 140);
            this.btnSaveChangesAdminProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveChangesAdminProfile.Name = "btnSaveChangesAdminProfile";
            this.btnSaveChangesAdminProfile.Size = new System.Drawing.Size(151, 33);
            this.btnSaveChangesAdminProfile.TabIndex = 10;
            this.btnSaveChangesAdminProfile.Text = "Save changes";
            this.btnSaveChangesAdminProfile.UseVisualStyleBackColor = false;
            this.btnSaveChangesAdminProfile.Click += new System.EventHandler(this.btnSaveChangesAdminProfile_Click);
            // 
            // tbxPasswordEditAdmin
            // 
            this.tbxPasswordEditAdmin.Location = new System.Drawing.Point(134, 101);
            this.tbxPasswordEditAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPasswordEditAdmin.Name = "tbxPasswordEditAdmin";
            this.tbxPasswordEditAdmin.Size = new System.Drawing.Size(152, 22);
            this.tbxPasswordEditAdmin.TabIndex = 9;
            // 
            // lbPasswordEditAdmin
            // 
            this.lbPasswordEditAdmin.AutoSize = true;
            this.lbPasswordEditAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPasswordEditAdmin.Location = new System.Drawing.Point(39, 103);
            this.lbPasswordEditAdmin.Name = "lbPasswordEditAdmin";
            this.lbPasswordEditAdmin.Size = new System.Drawing.Size(73, 17);
            this.lbPasswordEditAdmin.TabIndex = 8;
            this.lbPasswordEditAdmin.Text = "Password:";
            // 
            // tbxLNameEditAdmin
            // 
            this.tbxLNameEditAdmin.Location = new System.Drawing.Point(135, 65);
            this.tbxLNameEditAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLNameEditAdmin.Name = "tbxLNameEditAdmin";
            this.tbxLNameEditAdmin.Size = new System.Drawing.Size(152, 22);
            this.tbxLNameEditAdmin.TabIndex = 7;
            // 
            // lbLNameEditAdmin
            // 
            this.lbLNameEditAdmin.AutoSize = true;
            this.lbLNameEditAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLNameEditAdmin.Location = new System.Drawing.Point(36, 67);
            this.lbLNameEditAdmin.Name = "lbLNameEditAdmin";
            this.lbLNameEditAdmin.Size = new System.Drawing.Size(76, 17);
            this.lbLNameEditAdmin.TabIndex = 6;
            this.lbLNameEditAdmin.Text = "LastName:";
            // 
            // tbxFNameEditAdmin
            // 
            this.tbxFNameEditAdmin.Location = new System.Drawing.Point(135, 27);
            this.tbxFNameEditAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFNameEditAdmin.Name = "tbxFNameEditAdmin";
            this.tbxFNameEditAdmin.Size = new System.Drawing.Size(152, 22);
            this.tbxFNameEditAdmin.TabIndex = 5;
            // 
            // lbFNameEditAdmin
            // 
            this.lbFNameEditAdmin.AutoSize = true;
            this.lbFNameEditAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFNameEditAdmin.Location = new System.Drawing.Point(35, 30);
            this.lbFNameEditAdmin.Name = "lbFNameEditAdmin";
            this.lbFNameEditAdmin.Size = new System.Drawing.Size(78, 17);
            this.lbFNameEditAdmin.TabIndex = 4;
            this.lbFNameEditAdmin.Text = "First name:";
            // 
            // btnLogOutSuperuser
            // 
            this.btnLogOutSuperuser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogOutSuperuser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOutSuperuser.Location = new System.Drawing.Point(103, 306);
            this.btnLogOutSuperuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOutSuperuser.Name = "btnLogOutSuperuser";
            this.btnLogOutSuperuser.Size = new System.Drawing.Size(175, 43);
            this.btnLogOutSuperuser.TabIndex = 3;
            this.btnLogOutSuperuser.Text = "Log out";
            this.btnLogOutSuperuser.UseVisualStyleBackColor = false;
            this.btnLogOutSuperuser.Click += new System.EventHandler(this.btnLogOutSuperuser_Click);
            // 
            // ManageAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(799, 360);
            this.Controls.Add(this.btnLogOutSuperuser);
            this.Controls.Add(this.gbxEditAdmin);
            this.Controls.Add(this.gbxRemoveEditAdmins);
            this.Controls.Add(this.gbxRegisterAdmins);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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