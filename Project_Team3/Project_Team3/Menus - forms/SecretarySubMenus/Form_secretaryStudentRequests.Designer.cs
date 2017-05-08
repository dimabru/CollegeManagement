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
            this.studentRequestsLabel = new System.Windows.Forms.Label();
            this.StudentReqGrid = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentReqGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptRequestButton
            // 
            this.acceptRequestButton.BackColor = System.Drawing.Color.MistyRose;
            this.acceptRequestButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.acceptRequestButton.Location = new System.Drawing.Point(709, 257);
            this.acceptRequestButton.Name = "acceptRequestButton";
            this.acceptRequestButton.Size = new System.Drawing.Size(176, 37);
            this.acceptRequestButton.TabIndex = 1;
            this.acceptRequestButton.Text = "Accept";
            this.acceptRequestButton.UseVisualStyleBackColor = false;
            this.acceptRequestButton.Click += new System.EventHandler(this.acceptRequestButton_Click);
            // 
            // denyRequestButton
            // 
            this.denyRequestButton.BackColor = System.Drawing.Color.MistyRose;
            this.denyRequestButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.denyRequestButton.Location = new System.Drawing.Point(709, 367);
            this.denyRequestButton.Name = "denyRequestButton";
            this.denyRequestButton.Size = new System.Drawing.Size(176, 37);
            this.denyRequestButton.TabIndex = 2;
            this.denyRequestButton.Text = "Deny";
            this.denyRequestButton.UseVisualStyleBackColor = false;
            this.denyRequestButton.Click += new System.EventHandler(this.denyRequestButton_Click);
            // 
            // studentRequestsLabel
            // 
            this.studentRequestsLabel.AutoSize = true;
            this.studentRequestsLabel.Font = new System.Drawing.Font("David", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.studentRequestsLabel.Location = new System.Drawing.Point(298, 115);
            this.studentRequestsLabel.Name = "studentRequestsLabel";
            this.studentRequestsLabel.Size = new System.Drawing.Size(181, 21);
            this.studentRequestsLabel.TabIndex = 4;
            this.studentRequestsLabel.Text = "Student Requests:";
            // 
            // StudentReqGrid
            // 
            this.StudentReqGrid.AllowUserToAddRows = false;
            this.StudentReqGrid.AllowUserToDeleteRows = false;
            this.StudentReqGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StudentReqGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentReqGrid.Location = new System.Drawing.Point(60, 180);
            this.StudentReqGrid.MultiSelect = false;
            this.StudentReqGrid.Name = "StudentReqGrid";
            this.StudentReqGrid.ReadOnly = true;
            this.StudentReqGrid.Size = new System.Drawing.Size(609, 302);
            this.StudentReqGrid.TabIndex = 5;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.MistyRose;
            this.BackButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold);
            this.BackButton.Location = new System.Drawing.Point(418, 520);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(176, 37);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form_secretaryStudentRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 609);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StudentReqGrid);
            this.Controls.Add(this.studentRequestsLabel);
            this.Controls.Add(this.denyRequestButton);
            this.Controls.Add(this.acceptRequestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_secretaryStudentRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Requests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryStudentRequests_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.StudentReqGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button acceptRequestButton;
        private System.Windows.Forms.Button denyRequestButton;
        private System.Windows.Forms.Label studentRequestsLabel;
        private System.Windows.Forms.DataGridView StudentReqGrid;
        private System.Windows.Forms.Button BackButton;
    }
}