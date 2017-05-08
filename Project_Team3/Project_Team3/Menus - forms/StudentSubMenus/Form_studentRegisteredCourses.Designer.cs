namespace Project_Team3.Menus___forms.StudentSubMenus
{
    partial class Form_studentRegisteredCourses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CoursesGridView = new System.Windows.Forms.DataGridView();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursesGridView
            // 
            this.CoursesGridView.AllowUserToAddRows = false;
            this.CoursesGridView.AllowUserToDeleteRows = false;
            this.CoursesGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CoursesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CoursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesGridView.Location = new System.Drawing.Point(111, 105);
            this.CoursesGridView.Name = "CoursesGridView";
            this.CoursesGridView.ReadOnly = true;
            this.CoursesGridView.Size = new System.Drawing.Size(772, 346);
            this.CoursesGridView.TabIndex = 0;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GoBackButton.Location = new System.Drawing.Point(415, 475);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(157, 56);
            this.GoBackButton.TabIndex = 1;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Header_label.Location = new System.Drawing.Point(365, 52);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(246, 27);
            this.Header_label.TabIndex = 2;
            this.Header_label.Text = "Registered Courses:";
            // 
            // Form_studentRegisteredCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 570);
            this.Controls.Add(this.Header_label);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.CoursesGridView);
            this.Name = "Form_studentRegisteredCourses";
            this.Text = "Registered Courses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_studentRegisteredCourses_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CoursesGridView;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label Header_label;
    }
}