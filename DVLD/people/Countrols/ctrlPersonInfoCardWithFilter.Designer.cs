namespace DVLD.people.Countrols
{
    partial class ctrlPersonInfoCardWithFilter
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
            this.txSerash = new System.Windows.Forms.TextBox();
            this.cbFitler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlPersonInfoCard1 = new DVLD.people.Countrols.ctrlPersonInfoCard();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSersh = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txSerash
            // 
            this.txSerash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSerash.Location = new System.Drawing.Point(300, 17);
            this.txSerash.Name = "txSerash";
            this.txSerash.Size = new System.Drawing.Size(239, 30);
            this.txSerash.TabIndex = 1;
            this.txSerash.TextChanged += new System.EventHandler(this.txSerash_TextChanged);
            this.txSerash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSerash_KeyPress);
            // 
            // cbFitler
            // 
            this.cbFitler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFitler.FormattingEnabled = true;
            this.cbFitler.Location = new System.Drawing.Point(108, 19);
            this.cbFitler.Name = "cbFitler";
            this.cbFitler.Size = new System.Drawing.Size(174, 30);
            this.cbFitler.TabIndex = 2;
            this.cbFitler.SelectedIndexChanged += new System.EventHandler(this.cbFitler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter";
            // 
            // ctrlPersonInfoCard1
            // 
            this.ctrlPersonInfoCard1.Location = new System.Drawing.Point(20, 84);
            this.ctrlPersonInfoCard1.Name = "ctrlPersonInfoCard1";
            this.ctrlPersonInfoCard1.Size = new System.Drawing.Size(774, 363);
            this.ctrlPersonInfoCard1.TabIndex = 0;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = global::DVLD.Properties.Resources.AddPerson_32;
            this.btnAddPerson.Location = new System.Drawing.Point(617, 17);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(39, 45);
            this.btnAddPerson.TabIndex = 8;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSersh
            // 
            this.btnSersh.Image = global::DVLD.Properties.Resources.SearchPerson;
            this.btnSersh.Location = new System.Drawing.Point(558, 17);
            this.btnSersh.Name = "btnSersh";
            this.btnSersh.Size = new System.Drawing.Size(43, 45);
            this.btnSersh.TabIndex = 9;
            this.btnSersh.UseVisualStyleBackColor = true;
            this.btnSersh.Click += new System.EventHandler(this.btnSersh_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.cbFitler);
            this.gbFilter.Controls.Add(this.btnSersh);
            this.gbFilter.Controls.Add(this.txSerash);
            this.gbFilter.Controls.Add(this.btnAddPerson);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.Location = new System.Drawing.Point(20, 14);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(756, 64);
            this.gbFilter.TabIndex = 10;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // ctrlPersonInfoCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlPersonInfoCard1);
            this.Name = "ctrlPersonInfoCardWithFilter";
            this.Size = new System.Drawing.Size(803, 416);
            this.Load += new System.EventHandler(this.ctrlPersonInfoCardWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInfoCard ctrlPersonInfoCard1;
        private System.Windows.Forms.TextBox txSerash;
        private System.Windows.Forms.ComboBox cbFitler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSersh;
        private System.Windows.Forms.GroupBox gbFilter;
    }
}
