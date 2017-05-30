namespace Project_Team3.Menus___forms.AdminSubMenus
{
    partial class Form_adminAddAssociate
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
            this.generalLabel = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.secondName_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.firstname_box = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.surenameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addStudentToDatabase = new System.Windows.Forms.Button();
            this.email_label = new System.Windows.Forms.Label();
            this.email_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generalLabel
            // 
            this.generalLabel.AutoSize = true;
            this.generalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalLabel.Location = new System.Drawing.Point(30, 27);
            this.generalLabel.Name = "generalLabel";
            this.generalLabel.Size = new System.Drawing.Size(511, 24);
            this.generalLabel.TabIndex = 27;
            this.generalLabel.Text = "Fill all bellow fields to add new assosiate member to College";
            this.generalLabel.Click += new System.EventHandler(this.generalLabel_Click);
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(125, 255);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(319, 20);
            this.password_box.TabIndex = 21;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            // 
            // secondName_box
            // 
            this.secondName_box.Location = new System.Drawing.Point(125, 208);
            this.secondName_box.Name = "secondName_box";
            this.secondName_box.Size = new System.Drawing.Size(319, 20);
            this.secondName_box.TabIndex = 19;
            this.secondName_box.TextChanged += new System.EventHandler(this.secondName_box_TextChanged);
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(125, 87);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(319, 20);
            this.id_box.TabIndex = 14;
            this.id_box.TextChanged += new System.EventHandler(this.id_box_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(24, 87);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 13);
            this.idLabel.TabIndex = 26;
            this.idLabel.Text = "ID :";
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // firstname_box
            // 
            this.firstname_box.Location = new System.Drawing.Point(125, 165);
            this.firstname_box.Name = "firstname_box";
            this.firstname_box.Size = new System.Drawing.Size(319, 20);
            this.firstname_box.TabIndex = 17;
            this.firstname_box.TextChanged += new System.EventHandler(this.firstname_box_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(24, 255);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 22;
            this.passwordLabel.Text = "Password :";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // surenameLabel
            // 
            this.surenameLabel.AutoSize = true;
            this.surenameLabel.Location = new System.Drawing.Point(24, 216);
            this.surenameLabel.Name = "surenameLabel";
            this.surenameLabel.Size = new System.Drawing.Size(81, 13);
            this.surenameLabel.TabIndex = 20;
            this.surenameLabel.Text = "Second Name :";
            this.surenameLabel.Click += new System.EventHandler(this.surenameLabel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(24, 173);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 13);
            this.nameLabel.TabIndex = 18;
            this.nameLabel.Text = "First Name :";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(125, 125);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(319, 20);
            this.username_box.TabIndex = 16;
            this.username_box.TextChanged += new System.EventHandler(this.username_box_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(24, 128);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 13);
            this.usernameLabel.TabIndex = 15;
            this.usernameLabel.Text = "Username :";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // addStudentToDatabase
            // 
            this.addStudentToDatabase.Location = new System.Drawing.Point(218, 417);
            this.addStudentToDatabase.Name = "addStudentToDatabase";
            this.addStudentToDatabase.Size = new System.Drawing.Size(117, 23);
            this.addStudentToDatabase.TabIndex = 29;
            this.addStudentToDatabase.Text = "Add To database";
            this.addStudentToDatabase.UseVisualStyleBackColor = true;
            this.addStudentToDatabase.Click += new System.EventHandler(this.addStudentToDatabase_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(27, 299);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(35, 13);
            this.email_label.TabIndex = 28;
            this.email_label.Text = "Email:";
            // 
            // email_Box
            // 
            this.email_Box.Location = new System.Drawing.Point(125, 299);
            this.email_Box.Name = "email_Box";
            this.email_Box.Size = new System.Drawing.Size(319, 20);
            this.email_Box.TabIndex = 25;
            // 
            // Form_adminAddAssociate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 466);
            this.Controls.Add(this.email_Box);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.generalLabel);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.secondName_box);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.firstname_box);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.surenameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.addStudentToDatabase);
            this.Name = "Form_adminAddAssociate";
            this.Text = "Add new Associate member ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_adminAddAssociate_FormClosed);
            this.Load += new System.EventHandler(this.Form_adminAddAssociate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label generalLabel;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox secondName_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox firstname_box;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label surenameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button addStudentToDatabase;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email_Box;
    }
}