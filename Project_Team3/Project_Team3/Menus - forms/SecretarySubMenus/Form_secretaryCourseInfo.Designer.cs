namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    partial class Form_secretaryCourseInfo
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTeacherID = new System.Windows.Forms.Label();
            this.labelMaxStudents = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelStart_H = new System.Windows.Forms.Label();
            this.labelEnd_H = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelTrack = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelMiddle = new System.Windows.Forms.Label();
            this.CoursesGrid = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(49, 75);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "label1";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(124, 75);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label2";
            // 
            // labelTeacherID
            // 
            this.labelTeacherID.AutoSize = true;
            this.labelTeacherID.Location = new System.Drawing.Point(209, 75);
            this.labelTeacherID.Name = "labelTeacherID";
            this.labelTeacherID.Size = new System.Drawing.Size(35, 13);
            this.labelTeacherID.TabIndex = 2;
            this.labelTeacherID.Text = "label3";
            // 
            // labelMaxStudents
            // 
            this.labelMaxStudents.AutoSize = true;
            this.labelMaxStudents.Location = new System.Drawing.Point(298, 75);
            this.labelMaxStudents.Name = "labelMaxStudents";
            this.labelMaxStudents.Size = new System.Drawing.Size(35, 13);
            this.labelMaxStudents.TabIndex = 3;
            this.labelMaxStudents.Text = "label4";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(388, 75);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(35, 13);
            this.labelRoom.TabIndex = 4;
            this.labelRoom.Text = "label5";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(482, 75);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(35, 13);
            this.labelDay.TabIndex = 5;
            this.labelDay.Text = "label6";
            // 
            // labelStart_H
            // 
            this.labelStart_H.AutoSize = true;
            this.labelStart_H.Location = new System.Drawing.Point(571, 75);
            this.labelStart_H.Name = "labelStart_H";
            this.labelStart_H.Size = new System.Drawing.Size(35, 13);
            this.labelStart_H.TabIndex = 6;
            this.labelStart_H.Text = "label7";
            // 
            // labelEnd_H
            // 
            this.labelEnd_H.AutoSize = true;
            this.labelEnd_H.Location = new System.Drawing.Point(655, 75);
            this.labelEnd_H.Name = "labelEnd_H";
            this.labelEnd_H.Size = new System.Drawing.Size(35, 13);
            this.labelEnd_H.TabIndex = 7;
            this.labelEnd_H.Text = "label8";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(748, 75);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(35, 13);
            this.labelSemester.TabIndex = 8;
            this.labelSemester.Text = "label9";
            // 
            // labelTrack
            // 
            this.labelTrack.AutoSize = true;
            this.labelTrack.Location = new System.Drawing.Point(848, 75);
            this.labelTrack.Name = "labelTrack";
            this.labelTrack.Size = new System.Drawing.Size(35, 13);
            this.labelTrack.TabIndex = 9;
            this.labelTrack.Text = "label1";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeader.Location = new System.Drawing.Point(319, 25);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(355, 27);
            this.labelHeader.TabIndex = 10;
            this.labelHeader.Text = "Selected Course Information:";
            // 
            // labelMiddle
            // 
            this.labelMiddle.AutoSize = true;
            this.labelMiddle.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMiddle.Location = new System.Drawing.Point(319, 234);
            this.labelMiddle.Name = "labelMiddle";
            this.labelMiddle.Size = new System.Drawing.Size(348, 27);
            this.labelMiddle.TabIndex = 11;
            this.labelMiddle.Text = "Other options for the course:";
            // 
            // CoursesGrid
            // 
            this.CoursesGrid.AllowUserToAddRows = false;
            this.CoursesGrid.AllowUserToDeleteRows = false;
            this.CoursesGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CoursesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesGrid.Location = new System.Drawing.Point(52, 314);
            this.CoursesGrid.Name = "CoursesGrid";
            this.CoursesGrid.ReadOnly = true;
            this.CoursesGrid.Size = new System.Drawing.Size(868, 171);
            this.CoursesGrid.TabIndex = 12;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackButton.Location = new System.Drawing.Point(429, 504);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(132, 42);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form_secretaryCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 570);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CoursesGrid);
            this.Controls.Add(this.labelMiddle);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.labelTrack);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelEnd_H);
            this.Controls.Add(this.labelStart_H);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelMaxStudents);
            this.Controls.Add(this.labelTeacherID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Name = "Form_secretaryCourseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryCourseInfo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTeacherID;
        private System.Windows.Forms.Label labelMaxStudents;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelStart_H;
        private System.Windows.Forms.Label labelEnd_H;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelTrack;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelMiddle;
        private System.Windows.Forms.DataGridView CoursesGrid;
        private System.Windows.Forms.Button BackButton;
    }
}