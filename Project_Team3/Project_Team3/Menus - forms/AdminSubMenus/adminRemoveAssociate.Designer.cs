namespace Project_Team3.Menus___forms.AdminSubMenus
{
    partial class adminRemoveAssociate
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
            this.backButton = new System.Windows.Forms.Button();
            this.instructonLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.assocLst = new System.Windows.Forms.Button();
            this.removeAssoc = new System.Windows.Forms.Button();
            this.associatesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.associatesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(123, 287);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 36);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back to last menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // instructonLabel
            // 
            this.instructonLabel.AutoSize = true;
            this.instructonLabel.Location = new System.Drawing.Point(40, 102);
            this.instructonLabel.Name = "instructonLabel";
            this.instructonLabel.Size = new System.Drawing.Size(314, 17);
            this.instructonLabel.TabIndex = 6;
            this.instructonLabel.Text = "Enter the ID of the associate you want to remove";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 5;
            // 
            // assocLst
            // 
            this.assocLst.Location = new System.Drawing.Point(123, 241);
            this.assocLst.Name = "assocLst";
            this.assocLst.Size = new System.Drawing.Size(129, 36);
            this.assocLst.TabIndex = 10;
            this.assocLst.Text = "Associate List";
            this.assocLst.UseVisualStyleBackColor = true;
            this.assocLst.Click += new System.EventHandler(this.assocLst_Click);
            // 
            // removeAssoc
            // 
            this.removeAssoc.Location = new System.Drawing.Point(111, 190);
            this.removeAssoc.Name = "removeAssoc";
            this.removeAssoc.Size = new System.Drawing.Size(154, 34);
            this.removeAssoc.TabIndex = 11;
            this.removeAssoc.Text = "Remove Associate";
            this.removeAssoc.UseVisualStyleBackColor = true;
            this.removeAssoc.Click += new System.EventHandler(this.removeAssoc_Click);
            // 
            // associatesDataGrid
            // 
            this.associatesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatesDataGrid.Location = new System.Drawing.Point(360, 102);
            this.associatesDataGrid.Name = "associatesDataGrid";
            this.associatesDataGrid.RowTemplate.Height = 24;
            this.associatesDataGrid.Size = new System.Drawing.Size(467, 267);
            this.associatesDataGrid.TabIndex = 12;
            // 
            // adminRemoveAssociate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 519);
            this.Controls.Add(this.associatesDataGrid);
            this.Controls.Add(this.removeAssoc);
            this.Controls.Add(this.assocLst);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.instructonLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "adminRemoveAssociate";
            this.Text = "adminRemoveAssociate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminRemoveAssociate_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.associatesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label instructonLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button assocLst;
        private System.Windows.Forms.Button removeAssoc;
        private System.Windows.Forms.DataGridView associatesDataGrid;
    }
}