namespace Project_Team3.Menus___forms.AdminSubMenus
{
    partial class Form_adminAddGlobalMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.messageInputBox = new System.Windows.Forms.TextBox();
            this.addMessage = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.removeMessageLabel = new System.Windows.Forms.Label();
            this.globalMessageId_box = new System.Windows.Forms.TextBox();
            this.messageId_label = new System.Windows.Forms.Label();
            this.deleteMessageButton = new System.Windows.Forms.Button();
            this.showAllMessages_button = new System.Windows.Forms.Button();
            this.helpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input message that will be shown for all users in system ";
            // 
            // messageInputBox
            // 
            this.messageInputBox.Location = new System.Drawing.Point(34, 57);
            this.messageInputBox.Multiline = true;
            this.messageInputBox.Name = "messageInputBox";
            this.messageInputBox.Size = new System.Drawing.Size(509, 111);
            this.messageInputBox.TabIndex = 1;
            // 
            // addMessage
            // 
            this.addMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMessage.Location = new System.Drawing.Point(396, 185);
            this.addMessage.Name = "addMessage";
            this.addMessage.Size = new System.Drawing.Size(147, 23);
            this.addMessage.TabIndex = 2;
            this.addMessage.Text = "Add message";
            this.addMessage.UseVisualStyleBackColor = true;
            this.addMessage.Click += new System.EventHandler(this.addMessage_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.Location = new System.Drawing.Point(234, 389);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(147, 23);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Return back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // removeMessageLabel
            // 
            this.removeMessageLabel.AutoSize = true;
            this.removeMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeMessageLabel.Location = new System.Drawing.Point(30, 226);
            this.removeMessageLabel.Name = "removeMessageLabel";
            this.removeMessageLabel.Size = new System.Drawing.Size(369, 20);
            this.removeMessageLabel.TabIndex = 4;
            this.removeMessageLabel.Text = "To remove message, please inter it\'s ID in next field";
            // 
            // globalMessageId_box
            // 
            this.globalMessageId_box.Location = new System.Drawing.Point(126, 258);
            this.globalMessageId_box.Name = "globalMessageId_box";
            this.globalMessageId_box.Size = new System.Drawing.Size(100, 20);
            this.globalMessageId_box.TabIndex = 5;
            // 
            // messageId_label
            // 
            this.messageId_label.AutoSize = true;
            this.messageId_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageId_label.Location = new System.Drawing.Point(34, 261);
            this.messageId_label.Name = "messageId_label";
            this.messageId_label.Size = new System.Drawing.Size(90, 16);
            this.messageId_label.TabIndex = 6;
            this.messageId_label.Text = "Message ID : ";
            // 
            // deleteMessageButton
            // 
            this.deleteMessageButton.Location = new System.Drawing.Point(257, 256);
            this.deleteMessageButton.Name = "deleteMessageButton";
            this.deleteMessageButton.Size = new System.Drawing.Size(113, 23);
            this.deleteMessageButton.TabIndex = 7;
            this.deleteMessageButton.Text = "Delete Message";
            this.deleteMessageButton.UseVisualStyleBackColor = true;
            this.deleteMessageButton.Click += new System.EventHandler(this.deleteMessageButton_Click);
            // 
            // showAllMessages_button
            // 
            this.showAllMessages_button.Location = new System.Drawing.Point(344, 333);
            this.showAllMessages_button.Name = "showAllMessages_button";
            this.showAllMessages_button.Size = new System.Drawing.Size(110, 23);
            this.showAllMessages_button.TabIndex = 8;
            this.showAllMessages_button.Text = "Show All Messages";
            this.showAllMessages_button.UseVisualStyleBackColor = true;
            this.showAllMessages_button.Click += new System.EventHandler(this.showAllMessages_button_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpLabel.ForeColor = System.Drawing.Color.Green;
            this.helpLabel.Location = new System.Drawing.Point(30, 338);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(272, 16);
            this.helpLabel.TabIndex = 9;
            this.helpLabel.Text = "Want to see all Global Messages in system?";
            // 
            // Form_adminAddGlobalMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 435);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.showAllMessages_button);
            this.Controls.Add(this.deleteMessageButton);
            this.Controls.Add(this.messageId_label);
            this.Controls.Add(this.globalMessageId_box);
            this.Controls.Add(this.removeMessageLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addMessage);
            this.Controls.Add(this.messageInputBox);
            this.Controls.Add(this.label1);
            this.Name = "Form_adminAddGlobalMessage";
            this.Text = "Add new message to all users";
            this.Load += new System.EventHandler(this.Form_adminAddGlobalMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox messageInputBox;
        private System.Windows.Forms.Button addMessage;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label removeMessageLabel;
        private System.Windows.Forms.TextBox globalMessageId_box;
        private System.Windows.Forms.Label messageId_label;
        private System.Windows.Forms.Button deleteMessageButton;
        private System.Windows.Forms.Button showAllMessages_button;
        private System.Windows.Forms.Label helpLabel;
    }
}