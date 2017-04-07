namespace Project_Team3.Menus___forms.SecretarySubMenus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_secretaryAssociationEvents));
            this.eventsLabel = new System.Windows.Forms.Label();
            this.eventDetailsButton = new System.Windows.Forms.Button();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // eventsLabel
            // 
            this.eventsLabel.AutoSize = true;
            this.eventsLabel.Font = new System.Drawing.Font("David", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eventsLabel.Location = new System.Drawing.Point(405, 146);
            this.eventsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(349, 28);
            this.eventsLabel.TabIndex = 1;
            this.eventsLabel.Text = "Weekly Association Events: ";
            this.eventsLabel.UseWaitCursor = true;
            // 
            // eventDetailsButton
            // 
            this.eventDetailsButton.BackColor = System.Drawing.Color.MistyRose;
            this.eventDetailsButton.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eventDetailsButton.Location = new System.Drawing.Point(723, 209);
            this.eventDetailsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventDetailsButton.Name = "eventDetailsButton";
            this.eventDetailsButton.Size = new System.Drawing.Size(125, 181);
            this.eventDetailsButton.TabIndex = 2;
            this.eventDetailsButton.Text = "Get More Details";
            this.eventDetailsButton.UseVisualStyleBackColor = false;
            this.eventDetailsButton.UseWaitCursor = true;
            this.eventDetailsButton.Click += new System.EventHandler(this.eventDetailsButton_Click);
            // 
            // eventsListBox
            // 
            this.eventsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 20;
            this.eventsListBox.Items.AddRange(new object[] {
            "Bei\'t Habad Meeting",
            "She Codes",
            "Amir Benayoun Poetry Night",
            "Careers Center Meeting"});
            this.eventsListBox.Location = new System.Drawing.Point(405, 209);
            this.eventsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(276, 164);
            this.eventsListBox.TabIndex = 0;
            this.eventsListBox.UseWaitCursor = true;
            // 
            // Form_secretaryAssociationEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.eventDetailsButton);
            this.Controls.Add(this.eventsLabel);
            this.Controls.Add(this.eventsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_secretaryAssociationEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Association Events";
            this.UseWaitCursor = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_secretaryAssociationEvents_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label eventsLabel;
        private System.Windows.Forms.Button eventDetailsButton;
        private System.Windows.Forms.ListBox eventsListBox;
    }
}