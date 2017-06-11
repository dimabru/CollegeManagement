namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    partial class Form_secretaryManageStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_secretaryManageStudent));
            this.button1 = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.addCoursesLabel = new System.Windows.Forms.Label();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.noCoursesAvailableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(762, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Courses Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CoursesReport_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel.Location = new System.Drawing.Point(181, 72);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(84, 24);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name: ";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.semesterLabel.Location = new System.Drawing.Point(181, 156);
            this.semesterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(118, 24);
            this.semesterLabel.TabIndex = 2;
            this.semesterLabel.Text = "Semester: ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.usernameLabel.Location = new System.Drawing.Point(181, 113);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(128, 24);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username: ";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MistyRose;
            this.backButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.backButton.Location = new System.Drawing.Point(978, 60);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(164, 53);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addCoursesLabel
            // 
            this.addCoursesLabel.AutoSize = true;
            this.addCoursesLabel.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addCoursesLabel.Location = new System.Drawing.Point(552, 238);
            this.addCoursesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addCoursesLabel.Name = "addCoursesLabel";
            this.addCoursesLabel.Size = new System.Drawing.Size(134, 24);
            this.addCoursesLabel.TabIndex = 5;
            this.addCoursesLabel.Text = "Add courses";
            // 
            // coursesDataGridView
            // 
            this.coursesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.coursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesDataGridView.ColumnHeadersVisible = false;
            this.coursesDataGridView.Location = new System.Drawing.Point(165, 296);
            this.coursesDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coursesDataGridView.MultiSelect = false;
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.ReadOnly = true;
            this.coursesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.coursesDataGridView.Size = new System.Drawing.Size(977, 382);
            this.coursesDataGridView.TabIndex = 6;
            // 
            // addCourseButton
            // 
            this.addCourseButton.BackColor = System.Drawing.Color.MistyRose;
            this.addCourseButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addCourseButton.Location = new System.Drawing.Point(856, 226);
            this.addCourseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(275, 63);
            this.addCourseButton.TabIndex = 7;
            this.addCourseButton.Text = "Add Course";
            this.addCourseButton.UseVisualStyleBackColor = false;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // noCoursesAvailableLabel
            // 
            this.noCoursesAvailableLabel.AutoSize = true;
            this.noCoursesAvailableLabel.Enabled = false;
            this.noCoursesAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.noCoursesAvailableLabel.Location = new System.Drawing.Point(421, 457);
            this.noCoursesAvailableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noCoursesAvailableLabel.Name = "noCoursesAvailableLabel";
            this.noCoursesAvailableLabel.Size = new System.Drawing.Size(443, 52);
            this.noCoursesAvailableLabel.TabIndex = 8;
            this.noCoursesAvailableLabel.Text = "No Courses Available";
            this.noCoursesAvailableLabel.Visible = false;
            // 
            // Form_secretaryManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 703);
            this.Controls.Add(this.noCoursesAvailableLabel);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.coursesDataGridView);
            this.Controls.Add(this.addCoursesLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_secretaryManageStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_secretaryManageStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryManageStudent_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label addCoursesLabel;
        private System.Windows.Forms.DataGridView coursesDataGridView;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Label noCoursesAvailableLabel;
    }
}