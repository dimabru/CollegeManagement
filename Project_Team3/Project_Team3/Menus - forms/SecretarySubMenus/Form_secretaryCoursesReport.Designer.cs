namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    partial class Form_secretaryCoursesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_secretaryCoursesReport));
            this.GoBackButton = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.CoursesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.MistyRose;
            this.GoBackButton.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GoBackButton.Location = new System.Drawing.Point(572, 576);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(164, 66);
            this.GoBackButton.TabIndex = 1;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackClick);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Header_label.Location = new System.Drawing.Point(513, 41);
            this.Header_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(255, 33);
            this.Header_label.TabIndex = 2;
            this.Header_label.Text = "Courses Report:";
            // 
            // CoursesGridView
            // 
            this.CoursesGridView.AllowUserToAddRows = false;
            this.CoursesGridView.AllowUserToDeleteRows = false;
            this.CoursesGridView.AllowUserToResizeRows = false;
            this.CoursesGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CoursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CoursesGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.CoursesGridView.Location = new System.Drawing.Point(88, 97);
            this.CoursesGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoursesGridView.Name = "CoursesGridView";
            this.CoursesGridView.ReadOnly = true;
            this.CoursesGridView.Size = new System.Drawing.Size(1144, 442);
            this.CoursesGridView.TabIndex = 3;
            // 
            // Form_secretaryCoursesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 703);
            this.Controls.Add(this.CoursesGridView);
            this.Controls.Add(this.Header_label);
            this.Controls.Add(this.GoBackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_secretaryCoursesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryCoursesReport_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.DataGridView CoursesGridView;
    }
}