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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_studentRequiredCourses));
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
            this.NeededCoursesGridView.Location = new System.Drawing.Point(168, 142);
            this.NeededCoursesGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NeededCoursesGridView.Name = "NeededCoursesGridView";
            this.NeededCoursesGridView.ReadOnly = true;
            this.NeededCoursesGridView.Size = new System.Drawing.Size(1020, 418);
            this.NeededCoursesGridView.TabIndex = 0;
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Header_label.Location = new System.Drawing.Point(479, 68);
            this.Header_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(317, 33);
            this.Header_label.TabIndex = 1;
            this.Header_label.Text = "Mandatory Courses:";
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.MistyRose;
            this.GoBackButton.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GoBackButton.Location = new System.Drawing.Point(564, 603);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(180, 52);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButtonClick);
            // 
            // Form_studentRequiredCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 703);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.Header_label);
            this.Controls.Add(this.NeededCoursesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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