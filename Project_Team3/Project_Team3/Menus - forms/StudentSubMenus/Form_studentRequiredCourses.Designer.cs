namespace Project_Team3.Menus___forms.StudentSubMenus
{
    partial class Form_studentRequiredCourses
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
            this.NeededCoursesGridView = new System.Windows.Forms.DataGridView();
            this.Header_label = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NeededCoursesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NeededCoursesGridView
            // 
            this.NeededCoursesGridView.AllowUserToAddRows = false;
            this.NeededCoursesGridView.AllowUserToDeleteRows = false;
            this.NeededCoursesGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NeededCoursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NeededCoursesGridView.Location = new System.Drawing.Point(126, 115);
            this.NeededCoursesGridView.Name = "NeededCoursesGridView";
            this.NeededCoursesGridView.ReadOnly = true;
            this.NeededCoursesGridView.Size = new System.Drawing.Size(765, 340);
            this.NeededCoursesGridView.TabIndex = 0;
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Header_label.Location = new System.Drawing.Point(359, 55);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(254, 27);
            this.Header_label.TabIndex = 1;
            this.Header_label.Text = "Mandatory Courses:";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GoBackButton.Location = new System.Drawing.Point(423, 490);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(135, 42);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButtonClick);
            // 
            // Form_studentRequiredCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 570);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.Header_label);
            this.Controls.Add(this.NeededCoursesGridView);
            this.Name = "Form_studentRequiredCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Required Courses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_studentRequiredCourses_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.NeededCoursesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NeededCoursesGridView;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.Button GoBackButton;
    }
}