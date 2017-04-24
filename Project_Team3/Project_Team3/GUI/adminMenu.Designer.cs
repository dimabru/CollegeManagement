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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminMenu));
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
            this.amount_of_instructors_lable_const = new System.Windows.Forms.Label();
            this.amount_of_instructors_lable_dinamic = new System.Windows.Forms.Label();
            this.amount_of_professors_lable_const = new System.Windows.Forms.Label();
            this.amount_of_professors_lable_dinamic = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_access_group = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_add_new_user = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.amount_of_instructors_lable_dinamic);
            this.tabPage1.Controls.Add(this.amount_of_instructors_lable_const);
            this.tabPage1.Controls.Add(this.amount_of_professors_lable_dinamic);
            this.tabPage1.Controls.Add(this.numOfSecretaryLabelDinamic);
            this.tabPage1.Controls.Add(this.amount_of_professors_lable_const);
            this.tabPage1.Controls.Add(this.numOfSecretaryLabelConst);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "users details";
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // amount_of_instructors_lable_const
            // 
            this.amount_of_instructors_lable_const.AutoSize = true;
            this.amount_of_instructors_lable_const.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.amount_of_instructors_lable_const.Location = new System.Drawing.Point(7, 90);
            this.amount_of_instructors_lable_const.Name = "amount_of_instructors_lable_const";
            this.amount_of_instructors_lable_const.Size = new System.Drawing.Size(163, 20);
            this.amount_of_instructors_lable_const.TabIndex = 0;
            this.amount_of_instructors_lable_const.Text = "amount of instructors:";
            // 
            // amount_of_instructors_lable_dinamic
            // 
            this.amount_of_instructors_lable_dinamic.AutoSize = true;
            this.amount_of_instructors_lable_dinamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.amount_of_instructors_lable_dinamic.Location = new System.Drawing.Point(7, 115);
            this.amount_of_instructors_lable_dinamic.Name = "amount_of_instructors_lable_dinamic";
            this.amount_of_instructors_lable_dinamic.Size = new System.Drawing.Size(42, 20);
            this.amount_of_instructors_lable_dinamic.TabIndex = 0;
            this.amount_of_instructors_lable_dinamic.Text = "error";
            // 
            // amount_of_professors_lable_const
            // 
            this.amount_of_professors_lable_const.AutoSize = true;
            this.amount_of_professors_lable_const.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.amount_of_professors_lable_const.Location = new System.Drawing.Point(8, 147);
            this.amount_of_professors_lable_const.Name = "amount_of_professors_lable_const";
            this.amount_of_professors_lable_const.Size = new System.Drawing.Size(164, 20);
            this.amount_of_professors_lable_const.TabIndex = 0;
            this.amount_of_professors_lable_const.Text = "amount of professors:";
            // 
            // amount_of_professors_lable_dinamic
            // 
            this.amount_of_professors_lable_dinamic.AutoSize = true;
            this.amount_of_professors_lable_dinamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.amount_of_professors_lable_dinamic.Location = new System.Drawing.Point(8, 172);
            this.amount_of_professors_lable_dinamic.Name = "amount_of_professors_lable_dinamic";
            this.amount_of_professors_lable_dinamic.Size = new System.Drawing.Size(42, 20);
            this.amount_of_professors_lable_dinamic.TabIndex = 0;
            this.amount_of_professors_lable_dinamic.Text = "error";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.button_add_new_user);
            this.tabPage3.Controls.Add(this.textBox_password);
            this.tabPage3.Controls.Add(this.textBox_last_name);
            this.tabPage3.Controls.Add(this.textBox_id);
            this.tabPage3.Controls.Add(this.textBox_first_name);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.comboBox_access_group);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(713, 316);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "add user";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "first name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(33, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "last name:";
            // 
            // comboBox_access_group
            // 
            this.comboBox_access_group.FormattingEnabled = true;
            this.comboBox_access_group.Location = new System.Drawing.Point(37, 228);
            this.comboBox_access_group.Name = "comboBox_access_group";
            this.comboBox_access_group.Size = new System.Drawing.Size(189, 21);
            this.comboBox_access_group.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(33, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "access group:";
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Location = new System.Drawing.Point(37, 89);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(189, 20);
            this.textBox_first_name.TabIndex = 9;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Location = new System.Drawing.Point(37, 136);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(189, 20);
            this.textBox_last_name.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(33, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "id:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(37, 47);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(189, 20);
            this.textBox_id.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(33, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "password:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(37, 182);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(189, 20);
            this.textBox_password.TabIndex = 9;
            // 
            // button_add_new_user
            // 
            this.button_add_new_user.Location = new System.Drawing.Point(253, 47);
            this.button_add_new_user.Name = "button_add_new_user";
            this.button_add_new_user.Size = new System.Drawing.Size(147, 59);
            this.button_add_new_user.TabIndex = 12;
            this.button_add_new_user.Text = "add new user";
            this.button_add_new_user.UseVisualStyleBackColor = true;
            this.button_add_new_user.Click += new System.EventHandler(this.button_add_new_user_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(452, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label amount_of_instructors_lable_dinamic;
        private System.Windows.Forms.Label amount_of_instructors_lable_const;
        private System.Windows.Forms.Label amount_of_professors_lable_dinamic;
        private System.Windows.Forms.Label amount_of_professors_lable_const;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_access_group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_add_new_user;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}