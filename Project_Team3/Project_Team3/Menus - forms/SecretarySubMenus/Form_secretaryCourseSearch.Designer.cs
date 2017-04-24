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
            this.SuspendLayout();
            // 
            // courseIDRadio
            // 
            this.courseIDRadio.AutoSize = true;
            this.courseIDRadio.BackColor = System.Drawing.Color.Transparent;
            this.courseIDRadio.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.courseIDRadio.Location = new System.Drawing.Point(378, 145);
            this.courseIDRadio.Name = "courseIDRadio";
            this.courseIDRadio.Size = new System.Drawing.Size(105, 23);
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
            this.courseNameRadio.Location = new System.Drawing.Point(500, 145);
            this.courseNameRadio.Name = "courseNameRadio";
            this.courseNameRadio.Size = new System.Drawing.Size(130, 23);
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
            this.searchByLabel.Location = new System.Drawing.Point(451, 107);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(97, 19);
            this.searchByLabel.TabIndex = 3;
            this.searchByLabel.Text = "Search by:";
            // 
            // courseValueTextBox
            // 
            this.courseValueTextBox.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.courseValueTextBox.Location = new System.Drawing.Point(409, 191);
            this.courseValueTextBox.Name = "courseValueTextBox";
            this.courseValueTextBox.Size = new System.Drawing.Size(180, 26);
            this.courseValueTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.MistyRose;
            this.searchButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchButton.Location = new System.Drawing.Point(409, 226);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(180, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // coursesResultsListBox
            // 
            this.coursesResultsListBox.FormattingEnabled = true;
            this.coursesResultsListBox.Location = new System.Drawing.Point(409, 294);
            this.coursesResultsListBox.Name = "coursesResultsListBox";
            this.coursesResultsListBox.Size = new System.Drawing.Size(180, 160);
            this.coursesResultsListBox.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(455, 504);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form_secretaryCourseSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 609);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.coursesResultsListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.courseValueTextBox);
            this.Controls.Add(this.searchByLabel);
            this.Controls.Add(this.courseNameRadio);
            this.Controls.Add(this.courseIDRadio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}