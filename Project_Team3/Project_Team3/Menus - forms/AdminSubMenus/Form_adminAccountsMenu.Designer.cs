namespace Project_Team3.Menus___forms.AdminSubMenus
{
    partial class Form_adminAccountsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_adminAccountsMenu));
            this.watchStudents = new System.Windows.Forms.Button();
            this.watchAssociate = new System.Windows.Forms.Button();
            this.getStudentsNumberButton = new System.Windows.Forms.Button();
            this.getAssociatesNumber = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // watchStudents
            // 
            this.watchStudents.BackColor = System.Drawing.Color.MistyRose;
            this.watchStudents.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.watchStudents.Location = new System.Drawing.Point(123, 139);
            this.watchStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.watchStudents.Name = "watchStudents";
            this.watchStudents.Size = new System.Drawing.Size(235, 46);
            this.watchStudents.TabIndex = 1;
            this.watchStudents.Text = "Watch student\'s info.";
            this.watchStudents.UseVisualStyleBackColor = false;
            this.watchStudents.Click += new System.EventHandler(this.watchStudents_Click);
            // 
            // watchAssociate
            // 
            this.watchAssociate.BackColor = System.Drawing.Color.MistyRose;
            this.watchAssociate.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.watchAssociate.Location = new System.Drawing.Point(123, 212);
            this.watchAssociate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.watchAssociate.Name = "watchAssociate";
            this.watchAssociate.Size = new System.Drawing.Size(235, 57);
            this.watchAssociate.TabIndex = 2;
            this.watchAssociate.Text = "Watch associate\'s info.";
            this.watchAssociate.UseVisualStyleBackColor = false;
            this.watchAssociate.Click += new System.EventHandler(this.watchAssociates_Click);
            // 
            // getStudentsNumberButton
            // 
            this.getStudentsNumberButton.BackColor = System.Drawing.Color.MistyRose;
            this.getStudentsNumberButton.Font = new System.Drawing.Font("David", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.getStudentsNumberButton.Location = new System.Drawing.Point(123, 286);
            this.getStudentsNumberButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getStudentsNumberButton.Name = "getStudentsNumberButton";
            this.getStudentsNumberButton.Size = new System.Drawing.Size(235, 57);
            this.getStudentsNumberButton.TabIndex = 3;
            this.getStudentsNumberButton.Text = "Recieve amount of students.";
            this.getStudentsNumberButton.UseVisualStyleBackColor = false;
            this.getStudentsNumberButton.Click += new System.EventHandler(this.getStudentsNumber_Click);
            // 
            // getAssociatesNumber
            // 
            this.getAssociatesNumber.BackColor = System.Drawing.Color.MistyRose;
            this.getAssociatesNumber.Font = new System.Drawing.Font("David", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.getAssociatesNumber.Location = new System.Drawing.Point(123, 357);
            this.getAssociatesNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getAssociatesNumber.Name = "getAssociatesNumber";
            this.getAssociatesNumber.Size = new System.Drawing.Size(235, 56);
            this.getAssociatesNumber.TabIndex = 4;
            this.getAssociatesNumber.Text = "Recieve amount of associates.";
            this.getAssociatesNumber.UseVisualStyleBackColor = false;
            this.getAssociatesNumber.Click += new System.EventHandler(this.getAssociatesNumberClick);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.MistyRose;
            this.Back.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Back.Location = new System.Drawing.Point(123, 492);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(235, 46);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back to last menu.";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(141, 21);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(1012, 30);
            this.textBox.TabIndex = 6;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(453, 76);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(751, 569);
            this.dataGrid.TabIndex = 7;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // Form_adminAccountsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1349, 750);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.getAssociatesNumber);
            this.Controls.Add(this.getStudentsNumberButton);
            this.Controls.Add(this.watchAssociate);
            this.Controls.Add(this.watchStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_adminAccountsMenu";
            this.Text = "Admin\'s accounts menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_adminAccountsMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form_adminAccountsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button watchStudents;
        private System.Windows.Forms.Button watchAssociate;
        private System.Windows.Forms.Button getStudentsNumberButton;
        private System.Windows.Forms.Button getAssociatesNumber;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}