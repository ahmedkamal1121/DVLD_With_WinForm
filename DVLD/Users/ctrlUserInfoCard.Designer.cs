namespace DVLD.Users
{
    partial class ctrlUserInfoCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbActive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonInfoCard1 = new DVLD.people.Countrols.ctrlPersonInfoCard();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbActive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Info";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(485, 40);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(39, 20);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "UserID";
            // 
            // lbActive
            // 
            this.lbActive.AutoSize = true;
            this.lbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActive.Location = new System.Drawing.Point(702, 40);
            this.lbActive.Name = "lbActive";
            this.lbActive.Size = new System.Drawing.Size(39, 20);
            this.lbActive.TabIndex = 3;
            this.lbActive.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "IsActive";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(133, 40);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(49, 20);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // ctrlPersonInfoCard1
            // 
            this.ctrlPersonInfoCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonInfoCard1.Name = "ctrlPersonInfoCard1";
            this.ctrlPersonInfoCard1.Size = new System.Drawing.Size(765, 313);
            this.ctrlPersonInfoCard1.TabIndex = 0;
            this.ctrlPersonInfoCard1.Load += new System.EventHandler(this.ctrlPersonInfoCard1_Load);
            // 
            // ctrlUserInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlPersonInfoCard1);
            this.Name = "ctrlUserInfoCard";
            this.Size = new System.Drawing.Size(768, 432);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private people.Countrols.ctrlPersonInfoCard ctrlPersonInfoCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label5;
    }
}
