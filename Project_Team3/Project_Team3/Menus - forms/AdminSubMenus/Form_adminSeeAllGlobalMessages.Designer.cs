namespace Project_Team3.Menus___forms.AdminSubMenus
{
    partial class Form_adminSeeAllGlobalMessages
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
            this.viewAllMessages_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllMessages_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAllMessages_grid
            // 
            this.viewAllMessages_grid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.viewAllMessages_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAllMessages_grid.Location = new System.Drawing.Point(13, 13);
            this.viewAllMessages_grid.Name = "viewAllMessages_grid";
            this.viewAllMessages_grid.Size = new System.Drawing.Size(814, 269);
            this.viewAllMessages_grid.TabIndex = 0;
            // 
            // Form_adminSeeAllGlobalMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 294);
            this.Controls.Add(this.viewAllMessages_grid);
            this.Name = "Form_adminSeeAllGlobalMessages";
            this.Text = "All global messages in system";
            ((System.ComponentModel.ISupportInitialize)(this.viewAllMessages_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewAllMessages_grid;
    }
}