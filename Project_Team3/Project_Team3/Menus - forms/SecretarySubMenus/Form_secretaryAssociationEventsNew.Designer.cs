namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    partial class Form_secretaryAssociationEventsNew
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
            this.associationEventsGrid = new System.Windows.Forms.DataGridView();
            this.RefreshData = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.associationEventsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // associationEventsGrid
            // 
            this.associationEventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associationEventsGrid.Location = new System.Drawing.Point(192, 104);
            this.associationEventsGrid.Name = "associationEventsGrid";
            this.associationEventsGrid.RowTemplate.Height = 24;
            this.associationEventsGrid.Size = new System.Drawing.Size(500, 254);
            this.associationEventsGrid.TabIndex = 0;
            this.associationEventsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.associationEventsGrid_CellContentClick);
            // 
            // RefreshData
            // 
            this.RefreshData.Location = new System.Drawing.Point(376, 402);
            this.RefreshData.Name = "RefreshData";
            this.RefreshData.Size = new System.Drawing.Size(141, 37);
            this.RefreshData.TabIndex = 1;
            this.RefreshData.Text = "Refresh Data";
            this.RefreshData.UseVisualStyleBackColor = true;
            this.RefreshData.Click += new System.EventHandler(this.RefreshData_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(376, 463);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(141, 37);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back to last menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form_secretaryAssociationEventsNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 631);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RefreshData);
            this.Controls.Add(this.associationEventsGrid);
            this.Name = "Form_secretaryAssociationEventsNew";
            this.Text = "Form_secretaryAssociationEvents";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryAssociationEventsNew_FormClosed);
            this.Load += new System.EventHandler(this.Form_secretaryAssociationEventsNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.associationEventsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView associationEventsGrid;
        private System.Windows.Forms.Button RefreshData;
        private System.Windows.Forms.Button BackButton;
    }
}