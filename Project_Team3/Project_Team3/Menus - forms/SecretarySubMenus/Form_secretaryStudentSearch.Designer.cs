namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    partial class Form_secretaryStudentSearch
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
            this.idRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchValueTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // idRadioButton
            // 
            this.idRadioButton.AutoSize = true;
            this.idRadioButton.Location = new System.Drawing.Point(114, 41);
            this.idRadioButton.Name = "idRadioButton";
            this.idRadioButton.Size = new System.Drawing.Size(36, 17);
            this.idRadioButton.TabIndex = 0;
            this.idRadioButton.TabStop = true;
            this.idRadioButton.Text = "ID";
            this.idRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(200, 41);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.nameRadioButton.TabIndex = 1;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Location = new System.Drawing.Point(148, 14);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(59, 13);
            this.searchByLabel.TabIndex = 2;
            this.searchByLabel.Text = "Search By:";
            // 
            // searchValueTextBox
            // 
            this.searchValueTextBox.Location = new System.Drawing.Point(128, 77);
            this.searchValueTextBox.Name = "searchValueTextBox";
            this.searchValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchValueTextBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(128, 122);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 22);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchProgressBar
            // 
            this.searchProgressBar.Location = new System.Drawing.Point(93, 173);
            this.searchProgressBar.Name = "searchProgressBar";
            this.searchProgressBar.Size = new System.Drawing.Size(173, 23);
            this.searchProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.searchProgressBar.TabIndex = 5;
            this.searchProgressBar.Value = 50;
            // 
            // Form_secretaryStudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.searchProgressBar);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchValueTextBox);
            this.Controls.Add(this.searchByLabel);
            this.Controls.Add(this.nameRadioButton);
            this.Controls.Add(this.idRadioButton);
            this.Name = "Form_secretaryStudentSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryStudentSearch_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton idRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.TextBox searchValueTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ProgressBar searchProgressBar;
    }
}