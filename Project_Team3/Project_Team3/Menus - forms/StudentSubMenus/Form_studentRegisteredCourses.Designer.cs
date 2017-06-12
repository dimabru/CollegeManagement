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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_studentRegisteredCourses));
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
            this.CoursesGridView.Location = new System.Drawing.Point(148, 129);
            this.CoursesGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoursesGridView.Name = "CoursesGridView";
            this.CoursesGridView.ReadOnly = true;
            this.CoursesGridView.Size = new System.Drawing.Size(1029, 426);
            this.CoursesGridView.TabIndex = 0;
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.MistyRose;
            this.GoBackButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GoBackButton.Location = new System.Drawing.Point(553, 585);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(209, 69);
            this.GoBackButton.TabIndex = 1;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("David", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Header_label.Location = new System.Drawing.Point(487, 64);
            this.Header_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(307, 33);
            this.Header_label.TabIndex = 2;
            this.Header_label.Text = "Registered Courses:";
            // 
            // Form_studentRegisteredCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 703);
            this.Controls.Add(this.Header_label);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.CoursesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_studentRegisteredCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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