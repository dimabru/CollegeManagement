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
            this.SuspendLayout();
            // 
            // addStudentToDatabase
            // 
            this.addStudentToDatabase.Location = new System.Drawing.Point(170, 407);
            this.addStudentToDatabase.Name = "addStudentToDatabase";
            this.addStudentToDatabase.Size = new System.Drawing.Size(117, 23);
            this.addStudentToDatabase.TabIndex = 0;
            this.addStudentToDatabase.Text = "Add To database";
            this.addStudentToDatabase.UseVisualStyleBackColor = true;
            // 
            // Form_adminAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 442);
            this.Controls.Add(this.addStudentToDatabase);
            this.Name = "Form_adminAddStudent";
            this.Text = "Form_adminAddStudent";
            this.Load += new System.EventHandler(this.Form_adminAddStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudentToDatabase;
    }
}