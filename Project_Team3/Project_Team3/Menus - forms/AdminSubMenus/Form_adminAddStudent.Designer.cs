namespace Project_Team3.Menus___forms.AdminSubMenus
{
    partial class Form_adminAddStudent
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
            this.addStudentToDatabase = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surenameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.firstname_box = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.TextBox();
            this.secondName_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.semester_box = new System.Windows.Forms.TextBox();
            this.generalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addStudentToDatabase
            // 
            this.addStudentToDatabase.Location = new System.Drawing.Point(170, 407);
            this.addStudentToDatabase.Name = "addStudentToDatabase";
            this.addStudentToDatabase.Size = new System.Drawing.Size(117, 23);
            this.addStudentToDatabase.TabIndex = 7;
            this.addStudentToDatabase.Text = "Add To database";
            this.addStudentToDatabase.UseVisualStyleBackColor = true;
            this.addStudentToDatabase.Click += new System.EventHandler(this.addStudentToDatabase_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(16, 119);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username :";
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(122, 116);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(319, 20);
            this.username_box.TabIndex = 2;
            this.username_box.TextChanged += new System.EventHandler(this.username_box_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 164);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "First Name :";
            // 
            // surenameLabel
            // 
            this.surenameLabel.AutoSize = true;
            this.surenameLabel.Location = new System.Drawing.Point(16, 207);
            this.surenameLabel.Name = "surenameLabel";
            this.surenameLabel.Size = new System.Drawing.Size(81, 13);
            this.surenameLabel.TabIndex = 4;
            this.surenameLabel.Text = "Second Name :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(16, 246);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password :";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Location = new System.Drawing.Point(16, 297);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(57, 13);
            this.semesterLabel.TabIndex = 6;
            this.semesterLabel.Text = "Semester :";
            // 
            // firstname_box
            // 
            this.firstname_box.Location = new System.Drawing.Point(122, 156);
            this.firstname_box.Name = "firstname_box";
            this.firstname_box.Size = new System.Drawing.Size(319, 20);
            this.firstname_box.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(16, 78);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 13);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID :";
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(122, 78);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(319, 20);
            this.id_box.TabIndex = 1;
            // 
            // secondName_box
            // 
            this.secondName_box.Location = new System.Drawing.Point(122, 199);
            this.secondName_box.Name = "secondName_box";
            this.secondName_box.Size = new System.Drawing.Size(319, 20);
            this.secondName_box.TabIndex = 4;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(122, 246);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(319, 20);
            this.password_box.TabIndex = 5;
            // 
            // semester_box
            // 
            this.semester_box.Location = new System.Drawing.Point(122, 297);
            this.semester_box.Name = "semester_box";
            this.semester_box.Size = new System.Drawing.Size(319, 20);
            this.semester_box.TabIndex = 6;
            // 
            // generalLabel
            // 
            this.generalLabel.AutoSize = true;
            this.generalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalLabel.Location = new System.Drawing.Point(22, 18);
            this.generalLabel.Name = "generalLabel";
            this.generalLabel.Size = new System.Drawing.Size(419, 24);
            this.generalLabel.TabIndex = 13;
            this.generalLabel.Text = "Fill all bellow fields to add new student to College";
            this.generalLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_adminAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 442);
            this.Controls.Add(this.generalLabel);
            this.Controls.Add(this.semester_box);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.secondName_box);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.firstname_box);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.surenameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.addStudentToDatabase);
            this.Name = "Form_adminAddStudent";
            this.Text = "Add Student to College from Admin menu";
            this.Load += new System.EventHandler(this.Form_adminAddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudentToDatabase;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surenameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.TextBox firstname_box;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.TextBox secondName_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox semester_box;
        private System.Windows.Forms.Label generalLabel;
    }
}