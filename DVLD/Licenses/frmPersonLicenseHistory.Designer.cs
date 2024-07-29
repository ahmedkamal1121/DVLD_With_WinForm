namespace DVLD.Licenses
{
    partial class frmPersonLicenseHistory
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
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.ctrlLincenseCategory1 = new DVLD.Licenses.Controls.ctrlLincenseCategory();
            this.ctrlPersonInfoCardWithFilter1 = new DVLD.people.Countrols.ctrlPersonInfoCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_512;
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(13, 121);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(220, 189);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 131;
            this.pbPersonImage.TabStop = false;
            // 
            // ctrlLincenseCategory1
            // 
            this.ctrlLincenseCategory1.Location = new System.Drawing.Point(7, 357);
            this.ctrlLincenseCategory1.Name = "ctrlLincenseCategory1";
            this.ctrlLincenseCategory1.Size = new System.Drawing.Size(1059, 335);
            this.ctrlLincenseCategory1.TabIndex = 133;
            // 
            // ctrlPersonInfoCardWithFilter1
            // 
            this.ctrlPersonInfoCardWithFilter1.Location = new System.Drawing.Point(240, 12);
            this.ctrlPersonInfoCardWithFilter1.Name = "ctrlPersonInfoCardWithFilter1";
            this.ctrlPersonInfoCardWithFilter1.Size = new System.Drawing.Size(803, 416);
            this.ctrlPersonInfoCardWithFilter1.TabIndex = 132;
            // 
            // frmPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 686);
            this.Controls.Add(this.ctrlLincenseCategory1);
            this.Controls.Add(this.ctrlPersonInfoCardWithFilter1);
            this.Controls.Add(this.pbPersonImage);
            this.Name = "frmPersonLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonLicenseHistory";
            this.Load += new System.EventHandler(this.frmPersonLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPersonImage;
        private people.Countrols.ctrlPersonInfoCardWithFilter ctrlPersonInfoCardWithFilter1;
        private Controls.ctrlLincenseCategory ctrlLincenseCategory1;
    }
}