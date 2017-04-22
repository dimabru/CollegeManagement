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
            this.refreshBotton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllMessages_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAllMessages_grid
            // 
            this.viewAllMessages_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.viewAllMessages_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.viewAllMessages_grid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.viewAllMessages_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAllMessages_grid.Location = new System.Drawing.Point(13, 13);
            this.viewAllMessages_grid.Name = "viewAllMessages_grid";
            this.viewAllMessages_grid.Size = new System.Drawing.Size(814, 269);
            this.viewAllMessages_grid.TabIndex = 0;
            this.viewAllMessages_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAllMessages_grid_CellContentClick);
            // 
            // refreshBotton
            // 
            this.refreshBotton.Location = new System.Drawing.Point(13, 301);
            this.refreshBotton.Name = "refreshBotton";
            this.refreshBotton.Size = new System.Drawing.Size(75, 23);
            this.refreshBotton.TabIndex = 1;
            this.refreshBotton.Text = "Refresh List";
            this.refreshBotton.UseVisualStyleBackColor = true;
            this.refreshBotton.Click += new System.EventHandler(this.refreshBotton_Click);
            // 
            // Form_adminSeeAllGlobalMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 338);
            this.Controls.Add(this.refreshBotton);
            this.Controls.Add(this.viewAllMessages_grid);
            this.Name = "Form_adminSeeAllGlobalMessages";
            this.Text = "All global messages in system";
            this.Load += new System.EventHandler(this.Form_adminSeeAllGlobalMessages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllMessages_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewAllMessages_grid;
        private System.Windows.Forms.Button refreshBotton;
    }
}