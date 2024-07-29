namespace DVLD.Users
{
    partial class frmShowUserInfo
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
            this.ctrlUserInfoCard1 = new DVLD.Users.ctrlUserInfoCard();
            this.SuspendLayout();
            // 
            // ctrlUserInfoCard1
            // 
            this.ctrlUserInfoCard1.Location = new System.Drawing.Point(0, -3);
            this.ctrlUserInfoCard1.Name = "ctrlUserInfoCard1";
            this.ctrlUserInfoCard1.Size = new System.Drawing.Size(768, 432);
            this.ctrlUserInfoCard1.TabIndex = 0;
            // 
            // frmShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 431);
            this.Controls.Add(this.ctrlUserInfoCard1);
            this.Name = "frmShowUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowUserInfo";
            this.Load += new System.EventHandler(this.frmShowUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserInfoCard ctrlUserInfoCard1;
    }
}