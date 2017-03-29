namespace Project_Team3.Menus___forms
{
    partial class Form_secretaryCourseSearch
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
            this.searchProgressBar = new System.Windows.Forms.ProgressBar();
            this.courseIDRadio = new System.Windows.Forms.RadioButton();
            this.courseNameRadio = new System.Windows.Forms.RadioButton();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.courseValueTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchProgressBar
            // 
            this.searchProgressBar.Location = new System.Drawing.Point(52, 185);
            this.searchProgressBar.Name = "searchProgressBar";
            this.searchProgressBar.Size = new System.Drawing.Size(180, 23);
            this.searchProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.searchProgressBar.TabIndex = 0;
            this.searchProgressBar.Value = 50;
            // 
            // courseIDRadio
            // 
            this.courseIDRadio.AutoSize = true;
            this.courseIDRadio.Location = new System.Drawing.Point(52, 52);
            this.courseIDRadio.Name = "courseIDRadio";
            this.courseIDRadio.Size = new System.Drawing.Size(72, 17);
            this.courseIDRadio.TabIndex = 1;
            this.courseIDRadio.TabStop = true;
            this.courseIDRadio.Text = "Course ID";
            this.courseIDRadio.UseVisualStyleBackColor = true;
            // 
            // courseNameRadio
            // 
            this.courseNameRadio.AutoSize = true;
            this.courseNameRadio.Location = new System.Drawing.Point(143, 52);
            this.courseNameRadio.Name = "courseNameRadio";
            this.courseNameRadio.Size = new System.Drawing.Size(89, 17);
            this.courseNameRadio.TabIndex = 2;
            this.courseNameRadio.TabStop = true;
            this.courseNameRadio.Text = "Course Name";
            this.courseNameRadio.UseVisualStyleBackColor = true;
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Location = new System.Drawing.Point(108, 13);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(58, 13);
            this.searchByLabel.TabIndex = 3;
            this.searchByLabel.Text = "Search by:";
            // 
            // courseValueTextBox
            // 
            this.courseValueTextBox.Location = new System.Drawing.Point(52, 96);
            this.courseValueTextBox.Name = "courseValueTextBox";
            this.courseValueTextBox.Size = new System.Drawing.Size(180, 20);
            this.courseValueTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(52, 131);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(180, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // Form_secretaryCourseSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.courseValueTextBox);
            this.Controls.Add(this.searchByLabel);
            this.Controls.Add(this.courseNameRadio);
            this.Controls.Add(this.courseIDRadio);
            this.Controls.Add(this.searchProgressBar);
            this.Name = "Form_secretaryCourseSearch";
            this.Text = "Course Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar searchProgressBar;
        private System.Windows.Forms.RadioButton courseIDRadio;
        private System.Windows.Forms.RadioButton courseNameRadio;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.TextBox courseValueTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}