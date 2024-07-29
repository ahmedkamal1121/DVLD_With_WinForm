namespace DVLD.Tsets
{
    partial class frmShedoulTestList
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
            this.components = new System.ComponentModel.Container();
            this.pbTestTypeImage = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dvgAppoinments = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlApplicationInfo1 = new DVLD.Licenses.Controls.ctrlApplicationInfo();
            this.applicationInfo1 = new DVLD.Licenses.Controls.ctrlApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAppoinments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTestTypeImage
            // 
            this.pbTestTypeImage.Image = global::DVLD.Properties.Resources.Schedule_Test_512;
            this.pbTestTypeImage.Location = new System.Drawing.Point(45, -1);
            this.pbTestTypeImage.Name = "pbTestTypeImage";
            this.pbTestTypeImage.Size = new System.Drawing.Size(146, 97);
            this.pbTestTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestTypeImage.TabIndex = 1;
            this.pbTestTypeImage.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(218, 23);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(451, 44);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Vision Test Appointments";
            // 
            // dvgAppoinments
            // 
            this.dvgAppoinments.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgAppoinments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAppoinments.Location = new System.Drawing.Point(29, 446);
            this.dvgAppoinments.Name = "dvgAppoinments";
            this.dvgAppoinments.ReadOnly = true;
            this.dvgAppoinments.Size = new System.Drawing.Size(804, 131);
            this.dvgAppoinments.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Appointments :";
            // 
            // button1
            // 
            this.button1.Image = global::DVLD.Properties.Resources.AddAppointment_32;
            this.button1.Location = new System.Drawing.Point(765, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 33);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DVLD.Properties.Resources.Save_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(688, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 80);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(156, 38);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(156, 38);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // ctrlApplicationInfo1
            // 
            this.ctrlApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlApplicationInfo1.Location = new System.Drawing.Point(23, 92);
            this.ctrlApplicationInfo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            this.ctrlApplicationInfo1.Size = new System.Drawing.Size(820, 317);
            this.ctrlApplicationInfo1.TabIndex = 3;
            this.ctrlApplicationInfo1.Load += new System.EventHandler(this.ctrlApplicationInfo1_Load);
            // 
            // applicationInfo1
            // 
            this.applicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationInfo1.Location = new System.Drawing.Point(23, 163);
            this.applicationInfo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.applicationInfo1.Name = "applicationInfo1";
            this.applicationInfo1.Size = new System.Drawing.Size(820, 486);
            this.applicationInfo1.TabIndex = 0;
            // 
            // frmShedoulTestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 632);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgAppoinments);
            this.Controls.Add(this.ctrlApplicationInfo1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbTestTypeImage);
            this.Name = "frmShedoulTestList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisionTest";
            this.Load += new System.EventHandler(this.frmVisionTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAppoinments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Controls.ctrlApplicationInfo applicationInfo1;
        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private System.Windows.Forms.Label lbTitle;
        private Licenses.Controls.ctrlApplicationInfo ctrlApplicationInfo1;
        private System.Windows.Forms.DataGridView dvgAppoinments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}