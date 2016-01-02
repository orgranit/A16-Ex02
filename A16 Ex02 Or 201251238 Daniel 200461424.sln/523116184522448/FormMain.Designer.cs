using System;

namespace _523116184522448
{
    public partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonEventsLocations = new System.Windows.Forms.Button();
            this.buttonEventsImages = new System.Windows.Forms.Button();
            this.userNameLabel1 = new System.Windows.Forms.Label();
            this.userProfilePicturePictureBox = new System.Windows.Forms.PictureBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.AllowDrop = true;
            this.buttonLogin.Location = new System.Drawing.Point(118, 171);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 100);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonEventsLocations
            // 
            this.buttonEventsLocations.Location = new System.Drawing.Point(12, 171);
            this.buttonEventsLocations.Name = "buttonEventsLocations";
            this.buttonEventsLocations.Size = new System.Drawing.Size(100, 100);
            this.buttonEventsLocations.TabIndex = 6;
            this.buttonEventsLocations.Text = "Events Location";
            this.buttonEventsLocations.UseVisualStyleBackColor = true;
            this.buttonEventsLocations.Click += new System.EventHandler(this.buttonEventLocations_Click);
            // 
            // buttonEventsImages
            // 
            this.buttonEventsImages.Location = new System.Drawing.Point(224, 171);
            this.buttonEventsImages.Name = "buttonEventsImages";
            this.buttonEventsImages.Size = new System.Drawing.Size(100, 100);
            this.buttonEventsImages.TabIndex = 7;
            this.buttonEventsImages.Text = "Events Images";
            this.buttonEventsImages.UseVisualStyleBackColor = true;
            this.buttonEventsImages.Click += new System.EventHandler(this.buttonEventImages_Click);
            // 
            // userNameLabel1
            // 
            this.userNameLabel1.Location = new System.Drawing.Point(12, 134);
            this.userNameLabel1.Name = "userNameLabel1";
            this.userNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.userNameLabel1.TabIndex = 9;
            // 
            // userProfilePicturePictureBox
            // 
            this.userProfilePicturePictureBox.Location = new System.Drawing.Point(12, 19);
            this.userProfilePicturePictureBox.Name = "userProfilePicturePictureBox";
            this.userProfilePicturePictureBox.Size = new System.Drawing.Size(100, 98);
            this.userProfilePicturePictureBox.TabIndex = 10;
            this.userProfilePicturePictureBox.TabStop = false;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(118, 120);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(206, 45);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // eventsListBox
            // 
            this.eventsListBox.DataSource = this.eventBindingSource;
            this.eventsListBox.DisplayMember = "Name";
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(118, 19);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(206, 95);
            this.eventsListBox.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 283);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.userProfilePicturePictureBox);
            this.Controls.Add(this.userNameLabel1);
            this.Controls.Add(this.buttonEventsImages);
            this.Controls.Add(this.buttonEventsLocations);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonEventsLocations;
        private System.Windows.Forms.Button buttonEventsImages;
        private System.Windows.Forms.Label userNameLabel1;
        private System.Windows.Forms.PictureBox userProfilePicturePictureBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ListBox eventsListBox;
    }
}
