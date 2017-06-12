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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_adminMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.coursesMenuButton = new System.Windows.Forms.Button();
            this.accountsMenuButton = new System.Windows.Forms.Button();
            this.globalMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(541, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage accounts";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.manageAccountsButtonClick);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.MistyRose;
            this.logoutButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logoutButton.Location = new System.Drawing.Point(541, 487);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(235, 46);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButtonClick);
            // 
            // coursesMenuButton
            // 
            this.coursesMenuButton.BackColor = System.Drawing.Color.MistyRose;
            this.coursesMenuButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.coursesMenuButton.Location = new System.Drawing.Point(541, 220);
            this.coursesMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coursesMenuButton.Name = "coursesMenuButton";
            this.coursesMenuButton.Size = new System.Drawing.Size(235, 46);
            this.coursesMenuButton.TabIndex = 3;
            this.coursesMenuButton.Text = "Courses menu";
            this.coursesMenuButton.UseVisualStyleBackColor = false;
            this.coursesMenuButton.Click += new System.EventHandler(this.coursesMenuButtonClick);
            // 
            // accountsMenuButton
            // 
            this.accountsMenuButton.BackColor = System.Drawing.Color.MistyRose;
            this.accountsMenuButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.accountsMenuButton.Location = new System.Drawing.Point(541, 281);
            this.accountsMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountsMenuButton.Name = "accountsMenuButton";
            this.accountsMenuButton.Size = new System.Drawing.Size(235, 46);
            this.accountsMenuButton.TabIndex = 4;
            this.accountsMenuButton.Text = "Accounts menu";
            this.accountsMenuButton.UseVisualStyleBackColor = false;
            this.accountsMenuButton.Click += new System.EventHandler(this.accountsMenuButtonClick);
            // 
            // globalMessageButton
            // 
            this.globalMessageButton.BackColor = System.Drawing.Color.MistyRose;
            this.globalMessageButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.globalMessageButton.Location = new System.Drawing.Point(541, 342);
            this.globalMessageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.globalMessageButton.Name = "globalMessageButton";
            this.globalMessageButton.Size = new System.Drawing.Size(235, 46);
            this.globalMessageButton.TabIndex = 5;
            this.globalMessageButton.Text = "Global messages";
            this.globalMessageButton.UseVisualStyleBackColor = false;
            this.globalMessageButton.Click += new System.EventHandler(this.globalMessageButtonClick);
            // 
            // Form_adminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1349, 750);
            this.Controls.Add(this.globalMessageButton);
            this.Controls.Add(this.accountsMenuButton);
            this.Controls.Add(this.coursesMenuButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_adminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_adminMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form_adminMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button coursesMenuButton;
        private System.Windows.Forms.Button accountsMenuButton;
        private System.Windows.Forms.Button globalMessageButton;
    }
}