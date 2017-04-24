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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_studentRequestMenu));
            this.NewRequestButton = new System.Windows.Forms.Button();
            this.ExistingRequestsButton = new System.Windows.Forms.Button();
            this.BackToLastReqMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewRequestButton
            // 
            this.NewRequestButton.BackColor = System.Drawing.Color.MistyRose;
            this.NewRequestButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NewRequestButton.Location = new System.Drawing.Point(411, 79);
            this.NewRequestButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewRequestButton.Name = "NewRequestButton";
            this.NewRequestButton.Size = new System.Drawing.Size(176, 37);
            this.NewRequestButton.TabIndex = 4;
            this.NewRequestButton.Text = "New request";
            this.NewRequestButton.UseVisualStyleBackColor = false;
            this.NewRequestButton.Click += new System.EventHandler(this.NewRequestButton_Click);
            // 
            // ExistingRequestsButton
            // 
            this.ExistingRequestsButton.BackColor = System.Drawing.Color.MistyRose;
            this.ExistingRequestsButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExistingRequestsButton.Location = new System.Drawing.Point(411, 133);
            this.ExistingRequestsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExistingRequestsButton.Name = "ExistingRequestsButton";
            this.ExistingRequestsButton.Size = new System.Drawing.Size(176, 37);
            this.ExistingRequestsButton.TabIndex = 5;
            this.ExistingRequestsButton.Text = "Existing requests";
            this.ExistingRequestsButton.UseVisualStyleBackColor = false;
            this.ExistingRequestsButton.Click += new System.EventHandler(this.ExistingRequestsButton_Click);
            // 
            // BackToLastReqMenu
            // 
            this.BackToLastReqMenu.BackColor = System.Drawing.Color.MistyRose;
            this.BackToLastReqMenu.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackToLastReqMenu.Location = new System.Drawing.Point(411, 231);
            this.BackToLastReqMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackToLastReqMenu.Name = "BackToLastReqMenu";
            this.BackToLastReqMenu.Size = new System.Drawing.Size(176, 37);
            this.BackToLastReqMenu.TabIndex = 6;
            this.BackToLastReqMenu.Text = "Back to last menu";
            this.BackToLastReqMenu.UseVisualStyleBackColor = false;
            this.BackToLastReqMenu.Click += new System.EventHandler(this.BackToLastReqMenu_Click);
            // 
            // Form_studentRequestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 609);
            this.Controls.Add(this.BackToLastReqMenu);
            this.Controls.Add(this.ExistingRequestsButton);
            this.Controls.Add(this.NewRequestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_studentRequestMenu";
            this.Text = "Student Request Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_studentRequestMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form_studentRequestMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewRequestButton;
        private System.Windows.Forms.Button ExistingRequestsButton;
        private System.Windows.Forms.Button BackToLastReqMenu;
    }
}