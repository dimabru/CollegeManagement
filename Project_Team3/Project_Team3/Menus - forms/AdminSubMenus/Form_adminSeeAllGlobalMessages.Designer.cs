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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_adminSeeAllGlobalMessages));
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
            this.viewAllMessages_grid.Location = new System.Drawing.Point(90, 139);
            this.viewAllMessages_grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewAllMessages_grid.Name = "viewAllMessages_grid";
            this.viewAllMessages_grid.Size = new System.Drawing.Size(1085, 331);
            this.viewAllMessages_grid.TabIndex = 0;
            this.viewAllMessages_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAllMessages_grid_CellContentClick);
            // 
            // refreshBotton
            // 
            this.refreshBotton.BackColor = System.Drawing.Color.MistyRose;
            this.refreshBotton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.refreshBotton.Location = new System.Drawing.Point(90, 493);
            this.refreshBotton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshBotton.Name = "refreshBotton";
            this.refreshBotton.Size = new System.Drawing.Size(165, 40);
            this.refreshBotton.TabIndex = 1;
            this.refreshBotton.Text = "Refresh List";
            this.refreshBotton.UseVisualStyleBackColor = false;
            this.refreshBotton.Click += new System.EventHandler(this.refreshBotton_Click);
            // 
            // Form_adminSeeAllGlobalMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 703);
            this.Controls.Add(this.refreshBotton);
            this.Controls.Add(this.viewAllMessages_grid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_adminSeeAllGlobalMessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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