﻿namespace Project_Team3.Menus___forms.StudentSubMenus
{
    partial class Form_studentWatchEvents
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
            this.GoBackButton = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.EventsGridView = new System.Windows.Forms.DataGridView();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.RemoveEventButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GoBackButton.Location = new System.Drawing.Point(408, 472);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(173, 46);
            this.GoBackButton.TabIndex = 0;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Bold);
            this.Header_label.Location = new System.Drawing.Point(363, 49);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(242, 27);
            this.Header_label.TabIndex = 1;
            this.Header_label.Text = "Association Events:";
            // 
            // EventsGridView
            // 
            this.EventsGridView.AllowUserToAddRows = false;
            this.EventsGridView.AllowUserToDeleteRows = false;
            this.EventsGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EventsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsGridView.Location = new System.Drawing.Point(30, 105);
            this.EventsGridView.MultiSelect = false;
            this.EventsGridView.Name = "EventsGridView";
            this.EventsGridView.ReadOnly = true;
            this.EventsGridView.Size = new System.Drawing.Size(697, 315);
            this.EventsGridView.TabIndex = 2;
            this.EventsGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.EventsGridView_DataBindingComplete);
            // 
            // AddEventButton
            // 
            this.AddEventButton.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddEventButton.Location = new System.Drawing.Point(784, 174);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(173, 46);
            this.AddEventButton.TabIndex = 3;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // RemoveEventButton
            // 
            this.RemoveEventButton.Font = new System.Drawing.Font("David", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RemoveEventButton.Location = new System.Drawing.Point(784, 314);
            this.RemoveEventButton.Name = "RemoveEventButton";
            this.RemoveEventButton.Size = new System.Drawing.Size(173, 46);
            this.RemoveEventButton.TabIndex = 4;
            this.RemoveEventButton.Text = "Remove Event";
            this.RemoveEventButton.UseVisualStyleBackColor = true;
            this.RemoveEventButton.Click += new System.EventHandler(this.RemoveEventButton_Click);
            // 
            // Form_studentWatchEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 570);
            this.Controls.Add(this.RemoveEventButton);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.EventsGridView);
            this.Controls.Add(this.Header_label);
            this.Controls.Add(this.GoBackButton);
            this.Name = "Form_studentWatchEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Association Events Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_studentWatchEvents_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.EventsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.DataGridView EventsGridView;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Button RemoveEventButton;
    }
}