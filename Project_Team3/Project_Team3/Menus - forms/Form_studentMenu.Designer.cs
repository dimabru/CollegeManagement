namespace Project_Team3
{
    partial class Form_studentMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_studentMenu));
            this.LogoutStudent = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.associationMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associationInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToAssociationEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unregisterAssociationEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfMandatoryCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchMyCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCourseTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.sunday_box = new System.Windows.Forms.ListBox();
            this.monday_box = new System.Windows.Forms.ListBox();
            this.tuesday_box = new System.Windows.Forms.ListBox();
            this.wednesday_box = new System.Windows.Forms.ListBox();
            this.thursday_box = new System.Windows.Forms.ListBox();
            this.friday_box = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutStudent
            // 
            this.LogoutStudent.BackColor = System.Drawing.Color.MistyRose;
            this.LogoutStudent.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LogoutStudent.Location = new System.Drawing.Point(867, 26);
            this.LogoutStudent.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutStudent.Name = "LogoutStudent";
            this.LogoutStudent.Size = new System.Drawing.Size(145, 43);
            this.LogoutStudent.TabIndex = 0;
            this.LogoutStudent.Text = "Logout";
            this.LogoutStudent.UseVisualStyleBackColor = false;
            this.LogoutStudent.Click += new System.EventHandler(this.LogoutStudent_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(0, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(863, 43);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Future global message";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associationMenuToolStripMenuItem,
            this.studentRequestsToolStripMenuItem,
            this.coursesMenuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "StudentMenuStrip";
            // 
            // associationMenuToolStripMenuItem
            // 
            this.associationMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRequestToolStripMenuItem,
            this.myRequestsToolStripMenuItem});
            this.associationMenuToolStripMenuItem.Name = "associationMenuToolStripMenuItem";
            this.associationMenuToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.associationMenuToolStripMenuItem.Text = "Student Requests";
            // 
            // addNewRequestToolStripMenuItem
            // 
            this.addNewRequestToolStripMenuItem.Name = "addNewRequestToolStripMenuItem";
            this.addNewRequestToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addNewRequestToolStripMenuItem.Text = "Add new Request";
            this.addNewRequestToolStripMenuItem.Click += new System.EventHandler(this.NewRequestButton_Click);
            // 
            // myRequestsToolStripMenuItem
            // 
            this.myRequestsToolStripMenuItem.Name = "myRequestsToolStripMenuItem";
            this.myRequestsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.myRequestsToolStripMenuItem.Text = "My requests";
            this.myRequestsToolStripMenuItem.Click += new System.EventHandler(this.ExistingRequestsButton_Click);
            // 
            // studentRequestsToolStripMenuItem
            // 
            this.studentRequestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associationInformationToolStripMenuItem,
            this.registerToAssociationEventsToolStripMenuItem,
            this.unregisterAssociationEventsToolStripMenuItem});
            this.studentRequestsToolStripMenuItem.Name = "studentRequestsToolStripMenuItem";
            this.studentRequestsToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.studentRequestsToolStripMenuItem.Text = "Association Menu";
            this.studentRequestsToolStripMenuItem.Click += new System.EventHandler(this.studentRequestsToolStripMenuItem_Click);
            // 
            // associationInformationToolStripMenuItem
            // 
            this.associationInformationToolStripMenuItem.Name = "associationInformationToolStripMenuItem";
            this.associationInformationToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.associationInformationToolStripMenuItem.Text = "Association information";
            this.associationInformationToolStripMenuItem.Click += new System.EventHandler(this.AssociationInformationButton_Click);
            // 
            // registerToAssociationEventsToolStripMenuItem
            // 
            this.registerToAssociationEventsToolStripMenuItem.Name = "registerToAssociationEventsToolStripMenuItem";
            this.registerToAssociationEventsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.registerToAssociationEventsToolStripMenuItem.Text = "Register to association events";
            this.registerToAssociationEventsToolStripMenuItem.Click += new System.EventHandler(this.RegisterEventsButton_Click);
            // 
            // unregisterAssociationEventsToolStripMenuItem
            // 
            this.unregisterAssociationEventsToolStripMenuItem.Name = "unregisterAssociationEventsToolStripMenuItem";
            this.unregisterAssociationEventsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.unregisterAssociationEventsToolStripMenuItem.Text = "Unregister association events";
            this.unregisterAssociationEventsToolStripMenuItem.Click += new System.EventHandler(this.UnregisterEventsButton_Click);
            // 
            // coursesMenuToolStripMenuItem
            // 
            this.coursesMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfMandatoryCoursesToolStripMenuItem,
            this.watchMyCoursesToolStripMenuItem,
            this.changeCourseTimeToolStripMenuItem});
            this.coursesMenuToolStripMenuItem.Name = "coursesMenuToolStripMenuItem";
            this.coursesMenuToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.coursesMenuToolStripMenuItem.Text = "Courses Menu";
            // 
            // listOfMandatoryCoursesToolStripMenuItem
            // 
            this.listOfMandatoryCoursesToolStripMenuItem.Name = "listOfMandatoryCoursesToolStripMenuItem";
            this.listOfMandatoryCoursesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.listOfMandatoryCoursesToolStripMenuItem.Text = "List of mandatory courses";
            this.listOfMandatoryCoursesToolStripMenuItem.Click += new System.EventHandler(this.MandatoryCoursesListButton_Click);
            // 
            // watchMyCoursesToolStripMenuItem
            // 
            this.watchMyCoursesToolStripMenuItem.Name = "watchMyCoursesToolStripMenuItem";
            this.watchMyCoursesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.watchMyCoursesToolStripMenuItem.Text = "Watch my courses";
            this.watchMyCoursesToolStripMenuItem.Click += new System.EventHandler(this.WatchCoursesButton_Click);
            // 
            // changeCourseTimeToolStripMenuItem
            // 
            this.changeCourseTimeToolStripMenuItem.Name = "changeCourseTimeToolStripMenuItem";
            this.changeCourseTimeToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.changeCourseTimeToolStripMenuItem.Text = "Change course time";
            this.changeCourseTimeToolStripMenuItem.Click += new System.EventHandler(this.ChangeCourseTimeButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // sunday_box
            // 
            this.sunday_box.FormattingEnabled = true;
            this.sunday_box.Items.AddRange(new object[] {
            "8:00 - 12:00 - חדווא 1"});
            this.sunday_box.Location = new System.Drawing.Point(61, 106);
            this.sunday_box.Name = "sunday_box";
            this.sunday_box.Size = new System.Drawing.Size(156, 498);
            this.sunday_box.TabIndex = 8;
            // 
            // monday_box
            // 
            this.monday_box.FormattingEnabled = true;
            this.monday_box.Location = new System.Drawing.Point(224, 106);
            this.monday_box.Name = "monday_box";
            this.monday_box.Size = new System.Drawing.Size(152, 498);
            this.monday_box.TabIndex = 9;
            // 
            // tuesday_box
            // 
            this.tuesday_box.FormattingEnabled = true;
            this.tuesday_box.Location = new System.Drawing.Point(383, 106);
            this.tuesday_box.Name = "tuesday_box";
            this.tuesday_box.Size = new System.Drawing.Size(154, 498);
            this.tuesday_box.TabIndex = 10;
            // 
            // wednesday_box
            // 
            this.wednesday_box.FormattingEnabled = true;
            this.wednesday_box.Location = new System.Drawing.Point(542, 106);
            this.wednesday_box.Name = "wednesday_box";
            this.wednesday_box.Size = new System.Drawing.Size(151, 498);
            this.wednesday_box.TabIndex = 11;
            // 
            // thursday_box
            // 
            this.thursday_box.FormattingEnabled = true;
            this.thursday_box.Location = new System.Drawing.Point(699, 106);
            this.thursday_box.Name = "thursday_box";
            this.thursday_box.Size = new System.Drawing.Size(151, 498);
            this.thursday_box.TabIndex = 12;
            // 
            // friday_box
            // 
            this.friday_box.FormattingEnabled = true;
            this.friday_box.Location = new System.Drawing.Point(856, 106);
            this.friday_box.Name = "friday_box";
            this.friday_box.Size = new System.Drawing.Size(156, 498);
            this.friday_box.TabIndex = 13;
            // 
            // Form_studentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 609);
            this.Controls.Add(this.friday_box);
            this.Controls.Add(this.thursday_box);
            this.Controls.Add(this.wednesday_box);
            this.Controls.Add(this.tuesday_box);
            this.Controls.Add(this.monday_box);
            this.Controls.Add(this.sunday_box);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LogoutStudent);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_studentMenu";
            this.Text = "Student Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_studentMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form_studentMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutStudent;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem associationMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associationInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToAssociationEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unregisterAssociationEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfMandatoryCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchMyCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCourseTimeToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ListBox friday_box;
        private System.Windows.Forms.ListBox thursday_box;
        private System.Windows.Forms.ListBox wednesday_box;
        private System.Windows.Forms.ListBox tuesday_box;
        private System.Windows.Forms.ListBox monday_box;
        private System.Windows.Forms.ListBox sunday_box;
    }
}