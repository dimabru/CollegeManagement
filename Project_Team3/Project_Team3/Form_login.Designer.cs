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
            this.ManagementButton = new System.Windows.Forms.RadioButton();
            this.StudentButton = new System.Windows.Forms.RadioButton();
            this.facebookButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.facebookButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(287, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(456, 68);
            this.userNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(204, 20);
            this.userNameBox.TabIndex = 1;
            this.userNameBox.TextChanged += new System.EventHandler(this.userName_Text);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(287, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(456, 114);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(204, 20);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TextChanged += new System.EventHandler(this.password_Text);
            this.passwordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordBox_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(456, 144);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.loginButton_click);
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.ForeColor = System.Drawing.Color.Black;
            this.LabelHeader.Location = new System.Drawing.Point(278, 9);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(463, 44);
            this.LabelHeader.TabIndex = 6;
            this.LabelHeader.Text = "Welcome ! Please login :";
            // 
            // ManagementButton
            // 
            this.ManagementButton.AutoSize = true;
            this.ManagementButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ManagementButton.Location = new System.Drawing.Point(286, 191);
            this.ManagementButton.Name = "ManagementButton";
            this.ManagementButton.Size = new System.Drawing.Size(112, 17);
            this.ManagementButton.TabIndex = 7;
            this.ManagementButton.TabStop = true;
            this.ManagementButton.Text = "Staff Management";
            this.ManagementButton.UseVisualStyleBackColor = false;
            // 
            // StudentButton
            // 
            this.StudentButton.AutoSize = true;
            this.StudentButton.Location = new System.Drawing.Point(286, 218);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(127, 17);
            this.StudentButton.TabIndex = 8;
            this.StudentButton.TabStop = true;
            this.StudentButton.Text = "Student Management";
            this.StudentButton.UseVisualStyleBackColor = true;
            // 
            // facebookButton
            // 
            this.facebookButton.Image = global::Project_Team3.Properties.Resources.loginWithFacebook;
            this.facebookButton.Location = new System.Drawing.Point(456, 191);
            this.facebookButton.Name = "facebookButton";
            this.facebookButton.Size = new System.Drawing.Size(204, 44);
            this.facebookButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebookButton.TabIndex = 9;
            this.facebookButton.TabStop = false;
            this.facebookButton.Click += new System.EventHandler(this.facebookButton_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(686, 247);
            this.Controls.Add(this.facebookButton);
            this.Controls.Add(this.StudentButton);
            this.Controls.Add(this.ManagementButton);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule System : Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_login_FormClosed);
            this.Load += new System.EventHandler(this.Form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facebookButton)).EndInit();
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
        

        // methods for unit tests
        public System.Windows.Forms.TextBox getUsername() { return this.userNameBox; }
        public System.Windows.Forms.TextBox getPassword() { return this.passwordBox; }
        public bool setDBConnection(DBconnect db) { if (db != null) { this.db = db; return true; } else return false; }

        private System.Windows.Forms.RadioButton ManagementButton;
        private System.Windows.Forms.RadioButton StudentButton;
        private System.Windows.Forms.PictureBox facebookButton;
    }
}

