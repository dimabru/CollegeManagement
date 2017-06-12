namespace Project_Team3.Menus___forms.AdminSubMenus
{
    partial class adminRemoveStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminRemoveStudent));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.instructonLabel = new System.Windows.Forms.Label();
            this.removeStudent = new System.Windows.Forms.Button();
            this.studentList = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 0;
            // 
            // instructonLabel
            // 
            this.instructonLabel.AutoSize = true;
            this.instructonLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructonLabel.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.instructonLabel.Location = new System.Drawing.Point(251, 221);
            this.instructonLabel.Name = "instructonLabel";
            this.instructonLabel.Size = new System.Drawing.Size(405, 20);
            this.instructonLabel.TabIndex = 1;
            this.instructonLabel.Text = "Enter the ID of the student you want to remove";
            // 
            // removeStudent
            // 
            this.removeStudent.BackColor = System.Drawing.Color.MistyRose;
            this.removeStudent.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.removeStudent.Location = new System.Drawing.Point(293, 337);
            this.removeStudent.Name = "removeStudent";
            this.removeStudent.Size = new System.Drawing.Size(222, 40);
            this.removeStudent.TabIndex = 2;
            this.removeStudent.Text = "Remove Student";
            this.removeStudent.UseVisualStyleBackColor = false;
            this.removeStudent.Click += new System.EventHandler(this.removeStudent_Click);
            // 
            // studentList
            // 
            this.studentList.BackColor = System.Drawing.Color.MistyRose;
            this.studentList.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.studentList.Location = new System.Drawing.Point(316, 383);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(170, 41);
            this.studentList.TabIndex = 3;
            this.studentList.Text = "Student List";
            this.studentList.UseVisualStyleBackColor = false;
            this.studentList.Click += new System.EventHandler(this.studentList_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MistyRose;
            this.backButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.backButton.Location = new System.Drawing.Point(316, 430);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(170, 70);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back to last menu";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Location = new System.Drawing.Point(577, 245);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.RowTemplate.Height = 24;
            this.studentDataGrid.Size = new System.Drawing.Size(424, 290);
            this.studentDataGrid.TabIndex = 5;
            // 
            // adminRemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1349, 750);
            this.Controls.Add(this.studentDataGrid);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.removeStudent);
            this.Controls.Add(this.instructonLabel);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminRemoveStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminRemoveStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminRemoveStudent_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label instructonLabel;
        private System.Windows.Forms.Button removeStudent;
        private System.Windows.Forms.Button studentList;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView studentDataGrid;
    }
}