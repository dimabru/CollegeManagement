namespace Project_Team3.Menus___forms
{
    partial class Form_associateMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_associateMenu));
            this.logoutButton = new System.Windows.Forms.Button();
            this.globalMessageLabel = new System.Windows.Forms.Label();
            this.viewWeeklyPlanButton = new System.Windows.Forms.Button();
            this.defineNewEventButton = new System.Windows.Forms.Button();
            this.viewAllEventsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.MistyRose;
            resources.ApplyResources(this.logoutButton, "logoutButton");
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // globalMessageLabel
            // 
            resources.ApplyResources(this.globalMessageLabel, "globalMessageLabel");
            this.globalMessageLabel.BackColor = System.Drawing.Color.MistyRose;
            this.globalMessageLabel.Name = "globalMessageLabel";
            // 
            // viewWeeklyPlanButton
            // 
            this.viewWeeklyPlanButton.BackColor = System.Drawing.Color.MistyRose;
            resources.ApplyResources(this.viewWeeklyPlanButton, "viewWeeklyPlanButton");
            this.viewWeeklyPlanButton.Name = "viewWeeklyPlanButton";
            this.viewWeeklyPlanButton.UseVisualStyleBackColor = false;
            this.viewWeeklyPlanButton.Click += new System.EventHandler(this.viewWeeklyPlanButton_Click);
            // 
            // defineNewEventButton
            // 
            this.defineNewEventButton.BackColor = System.Drawing.Color.MistyRose;
            resources.ApplyResources(this.defineNewEventButton, "defineNewEventButton");
            this.defineNewEventButton.Name = "defineNewEventButton";
            this.defineNewEventButton.UseVisualStyleBackColor = false;
            this.defineNewEventButton.Click += new System.EventHandler(this.defineNewEventButton_Click);
            // 
            // viewAllEventsButton
            // 
            this.viewAllEventsButton.BackColor = System.Drawing.Color.MistyRose;
            resources.ApplyResources(this.viewAllEventsButton, "viewAllEventsButton");
            this.viewAllEventsButton.Name = "viewAllEventsButton";
            this.viewAllEventsButton.UseVisualStyleBackColor = false;
            this.viewAllEventsButton.Click += new System.EventHandler(this.viewAllEventsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_associateMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewAllEventsButton);
            this.Controls.Add(this.defineNewEventButton);
            this.Controls.Add(this.viewWeeklyPlanButton);
            this.Controls.Add(this.globalMessageLabel);
            this.Controls.Add(this.logoutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_associateMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_associateMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form_associateMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label globalMessageLabel;
        private System.Windows.Forms.Button viewWeeklyPlanButton;
        private System.Windows.Forms.Button defineNewEventButton;
        private System.Windows.Forms.Button viewAllEventsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}