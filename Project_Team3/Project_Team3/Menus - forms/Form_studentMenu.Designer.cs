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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AddNewReqbutton = new System.Windows.Forms.Button();
            this.WatchReqbutton = new System.Windows.Forms.Button();
            this.AssociationMenubutton = new System.Windows.Forms.Button();
            this.WatchCoursesbutton = new System.Windows.Forms.Button();
            this.MandatoryCoursesbutton = new System.Windows.Forms.Button();
            this.ChangeCourseTimebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutStudent
            // 
            this.LogoutStudent.BackColor = System.Drawing.Color.MistyRose;
            this.LogoutStudent.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LogoutStudent.Location = new System.Drawing.Point(487, 615);
            this.LogoutStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutStudent.Name = "LogoutStudent";
            this.LogoutStudent.Size = new System.Drawing.Size(373, 62);
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
            this.textBox1.Location = new System.Drawing.Point(0, 1);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1149, 52);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Future global message";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AddNewReqbutton
            // 
            this.AddNewReqbutton.BackColor = System.Drawing.Color.MistyRose;
            this.AddNewReqbutton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddNewReqbutton.Location = new System.Drawing.Point(487, 442);
            this.AddNewReqbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddNewReqbutton.Name = "AddNewReqbutton";
            this.AddNewReqbutton.Size = new System.Drawing.Size(373, 62);
            this.AddNewReqbutton.TabIndex = 8;
            this.AddNewReqbutton.Text = "Add New Request";
            this.AddNewReqbutton.UseVisualStyleBackColor = false;
            this.AddNewReqbutton.Click += new System.EventHandler(this.AddNewReqbutton_Click);
            // 
            // WatchReqbutton
            // 
            this.WatchReqbutton.BackColor = System.Drawing.Color.MistyRose;
            this.WatchReqbutton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WatchReqbutton.Location = new System.Drawing.Point(487, 530);
            this.WatchReqbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WatchReqbutton.Name = "WatchReqbutton";
            this.WatchReqbutton.Size = new System.Drawing.Size(373, 62);
            this.WatchReqbutton.TabIndex = 9;
            this.WatchReqbutton.Text = "Watch My Requests";
            this.WatchReqbutton.UseVisualStyleBackColor = false;
            this.WatchReqbutton.Click += new System.EventHandler(this.WatchReqbutton_Click);
            // 
            // AssociationMenubutton
            // 
            this.AssociationMenubutton.BackColor = System.Drawing.Color.MistyRose;
            this.AssociationMenubutton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AssociationMenubutton.Location = new System.Drawing.Point(487, 353);
            this.AssociationMenubutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssociationMenubutton.Name = "AssociationMenubutton";
            this.AssociationMenubutton.Size = new System.Drawing.Size(373, 62);
            this.AssociationMenubutton.TabIndex = 10;
            this.AssociationMenubutton.Text = "Association Menu";
            this.AssociationMenubutton.UseVisualStyleBackColor = false;
            this.AssociationMenubutton.Click += new System.EventHandler(this.AssociationMenubutton_Click_1);
            // 
            // WatchCoursesbutton
            // 
            this.WatchCoursesbutton.BackColor = System.Drawing.Color.MistyRose;
            this.WatchCoursesbutton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WatchCoursesbutton.Location = new System.Drawing.Point(487, 92);
            this.WatchCoursesbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WatchCoursesbutton.Name = "WatchCoursesbutton";
            this.WatchCoursesbutton.Size = new System.Drawing.Size(373, 62);
            this.WatchCoursesbutton.TabIndex = 11;
            this.WatchCoursesbutton.Text = "Watch My Courses";
            this.WatchCoursesbutton.UseVisualStyleBackColor = false;
            this.WatchCoursesbutton.Click += new System.EventHandler(this.WatchCoursesbutton_Click_1);
            // 
            // MandatoryCoursesbutton
            // 
            this.MandatoryCoursesbutton.BackColor = System.Drawing.Color.MistyRose;
            this.MandatoryCoursesbutton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MandatoryCoursesbutton.Location = new System.Drawing.Point(487, 182);
            this.MandatoryCoursesbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MandatoryCoursesbutton.Name = "MandatoryCoursesbutton";
            this.MandatoryCoursesbutton.Size = new System.Drawing.Size(373, 62);
            this.MandatoryCoursesbutton.TabIndex = 12;
            this.MandatoryCoursesbutton.Text = "Watch Mandatory Courses";
            this.MandatoryCoursesbutton.UseVisualStyleBackColor = false;
            this.MandatoryCoursesbutton.Click += new System.EventHandler(this.MandatoryCoursesbutton_Click);
            // 
            // ChangeCourseTimebutton
            // 
            this.ChangeCourseTimebutton.BackColor = System.Drawing.Color.MistyRose;
            this.ChangeCourseTimebutton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChangeCourseTimebutton.Location = new System.Drawing.Point(487, 271);
            this.ChangeCourseTimebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeCourseTimebutton.Name = "ChangeCourseTimebutton";
            this.ChangeCourseTimebutton.Size = new System.Drawing.Size(373, 62);
            this.ChangeCourseTimebutton.TabIndex = 13;
            this.ChangeCourseTimebutton.Text = "Change Course Time";
            this.ChangeCourseTimebutton.UseVisualStyleBackColor = false;
            this.ChangeCourseTimebutton.Click += new System.EventHandler(this.ChangeCourseTimebutton_Click_1);
            // 
            // Form_studentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 703);
            this.Controls.Add(this.ChangeCourseTimebutton);
            this.Controls.Add(this.MandatoryCoursesbutton);
            this.Controls.Add(this.WatchCoursesbutton);
            this.Controls.Add(this.AssociationMenubutton);
            this.Controls.Add(this.WatchReqbutton);
            this.Controls.Add(this.AddNewReqbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LogoutStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_studentMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_studentMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form_studentMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutStudent;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button ChangeCourseTimebutton;
        private System.Windows.Forms.Button MandatoryCoursesbutton;
        private System.Windows.Forms.Button WatchCoursesbutton;
        private System.Windows.Forms.Button AssociationMenubutton;
        private System.Windows.Forms.Button WatchReqbutton;
        private System.Windows.Forms.Button AddNewReqbutton;
    }
}