namespace Project_Team3.Menus___forms.AdminSubMenus
{
    partial class adminRemoveStudent
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.instructonLabel = new System.Windows.Forms.Label();
            this.removeStudent = new System.Windows.Forms.Button();
            this.studentList = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 0;
            // 
            // instructonLabel
            // 
            this.instructonLabel.AutoSize = true;
            this.instructonLabel.Location = new System.Drawing.Point(114, 66);
            this.instructonLabel.Name = "instructonLabel";
            this.instructonLabel.Size = new System.Drawing.Size(301, 17);
            this.instructonLabel.TabIndex = 1;
            this.instructonLabel.Text = "Enter the ID of the student you want to remove";
            // 
            // removeStudent
            // 
            this.removeStudent.Location = new System.Drawing.Point(197, 158);
            this.removeStudent.Name = "removeStudent";
            this.removeStudent.Size = new System.Drawing.Size(129, 40);
            this.removeStudent.TabIndex = 2;
            this.removeStudent.Text = "Remove Student";
            this.removeStudent.UseVisualStyleBackColor = true;
            this.removeStudent.Click += new System.EventHandler(this.removeStudent_Click);
            // 
            // studentList
            // 
            this.studentList.Location = new System.Drawing.Point(197, 204);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(129, 41);
            this.studentList.TabIndex = 3;
            this.studentList.Text = "Student List";
            this.studentList.UseVisualStyleBackColor = true;
            this.studentList.Click += new System.EventHandler(this.studentList_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(197, 251);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 36);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back to last menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // adminRemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 515);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.removeStudent);
            this.Controls.Add(this.instructonLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "adminRemoveStudent";
            this.Text = "adminRemoveStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminRemoveStudent_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label instructonLabel;
        private System.Windows.Forms.Button removeStudent;
        private System.Windows.Forms.Button studentList;
        private System.Windows.Forms.Button backButton;
    }
}