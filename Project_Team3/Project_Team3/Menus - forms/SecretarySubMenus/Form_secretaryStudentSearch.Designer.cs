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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_secretaryStudentSearch));
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
            this.idRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.idRadioButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.idRadioButton.Location = new System.Drawing.Point(558, 181);
            this.idRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idRadioButton.Name = "idRadioButton";
            this.idRadioButton.Size = new System.Drawing.Size(57, 28);
            this.idRadioButton.TabIndex = 0;
            this.idRadioButton.TabStop = true;
            this.idRadioButton.Text = "ID";
            this.idRadioButton.UseVisualStyleBackColor = false;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.nameRadioButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameRadioButton.Location = new System.Drawing.Point(673, 181);
            this.nameRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(91, 28);
            this.nameRadioButton.TabIndex = 1;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = false;
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchByLabel.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchByLabel.Location = new System.Drawing.Point(587, 142);
            this.searchByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(123, 24);
            this.searchByLabel.TabIndex = 2;
            this.searchByLabel.Text = "Search By:";
            // 
            // searchValueTextBox
            // 
            this.searchValueTextBox.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchValueTextBox.Location = new System.Drawing.Point(577, 226);
            this.searchValueTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchValueTextBox.Name = "searchValueTextBox";
            this.searchValueTextBox.Size = new System.Drawing.Size(132, 30);
            this.searchValueTextBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.MistyRose;
            this.searchButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchButton.Location = new System.Drawing.Point(577, 281);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 30);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchProgressBar
            // 
            this.searchProgressBar.Location = new System.Drawing.Point(530, 344);
            this.searchProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchProgressBar.Name = "searchProgressBar";
            this.searchProgressBar.Size = new System.Drawing.Size(231, 28);
            this.searchProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.searchProgressBar.TabIndex = 5;
            this.searchProgressBar.Value = 50;
            // 
            // Form_secretaryStudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.searchProgressBar);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchValueTextBox);
            this.Controls.Add(this.searchByLabel);
            this.Controls.Add(this.nameRadioButton);
            this.Controls.Add(this.idRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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