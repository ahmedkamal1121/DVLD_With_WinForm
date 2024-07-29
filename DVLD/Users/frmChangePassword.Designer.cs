namespace DVLD.Users
{
    partial class frmChangePassword
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
            this.txCPpass = new System.Windows.Forms.TextBox();
            this.txNpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txOpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlUserInfoCard1 = new DVLD.Users.ctrlUserInfoCard();
            this.SuspendLayout();
            // 
            // txCPpass
            // 
            this.txCPpass.Location = new System.Drawing.Point(220, 562);
            this.txCPpass.Name = "txCPpass";
            this.txCPpass.Size = new System.Drawing.Size(195, 20);
            this.txCPpass.TabIndex = 12;
            // 
            // txNpass
            // 
            this.txNpass.Location = new System.Drawing.Point(220, 514);
            this.txNpass.Name = "txNpass";
            this.txNpass.Size = new System.Drawing.Size(195, 20);
            this.txNpass.TabIndex = 11;
            this.txNpass.TextChanged += new System.EventHandler(this.txNpass_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "New Password";
            // 
            // txOpass
            // 
            this.txOpass.Location = new System.Drawing.Point(220, 472);
            this.txOpass.Name = "txOpass";
            this.txOpass.Size = new System.Drawing.Size(195, 20);
            this.txOpass.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Old Password";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(583, 548);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 34);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlUserInfoCard1
            // 
            this.ctrlUserInfoCard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlUserInfoCard1.Name = "ctrlUserInfoCard1";
            this.ctrlUserInfoCard1.Size = new System.Drawing.Size(768, 432);
            this.ctrlUserInfoCard1.TabIndex = 0;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 627);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txOpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCPpass);
            this.Controls.Add(this.txNpass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctrlUserInfoCard1);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlUserInfoCard ctrlUserInfoCard1;
        private System.Windows.Forms.TextBox txCPpass;
        private System.Windows.Forms.TextBox txNpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txOpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}