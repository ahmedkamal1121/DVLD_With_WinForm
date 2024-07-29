namespace DVLD
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLiiceneseServiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internatinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasDetainedDrivingLiceneseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.internatinalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageDetainedLicensestoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSeToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLiiceneseServiesToolStripMenuItem,
            this.manageApplicationToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.applicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.applicationsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Application_Types_64;
            this.applicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(186, 68);
            this.applicationsToolStripMenuItem.Text = "Applications ";
            this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
            // 
            // drivingLiiceneseServiesToolStripMenuItem
            // 
            this.drivingLiiceneseServiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem,
            this.releasDetainedDrivingLiceneseToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingLiiceneseServiesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.drivingLiiceneseServiesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Applications_64;
            this.drivingLiiceneseServiesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.drivingLiiceneseServiesToolStripMenuItem.Name = "drivingLiiceneseServiesToolStripMenuItem";
            this.drivingLiiceneseServiesToolStripMenuItem.Size = new System.Drawing.Size(344, 70);
            this.drivingLiiceneseServiesToolStripMenuItem.Text = "Driving Licenese Servies";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localToolStripMenuItem,
            this.internatinalToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.New_Driving_License_32;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(446, 30);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            this.newDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.newDrivingLicenseToolStripMenuItem_Click);
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Image = global::DVLD.Properties.Resources.Local_32;
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.localToolStripMenuItem.Text = "Local";
            this.localToolStripMenuItem.Click += new System.EventHandler(this.localToolStripMenuItem_Click);
            // 
            // internatinalToolStripMenuItem
            // 
            this.internatinalToolStripMenuItem.Image = global::DVLD.Properties.Resources.International_32;
            this.internatinalToolStripMenuItem.Name = "internatinalToolStripMenuItem";
            this.internatinalToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.internatinalToolStripMenuItem.Text = "Internatinal";
            this.internatinalToolStripMenuItem.Click += new System.EventHandler(this.internatinalToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(446, 30);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // replacmentForLostOrDamagedLicenseToolStripMenuItem
            // 
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.SearchPerson;
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem.Name = "replacmentForLostOrDamagedLicenseToolStripMenuItem";
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem.Size = new System.Drawing.Size(446, 30);
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem.Text = "Replacment for Lost or Damaged License";
            this.replacmentForLostOrDamagedLicenseToolStripMenuItem.Click += new System.EventHandler(this.replacmentForLostOrDamagedLicenseToolStripMenuItem_Click);
            // 
            // releasDetainedDrivingLiceneseToolStripMenuItem
            // 
            this.releasDetainedDrivingLiceneseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.releasDetainedDrivingLiceneseToolStripMenuItem.Name = "releasDetainedDrivingLiceneseToolStripMenuItem";
            this.releasDetainedDrivingLiceneseToolStripMenuItem.Size = new System.Drawing.Size(455, 32);
            this.releasDetainedDrivingLiceneseToolStripMenuItem.Text = "Releas Detained Driving Licenese";
            this.releasDetainedDrivingLiceneseToolStripMenuItem.Click += new System.EventHandler(this.releasDetainedDrivingLiceneseToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Retake_Test_32;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(446, 30);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // manageApplicationToolStripMenuItem
            // 
            this.manageApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localToolStripMenuItem1,
            this.internatinalToolStripMenuItem1});
            this.manageApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.Manage_Applications_64;
            this.manageApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationToolStripMenuItem.Name = "manageApplicationToolStripMenuItem";
            this.manageApplicationToolStripMenuItem.Size = new System.Drawing.Size(344, 70);
            this.manageApplicationToolStripMenuItem.Text = "Manage Application";
            // 
            // localToolStripMenuItem1
            // 
            this.localToolStripMenuItem1.Image = global::DVLD.Properties.Resources.Local_32;
            this.localToolStripMenuItem1.Name = "localToolStripMenuItem1";
            this.localToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.localToolStripMenuItem1.Text = "Local";
            this.localToolStripMenuItem1.Click += new System.EventHandler(this.localToolStripMenuItem1_Click);
            // 
            // internatinalToolStripMenuItem1
            // 
            this.internatinalToolStripMenuItem1.Image = global::DVLD.Properties.Resources.International_32;
            this.internatinalToolStripMenuItem1.Name = "internatinalToolStripMenuItem1";
            this.internatinalToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.internatinalToolStripMenuItem1.Text = "Internatinal";
            this.internatinalToolStripMenuItem1.Click += new System.EventHandler(this.internatinalToolStripMenuItem1_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageDetainedLicensestoolStripMenuItem1,
            this.detainLicenseToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detain_64;
            this.detainLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(344, 70);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // ManageDetainedLicensestoolStripMenuItem1
            // 
            this.ManageDetainedLicensestoolStripMenuItem1.Image = global::DVLD.Properties.Resources.Detain_32;
            this.ManageDetainedLicensestoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManageDetainedLicensestoolStripMenuItem1.Name = "ManageDetainedLicensestoolStripMenuItem1";
            this.ManageDetainedLicensestoolStripMenuItem1.Size = new System.Drawing.Size(300, 38);
            this.ManageDetainedLicensestoolStripMenuItem1.Text = "Manage Detained Licenses";
            this.ManageDetainedLicensestoolStripMenuItem1.Click += new System.EventHandler(this.ManageDetainedLicensestoolStripMenuItem1_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detain_32;
            this.detainLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.releaseDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Application_Types_64;
            this.manageApplicationTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(344, 70);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_Type_64;
            this.manageTestTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(344, 70);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.peopleToolStripMenuItem.Image = global::DVLD.Properties.Resources.People_64;
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(139, 68);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.driversToolStripMenuItem.Image = global::DVLD.Properties.Resources.Drivers_64;
            this.driversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(140, 68);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.usersToolStripMenuItem.Image = global::DVLD.Properties.Resources.Users_2_64;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(127, 68);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSeToolStripMenuItem
            // 
            this.accountSeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountSeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.accountSeToolStripMenuItem.Image = global::DVLD.Properties.Resources.account_settings_64;
            this.accountSeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSeToolStripMenuItem.Name = "accountSeToolStripMenuItem";
            this.accountSeToolStripMenuItem.Size = new System.Drawing.Size(208, 68);
            this.accountSeToolStripMenuItem.Text = "Account Setting";
            // 
            // currentUserToolStripMenuItem
            // 
            this.currentUserToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            this.currentUserToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.currentUserToolStripMenuItem.Text = "Current User";
            this.currentUserToolStripMenuItem.Click += new System.EventHandler(this.currentUserToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::DVLD.Properties.Resources.sign_out_32__2;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 749);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLiiceneseServiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacmentForLostOrDamagedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releasDetainedDrivingLiceneseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internatinalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem internatinalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ManageDetainedLicensestoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}

