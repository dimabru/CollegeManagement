namespace Project_Team3.GUI
{
    partial class adminMenu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.confPassTextBox = new System.Windows.Forms.TextBox();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.oldPassTextBox = new System.Windows.Forms.TextBox();
            this.changeMyPassbutton = new System.Windows.Forms.Button();
            this.lNameLable = new System.Windows.Forms.Label();
            this.UnameLable = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLable = new System.Windows.Forms.Label();
            this.numOfSecretaryLabelConst = new System.Windows.Forms.Label();
            this.numOfSecretaryLabelDinamic = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numOfSecretaryLabelDinamic);
            this.tabPage1.Controls.Add(this.numOfSecretaryLabelConst);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "users management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.confPassTextBox);
            this.tabPage2.Controls.Add(this.newPassTextBox);
            this.tabPage2.Controls.Add(this.oldPassTextBox);
            this.tabPage2.Controls.Add(this.changeMyPassbutton);
            this.tabPage2.Controls.Add(this.lNameLable);
            this.tabPage2.Controls.Add(this.UnameLable);
            this.tabPage2.Controls.Add(this.lastNameLabel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.nameLable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "account management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "about";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 374);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "log off";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // confPassTextBox
            // 
            this.confPassTextBox.Location = new System.Drawing.Point(479, 157);
            this.confPassTextBox.Name = "confPassTextBox";
            this.confPassTextBox.Size = new System.Drawing.Size(175, 20);
            this.confPassTextBox.TabIndex = 12;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(479, 99);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(175, 20);
            this.newPassTextBox.TabIndex = 13;
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.Location = new System.Drawing.Point(479, 43);
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.Size = new System.Drawing.Size(175, 20);
            this.oldPassTextBox.TabIndex = 14;
            // 
            // changeMyPassbutton
            // 
            this.changeMyPassbutton.Location = new System.Drawing.Point(289, 23);
            this.changeMyPassbutton.Name = "changeMyPassbutton";
            this.changeMyPassbutton.Size = new System.Drawing.Size(147, 59);
            this.changeMyPassbutton.TabIndex = 11;
            this.changeMyPassbutton.Text = "change My Password";
            this.changeMyPassbutton.UseVisualStyleBackColor = true;
            this.changeMyPassbutton.Click += new System.EventHandler(this.changeMyPassbutton_Click);
            // 
            // lNameLable
            // 
            this.lNameLable.AutoSize = true;
            this.lNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lNameLable.Location = new System.Drawing.Point(17, 111);
            this.lNameLable.Name = "lNameLable";
            this.lNameLable.Size = new System.Drawing.Size(51, 20);
            this.lNameLable.TabIndex = 9;
            this.lNameLable.Text = "label5";
            // 
            // UnameLable
            // 
            this.UnameLable.AutoSize = true;
            this.UnameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UnameLable.Location = new System.Drawing.Point(17, 38);
            this.UnameLable.Name = "UnameLable";
            this.UnameLable.Size = new System.Drawing.Size(51, 20);
            this.UnameLable.TabIndex = 10;
            this.UnameLable.Text = "label5";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastNameLabel.Location = new System.Drawing.Point(6, 76);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(119, 20);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "lastNameLabel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(475, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "confirm new password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(475, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "new password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(475, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "old password:";
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLable.Location = new System.Drawing.Point(6, 3);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(53, 20);
            this.nameLable.TabIndex = 8;
            this.nameLable.Text = "name:";
            // 
            // numOfSecretaryLabelConst
            // 
            this.numOfSecretaryLabelConst.AutoSize = true;
            this.numOfSecretaryLabelConst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numOfSecretaryLabelConst.Location = new System.Drawing.Point(7, 32);
            this.numOfSecretaryLabelConst.Name = "numOfSecretaryLabelConst";
            this.numOfSecretaryLabelConst.Size = new System.Drawing.Size(162, 20);
            this.numOfSecretaryLabelConst.TabIndex = 0;
            this.numOfSecretaryLabelConst.Text = "amount of secretarys:";
            // 
            // numOfSecretaryLabelDinamic
            // 
            this.numOfSecretaryLabelDinamic.AutoSize = true;
            this.numOfSecretaryLabelDinamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numOfSecretaryLabelDinamic.Location = new System.Drawing.Point(7, 57);
            this.numOfSecretaryLabelDinamic.Name = "numOfSecretaryLabelDinamic";
            this.numOfSecretaryLabelDinamic.Size = new System.Drawing.Size(42, 20);
            this.numOfSecretaryLabelDinamic.TabIndex = 0;
            this.numOfSecretaryLabelDinamic.Text = "error";
            // 
            // adminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "adminMenu";
            this.Text = "adminMenu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox confPassTextBox;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.TextBox oldPassTextBox;
        private System.Windows.Forms.Button changeMyPassbutton;
        private System.Windows.Forms.Label lNameLable;
        private System.Windows.Forms.Label UnameLable;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label numOfSecretaryLabelDinamic;
        private System.Windows.Forms.Label numOfSecretaryLabelConst;
    }
}