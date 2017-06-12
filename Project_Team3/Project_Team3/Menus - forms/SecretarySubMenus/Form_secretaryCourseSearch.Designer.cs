namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    partial class Form_secretaryCourseSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_secretaryCourseSearch));
            this.courseIDRadio = new System.Windows.Forms.RadioButton();
            this.courseNameRadio = new System.Windows.Forms.RadioButton();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.courseValueTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.coursesResultsListBox = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.CourseInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseIDRadio
            // 
            this.courseIDRadio.AutoSize = true;
            this.courseIDRadio.BackColor = System.Drawing.Color.Transparent;
            this.courseIDRadio.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.courseIDRadio.Location = new System.Drawing.Point(504, 178);
            this.courseIDRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseIDRadio.Name = "courseIDRadio";
            this.courseIDRadio.Size = new System.Drawing.Size(129, 28);
            this.courseIDRadio.TabIndex = 1;
            this.courseIDRadio.TabStop = true;
            this.courseIDRadio.Text = "Course ID";
            this.courseIDRadio.UseVisualStyleBackColor = false;
            // 
            // courseNameRadio
            // 
            this.courseNameRadio.AutoSize = true;
            this.courseNameRadio.BackColor = System.Drawing.Color.Transparent;
            this.courseNameRadio.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.courseNameRadio.Location = new System.Drawing.Point(667, 178);
            this.courseNameRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseNameRadio.Name = "courseNameRadio";
            this.courseNameRadio.Size = new System.Drawing.Size(162, 28);
            this.courseNameRadio.TabIndex = 2;
            this.courseNameRadio.TabStop = true;
            this.courseNameRadio.Text = "Course Name";
            this.courseNameRadio.UseVisualStyleBackColor = false;
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchByLabel.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchByLabel.Location = new System.Drawing.Point(601, 132);
            this.searchByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(120, 24);
            this.searchByLabel.TabIndex = 3;
            this.searchByLabel.Text = "Search by:";
            // 
            // courseValueTextBox
            // 
            this.courseValueTextBox.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.courseValueTextBox.Location = new System.Drawing.Point(545, 235);
            this.courseValueTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseValueTextBox.Name = "courseValueTextBox";
            this.courseValueTextBox.Size = new System.Drawing.Size(239, 30);
            this.courseValueTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.MistyRose;
            this.searchButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchButton.Location = new System.Drawing.Point(545, 278);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(240, 28);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // coursesResultsListBox
            // 
            this.coursesResultsListBox.FormattingEnabled = true;
            this.coursesResultsListBox.ItemHeight = 16;
            this.coursesResultsListBox.Location = new System.Drawing.Point(545, 362);
            this.coursesResultsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coursesResultsListBox.Name = "coursesResultsListBox";
            this.coursesResultsListBox.Size = new System.Drawing.Size(239, 196);
            this.coursesResultsListBox.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MistyRose;
            this.backButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.backButton.Location = new System.Drawing.Point(605, 618);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(132, 28);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CourseInfoButton
            // 
            this.CourseInfoButton.BackColor = System.Drawing.Color.MistyRose;
            this.CourseInfoButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CourseInfoButton.Location = new System.Drawing.Point(840, 427);
            this.CourseInfoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseInfoButton.Name = "CourseInfoButton";
            this.CourseInfoButton.Size = new System.Drawing.Size(260, 78);
            this.CourseInfoButton.TabIndex = 8;
            this.CourseInfoButton.Text = "Course Information";
            this.CourseInfoButton.UseVisualStyleBackColor = false;
            this.CourseInfoButton.Click += new System.EventHandler(this.CourseInfoButton_Click);
            // 
            // Form_secretaryCourseSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1349, 750);
            this.Controls.Add(this.CourseInfoButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.coursesResultsListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.courseValueTextBox);
            this.Controls.Add(this.searchByLabel);
            this.Controls.Add(this.courseNameRadio);
            this.Controls.Add(this.courseIDRadio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_secretaryCourseSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryCourseSearch_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton courseIDRadio;
        private System.Windows.Forms.RadioButton courseNameRadio;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.TextBox courseValueTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox coursesResultsListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button CourseInfoButton;

        public System.Windows.Forms.RadioButton getCourseRadio() { return this.courseIDRadio; }
        public System.Windows.Forms.RadioButton getCourseNameRadio() { return this.courseNameRadio; }
        public System.Windows.Forms.TextBox getValueTextBox() { return this.courseValueTextBox; }
        public System.Windows.Forms.ListBox getCoursesResults() { return this.coursesResultsListBox; }

    }
}