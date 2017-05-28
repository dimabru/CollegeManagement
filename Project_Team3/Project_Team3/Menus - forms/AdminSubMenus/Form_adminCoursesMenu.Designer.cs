namespace Project_Team3.Menus___forms.AdminSubMenus
{
    partial class Form_adminCoursesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_adminCoursesMenu));
            this.List_courses = new System.Windows.Forms.Button();
            this.watchInfo = new System.Windows.Forms.Button();
            this.recieveAmount = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // List_courses
            // 
            this.List_courses.BackColor = System.Drawing.Color.MistyRose;
            this.List_courses.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.List_courses.Location = new System.Drawing.Point(134, 157);
            this.List_courses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.List_courses.Name = "List_courses";
            this.List_courses.Size = new System.Drawing.Size(235, 51);
            this.List_courses.TabIndex = 2;
            this.List_courses.Text = "List of all courses.";
            this.List_courses.UseVisualStyleBackColor = false;
            this.List_courses.Click += new System.EventHandler(this.ListCoursesClick);
            // 
            // watchInfo
            // 
            this.watchInfo.BackColor = System.Drawing.Color.MistyRose;
            this.watchInfo.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.watchInfo.Location = new System.Drawing.Point(134, 233);
            this.watchInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.watchInfo.Name = "watchInfo";
            this.watchInfo.Size = new System.Drawing.Size(235, 53);
            this.watchInfo.TabIndex = 3;
            this.watchInfo.Text = "Watch course\'s info.";
            this.watchInfo.UseVisualStyleBackColor = false;
            this.watchInfo.Click += new System.EventHandler(this.watchInfoClick);
            // 
            // recieveAmount
            // 
            this.recieveAmount.BackColor = System.Drawing.Color.MistyRose;
            this.recieveAmount.Font = new System.Drawing.Font("David", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.recieveAmount.Location = new System.Drawing.Point(134, 309);
            this.recieveAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recieveAmount.Name = "recieveAmount";
            this.recieveAmount.Size = new System.Drawing.Size(235, 54);
            this.recieveAmount.TabIndex = 4;
            this.recieveAmount.Text = "Receive amount of courses.";
            this.recieveAmount.UseVisualStyleBackColor = false;
            this.recieveAmount.Click += new System.EventHandler(this.recieveAmountClick);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.MistyRose;
            this.Back.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Back.Location = new System.Drawing.Point(134, 435);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(235, 46);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back to last menu.";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(433, 119);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(755, 422);
            this.dataGrid.TabIndex = 6;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            this.dataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseDoubleClick);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(153, 51);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(1013, 30);
            this.textBox.TabIndex = 7;
            // 
            // Form_adminCoursesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.recieveAmount);
            this.Controls.Add(this.watchInfo);
            this.Controls.Add(this.List_courses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_adminCoursesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin\'s courses menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_adminCoursesMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form_adminCoursesMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button List_courses;
        private System.Windows.Forms.Button watchInfo;
        private System.Windows.Forms.Button recieveAmount;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox textBox;
    }
}