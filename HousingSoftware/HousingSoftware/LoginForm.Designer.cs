
namespace HousingSoftware
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxPasswordLogin = new System.Windows.Forms.TextBox();
            this.tbxUsernameLogin = new System.Windows.Forms.TextBox();
            this.lbPasswordLogin = new System.Windows.Forms.Label();
            this.lbUsernameLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.btnLogin);
            this.gbxLogin.Controls.Add(this.tbxPasswordLogin);
            this.gbxLogin.Controls.Add(this.tbxUsernameLogin);
            this.gbxLogin.Controls.Add(this.lbPasswordLogin);
            this.gbxLogin.Controls.Add(this.lbUsernameLogin);
            this.gbxLogin.Controls.Add(this.pictureBox1);
            this.gbxLogin.Location = new System.Drawing.Point(58, 119);
            this.gbxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxLogin.Size = new System.Drawing.Size(685, 212);
            this.gbxLogin.TabIndex = 2;
            this.gbxLogin.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(356, 153);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 31);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
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
            this.tbxUsernameLogin.Location = new System.Drawing.Point(358, 63);
            this.tbxUsernameLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxUsernameLogin.Name = "tbxUsernameLogin";
            this.tbxUsernameLogin.Size = new System.Drawing.Size(139, 22);
            this.tbxUsernameLogin.TabIndex = 2;
            // 
            // lbPasswordLogin
            // 
            this.lbPasswordLogin.AutoSize = true;
            this.lbPasswordLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.lbUsernameLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbUsernameLogin.Location = new System.Drawing.Point(124, 66);
            this.lbUsernameLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsernameLogin.Name = "lbUsernameLogin";
            this.lbUsernameLogin.Size = new System.Drawing.Size(190, 17);
            this.lbUsernameLogin.TabIndex = 0;
            this.lbUsernameLogin.Text = "Username / Student number:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(294, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 212);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxLogin);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxPasswordLogin;
        private System.Windows.Forms.TextBox tbxUsernameLogin;
        private System.Windows.Forms.Label lbPasswordLogin;
        private System.Windows.Forms.Label lbUsernameLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}