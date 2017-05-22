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
            this.dataGrid.Location = new System.Drawing.Point(13, 53);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(705, 217);
            this.dataGrid.TabIndex = 0;
            // 
            // requests_header_label
            // 
            this.requests_header_label.AutoSize = true;
            this.requests_header_label.Location = new System.Drawing.Point(12, 22);
            this.requests_header_label.Name = "requests_header_label";
            this.requests_header_label.Size = new System.Drawing.Size(152, 13);
            this.requests_header_label.TabIndex = 1;
            this.requests_header_label.Text = "List of all your student requests";
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(15, 285);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 2;
            this.refresh_button.Text = "Refresh list";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // Form_studentViewRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 320);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.requests_header_label);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form_studentViewRequests";
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