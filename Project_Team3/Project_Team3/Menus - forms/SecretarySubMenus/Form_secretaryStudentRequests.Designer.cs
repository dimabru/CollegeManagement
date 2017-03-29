namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    partial class Form_secretaryStudentRequests
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
            this.acceptRequestButton = new System.Windows.Forms.Button();
            this.denyRequestButton = new System.Windows.Forms.Button();
            this.detailsRequestButton = new System.Windows.Forms.Button();
            this.studentRequestsLabel = new System.Windows.Forms.Label();
            this.requestsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // acceptRequestButton
            // 
            this.acceptRequestButton.Location = new System.Drawing.Point(234, 73);
            this.acceptRequestButton.Name = "acceptRequestButton";
            this.acceptRequestButton.Size = new System.Drawing.Size(138, 23);
            this.acceptRequestButton.TabIndex = 1;
            this.acceptRequestButton.Text = "Accept";
            this.acceptRequestButton.UseVisualStyleBackColor = true;
            // 
            // denyRequestButton
            // 
            this.denyRequestButton.Location = new System.Drawing.Point(234, 137);
            this.denyRequestButton.Name = "denyRequestButton";
            this.denyRequestButton.Size = new System.Drawing.Size(138, 23);
            this.denyRequestButton.TabIndex = 2;
            this.denyRequestButton.Text = "Deny";
            this.denyRequestButton.UseVisualStyleBackColor = true;
            // 
            // detailsRequestButton
            // 
            this.detailsRequestButton.Location = new System.Drawing.Point(234, 197);
            this.detailsRequestButton.Name = "detailsRequestButton";
            this.detailsRequestButton.Size = new System.Drawing.Size(138, 23);
            this.detailsRequestButton.TabIndex = 3;
            this.detailsRequestButton.Text = "Details";
            this.detailsRequestButton.UseVisualStyleBackColor = true;
            // 
            // studentRequestsLabel
            // 
            this.studentRequestsLabel.AutoSize = true;
            this.studentRequestsLabel.Location = new System.Drawing.Point(12, 33);
            this.studentRequestsLabel.Name = "studentRequestsLabel";
            this.studentRequestsLabel.Size = new System.Drawing.Size(95, 13);
            this.studentRequestsLabel.TabIndex = 4;
            this.studentRequestsLabel.Text = "Student Requests:";
            // 
            // requestsListBox
            // 
            this.requestsListBox.FormattingEnabled = true;
            this.requestsListBox.Items.AddRange(new object[] {
            "Jonathan:Hedva 2 hours",
            "Isabelle:\tLinear Algebra cancel",
            "Alexei:\tAlgorithms switch",
            "Liran:\tDatabases change"});
            this.requestsListBox.Location = new System.Drawing.Point(15, 73);
            this.requestsListBox.Name = "requestsListBox";
            this.requestsListBox.Size = new System.Drawing.Size(213, 147);
            this.requestsListBox.TabIndex = 5;
            // 
            // Form_secretaryStudentRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.requestsListBox);
            this.Controls.Add(this.studentRequestsLabel);
            this.Controls.Add(this.detailsRequestButton);
            this.Controls.Add(this.denyRequestButton);
            this.Controls.Add(this.acceptRequestButton);
            this.Name = "Form_secretaryStudentRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Requests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button acceptRequestButton;
        private System.Windows.Forms.Button denyRequestButton;
        private System.Windows.Forms.Button detailsRequestButton;
        private System.Windows.Forms.Label studentRequestsLabel;
        private System.Windows.Forms.ListBox requestsListBox;
    }
}