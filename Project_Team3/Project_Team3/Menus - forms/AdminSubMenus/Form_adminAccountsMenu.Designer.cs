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
            this.watchStudents.Location = new System.Drawing.Point(11, 67);
            this.watchStudents.Margin = new System.Windows.Forms.Padding(2);
            this.watchStudents.Name = "watchStudents";
            this.watchStudents.Size = new System.Drawing.Size(176, 37);
            this.watchStudents.TabIndex = 1;
            this.watchStudents.Text = "Watch student\'s info.";
            this.watchStudents.UseVisualStyleBackColor = true;
            this.watchStudents.Click += new System.EventHandler(this.watchStudents_Click);
            // 
            // watchAssociate
            // 
            this.watchAssociate.Location = new System.Drawing.Point(11, 126);
            this.watchAssociate.Margin = new System.Windows.Forms.Padding(2);
            this.watchAssociate.Name = "watchAssociate";
            this.watchAssociate.Size = new System.Drawing.Size(176, 37);
            this.watchAssociate.TabIndex = 2;
            this.watchAssociate.Text = "Watch associate\'s info.";
            this.watchAssociate.UseVisualStyleBackColor = true;
            this.watchAssociate.Click += new System.EventHandler(this.watchAssociates_Click);
            // 
            // getStudentsNumberButton
            // 
            this.getStudentsNumberButton.Location = new System.Drawing.Point(11, 186);
            this.getStudentsNumberButton.Margin = new System.Windows.Forms.Padding(2);
            this.getStudentsNumberButton.Name = "getStudentsNumberButton";
            this.getStudentsNumberButton.Size = new System.Drawing.Size(176, 37);
            this.getStudentsNumberButton.TabIndex = 3;
            this.getStudentsNumberButton.Text = "Recieve amount of students.";
            this.getStudentsNumberButton.UseVisualStyleBackColor = true;
            this.getStudentsNumberButton.Click += new System.EventHandler(this.getStudentsNumber_Click);
            // 
            // getAssociatesNumber
            // 
            this.getAssociatesNumber.Location = new System.Drawing.Point(11, 244);
            this.getAssociatesNumber.Margin = new System.Windows.Forms.Padding(2);
            this.getAssociatesNumber.Name = "getAssociatesNumber";
            this.getAssociatesNumber.Size = new System.Drawing.Size(176, 37);
            this.getAssociatesNumber.TabIndex = 4;
            this.getAssociatesNumber.Text = "Recieve amount of associates.";
            this.getAssociatesNumber.UseVisualStyleBackColor = true;
            this.getAssociatesNumber.Click += new System.EventHandler(this.getAssociatesNumberClick);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(11, 299);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(176, 37);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back to last menu.";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(12, 22);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(760, 26);
            this.textBox.TabIndex = 6;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(209, 67);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(563, 462);
            this.dataGrid.TabIndex = 7;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // Form_adminAccountsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.getAssociatesNumber);
            this.Controls.Add(this.getStudentsNumberButton);
            this.Controls.Add(this.watchAssociate);
            this.Controls.Add(this.watchStudents);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_adminAccountsMenu";
            this.Text = "Admin\'s accounts menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_adminAccountsMenu_FormClosed);
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