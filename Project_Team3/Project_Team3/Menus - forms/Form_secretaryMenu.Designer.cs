namespace Project_Team3
{
    partial class Form_secretaryMenu
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.globalMessage = new System.Windows.Forms.Label();
            this.coursesReportButton = new System.Windows.Forms.Button();
            this.studentSearchButton = new System.Windows.Forms.Button();
            this.searchCourseButton = new System.Windows.Forms.Button();
            this.studentRequestsButton = new System.Windows.Forms.Button();
            this.associationEventsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(211, 205);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(129, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // globalMessage
            // 
            this.globalMessage.AutoSize = true;
            this.globalMessage.Location = new System.Drawing.Point(87, 10);
            this.globalMessage.Name = "globalMessage";
            this.globalMessage.Size = new System.Drawing.Size(193, 13);
            this.globalMessage.TabIndex = 1;
            this.globalMessage.Text = "Global Message Will be Displayed Here";
            // 
            // coursesReportButton
            // 
            this.coursesReportButton.Location = new System.Drawing.Point(44, 115);
            this.coursesReportButton.Name = "coursesReportButton";
            this.coursesReportButton.Size = new System.Drawing.Size(118, 23);
            this.coursesReportButton.TabIndex = 3;
            this.coursesReportButton.Text = "Courses Report";
            this.coursesReportButton.UseVisualStyleBackColor = true;
            // 
            // studentSearchButton
            // 
            this.studentSearchButton.Location = new System.Drawing.Point(44, 157);
            this.studentSearchButton.Name = "studentSearchButton";
            this.studentSearchButton.Size = new System.Drawing.Size(118, 23);
            this.studentSearchButton.TabIndex = 4;
            this.studentSearchButton.Text = "Search for a Student";
            this.studentSearchButton.UseVisualStyleBackColor = true;
            // 
            // searchCourseButton
            // 
            this.searchCourseButton.Location = new System.Drawing.Point(44, 205);
            this.searchCourseButton.Name = "searchCourseButton";
            this.searchCourseButton.Size = new System.Drawing.Size(118, 23);
            this.searchCourseButton.TabIndex = 5;
            this.searchCourseButton.Text = "Search for a course";
            this.searchCourseButton.UseVisualStyleBackColor = true;
            // 
            // studentRequestsButton
            // 
            this.studentRequestsButton.Location = new System.Drawing.Point(211, 115);
            this.studentRequestsButton.Name = "studentRequestsButton";
            this.studentRequestsButton.Size = new System.Drawing.Size(129, 23);
            this.studentRequestsButton.TabIndex = 6;
            this.studentRequestsButton.Text = "Student Requests";
            this.studentRequestsButton.UseVisualStyleBackColor = true;
            // 
            // associationEventsButton
            // 
            this.associationEventsButton.Location = new System.Drawing.Point(211, 157);
            this.associationEventsButton.Name = "associationEventsButton";
            this.associationEventsButton.Size = new System.Drawing.Size(129, 23);
            this.associationEventsButton.TabIndex = 7;
            this.associationEventsButton.Text = "Association Events";
            this.associationEventsButton.UseVisualStyleBackColor = true;
            // 
            // Form_secretaryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.associationEventsButton);
            this.Controls.Add(this.studentRequestsButton);
            this.Controls.Add(this.searchCourseButton);
            this.Controls.Add(this.studentSearchButton);
            this.Controls.Add(this.coursesReportButton);
            this.Controls.Add(this.globalMessage);
            this.Controls.Add(this.logoutButton);
            this.Name = "Form_secretaryMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_secretaryMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label globalMessage;
        private System.Windows.Forms.Button coursesReportButton;
        private System.Windows.Forms.Button studentSearchButton;
        private System.Windows.Forms.Button searchCourseButton;
        private System.Windows.Forms.Button studentRequestsButton;
        private System.Windows.Forms.Button associationEventsButton;
    }
}