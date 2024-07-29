namespace DVLD.LiecinesApplication
{
    partial class frmNewLocalLicencs
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
            this.Title = new System.Windows.Forms.Label();
            this.tbNewApp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonInfoCardWithFilter1 = new DVLD.people.Countrols.ctrlPersonInfoCardWithFilter();
            this.tbAppinfo = new System.Windows.Forms.TabPage();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbNewApp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbAppinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Blue;
            this.Title.Location = new System.Drawing.Point(222, 34);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(417, 37);
            this.Title.TabIndex = 0;
            this.Title.Text = "New Local Driving Licencs";
            // 
            // tbNewApp
            // 
            this.tbNewApp.Controls.Add(this.tabPage1);
            this.tbNewApp.Controls.Add(this.tbAppinfo);
            this.tbNewApp.Location = new System.Drawing.Point(10, 84);
            this.tbNewApp.Name = "tbNewApp";
            this.tbNewApp.SelectedIndex = 0;
            this.tbNewApp.Size = new System.Drawing.Size(892, 508);
            this.tbNewApp.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlPersonInfoCardWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(884, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Informtion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(671, 420);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 44);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonInfoCardWithFilter1
            // 
            this.ctrlPersonInfoCardWithFilter1.Location = new System.Drawing.Point(7, 6);
            this.ctrlPersonInfoCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPersonInfoCardWithFilter1.Name = "ctrlPersonInfoCardWithFilter1";
            this.ctrlPersonInfoCardWithFilter1.Size = new System.Drawing.Size(873, 394);
            this.ctrlPersonInfoCardWithFilter1.TabIndex = 2;
            // 
            // tbAppinfo
            // 
            this.tbAppinfo.Controls.Add(this.cbClasses);
            this.tbAppinfo.Controls.Add(this.lbUser);
            this.tbAppinfo.Controls.Add(this.lbFees);
            this.tbAppinfo.Controls.Add(this.lbDate);
            this.tbAppinfo.Controls.Add(this.label7);
            this.tbAppinfo.Controls.Add(this.label6);
            this.tbAppinfo.Controls.Add(this.label5);
            this.tbAppinfo.Controls.Add(this.label4);
            this.tbAppinfo.Controls.Add(this.label3);
            this.tbAppinfo.Controls.Add(this.label2);
            this.tbAppinfo.Location = new System.Drawing.Point(4, 24);
            this.tbAppinfo.Name = "tbAppinfo";
            this.tbAppinfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbAppinfo.Size = new System.Drawing.Size(884, 480);
            this.tbAppinfo.TabIndex = 1;
            this.tbAppinfo.Text = "Application Info";
            this.tbAppinfo.UseVisualStyleBackColor = true;
            // 
            // cbClasses
            // 
            this.cbClasses.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(285, 205);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(324, 32);
            this.cbClasses.TabIndex = 6;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(290, 330);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(30, 22);
            this.lbUser.TabIndex = 5;
            this.lbUser.Text = "??";
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Location = new System.Drawing.Point(290, 270);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(30, 22);
            this.lbFees.TabIndex = 4;
            this.lbFees.Text = "15";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(290, 144);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(46, 22);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Now";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Application Fees :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ceated By :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Licsncs Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Application ID :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(783, 598);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 44);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmNewLocalLicencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 653);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbNewApp);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNewLocalLicencs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewLocalLicencs";
            this.Load += new System.EventHandler(this.frmNewLocalLicencs_Load);
            this.tbNewApp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tbAppinfo.ResumeLayout(false);
            this.tbAppinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TabControl tbNewApp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbAppinfo;
        private System.Windows.Forms.Button btnNext;
        private people.Countrols.ctrlPersonInfoCardWithFilter ctrlPersonInfoCardWithFilter1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbDate;
    }
}