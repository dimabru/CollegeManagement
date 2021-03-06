﻿namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    partial class Form_secretaryStudentCoursesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_secretaryStudentCoursesReport));
            this.CoursesReport = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Course_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Teacher_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start_Hour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.End_Hour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header_label = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.removeCourseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoursesReport
            // 
            this.CoursesReport.BackColor = System.Drawing.Color.Azure;
            this.CoursesReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.Course_ID,
            this.CourseName,
            this.Teacher_ID,
            this.Room,
            this.Day,
            this.Start_Hour,
            this.End_Hour,
            this.Semester});
            this.CoursesReport.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CoursesReport.FullRowSelect = true;
            this.CoursesReport.GridLines = true;
            this.CoursesReport.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CoursesReport.Location = new System.Drawing.Point(16, 130);
            this.CoursesReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoursesReport.MultiSelect = false;
            this.CoursesReport.Name = "CoursesReport";
            this.CoursesReport.Size = new System.Drawing.Size(977, 431);
            this.CoursesReport.TabIndex = 0;
            this.CoursesReport.UseCompatibleStateImageBehavior = false;
            this.CoursesReport.View = System.Windows.Forms.View.Details;
            // 
            // Num
            // 
            this.Num.Text = "Num.";
            // 
            // Course_ID
            // 
            this.Course_ID.Text = "Course ID";
            this.Course_ID.Width = 66;
            // 
            // CourseName
            // 
            this.CourseName.Text = "Name";
            this.CourseName.Width = 91;
            // 
            // Teacher_ID
            // 
            this.Teacher_ID.Text = "Teacher ID";
            this.Teacher_ID.Width = 72;
            // 
            // Room
            // 
            this.Room.Text = "Room";
            // 
            // Day
            // 
            this.Day.Text = "Day";
            // 
            // Start_Hour
            // 
            this.Start_Hour.Text = "Start Hour";
            this.Start_Hour.Width = 78;
            // 
            // End_Hour
            // 
            this.End_Hour.Text = "End Hour";
            this.End_Hour.Width = 67;
            // 
            // Semester
            // 
            this.Semester.Text = "Semester";
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Header_label.Enabled = false;
            this.Header_label.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Header_label.ForeColor = System.Drawing.Color.Black;
            this.Header_label.Location = new System.Drawing.Point(16, 44);
            this.Header_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(256, 33);
            this.Header_label.TabIndex = 1;
            this.Header_label.Text = "Student courses:";
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.MistyRose;
            this.GoBackButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GoBackButton.Location = new System.Drawing.Point(571, 603);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(172, 87);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackClick);
            // 
            // removeCourseButton
            // 
            this.removeCourseButton.BackColor = System.Drawing.Color.MistyRose;
            this.removeCourseButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.removeCourseButton.Location = new System.Drawing.Point(1053, 271);
            this.removeCourseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeCourseButton.Name = "removeCourseButton";
            this.removeCourseButton.Size = new System.Drawing.Size(152, 85);
            this.removeCourseButton.TabIndex = 3;
            this.removeCourseButton.Text = "Remove Course";
            this.removeCourseButton.UseVisualStyleBackColor = false;
            this.removeCourseButton.Click += new System.EventHandler(this.removeCourseButton_Click);
            // 
            // Form_secretaryStudentCoursesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1331, 703);
            this.Controls.Add(this.removeCourseButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.Header_label);
            this.Controls.Add(this.CoursesReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_secretaryStudentCoursesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Courses Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryStudentCoursesReport_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CoursesReport;
        private System.Windows.Forms.ColumnHeader Course_ID;
        private System.Windows.Forms.ColumnHeader Teacher_ID;
        private System.Windows.Forms.ColumnHeader Room;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.ColumnHeader Start_Hour;
        private System.Windows.Forms.ColumnHeader End_Hour;
        private System.Windows.Forms.ColumnHeader Semester;
        private System.Windows.Forms.ColumnHeader CourseName;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button removeCourseButton;
    }
}