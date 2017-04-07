namespace Project_Team3.Menus___forms.StudentSubMenus
{
    partial class Form_studentCoursesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_studentCoursesMenu));
            this.MandatoryCoursesListButton = new System.Windows.Forms.Button();
            this.WatchCoursesButton = new System.Windows.Forms.Button();
            this.ChangeCourseTimeButton = new System.Windows.Forms.Button();
            this.BackToLastCoursesMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MandatoryCoursesListButton
            // 
            this.MandatoryCoursesListButton.BackColor = System.Drawing.Color.MistyRose;
            this.MandatoryCoursesListButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MandatoryCoursesListButton.Location = new System.Drawing.Point(547, 97);
            this.MandatoryCoursesListButton.Name = "MandatoryCoursesListButton";
            this.MandatoryCoursesListButton.Size = new System.Drawing.Size(235, 46);
            this.MandatoryCoursesListButton.TabIndex = 6;
            this.MandatoryCoursesListButton.Text = "List of mandatory courses";
            this.MandatoryCoursesListButton.UseVisualStyleBackColor = false;
            this.MandatoryCoursesListButton.Click += new System.EventHandler(this.MandatoryCoursesListButton_Click);
            // 
            // WatchCoursesButton
            // 
            this.WatchCoursesButton.BackColor = System.Drawing.Color.MistyRose;
            this.WatchCoursesButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WatchCoursesButton.Location = new System.Drawing.Point(547, 163);
            this.WatchCoursesButton.Name = "WatchCoursesButton";
            this.WatchCoursesButton.Size = new System.Drawing.Size(235, 46);
            this.WatchCoursesButton.TabIndex = 7;
            this.WatchCoursesButton.Text = "Watch my courses";
            this.WatchCoursesButton.UseVisualStyleBackColor = false;
            this.WatchCoursesButton.Click += new System.EventHandler(this.WatchCoursesButton_Click);
            // 
            // ChangeCourseTimeButton
            // 
            this.ChangeCourseTimeButton.BackColor = System.Drawing.Color.MistyRose;
            this.ChangeCourseTimeButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChangeCourseTimeButton.Location = new System.Drawing.Point(547, 228);
            this.ChangeCourseTimeButton.Name = "ChangeCourseTimeButton";
            this.ChangeCourseTimeButton.Size = new System.Drawing.Size(235, 46);
            this.ChangeCourseTimeButton.TabIndex = 8;
            this.ChangeCourseTimeButton.Text = "Change course time";
            this.ChangeCourseTimeButton.UseVisualStyleBackColor = false;
            this.ChangeCourseTimeButton.Click += new System.EventHandler(this.ChangeCourseTimeButton_Click);
            // 
            // BackToLastCoursesMenu
            // 
            this.BackToLastCoursesMenu.BackColor = System.Drawing.Color.MistyRose;
            this.BackToLastCoursesMenu.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackToLastCoursesMenu.Location = new System.Drawing.Point(547, 352);
            this.BackToLastCoursesMenu.Name = "BackToLastCoursesMenu";
            this.BackToLastCoursesMenu.Size = new System.Drawing.Size(235, 46);
            this.BackToLastCoursesMenu.TabIndex = 9;
            this.BackToLastCoursesMenu.Text = "Back to last menu";
            this.BackToLastCoursesMenu.UseVisualStyleBackColor = false;
            this.BackToLastCoursesMenu.Click += new System.EventHandler(this.BackToLastCoursesMenu_Click);
            // 
            // Form_studentCoursesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.BackToLastCoursesMenu);
            this.Controls.Add(this.ChangeCourseTimeButton);
            this.Controls.Add(this.WatchCoursesButton);
            this.Controls.Add(this.MandatoryCoursesListButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_studentCoursesMenu";
            this.Text = "Student\'s Courses Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_studentCoursesMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form_studentCoursesMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MandatoryCoursesListButton;
        private System.Windows.Forms.Button WatchCoursesButton;
        private System.Windows.Forms.Button ChangeCourseTimeButton;
        private System.Windows.Forms.Button BackToLastCoursesMenu;
    }
}