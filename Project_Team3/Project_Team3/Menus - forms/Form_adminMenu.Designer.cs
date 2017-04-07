namespace Project_Team3
{
    partial class Form_adminMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.coursesMenuButton = new System.Windows.Forms.Button();
            this.accountsMenuButton = new System.Windows.Forms.Button();
            this.globalMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage accounts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.manageAccountsButtonClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(80, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "show global message";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(118, 300);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(176, 37);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButtonClick);
            // 
            // coursesMenuButton
            // 
            this.coursesMenuButton.Location = new System.Drawing.Point(118, 121);
            this.coursesMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.coursesMenuButton.Name = "coursesMenuButton";
            this.coursesMenuButton.Size = new System.Drawing.Size(176, 37);
            this.coursesMenuButton.TabIndex = 3;
            this.coursesMenuButton.Text = "Courses menu";
            this.coursesMenuButton.UseVisualStyleBackColor = true;
            this.coursesMenuButton.Click += new System.EventHandler(this.coursesMenuButtonClick);
            // 
            // accountsMenuButton
            // 
            this.accountsMenuButton.Location = new System.Drawing.Point(118, 171);
            this.accountsMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.accountsMenuButton.Name = "accountsMenuButton";
            this.accountsMenuButton.Size = new System.Drawing.Size(176, 37);
            this.accountsMenuButton.TabIndex = 4;
            this.accountsMenuButton.Text = "Accounts menu";
            this.accountsMenuButton.UseVisualStyleBackColor = true;
            this.accountsMenuButton.Click += new System.EventHandler(this.accountsMenuButtonClick);
            // 
            // globalMessageButton
            // 
            this.globalMessageButton.Location = new System.Drawing.Point(118, 224);
            this.globalMessageButton.Margin = new System.Windows.Forms.Padding(2);
            this.globalMessageButton.Name = "globalMessageButton";
            this.globalMessageButton.Size = new System.Drawing.Size(176, 37);
            this.globalMessageButton.TabIndex = 5;
            this.globalMessageButton.Text = "Global message";
            this.globalMessageButton.UseVisualStyleBackColor = true;
            this.globalMessageButton.Click += new System.EventHandler(this.globalMessageButtonClick);
            // 
            // Form_adminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 448);
            this.Controls.Add(this.globalMessageButton);
            this.Controls.Add(this.accountsMenuButton);
            this.Controls.Add(this.coursesMenuButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_adminMenu";
            this.Text = "Admin Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_adminMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form_adminMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button coursesMenuButton;
        private System.Windows.Forms.Button accountsMenuButton;
        private System.Windows.Forms.Button globalMessageButton;
    }
}