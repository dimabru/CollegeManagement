namespace Project_Team3.Menus___forms.StudentSubMenus
{
    partial class Form_studentAssociationMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_studentAssociationMenu));
            this.AssociationInformationButton = new System.Windows.Forms.Button();
            this.RegisterEventsButton = new System.Windows.Forms.Button();
            this.UnregisterEventsButton = new System.Windows.Forms.Button();
            this.BackToLastAssMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AssociationInformationButton
            // 
            this.AssociationInformationButton.BackColor = System.Drawing.Color.MistyRose;
            this.AssociationInformationButton.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AssociationInformationButton.Location = new System.Drawing.Point(405, 88);
            this.AssociationInformationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AssociationInformationButton.Name = "AssociationInformationButton";
            this.AssociationInformationButton.Size = new System.Drawing.Size(176, 47);
            this.AssociationInformationButton.TabIndex = 3;
            this.AssociationInformationButton.Text = "Association information";
            this.AssociationInformationButton.UseVisualStyleBackColor = false;
            this.AssociationInformationButton.Click += new System.EventHandler(this.AssociationInformationButton_Click);
            // 
            // RegisterEventsButton
            // 
            this.RegisterEventsButton.BackColor = System.Drawing.Color.MistyRose;
            this.RegisterEventsButton.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RegisterEventsButton.Location = new System.Drawing.Point(405, 150);
            this.RegisterEventsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegisterEventsButton.Name = "RegisterEventsButton";
            this.RegisterEventsButton.Size = new System.Drawing.Size(176, 47);
            this.RegisterEventsButton.TabIndex = 4;
            this.RegisterEventsButton.Text = "Register to association events";
            this.RegisterEventsButton.UseVisualStyleBackColor = false;
            this.RegisterEventsButton.Click += new System.EventHandler(this.RegisterEventsButton_Click);
            // 
            // UnregisterEventsButton
            // 
            this.UnregisterEventsButton.BackColor = System.Drawing.Color.MistyRose;
            this.UnregisterEventsButton.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UnregisterEventsButton.Location = new System.Drawing.Point(405, 211);
            this.UnregisterEventsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UnregisterEventsButton.Name = "UnregisterEventsButton";
            this.UnregisterEventsButton.Size = new System.Drawing.Size(176, 47);
            this.UnregisterEventsButton.TabIndex = 5;
            this.UnregisterEventsButton.Text = "Unregister association events";
            this.UnregisterEventsButton.UseVisualStyleBackColor = false;
            this.UnregisterEventsButton.Click += new System.EventHandler(this.UnregisterEventsButton_Click);
            // 
            // BackToLastAssMenu
            // 
            this.BackToLastAssMenu.BackColor = System.Drawing.Color.MistyRose;
            this.BackToLastAssMenu.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackToLastAssMenu.Location = new System.Drawing.Point(405, 316);
            this.BackToLastAssMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackToLastAssMenu.Name = "BackToLastAssMenu";
            this.BackToLastAssMenu.Size = new System.Drawing.Size(176, 37);
            this.BackToLastAssMenu.TabIndex = 6;
            this.BackToLastAssMenu.Text = "Back to last menu";
            this.BackToLastAssMenu.UseVisualStyleBackColor = false;
            this.BackToLastAssMenu.Click += new System.EventHandler(this.BackToLastAssMenu_Click);
            // 
            // Form_studentAssociationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 609);
            this.Controls.Add(this.BackToLastAssMenu);
            this.Controls.Add(this.UnregisterEventsButton);
            this.Controls.Add(this.RegisterEventsButton);
            this.Controls.Add(this.AssociationInformationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_studentAssociationMenu";
            this.Text = "Student\'s Association Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_studentAssociationMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form_studentAssociationMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AssociationInformationButton;
        private System.Windows.Forms.Button RegisterEventsButton;
        private System.Windows.Forms.Button UnregisterEventsButton;
        private System.Windows.Forms.Button BackToLastAssMenu;
    }
}