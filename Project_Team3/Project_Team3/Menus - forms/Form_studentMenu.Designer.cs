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
            this.AssociationMenuButton = new System.Windows.Forms.Button();
            this.StudentRequestButton = new System.Windows.Forms.Button();
            this.CoursesMenuButton = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutStudent
            // 
            this.LogoutStudent.Location = new System.Drawing.Point(37, 372);
            this.LogoutStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutStudent.Name = "LogoutStudent";
            this.LogoutStudent.Size = new System.Drawing.Size(211, 42);
            this.LogoutStudent.TabIndex = 0;
            this.LogoutStudent.Text = "Logout";
            this.LogoutStudent.UseVisualStyleBackColor = true;
            this.LogoutStudent.Click += new System.EventHandler(this.LogoutStudent_Click);
            // 
            // AssociationMenuButton
            // 
            this.AssociationMenuButton.Location = new System.Drawing.Point(37, 102);
            this.AssociationMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssociationMenuButton.Name = "AssociationMenuButton";
            this.AssociationMenuButton.Size = new System.Drawing.Size(211, 42);
            this.AssociationMenuButton.TabIndex = 2;
            this.AssociationMenuButton.Text = "Association menu";
            this.AssociationMenuButton.UseVisualStyleBackColor = true;
            this.AssociationMenuButton.Click += new System.EventHandler(this.AssociationMenuButton_Click);
            // 
            // StudentRequestButton
            // 
            this.StudentRequestButton.Location = new System.Drawing.Point(37, 164);
            this.StudentRequestButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentRequestButton.Name = "StudentRequestButton";
            this.StudentRequestButton.Size = new System.Drawing.Size(211, 42);
            this.StudentRequestButton.TabIndex = 3;
            this.StudentRequestButton.Text = "Student request";
            this.StudentRequestButton.UseVisualStyleBackColor = true;
            this.StudentRequestButton.Click += new System.EventHandler(this.StudentRequestButton_Click);
            // 
            // CoursesMenuButton
            // 
            this.CoursesMenuButton.Location = new System.Drawing.Point(37, 225);
            this.CoursesMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CoursesMenuButton.Name = "CoursesMenuButton";
            this.CoursesMenuButton.Size = new System.Drawing.Size(211, 42);
            this.CoursesMenuButton.TabIndex = 4;
            this.CoursesMenuButton.Text = "Courses menu";
            this.CoursesMenuButton.UseVisualStyleBackColor = true;
            this.CoursesMenuButton.Click += new System.EventHandler(this.CoursesMenuButton_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(37, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(883, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Future global message";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(968, 479);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form_studentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CoursesMenuButton);
            this.Controls.Add(this.StudentRequestButton);
            this.Controls.Add(this.AssociationMenuButton);
            this.Controls.Add(this.LogoutStudent);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_studentMenu";
            this.Text = "Student Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_studentMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form_studentMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutStudent;
        private System.Windows.Forms.Button AssociationMenuButton;
        private System.Windows.Forms.Button StudentRequestButton;
        private System.Windows.Forms.Button CoursesMenuButton;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}