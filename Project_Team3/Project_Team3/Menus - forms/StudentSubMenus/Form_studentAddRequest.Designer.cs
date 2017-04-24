namespace Project_Team3.Menus___forms.StudentSubMenus
{
    partial class Form_studentAddRequest
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
            this.messageLAbel = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.secretaryChooseList = new System.Windows.Forms.ComboBox();
            this.secretaryChooseLabel = new System.Windows.Forms.Label();
            this.sendRequest_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLAbel
            // 
            this.messageLAbel.AutoSize = true;
            this.messageLAbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLAbel.Location = new System.Drawing.Point(13, 22);
            this.messageLAbel.Name = "messageLAbel";
            this.messageLAbel.Size = new System.Drawing.Size(235, 24);
            this.messageLAbel.TabIndex = 0;
            this.messageLAbel.Text = "Send new student request ";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(17, 78);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(699, 187);
            this.messageBox.TabIndex = 1;
            // 
            // secretaryChooseList
            // 
            this.secretaryChooseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secretaryChooseList.FormattingEnabled = true;
            this.secretaryChooseList.Location = new System.Drawing.Point(115, 286);
            this.secretaryChooseList.Name = "secretaryChooseList";
            this.secretaryChooseList.Size = new System.Drawing.Size(218, 21);
            this.secretaryChooseList.TabIndex = 2;
            this.secretaryChooseList.SelectedIndexChanged += new System.EventHandler(this.secretaryChooseList_SelectedIndexChanged);
            // 
            // secretaryChooseLabel
            // 
            this.secretaryChooseLabel.AutoSize = true;
            this.secretaryChooseLabel.Location = new System.Drawing.Point(12, 289);
            this.secretaryChooseLabel.Name = "secretaryChooseLabel";
            this.secretaryChooseLabel.Size = new System.Drawing.Size(95, 13);
            this.secretaryChooseLabel.TabIndex = 3;
            this.secretaryChooseLabel.Text = "Choose secretary :";
            // 
            // sendRequest_button
            // 
            this.sendRequest_button.Location = new System.Drawing.Point(614, 287);
            this.sendRequest_button.Name = "sendRequest_button";
            this.sendRequest_button.Size = new System.Drawing.Size(102, 23);
            this.sendRequest_button.TabIndex = 4;
            this.sendRequest_button.Text = "Send request";
            this.sendRequest_button.UseVisualStyleBackColor = true;
            this.sendRequest_button.Click += new System.EventHandler(this.sendRequest_button_Click);
            // 
            // Form_studentAddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 349);
            this.Controls.Add(this.sendRequest_button);
            this.Controls.Add(this.secretaryChooseLabel);
            this.Controls.Add(this.secretaryChooseList);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.messageLAbel);
            this.Name = "Form_studentAddRequest";
            this.Text = "New student request form";
            this.Load += new System.EventHandler(this.Form_studentAddRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLAbel;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.ComboBox secretaryChooseList;
        private System.Windows.Forms.Label secretaryChooseLabel;
        private System.Windows.Forms.Button sendRequest_button;
    }
}