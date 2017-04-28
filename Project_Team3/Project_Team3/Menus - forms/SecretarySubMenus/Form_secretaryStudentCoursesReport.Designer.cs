namespace Project_Team3.Menus___forms.SecretarySubMenus
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
            this.CoursesReport = new System.Windows.Forms.ListView();
            this.Course_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Teacher_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start_Hour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.End_Hour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CoursesReport
            // 
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
            this.CoursesReport.GridLines = true;
            this.CoursesReport.Location = new System.Drawing.Point(109, 78);
            this.CoursesReport.Name = "CoursesReport";
            this.CoursesReport.Size = new System.Drawing.Size(734, 351);
            this.CoursesReport.TabIndex = 0;
            this.CoursesReport.UseCompatibleStateImageBehavior = false;
            this.CoursesReport.View = System.Windows.Forms.View.Details;
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
            // Num
            // 
            this.Num.Text = "Num.";
            // 
            // Form_secretaryStudentCoursesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 570);
            this.Controls.Add(this.CoursesReport);
            this.Name = "Form_secretaryStudentCoursesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_secretaryStudentCoursesReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryStudentCoursesReport_FormClosed);
            this.ResumeLayout(false);

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
    }
}