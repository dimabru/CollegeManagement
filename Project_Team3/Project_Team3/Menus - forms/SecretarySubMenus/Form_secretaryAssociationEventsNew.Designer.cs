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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_secretaryAssociationEventsNew));
            this.associationEventsGrid = new System.Windows.Forms.DataGridView();
            this.RefreshData = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.associationEventsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // associationEventsGrid
            // 
            this.associationEventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associationEventsGrid.Location = new System.Drawing.Point(377, 166);
            this.associationEventsGrid.Name = "associationEventsGrid";
            this.associationEventsGrid.RowTemplate.Height = 24;
            this.associationEventsGrid.Size = new System.Drawing.Size(500, 254);
            this.associationEventsGrid.TabIndex = 0;
            this.associationEventsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.associationEventsGrid_CellContentClick);
            // 
            // RefreshData
            // 
            this.RefreshData.BackColor = System.Drawing.Color.MistyRose;
            this.RefreshData.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RefreshData.Location = new System.Drawing.Point(524, 462);
            this.RefreshData.Name = "RefreshData";
            this.RefreshData.Size = new System.Drawing.Size(245, 37);
            this.RefreshData.TabIndex = 1;
            this.RefreshData.Text = "Refresh Data";
            this.RefreshData.UseVisualStyleBackColor = false;
            this.RefreshData.Click += new System.EventHandler(this.RefreshData_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.MistyRose;
            this.BackButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackButton.Location = new System.Drawing.Point(524, 523);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(245, 37);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back to last menu";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionLabel.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.instructionLabel.Location = new System.Drawing.Point(389, 116);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(477, 20);
            this.instructionLabel.TabIndex = 3;
            this.instructionLabel.Text = "Click on the event you\'re interested in for more details.";
            // 
            // Form_secretaryAssociationEventsNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 703);
            this.ControlBox = false;
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RefreshData);
            this.Controls.Add(this.associationEventsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_secretaryAssociationEventsNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_secretaryAssociationEvents";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryAssociationEventsNew_FormClosed);
            this.Load += new System.EventHandler(this.Form_secretaryAssociationEventsNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.associationEventsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView associationEventsGrid;
        private System.Windows.Forms.Button RefreshData;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label instructionLabel;
    }
}