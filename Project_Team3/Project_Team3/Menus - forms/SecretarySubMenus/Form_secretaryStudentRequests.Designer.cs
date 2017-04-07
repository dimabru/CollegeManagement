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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_secretaryStudentRequests));
            this.acceptRequestButton = new System.Windows.Forms.Button();
            this.denyRequestButton = new System.Windows.Forms.Button();
            this.detailsRequestButton = new System.Windows.Forms.Button();
            this.studentRequestsLabel = new System.Windows.Forms.Label();
            this.requestsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // acceptRequestButton
            // 
            this.acceptRequestButton.BackColor = System.Drawing.Color.MistyRose;
            this.acceptRequestButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.acceptRequestButton.Location = new System.Drawing.Point(693, 191);
            this.acceptRequestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptRequestButton.Name = "acceptRequestButton";
            this.acceptRequestButton.Size = new System.Drawing.Size(235, 46);
            this.acceptRequestButton.TabIndex = 1;
            this.acceptRequestButton.Text = "Accept";
            this.acceptRequestButton.UseVisualStyleBackColor = false;
            this.acceptRequestButton.Click += new System.EventHandler(this.acceptRequestButton_Click);
            // 
            // denyRequestButton
            // 
            this.denyRequestButton.BackColor = System.Drawing.Color.MistyRose;
            this.denyRequestButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.denyRequestButton.Location = new System.Drawing.Point(693, 270);
            this.denyRequestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.denyRequestButton.Name = "denyRequestButton";
            this.denyRequestButton.Size = new System.Drawing.Size(235, 46);
            this.denyRequestButton.TabIndex = 2;
            this.denyRequestButton.Text = "Deny";
            this.denyRequestButton.UseVisualStyleBackColor = false;
            this.denyRequestButton.Click += new System.EventHandler(this.denyRequestButton_Click);
            // 
            // detailsRequestButton
            // 
            this.detailsRequestButton.BackColor = System.Drawing.Color.MistyRose;
            this.detailsRequestButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.detailsRequestButton.Location = new System.Drawing.Point(693, 343);
            this.detailsRequestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailsRequestButton.Name = "detailsRequestButton";
            this.detailsRequestButton.Size = new System.Drawing.Size(235, 46);
            this.detailsRequestButton.TabIndex = 3;
            this.detailsRequestButton.Text = "Details";
            this.detailsRequestButton.UseVisualStyleBackColor = false;
            this.detailsRequestButton.Click += new System.EventHandler(this.detailsRequestButton_Click);
            // 
            // studentRequestsLabel
            // 
            this.studentRequestsLabel.AutoSize = true;
            this.studentRequestsLabel.Font = new System.Drawing.Font("David", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.studentRequestsLabel.Location = new System.Drawing.Point(397, 142);
            this.studentRequestsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentRequestsLabel.Name = "studentRequestsLabel";
            this.studentRequestsLabel.Size = new System.Drawing.Size(230, 28);
            this.studentRequestsLabel.TabIndex = 4;
            this.studentRequestsLabel.Text = "Student Requests:";
            // 
            // requestsListBox
            // 
            this.requestsListBox.Font = new System.Drawing.Font("David", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.requestsListBox.FormattingEnabled = true;
            this.requestsListBox.ItemHeight = 17;
            this.requestsListBox.Items.AddRange(new object[] {
            "Jonathan:Hedva 2 hours",
            "Isabelle:\tLinear Algebra cancel",
            "Alexei:\tAlgorithms switch",
            "Liran:\tDatabases change"});
            this.requestsListBox.Location = new System.Drawing.Point(376, 202);
            this.requestsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.requestsListBox.Name = "requestsListBox";
            this.requestsListBox.Size = new System.Drawing.Size(283, 174);
            this.requestsListBox.TabIndex = 5;
            // 
            // Form_secretaryStudentRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.requestsListBox);
            this.Controls.Add(this.studentRequestsLabel);
            this.Controls.Add(this.detailsRequestButton);
            this.Controls.Add(this.denyRequestButton);
            this.Controls.Add(this.acceptRequestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_secretaryStudentRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Requests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryStudentRequests_FormClosed);
            this.Load += new System.EventHandler(this.Form_secretaryStudentRequests_Load);
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