namespace DVLD.Users
{
    partial class frmAddEditUser
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
            this.tcADDUser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlPersonInfoCardWithFilter1 = new DVLD.people.Countrols.ctrlPersonInfoCardWithFilter();
            this.tbLogin = new System.Windows.Forms.TabPage();
            this.chIsactive = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tcADDUser.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcADDUser
            // 
            this.tcADDUser.Controls.Add(this.tabPage1);
            this.tcADDUser.Controls.Add(this.tbLogin);
            this.tcADDUser.Location = new System.Drawing.Point(3, 93);
            this.tcADDUser.Name = "tcADDUser";
            this.tcADDUser.SelectedIndex = 0;
            this.tcADDUser.Size = new System.Drawing.Size(797, 490);
            this.tcADDUser.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.ctrlPersonInfoCardWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Next_Click);
            // 
            // ctrlPersonInfoCardWithFilter1
            // 
            this.ctrlPersonInfoCardWithFilter1.Location = new System.Drawing.Point(7, 7);
            this.ctrlPersonInfoCardWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonInfoCardWithFilter1.Name = "ctrlPersonInfoCardWithFilter1";
            this.ctrlPersonInfoCardWithFilter1.Size = new System.Drawing.Size(778, 388);
            this.ctrlPersonInfoCardWithFilter1.TabIndex = 0;
            this.ctrlPersonInfoCardWithFilter1.Load += new System.EventHandler(this.ctrlPersonInfoCardWithFilter1_Load);
            // 
            // tbLogin
            // 
            this.tbLogin.Controls.Add(this.chIsactive);
            this.tbLogin.Controls.Add(this.textBox4);
            this.tbLogin.Controls.Add(this.txPassword);
            this.tbLogin.Controls.Add(this.txUsername);
            this.tbLogin.Controls.Add(this.label6);
            this.tbLogin.Controls.Add(this.label5);
            this.tbLogin.Controls.Add(this.label4);
            this.tbLogin.Controls.Add(this.lbUserID);
            this.tbLogin.Controls.Add(this.label1);
            this.tbLogin.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbLogin.Location = new System.Drawing.Point(4, 22);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tbLogin.Size = new System.Drawing.Size(789, 464);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "Login Info";
            this.tbLogin.UseVisualStyleBackColor = true;
            // 
            // chIsactive
            // 
            this.chIsactive.AutoSize = true;
            this.chIsactive.Checked = true;
            this.chIsactive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chIsactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chIsactive.Location = new System.Drawing.Point(217, 276);
            this.chIsactive.Name = "chIsactive";
            this.chIsactive.Size = new System.Drawing.Size(97, 24);
            this.chIsactive.TabIndex = 9;
            this.chIsactive.Text = "Is Active";
            this.chIsactive.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(240, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 20);
            this.textBox4.TabIndex = 8;
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(240, 177);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(195, 20);
            this.txPassword.TabIndex = 6;
            // 
            // txUsername
            // 
            this.txUsername.Location = new System.Drawing.Point(240, 131);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(195, 20);
            this.txUsername.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "UserName";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(245, 82);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(54, 24);
            this.lbUserID.TabIndex = 1;
            this.lbUserID.Text = "????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(272, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add New User";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(641, 585);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Save_Click);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 652);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tcADDUser);
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUser";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.tcADDUser.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tbLogin.ResumeLayout(false);
            this.tbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcADDUser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbLogin;
        private people.Countrols.ctrlPersonInfoCardWithFilter ctrlPersonInfoCardWithFilter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chIsactive;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}