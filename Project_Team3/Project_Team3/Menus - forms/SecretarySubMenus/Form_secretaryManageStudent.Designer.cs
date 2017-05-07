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
            this.button1 = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.addCoursesLabel = new System.Windows.Forms.Label();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.addCourseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Courses Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CoursesReport_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel.Location = new System.Drawing.Point(12, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name: ";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.semesterLabel.Location = new System.Drawing.Point(12, 81);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(86, 20);
            this.semesterLabel.TabIndex = 2;
            this.semesterLabel.Text = "Semester: ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.usernameLabel.Location = new System.Drawing.Point(12, 46);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 20);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username: ";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(610, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(123, 43);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addCoursesLabel
            // 
            this.addCoursesLabel.AutoSize = true;
            this.addCoursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addCoursesLabel.Location = new System.Drawing.Point(290, 148);
            this.addCoursesLabel.Name = "addCoursesLabel";
            this.addCoursesLabel.Size = new System.Drawing.Size(132, 25);
            this.addCoursesLabel.TabIndex = 5;
            this.addCoursesLabel.Text = "Add courses";
            // 
            // coursesDataGridView
            // 
            this.coursesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.coursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesDataGridView.ColumnHeadersVisible = false;
            this.coursesDataGridView.Location = new System.Drawing.Point(0, 195);
            this.coursesDataGridView.MultiSelect = false;
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.ReadOnly = true;
            this.coursesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.coursesDataGridView.Size = new System.Drawing.Size(733, 310);
            this.coursesDataGridView.TabIndex = 6;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addCourseButton.Location = new System.Drawing.Point(518, 138);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(206, 51);
            this.addCourseButton.TabIndex = 7;
            this.addCourseButton.Text = "Add Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // Form_secretaryManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 517);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.coursesDataGridView);
            this.Controls.Add(this.addCoursesLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.button1);
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
    }
}