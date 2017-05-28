namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    partial class Form_secretaryStudentSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_secretaryStudentSearch));
            this.idRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchValueTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.studentsResultListBox = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.manageCourseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idRadioButton
            // 
            this.idRadioButton.AutoSize = true;
            this.idRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.idRadioButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.idRadioButton.Location = new System.Drawing.Point(418, 147);
            this.idRadioButton.Name = "idRadioButton";
            this.idRadioButton.Size = new System.Drawing.Size(48, 23);
            this.idRadioButton.TabIndex = 0;
            this.idRadioButton.TabStop = true;
            this.idRadioButton.Text = "ID";
            this.idRadioButton.UseVisualStyleBackColor = false;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.nameRadioButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameRadioButton.Location = new System.Drawing.Point(505, 147);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(75, 23);
            this.nameRadioButton.TabIndex = 1;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = false;
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchByLabel.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchByLabel.Location = new System.Drawing.Point(440, 115);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(99, 19);
            this.searchByLabel.TabIndex = 2;
            this.searchByLabel.Text = "Search By:";
            // 
            // searchValueTextBox
            // 
            this.searchValueTextBox.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchValueTextBox.Location = new System.Drawing.Point(433, 184);
            this.searchValueTextBox.Name = "searchValueTextBox";
            this.searchValueTextBox.Size = new System.Drawing.Size(100, 26);
            this.searchValueTextBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.MistyRose;
            this.searchButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchButton.Location = new System.Drawing.Point(433, 228);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 24);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // studentsResultListBox
            // 
            this.studentsResultListBox.FormattingEnabled = true;
            this.studentsResultListBox.Location = new System.Drawing.Point(419, 360);
            this.studentsResultListBox.Name = "studentsResultListBox";
            this.studentsResultListBox.Size = new System.Drawing.Size(120, 95);
            this.studentsResultListBox.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(419, 518);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // manageCourseButton
            // 
            this.manageCourseButton.Location = new System.Drawing.Point(572, 390);
            this.manageCourseButton.Name = "manageCourseButton";
            this.manageCourseButton.Size = new System.Drawing.Size(112, 33);
            this.manageCourseButton.TabIndex = 8;
            this.manageCourseButton.Text = "Manage Courses";
            this.manageCourseButton.UseVisualStyleBackColor = true;
            this.manageCourseButton.Click += new System.EventHandler(this.manageCourseButton_Click);
            // 
            // Form_secretaryStudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 609);
            this.Controls.Add(this.manageCourseButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.studentsResultListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchValueTextBox);
            this.Controls.Add(this.searchByLabel);
            this.Controls.Add(this.nameRadioButton);
            this.Controls.Add(this.idRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_secretaryStudentSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryStudentSearch_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton idRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.TextBox searchValueTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox studentsResultListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button manageCourseButton;
    }
}