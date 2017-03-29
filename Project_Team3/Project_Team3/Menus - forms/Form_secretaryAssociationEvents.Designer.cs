namespace Project_Team3.Menus___forms
{
    partial class Form_secretaryAssociationEvents
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
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.eventsLabel = new System.Windows.Forms.Label();
            this.eventDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Items.AddRange(new object[] {
            "Bei\'t Habad Meeting",
            "She Codes",
            "Amir Benayoun Poetry Night",
            "Careers Center Meeting"});
            this.eventsListBox.Location = new System.Drawing.Point(47, 64);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(208, 147);
            this.eventsListBox.TabIndex = 0;
            // 
            // eventsLabel
            // 
            this.eventsLabel.AutoSize = true;
            this.eventsLabel.Location = new System.Drawing.Point(47, 13);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(142, 13);
            this.eventsLabel.TabIndex = 1;
            this.eventsLabel.Text = "Weekly Association Events: ";
            // 
            // eventDetailsButton
            // 
            this.eventDetailsButton.Location = new System.Drawing.Point(286, 64);
            this.eventDetailsButton.Name = "eventDetailsButton";
            this.eventDetailsButton.Size = new System.Drawing.Size(94, 147);
            this.eventDetailsButton.TabIndex = 2;
            this.eventDetailsButton.Text = "Get More Details";
            this.eventDetailsButton.UseVisualStyleBackColor = true;
            // 
            // Form_secretaryAssociationEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.eventDetailsButton);
            this.Controls.Add(this.eventsLabel);
            this.Controls.Add(this.eventsListBox);
            this.Name = "Form_secretaryAssociationEvents";
            this.Text = "Association Events";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.Label eventsLabel;
        private System.Windows.Forms.Button eventDetailsButton;
    }
}