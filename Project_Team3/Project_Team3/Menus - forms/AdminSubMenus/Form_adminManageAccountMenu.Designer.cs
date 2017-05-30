namespace Project_Team3.Menus___forms.AdminSubMenus
{
    partial class Form_adminManageAccountMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_adminManageAccountMenu));
            this.AddStudentAccount = new System.Windows.Forms.Button();
            this.AddAssociateAccount = new System.Windows.Forms.Button();
            this.DeleteStudentAccount = new System.Windows.Forms.Button();
            this.DeleteAssociateAccount = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddStudentAccount
            // 
            this.AddStudentAccount.BackColor = System.Drawing.Color.MistyRose;
            this.AddStudentAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddStudentAccount.Location = new System.Drawing.Point(41, 81);
            this.AddStudentAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddStudentAccount.Name = "AddStudentAccount";
            this.AddStudentAccount.Size = new System.Drawing.Size(200, 40);
            this.AddStudentAccount.TabIndex = 3;
            this.AddStudentAccount.Text = "Add student account.";
            this.AddStudentAccount.UseVisualStyleBackColor = false;
            this.AddStudentAccount.Click += new System.EventHandler(this.addAccountClick);
            // 
            // AddAssociateAccount
            // 
            this.AddAssociateAccount.BackColor = System.Drawing.Color.MistyRose;
            this.AddAssociateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddAssociateAccount.Location = new System.Drawing.Point(41, 138);
            this.AddAssociateAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddAssociateAccount.Name = "AddAssociateAccount";
            this.AddAssociateAccount.Size = new System.Drawing.Size(200, 40);
            this.AddAssociateAccount.TabIndex = 4;
            this.AddAssociateAccount.Text = "Add associate account.";
            this.AddAssociateAccount.UseVisualStyleBackColor = false;
            this.AddAssociateAccount.Click += new System.EventHandler(this.addAssociateClick);
            // 
            // DeleteStudentAccount
            // 
            this.DeleteStudentAccount.BackColor = System.Drawing.Color.MistyRose;
            this.DeleteStudentAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DeleteStudentAccount.Location = new System.Drawing.Point(41, 198);
            this.DeleteStudentAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteStudentAccount.Name = "DeleteStudentAccount";
            this.DeleteStudentAccount.Size = new System.Drawing.Size(200, 40);
            this.DeleteStudentAccount.TabIndex = 5;
            this.DeleteStudentAccount.Text = "Delete student account.";
            this.DeleteStudentAccount.UseVisualStyleBackColor = false;
            this.DeleteStudentAccount.Click += new System.EventHandler(this.deleteStudentClick);
            // 
            // DeleteAssociateAccount
            // 
            this.DeleteAssociateAccount.BackColor = System.Drawing.Color.MistyRose;
            this.DeleteAssociateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DeleteAssociateAccount.Location = new System.Drawing.Point(41, 255);
            this.DeleteAssociateAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteAssociateAccount.Name = "DeleteAssociateAccount";
            this.DeleteAssociateAccount.Size = new System.Drawing.Size(200, 40);
            this.DeleteAssociateAccount.TabIndex = 6;
            this.DeleteAssociateAccount.Text = "Delete Associate account.";
            this.DeleteAssociateAccount.UseVisualStyleBackColor = false;
            this.DeleteAssociateAccount.Click += new System.EventHandler(this.deleteAssociateClick);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.MistyRose;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Back.Location = new System.Drawing.Point(41, 355);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(200, 40);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back to last menu.";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // Form_adminManageAccountMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 609);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DeleteAssociateAccount);
            this.Controls.Add(this.DeleteStudentAccount);
            this.Controls.Add(this.AddAssociateAccount);
            this.Controls.Add(this.AddStudentAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_adminManageAccountMenu";
            this.Text = "Admin - Manage accounts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_adminManageAccountMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddStudentAccount;
        private System.Windows.Forms.Button AddAssociateAccount;
        private System.Windows.Forms.Button DeleteStudentAccount;
        private System.Windows.Forms.Button DeleteAssociateAccount;
        private System.Windows.Forms.Button Back;
    }
}