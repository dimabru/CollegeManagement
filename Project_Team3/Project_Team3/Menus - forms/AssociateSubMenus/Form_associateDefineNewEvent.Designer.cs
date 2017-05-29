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
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventDescriptionRichTextBox
            // 
            this.eventDescriptionRichTextBox.Location = new System.Drawing.Point(358, 206);
            this.eventDescriptionRichTextBox.Name = "eventDescriptionRichTextBox";
            this.eventDescriptionRichTextBox.Size = new System.Drawing.Size(116, 96);
            this.eventDescriptionRichTextBox.TabIndex = 0;
            this.eventDescriptionRichTextBox.Text = "";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(358, 142);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.eventNameTextBox.TabIndex = 1;
            // 
            // createEventButton
            // 
            this.createEventButton.BackColor = System.Drawing.Color.MistyRose;
            this.createEventButton.Font = new System.Drawing.Font("David", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createEventButton.Location = new System.Drawing.Point(358, 321);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(116, 23);
            this.createEventButton.TabIndex = 4;
            this.createEventButton.Text = "Create Event";
            this.createEventButton.UseVisualStyleBackColor = false;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // clearNameButton
            // 
            this.clearNameButton.BackColor = System.Drawing.Color.Bisque;
            this.clearNameButton.Location = new System.Drawing.Point(330, 142);
            this.clearNameButton.Name = "clearNameButton";
            this.clearNameButton.Size = new System.Drawing.Size(22, 21);
            this.clearNameButton.TabIndex = 5;
            this.clearNameButton.UseVisualStyleBackColor = false;
            this.clearNameButton.Click += new System.EventHandler(this.clearNameButton_Click);
            // 
            // clearDescription
            // 
            this.clearDescription.BackColor = System.Drawing.Color.Bisque;
            this.clearDescription.Location = new System.Drawing.Point(330, 206);
            this.clearDescription.Name = "clearDescription";
            this.clearDescription.Size = new System.Drawing.Size(22, 23);
            this.clearDescription.TabIndex = 6;
            this.clearDescription.UseVisualStyleBackColor = false;
            this.clearDescription.Click += new System.EventHandler(this.clearDescription_Click);
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(358, 123);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(69, 13);
            this.eventNameLabel.TabIndex = 8;
            this.eventNameLabel.Text = "Event Name:";
            // 
            // eventDescriptionLabel
            // 
            this.eventDescriptionLabel.AutoSize = true;
            this.eventDescriptionLabel.Location = new System.Drawing.Point(358, 190);
            this.eventDescriptionLabel.Name = "eventDescriptionLabel";
            this.eventDescriptionLabel.Size = new System.Drawing.Size(94, 13);
            this.eventDescriptionLabel.TabIndex = 9;
            this.eventDescriptionLabel.Text = "Event Description:";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(520, 142);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(35, 20);
            this.startTimePicker.TabIndex = 10;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(597, 142);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(35, 20);
            this.endTimePicker.TabIndex = 11;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(517, 123);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(29, 13);
            this.startLabel.TabIndex = 12;
            this.startLabel.Text = "Start";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(600, 123);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(29, 13);
            this.endLabel.TabIndex = 13;
            this.endLabel.Text = "End:";
            // 
            // dayPickerListBox
            // 
            this.dayPickerListBox.FormattingEnabled = true;
            this.dayPickerListBox.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.dayPickerListBox.Location = new System.Drawing.Point(520, 190);
            this.dayPickerListBox.Name = "dayPickerListBox";
            this.dayPickerListBox.Size = new System.Drawing.Size(65, 95);
            this.dayPickerListBox.TabIndex = 14;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(520, 321);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form_associateDefineNewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 609);
            this.Controls.Add(this.back);
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
        private System.Windows.Forms.Button back;


        public System.Windows.Forms.TextBox getEventName() { return this.eventNameTextBox; }
        public System.Windows.Forms.RichTextBox getEventDescription() { return this.eventDescriptionRichTextBox; }
        public System.Windows.Forms.DateTimePicker getStartTime() { return this.startTimePicker; }
        public System.Windows.Forms.DateTimePicker getEndTime() { return this.endTimePicker; }


    }
}