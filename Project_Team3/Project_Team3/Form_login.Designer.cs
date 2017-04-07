namespace Project_Team3
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.label1 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("David", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(406, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(621, 261);
            this.userNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(271, 22);
            this.userNameBox.TabIndex = 2;
            this.userNameBox.TextChanged += new System.EventHandler(this.userName_Text);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("David", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(419, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(621, 339);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(271, 22);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.TextChanged += new System.EventHandler(this.password_Text);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("David", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(684, 404);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.loginButton_click);
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeader.Font = new System.Drawing.Font("David", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LabelHeader.Location = new System.Drawing.Point(429, 153);
            this.LabelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(507, 47);
            this.LabelHeader.TabIndex = 6;
            this.LabelHeader.Text = "Welcome! Please login :";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExitButton.Font = new System.Drawing.Font("David", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.DarkGray;
            this.ExitButton.Location = new System.Drawing.Point(684, 461);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(123, 39);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login form";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button ExitButton;
    }
}

