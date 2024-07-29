namespace DVLD.Tsets
{
    partial class frmSheodleTest
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
            this.ctrlShodelTest1 = new DVLD.Tsets.Controls.ctrlShodelTest();
            this.SuspendLayout();
            // 
            // ctrlShodelTest1
            // 
            this.ctrlShodelTest1.Location = new System.Drawing.Point(0, 0);
            this.ctrlShodelTest1.Name = "ctrlShodelTest1";
            this.ctrlShodelTest1.Size = new System.Drawing.Size(524, 647);
            this.ctrlShodelTest1.TabIndex = 0;
            // 
            // frmSheodleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 653);
            this.Controls.Add(this.ctrlShodelTest1);
            this.Name = "frmSheodleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSheodleTest";
            this.Load += new System.EventHandler(this.frmSheodleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlShodelTest ctrlShodelTest1;
    }
}