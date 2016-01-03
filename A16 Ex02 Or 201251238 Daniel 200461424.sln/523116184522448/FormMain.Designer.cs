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
            this.bioTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel1 = new System.Windows.Forms.Label();
            this.profilePitcturePictureBox = new System.Windows.Forms.PictureBox();
            this.bioLabel = new System.Windows.Forms.Label();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.profilePitcturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
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
            // bioTextBox
            // 
            this.bioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInfoBindingSource, "Bio", true));
            this.bioTextBox.Location = new System.Drawing.Point(15, 135);
            this.bioTextBox.Multiline = true;
            this.bioTextBox.Name = "bioTextBox";
            this.bioTextBox.Size = new System.Drawing.Size(309, 30);
            this.bioTextBox.TabIndex = 9;
            this.bioTextBox.Visible = false;
            // 
            // userNameLabel1
            // 
            this.userNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInfoBindingSource, "Name", true));
            this.userNameLabel1.Location = new System.Drawing.Point(118, 109);
            this.userNameLabel1.Name = "userNameLabel1";
            this.userNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.userNameLabel1.TabIndex = 11;
            // 
            // profilePitcturePictureBox
            // 
            this.profilePitcturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userInfoBindingSource, "ProfilePitcture", true));
            this.profilePitcturePictureBox.Location = new System.Drawing.Point(118, 12);
            this.profilePitcturePictureBox.Name = "profilePitcturePictureBox";
            this.profilePitcturePictureBox.Size = new System.Drawing.Size(100, 94);
            this.profilePitcturePictureBox.TabIndex = 13;
            this.profilePitcturePictureBox.TabStop = false;
            // 
            // bioLabel
            // 
            this.bioLabel.Location = new System.Drawing.Point(12, 114);
            this.bioLabel.Name = "bioLabel";
            this.bioLabel.Size = new System.Drawing.Size(65, 18);
            this.bioLabel.TabIndex = 14;
            this.bioLabel.Text = "Bio:";
            this.bioLabel.Visible = false;
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataSource = typeof(_523116184522448.UserInfo);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 291);
            this.Controls.Add(this.bioLabel);
            this.Controls.Add(this.bioTextBox);
            this.Controls.Add(this.userNameLabel1);
            this.Controls.Add(this.profilePitcturePictureBox);
            this.Controls.Add(this.buttonEventsImages);
            this.Controls.Add(this.buttonEventsLocations);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.profilePitcturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonEventsLocations;
        private System.Windows.Forms.Button buttonEventsImages;
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private System.Windows.Forms.TextBox bioTextBox;
        private System.Windows.Forms.Label userNameLabel1;
        private System.Windows.Forms.PictureBox profilePitcturePictureBox;
        private System.Windows.Forms.Label bioLabel;
    }
}
