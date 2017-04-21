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
            this.addMessage.Location = new System.Drawing.Point(395, 198);
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
            this.returnButton.Location = new System.Drawing.Point(395, 241);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(147, 23);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Return back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // Form_adminAddGlobalMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 435);
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
    }
}