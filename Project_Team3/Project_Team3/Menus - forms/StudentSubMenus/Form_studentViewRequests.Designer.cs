namespace Project_Team3.Menus___forms.StudentSubMenus
{
    partial class Form_studentViewRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_studentViewRequests));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.requests_header_label = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(190, 182);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(940, 267);
            this.dataGrid.TabIndex = 0;
            // 
            // requests_header_label
            // 
            this.requests_header_label.AutoSize = true;
            this.requests_header_label.BackColor = System.Drawing.Color.Transparent;
            this.requests_header_label.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.requests_header_label.Location = new System.Drawing.Point(189, 144);
            this.requests_header_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requests_header_label.Name = "requests_header_label";
            this.requests_header_label.Size = new System.Drawing.Size(278, 20);
            this.requests_header_label.TabIndex = 1;
            this.requests_header_label.Text = "List of all your student requests";
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.MistyRose;
            this.refresh_button.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.refresh_button.Location = new System.Drawing.Point(193, 468);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(209, 46);
            this.refresh_button.TabIndex = 2;
            this.refresh_button.Text = "Refresh list";
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // Form_studentViewRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 703);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.requests_header_label);
            this.Controls.Add(this.dataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_studentViewRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Student requests";
            this.Load += new System.EventHandler(this.Form_studentViewRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label requests_header_label;
        private System.Windows.Forms.Button refresh_button;
    }
}