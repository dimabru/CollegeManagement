namespace Project_Team3.Menus___forms.AssociateSubMenus
{
    partial class Form_associateDefineNewEvent
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
            this.eventDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.createEventButton = new System.Windows.Forms.Button();
            this.clearNameButton = new System.Windows.Forms.Button();
            this.clearDescription = new System.Windows.Forms.Button();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventDescriptionLabel = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventDescriptionRichTextBox
            // 
            this.eventDescriptionRichTextBox.Location = new System.Drawing.Point(60, 106);
            this.eventDescriptionRichTextBox.Name = "eventDescriptionRichTextBox";
            this.eventDescriptionRichTextBox.Size = new System.Drawing.Size(116, 96);
            this.eventDescriptionRichTextBox.TabIndex = 0;
            this.eventDescriptionRichTextBox.Text = "";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(60, 42);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.eventNameTextBox.TabIndex = 1;
            // 
            // createEventButton
            // 
            this.createEventButton.Location = new System.Drawing.Point(60, 221);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(116, 23);
            this.createEventButton.TabIndex = 4;
            this.createEventButton.Text = "Create Event";
            this.createEventButton.UseVisualStyleBackColor = true;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // clearNameButton
            // 
            this.clearNameButton.BackColor = System.Drawing.Color.Red;
            this.clearNameButton.Location = new System.Drawing.Point(32, 42);
            this.clearNameButton.Name = "clearNameButton";
            this.clearNameButton.Size = new System.Drawing.Size(22, 21);
            this.clearNameButton.TabIndex = 5;
            this.clearNameButton.UseVisualStyleBackColor = false;
            this.clearNameButton.Click += new System.EventHandler(this.clearNameButton_Click);
            // 
            // clearDescription
            // 
            this.clearDescription.BackColor = System.Drawing.Color.Red;
            this.clearDescription.Location = new System.Drawing.Point(32, 106);
            this.clearDescription.Name = "clearDescription";
            this.clearDescription.Size = new System.Drawing.Size(22, 23);
            this.clearDescription.TabIndex = 6;
            this.clearDescription.UseVisualStyleBackColor = false;
            this.clearDescription.Click += new System.EventHandler(this.clearDescription_Click);
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(60, 23);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(69, 13);
            this.eventNameLabel.TabIndex = 8;
            this.eventNameLabel.Text = "Event Name:";
            // 
            // eventDescriptionLabel
            // 
            this.eventDescriptionLabel.AutoSize = true;
            this.eventDescriptionLabel.Location = new System.Drawing.Point(60, 90);
            this.eventDescriptionLabel.Name = "eventDescriptionLabel";
            this.eventDescriptionLabel.Size = new System.Drawing.Size(94, 13);
            this.eventDescriptionLabel.TabIndex = 9;
            this.eventDescriptionLabel.Text = "Event Description:";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(222, 42);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(85, 20);
            this.startTimePicker.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(219, 23);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(29, 13);
            this.startLabel.TabIndex = 12;
            this.startLabel.Text = "Start";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(219, 90);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(29, 13);
            this.endLabel.TabIndex = 13;
            this.endLabel.Text = "End:";
            // 
            // Form_associateDefineNewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.eventDescriptionLabel);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.clearDescription);
            this.Controls.Add(this.clearNameButton);
            this.Controls.Add(this.createEventButton);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.eventDescriptionRichTextBox);
            this.Name = "Form_associateDefineNewEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_associateDefineNewEvent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_associateDefineNewEvent_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox eventDescriptionRichTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.Button clearNameButton;
        private System.Windows.Forms.Button clearDescription;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label eventDescriptionLabel;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
    }
}