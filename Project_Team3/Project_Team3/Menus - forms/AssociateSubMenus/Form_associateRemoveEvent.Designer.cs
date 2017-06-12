namespace Project_Team3.Menus___forms.AssociateSubMenus
{
    partial class Form_associateRemoveEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_associateRemoveEvent));
            this.backButton = new System.Windows.Forms.Button();
            this.eventList = new System.Windows.Forms.Button();
            this.removeEvent = new System.Windows.Forms.Button();
            this.instructonLabel = new System.Windows.Forms.Label();
            this.eventIdTextBox = new System.Windows.Forms.TextBox();
            this.eventsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MistyRose;
            this.backButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.backButton.Location = new System.Drawing.Point(231, 384);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(245, 41);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back to last menu";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // eventList
            // 
            this.eventList.BackColor = System.Drawing.Color.MistyRose;
            this.eventList.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eventList.Location = new System.Drawing.Point(231, 337);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(245, 46);
            this.eventList.TabIndex = 8;
            this.eventList.Text = "Event List";
            this.eventList.UseVisualStyleBackColor = false;
            this.eventList.Click += new System.EventHandler(this.eventList_Click_1);
            // 
            // removeEvent
            // 
            this.removeEvent.BackColor = System.Drawing.Color.MistyRose;
            this.removeEvent.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.removeEvent.Location = new System.Drawing.Point(231, 291);
            this.removeEvent.Name = "removeEvent";
            this.removeEvent.Size = new System.Drawing.Size(245, 45);
            this.removeEvent.TabIndex = 7;
            this.removeEvent.Text = "Remove Event";
            this.removeEvent.UseVisualStyleBackColor = false;
            this.removeEvent.Click += new System.EventHandler(this.removeEvent_Click_1);
            // 
            // instructonLabel
            // 
            this.instructonLabel.AutoSize = true;
            this.instructonLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructonLabel.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.instructonLabel.Location = new System.Drawing.Point(205, 169);
            this.instructonLabel.Name = "instructonLabel";
            this.instructonLabel.Size = new System.Drawing.Size(387, 20);
            this.instructonLabel.TabIndex = 6;
            this.instructonLabel.Text = "Enter the ID of the event you want to remove";
            // 
            // eventIdTextBox
            // 
            this.eventIdTextBox.Location = new System.Drawing.Point(261, 244);
            this.eventIdTextBox.Name = "eventIdTextBox";
            this.eventIdTextBox.Size = new System.Drawing.Size(181, 22);
            this.eventIdTextBox.TabIndex = 5;
            // 
            // eventsDataGrid
            // 
            this.eventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGrid.Location = new System.Drawing.Point(519, 192);
            this.eventsDataGrid.Name = "eventsDataGrid";
            this.eventsDataGrid.RowTemplate.Height = 24;
            this.eventsDataGrid.Size = new System.Drawing.Size(524, 265);
            this.eventsDataGrid.TabIndex = 10;
            // 
            // Form_associateRemoveEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 703);
            this.Controls.Add(this.eventsDataGrid);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.removeEvent);
            this.Controls.Add(this.instructonLabel);
            this.Controls.Add(this.eventIdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_associateRemoveEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_associateRemoveEvent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_associateRemoveEvent_FormClosed_1);
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button eventList;
        private System.Windows.Forms.Button removeEvent;
        private System.Windows.Forms.Label instructonLabel;
        private System.Windows.Forms.TextBox eventIdTextBox;
        private System.Windows.Forms.DataGridView eventsDataGrid;
    }
}