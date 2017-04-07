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
            this.LogoutStudent.BackColor = System.Drawing.Color.MistyRose;
            this.LogoutStudent.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LogoutStudent.Location = new System.Drawing.Point(51, 439);
            this.LogoutStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutStudent.Name = "LogoutStudent";
            this.LogoutStudent.Size = new System.Drawing.Size(235, 46);
            this.LogoutStudent.TabIndex = 0;
            this.LogoutStudent.Text = "Logout";
            this.LogoutStudent.UseVisualStyleBackColor = false;
            this.LogoutStudent.Click += new System.EventHandler(this.LogoutStudent_Click);
            // 
            // AssociationMenuButton
            // 
            this.AssociationMenuButton.BackColor = System.Drawing.Color.MistyRose;
            this.AssociationMenuButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AssociationMenuButton.Location = new System.Drawing.Point(51, 169);
            this.AssociationMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssociationMenuButton.Name = "AssociationMenuButton";
            this.AssociationMenuButton.Size = new System.Drawing.Size(235, 46);
            this.AssociationMenuButton.TabIndex = 2;
            this.AssociationMenuButton.Text = "Association menu";
            this.AssociationMenuButton.UseVisualStyleBackColor = false;
            this.AssociationMenuButton.Click += new System.EventHandler(this.AssociationMenuButton_Click);
            // 
            // StudentRequestButton
            // 
            this.StudentRequestButton.BackColor = System.Drawing.Color.MistyRose;
            this.StudentRequestButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StudentRequestButton.Location = new System.Drawing.Point(51, 231);
            this.StudentRequestButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentRequestButton.Name = "StudentRequestButton";
            this.StudentRequestButton.Size = new System.Drawing.Size(235, 46);
            this.StudentRequestButton.TabIndex = 3;
            this.StudentRequestButton.Text = "Student request";
            this.StudentRequestButton.UseVisualStyleBackColor = false;
            this.StudentRequestButton.Click += new System.EventHandler(this.StudentRequestButton_Click);
            // 
            // CoursesMenuButton
            // 
            this.CoursesMenuButton.BackColor = System.Drawing.Color.MistyRose;
            this.CoursesMenuButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CoursesMenuButton.Location = new System.Drawing.Point(51, 292);
            this.CoursesMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CoursesMenuButton.Name = "CoursesMenuButton";
            this.CoursesMenuButton.Size = new System.Drawing.Size(235, 46);
            this.CoursesMenuButton.TabIndex = 4;
            this.CoursesMenuButton.Text = "Courses menu";
            this.CoursesMenuButton.UseVisualStyleBackColor = false;
            this.CoursesMenuButton.Click += new System.EventHandler(this.CoursesMenuButton_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(47, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(883, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Future global message";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 105);
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CoursesMenuButton);
            this.Controls.Add(this.StudentRequestButton);
            this.Controls.Add(this.AssociationMenuButton);
            this.Controls.Add(this.LogoutStudent);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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