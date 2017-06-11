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
            this.backButton.Location = new System.Drawing.Point(112, 299);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 36);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back to last menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // eventList
            // 
            this.eventList.Location = new System.Drawing.Point(112, 252);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(129, 41);
            this.eventList.TabIndex = 8;
            this.eventList.Text = "Event List";
            this.eventList.UseVisualStyleBackColor = true;
            this.eventList.Click += new System.EventHandler(this.eventList_Click_1);
            // 
            // removeEvent
            // 
            this.removeEvent.Location = new System.Drawing.Point(112, 206);
            this.removeEvent.Name = "removeEvent";
            this.removeEvent.Size = new System.Drawing.Size(129, 40);
            this.removeEvent.TabIndex = 7;
            this.removeEvent.Text = "Remove Event";
            this.removeEvent.UseVisualStyleBackColor = true;
            this.removeEvent.Click += new System.EventHandler(this.removeEvent_Click_1);
            // 
            // instructonLabel
            // 
            this.instructonLabel.AutoSize = true;
            this.instructonLabel.Location = new System.Drawing.Point(29, 114);
            this.instructonLabel.Name = "instructonLabel";
            this.instructonLabel.Size = new System.Drawing.Size(289, 17);
            this.instructonLabel.TabIndex = 6;
            this.instructonLabel.Text = "Enter the ID of the event you want to remove";
            // 
            // eventIdTextBox
            // 
            this.eventIdTextBox.Location = new System.Drawing.Point(85, 155);
            this.eventIdTextBox.Name = "eventIdTextBox";
            this.eventIdTextBox.Size = new System.Drawing.Size(181, 22);
            this.eventIdTextBox.TabIndex = 5;
            // 
            // eventsDataGrid
            // 
            this.eventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGrid.Location = new System.Drawing.Point(343, 103);
            this.eventsDataGrid.Name = "eventsDataGrid";
            this.eventsDataGrid.RowTemplate.Height = 24;
            this.eventsDataGrid.Size = new System.Drawing.Size(524, 265);
            this.eventsDataGrid.TabIndex = 10;
            // 
            // Form_associateRemoveEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 501);
            this.Controls.Add(this.eventsDataGrid);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.removeEvent);
            this.Controls.Add(this.instructonLabel);
            this.Controls.Add(this.eventIdTextBox);
            this.Name = "Form_associateRemoveEvent";
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