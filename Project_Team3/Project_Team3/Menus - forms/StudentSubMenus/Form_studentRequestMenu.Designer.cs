namespace Project_Team3.Menus___forms.StudentSubMenus
{
    partial class Form_studentRequestMenu
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
            this.NewRequestButton = new System.Windows.Forms.Button();
            this.ExistingRequestsButton = new System.Windows.Forms.Button();
            this.BackToLastReqMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewRequestButton
            // 
            this.NewRequestButton.Location = new System.Drawing.Point(51, 33);
            this.NewRequestButton.Name = "NewRequestButton";
            this.NewRequestButton.Size = new System.Drawing.Size(210, 42);
            this.NewRequestButton.TabIndex = 4;
            this.NewRequestButton.Text = "New request";
            this.NewRequestButton.UseVisualStyleBackColor = true;
            this.NewRequestButton.Click += new System.EventHandler(this.NewRequestButton_Click);
            // 
            // ExistingRequestsButton
            // 
            this.ExistingRequestsButton.Location = new System.Drawing.Point(51, 100);
            this.ExistingRequestsButton.Name = "ExistingRequestsButton";
            this.ExistingRequestsButton.Size = new System.Drawing.Size(210, 42);
            this.ExistingRequestsButton.TabIndex = 5;
            this.ExistingRequestsButton.Text = "Existing requests";
            this.ExistingRequestsButton.UseVisualStyleBackColor = true;
            this.ExistingRequestsButton.Click += new System.EventHandler(this.ExistingRequestsButton_Click);
            // 
            // BackToLastReqMenu
            // 
            this.BackToLastReqMenu.Location = new System.Drawing.Point(51, 173);
            this.BackToLastReqMenu.Name = "BackToLastReqMenu";
            this.BackToLastReqMenu.Size = new System.Drawing.Size(210, 42);
            this.BackToLastReqMenu.TabIndex = 6;
            this.BackToLastReqMenu.Text = "Back to last menu";
            this.BackToLastReqMenu.UseVisualStyleBackColor = true;
            this.BackToLastReqMenu.Click += new System.EventHandler(this.BackToLastReqMenu_Click);
            // 
            // Form_studentRequestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 253);
            this.Controls.Add(this.BackToLastReqMenu);
            this.Controls.Add(this.ExistingRequestsButton);
            this.Controls.Add(this.NewRequestButton);
            this.Name = "Form_studentRequestMenu";
            this.Text = "Student Request Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_studentRequestMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewRequestButton;
        private System.Windows.Forms.Button ExistingRequestsButton;
        private System.Windows.Forms.Button BackToLastReqMenu;
    }
}