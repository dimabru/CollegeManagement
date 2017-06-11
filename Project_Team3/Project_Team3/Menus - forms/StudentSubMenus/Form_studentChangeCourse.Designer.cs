namespace Project_Team3.Menus___forms.StudentSubMenus
{
    partial class Form_studentChangeCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_studentChangeCourse));
            this.back_button = new System.Windows.Forms.Button();
            this.showCoursesGrid = new System.Windows.Forms.DataGridView();
            this.request_change = new System.Windows.Forms.Button();
            this.header_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showCoursesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.MistyRose;
            this.back_button.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back_button.Location = new System.Drawing.Point(536, 529);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(157, 59);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Go Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // showCoursesGrid
            // 
            this.showCoursesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showCoursesGrid.Location = new System.Drawing.Point(237, 176);
            this.showCoursesGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showCoursesGrid.Name = "showCoursesGrid";
            this.showCoursesGrid.Size = new System.Drawing.Size(733, 321);
            this.showCoursesGrid.TabIndex = 1;
            // 
            // request_change
            // 
            this.request_change.BackColor = System.Drawing.Color.MistyRose;
            this.request_change.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.request_change.Location = new System.Drawing.Point(996, 191);
            this.request_change.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.request_change.Name = "request_change";
            this.request_change.Size = new System.Drawing.Size(197, 59);
            this.request_change.TabIndex = 2;
            this.request_change.Text = "Ask to change";
            this.request_change.UseVisualStyleBackColor = false;
            this.request_change.Click += new System.EventHandler(this.request_change_Click);
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label.Location = new System.Drawing.Point(236, 125);
            this.header_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(689, 24);
            this.header_label.TabIndex = 3;
            this.header_label.Text = "Choose course you want to change to and press \"Ask to change\" button";
            // 
            // Form_studentChangeCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 703);
            this.Controls.Add(this.header_label);
            this.Controls.Add(this.request_change);
            this.Controls.Add(this.showCoursesGrid);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_studentChangeCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_studentChangeCourse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_studentChangeCourse_FormClosed);
            this.Load += new System.EventHandler(this.Form_studentChangeCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showCoursesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataGridView showCoursesGrid;
        private System.Windows.Forms.Button request_change;
        private System.Windows.Forms.Label header_label;
    }
}