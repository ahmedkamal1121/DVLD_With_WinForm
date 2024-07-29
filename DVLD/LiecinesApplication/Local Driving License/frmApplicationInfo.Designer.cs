namespace DVLD.LiecinesApplication.Local_Driving_License
{
    partial class frmApplicationInfo
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
            this.ctrlApplicationInfo1 = new DVLD.Licenses.Controls.ctrlApplicationInfo();
            this.SuspendLayout();
            // 
            // ctrlApplicationInfo1
            // 
            this.ctrlApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlApplicationInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlApplicationInfo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            this.ctrlApplicationInfo1.Size = new System.Drawing.Size(820, 317);
            this.ctrlApplicationInfo1.TabIndex = 0;
            // 
            // frmApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 319);
            this.Controls.Add(this.ctrlApplicationInfo1);
            this.Name = "frmApplicationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApplicationInfo";
            this.Load += new System.EventHandler(this.frmApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Licenses.Controls.ctrlApplicationInfo ctrlApplicationInfo1;
    }
}