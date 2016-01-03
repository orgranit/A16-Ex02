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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label bioLabel;
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonEventsLocations = new System.Windows.Forms.Button();
            this.buttonEventsImages = new System.Windows.Forms.Button();
            this.userInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.userInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bioTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel1 = new System.Windows.Forms.Label();
            this.profilePitcturePictureBox = new System.Windows.Forms.PictureBox();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.postsLabel = new System.Windows.Forms.Label();
            bioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingNavigator)).BeginInit();
            this.userInfoBindingNavigator.SuspendLayout();
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
            // userInfoBindingNavigator
            // 
            this.userInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userInfoBindingNavigator.BindingSource = this.userInfoBindingSource;
            this.userInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userInfoBindingNavigatorSaveItem});
            this.userInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userInfoBindingNavigator.Name = "userInfoBindingNavigator";
            this.userInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userInfoBindingNavigator.Size = new System.Drawing.Size(335, 25);
            this.userInfoBindingNavigator.TabIndex = 8;
            this.userInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // userInfoBindingNavigatorSaveItem
            // 
            this.userInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userInfoBindingNavigatorSaveItem.Enabled = false;
            this.userInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userInfoBindingNavigatorSaveItem.Image")));
            this.userInfoBindingNavigatorSaveItem.Name = "userInfoBindingNavigatorSaveItem";
            this.userInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.userInfoBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // bioLabel
            // 
            bioLabel.AutoSize = true;
            bioLabel.Location = new System.Drawing.Point(9, 148);
            bioLabel.Name = "bioLabel";
            bioLabel.Size = new System.Drawing.Size(25, 13);
            bioLabel.TabIndex = 8;
            bioLabel.Text = "Bio:";
            // 
            // bioTextBox
            // 
            this.bioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInfoBindingSource, "Bio", true));
            this.bioTextBox.Location = new System.Drawing.Point(40, 148);
            this.bioTextBox.Multiline = true;
            this.bioTextBox.Name = "bioTextBox";
            this.bioTextBox.Size = new System.Drawing.Size(284, 17);
            this.bioTextBox.TabIndex = 9;
            // 
            // userNameLabel1
            // 
            this.userNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInfoBindingSource, "Name", true));
            this.userNameLabel1.Location = new System.Drawing.Point(12, 125);
            this.userNameLabel1.Name = "userNameLabel1";
            this.userNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.userNameLabel1.TabIndex = 11;
            // 
            // profilePitcturePictureBox
            // 
            this.profilePitcturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userInfoBindingSource, "ProfilePitcture", true));
            this.profilePitcturePictureBox.Location = new System.Drawing.Point(12, 28);
            this.profilePitcturePictureBox.Name = "profilePitcturePictureBox";
            this.profilePitcturePictureBox.Size = new System.Drawing.Size(100, 94);
            this.profilePitcturePictureBox.TabIndex = 13;
            this.profilePitcturePictureBox.TabStop = false;
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataSource = typeof(_523116184522448.UserInfo);
            // 
            // postsListBox
            // 
            this.postsListBox.DataSource = this.userInfoBindingSource;
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.Location = new System.Drawing.Point(118, 47);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(206, 95);
            this.postsListBox.TabIndex = 13;
            this.postsListBox.ValueMember = "Caption";
            // 
            // postsLabel
            // 
            this.postsLabel.AutoSize = true;
            this.postsLabel.Location = new System.Drawing.Point(118, 28);
            this.postsLabel.Name = "postsLabel";
            this.postsLabel.Size = new System.Drawing.Size(36, 13);
            this.postsLabel.TabIndex = 14;
            this.postsLabel.Text = "Posts:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 291);
            this.Controls.Add(this.postsLabel);
            this.Controls.Add(this.postsListBox);
            this.Controls.Add(bioLabel);
            this.Controls.Add(this.bioTextBox);
            this.Controls.Add(this.userNameLabel1);
            this.Controls.Add(this.profilePitcturePictureBox);
            this.Controls.Add(this.userInfoBindingNavigator);
            this.Controls.Add(this.buttonEventsImages);
            this.Controls.Add(this.buttonEventsLocations);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingNavigator)).EndInit();
            this.userInfoBindingNavigator.ResumeLayout(false);
            this.userInfoBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator userInfoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bioTextBox;
        private System.Windows.Forms.Label userNameLabel1;
        private System.Windows.Forms.PictureBox profilePitcturePictureBox;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.Label postsLabel;
    }
}
