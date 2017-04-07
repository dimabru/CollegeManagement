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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_associateDefineNewEvent));
            this.eventDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.createEventButton = new System.Windows.Forms.Button();
            this.clearNameButton = new System.Windows.Forms.Button();
            this.clearDescription = new System.Windows.Forms.Button();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventDescriptionLabel = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.dayPickerListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // eventDescriptionRichTextBox
            // 
            this.eventDescriptionRichTextBox.Location = new System.Drawing.Point(477, 253);
            this.eventDescriptionRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventDescriptionRichTextBox.Name = "eventDescriptionRichTextBox";
            this.eventDescriptionRichTextBox.Size = new System.Drawing.Size(153, 117);
            this.eventDescriptionRichTextBox.TabIndex = 0;
            this.eventDescriptionRichTextBox.Text = "";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(477, 175);
            this.eventNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(153, 22);
            this.eventNameTextBox.TabIndex = 1;
            // 
            // createEventButton
            // 
            this.createEventButton.BackColor = System.Drawing.Color.MistyRose;
            this.createEventButton.Font = new System.Drawing.Font("David", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createEventButton.Location = new System.Drawing.Point(477, 395);
            this.createEventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(155, 28);
            this.createEventButton.TabIndex = 4;
            this.createEventButton.Text = "Create Event";
            this.createEventButton.UseVisualStyleBackColor = false;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // clearNameButton
            // 
            this.clearNameButton.BackColor = System.Drawing.Color.Bisque;
            this.clearNameButton.Location = new System.Drawing.Point(440, 175);
            this.clearNameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearNameButton.Name = "clearNameButton";
            this.clearNameButton.Size = new System.Drawing.Size(29, 26);
            this.clearNameButton.TabIndex = 5;
            this.clearNameButton.UseVisualStyleBackColor = false;
            this.clearNameButton.Click += new System.EventHandler(this.clearNameButton_Click);
            // 
            // clearDescription
            // 
            this.clearDescription.BackColor = System.Drawing.Color.Bisque;
            this.clearDescription.Location = new System.Drawing.Point(440, 253);
            this.clearDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearDescription.Name = "clearDescription";
            this.clearDescription.Size = new System.Drawing.Size(29, 28);
            this.clearDescription.TabIndex = 6;
            this.clearDescription.UseVisualStyleBackColor = false;
            this.clearDescription.Click += new System.EventHandler(this.clearDescription_Click);
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(477, 151);
            this.eventNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(89, 17);
            this.eventNameLabel.TabIndex = 8;
            this.eventNameLabel.Text = "Event Name:";
            // 
            // eventDescriptionLabel
            // 
            this.eventDescriptionLabel.AutoSize = true;
            this.eventDescriptionLabel.Location = new System.Drawing.Point(477, 234);
            this.eventDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventDescriptionLabel.Name = "eventDescriptionLabel";
            this.eventDescriptionLabel.Size = new System.Drawing.Size(123, 17);
            this.eventDescriptionLabel.TabIndex = 9;
            this.eventDescriptionLabel.Text = "Event Description:";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(693, 175);
            this.startTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(45, 22);
            this.startTimePicker.TabIndex = 10;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(796, 175);
            this.endTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(45, 22);
            this.endTimePicker.TabIndex = 11;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(689, 151);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(38, 17);
            this.startLabel.TabIndex = 12;
            this.startLabel.Text = "Start";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(800, 151);
            this.endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(37, 17);
            this.endLabel.TabIndex = 13;
            this.endLabel.Text = "End:";
            // 
            // dayPickerListBox
            // 
            this.dayPickerListBox.FormattingEnabled = true;
            this.dayPickerListBox.ItemHeight = 16;
            this.dayPickerListBox.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.dayPickerListBox.Location = new System.Drawing.Point(693, 234);
            this.dayPickerListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dayPickerListBox.Name = "dayPickerListBox";
            this.dayPickerListBox.Size = new System.Drawing.Size(85, 116);
            this.dayPickerListBox.TabIndex = 14;
            // 
            // Form_associateDefineNewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.dayPickerListBox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.eventDescriptionLabel);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.clearDescription);
            this.Controls.Add(this.clearNameButton);
            this.Controls.Add(this.createEventButton);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.eventDescriptionRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.ListBox dayPickerListBox;
    }
}