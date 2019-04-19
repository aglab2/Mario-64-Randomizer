namespace Mario64Randomizer
{
    partial class EditSequence
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
            this.cmbAreas = new System.Windows.Forms.ComboBox();
            this.btnSetArea = new System.Windows.Forms.Button();
            this.lbCourseList = new System.Windows.Forms.ListBox();
            this.lbCoursesInArea = new System.Windows.Forms.ListBox();
            this.btnUnsetArea = new System.Windows.Forms.Button();
            this.btnAddToArea = new System.Windows.Forms.Button();
            this.btnRemoveFromArea = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSectionName = new System.Windows.Forms.TextBox();
            this.cmbSections = new System.Windows.Forms.ComboBox();
            this.btnAddToSection = new System.Windows.Forms.Button();
            this.btnRemoveFromSection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAreas
            // 
            this.cmbAreas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbAreas.FormattingEnabled = true;
            this.cmbAreas.Location = new System.Drawing.Point(235, 64);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(156, 21);
            this.cmbAreas.TabIndex = 0;
            this.cmbAreas.SelectedIndexChanged += new System.EventHandler(this.cmbAreas_SelectedIndexChanged);
            // 
            // btnSetArea
            // 
            this.btnSetArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetArea.Location = new System.Drawing.Point(235, 29);
            this.btnSetArea.Name = "btnSetArea";
            this.btnSetArea.Size = new System.Drawing.Size(75, 23);
            this.btnSetArea.TabIndex = 2;
            this.btnSetArea.Text = "Set Area";
            this.btnSetArea.UseVisualStyleBackColor = true;
            this.btnSetArea.Click += new System.EventHandler(this.btnSetArea_Click);
            // 
            // lbCourseList
            // 
            this.lbCourseList.FormattingEnabled = true;
            this.lbCourseList.Location = new System.Drawing.Point(12, 29);
            this.lbCourseList.Name = "lbCourseList";
            this.lbCourseList.Size = new System.Drawing.Size(199, 264);
            this.lbCourseList.TabIndex = 4;
            // 
            // lbCoursesInArea
            // 
            this.lbCoursesInArea.FormattingEnabled = true;
            this.lbCoursesInArea.Location = new System.Drawing.Point(235, 135);
            this.lbCoursesInArea.Name = "lbCoursesInArea";
            this.lbCoursesInArea.Size = new System.Drawing.Size(156, 160);
            this.lbCoursesInArea.TabIndex = 5;
            // 
            // btnUnsetArea
            // 
            this.btnUnsetArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUnsetArea.Location = new System.Drawing.Point(316, 29);
            this.btnUnsetArea.Name = "btnUnsetArea";
            this.btnUnsetArea.Size = new System.Drawing.Size(75, 23);
            this.btnUnsetArea.TabIndex = 6;
            this.btnUnsetArea.Text = "Remove Area";
            this.btnUnsetArea.UseVisualStyleBackColor = true;
            this.btnUnsetArea.Click += new System.EventHandler(this.btnUnsetArea_Click);
            // 
            // btnAddToArea
            // 
            this.btnAddToArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddToArea.Location = new System.Drawing.Point(235, 98);
            this.btnAddToArea.Name = "btnAddToArea";
            this.btnAddToArea.Size = new System.Drawing.Size(75, 23);
            this.btnAddToArea.TabIndex = 7;
            this.btnAddToArea.Text = "Add to Area";
            this.btnAddToArea.UseVisualStyleBackColor = true;
            this.btnAddToArea.Click += new System.EventHandler(this.btnAddToArea_Click);
            // 
            // btnRemoveFromArea
            // 
            this.btnRemoveFromArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveFromArea.Location = new System.Drawing.Point(316, 98);
            this.btnRemoveFromArea.Name = "btnRemoveFromArea";
            this.btnRemoveFromArea.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFromArea.TabIndex = 8;
            this.btnRemoveFromArea.Text = "Remove from Area";
            this.btnRemoveFromArea.UseVisualStyleBackColor = true;
            this.btnRemoveFromArea.Click += new System.EventHandler(this.btnRemoveFromArea_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(406, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Section";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(488, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Remove Section";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtSectionName
            // 
            this.txtSectionName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSectionName.Location = new System.Drawing.Point(407, 65);
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.Size = new System.Drawing.Size(156, 20);
            this.txtSectionName.TabIndex = 11;
            // 
            // cmbSections
            // 
            this.cmbSections.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbSections.FormattingEnabled = true;
            this.cmbSections.Location = new System.Drawing.Point(406, 98);
            this.cmbSections.Name = "cmbSections";
            this.cmbSections.Size = new System.Drawing.Size(156, 21);
            this.cmbSections.TabIndex = 12;
            // 
            // btnAddToSection
            // 
            this.btnAddToSection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddToSection.Location = new System.Drawing.Point(406, 135);
            this.btnAddToSection.Name = "btnAddToSection";
            this.btnAddToSection.Size = new System.Drawing.Size(75, 23);
            this.btnAddToSection.TabIndex = 13;
            this.btnAddToSection.Text = "Add Course To Section";
            this.btnAddToSection.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromSection
            // 
            this.btnRemoveFromSection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveFromSection.Location = new System.Drawing.Point(488, 135);
            this.btnRemoveFromSection.Name = "btnRemoveFromSection";
            this.btnRemoveFromSection.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFromSection.TabIndex = 14;
            this.btnRemoveFromSection.Text = "btnRemoveFromSection";
            this.btnRemoveFromSection.UseVisualStyleBackColor = true;
            // 
            // EditSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(595, 309);
            this.Controls.Add(this.btnRemoveFromSection);
            this.Controls.Add(this.btnAddToSection);
            this.Controls.Add(this.cmbSections);
            this.Controls.Add(this.txtSectionName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveFromArea);
            this.Controls.Add(this.btnAddToArea);
            this.Controls.Add(this.btnUnsetArea);
            this.Controls.Add(this.lbCoursesInArea);
            this.Controls.Add(this.lbCourseList);
            this.Controls.Add(this.btnSetArea);
            this.Controls.Add(this.cmbAreas);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "EditSequence";
            this.Text = "EditSequence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAreas;
        private System.Windows.Forms.Button btnSetArea;
        private System.Windows.Forms.ListBox lbCourseList;
        private System.Windows.Forms.ListBox lbCoursesInArea;
        private System.Windows.Forms.Button btnUnsetArea;
        private System.Windows.Forms.Button btnAddToArea;
        private System.Windows.Forms.Button btnRemoveFromArea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSectionName;
        private System.Windows.Forms.ComboBox cmbSections;
        private System.Windows.Forms.Button btnAddToSection;
        private System.Windows.Forms.Button btnRemoveFromSection;
    }
}