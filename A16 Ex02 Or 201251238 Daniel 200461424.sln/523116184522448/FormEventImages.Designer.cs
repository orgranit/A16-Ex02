namespace _523116184522448
{
    public partial class EventImagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventImagesForm));
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listView = new System.Windows.Forms.ListView();
            this.imageListEventImages = new System.Windows.Forms.ImageList(this.components);
            this.labelEventImages = new System.Windows.Forms.Label();
            this.labelPhotosList = new System.Windows.Forms.Label();
            this.textBoxCommentPhoto = new System.Windows.Forms.TextBox();
            this.buttonPostComment = new System.Windows.Forms.Button();
            this.labelCommentPhoto = new System.Windows.Forms.Label();
            this.buttonlikePhto = new System.Windows.Forms.Button();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.labelListOfComments = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFetchEvents
            // 
            resources.ApplyResources(this.buttonFetchEvents, "buttonFetchEvents");
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxEvents, "listBoxEvents");
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // listView
            // 
            this.listView.LargeImageList = this.imageListEventImages;
            resources.ApplyResources(this.listView, "listView");
            this.listView.Name = "listView";
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // imageListEventImages
            // 
            this.imageListEventImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageListEventImages, "imageListEventImages");
            this.imageListEventImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelEventImages
            // 
            resources.ApplyResources(this.labelEventImages, "labelEventImages");
            this.labelEventImages.Name = "labelEventImages";
            // 
            // labelPhotosList
            // 
            resources.ApplyResources(this.labelPhotosList, "labelPhotosList");
            this.labelPhotosList.Name = "labelPhotosList";
            // 
            // textBoxCommentPhoto
            // 
            resources.ApplyResources(this.textBoxCommentPhoto, "textBoxCommentPhoto");
            this.textBoxCommentPhoto.Name = "textBoxCommentPhoto";
            // 
            // buttonPostComment
            // 
            resources.ApplyResources(this.buttonPostComment, "buttonPostComment");
            this.buttonPostComment.Name = "buttonPostComment";
            this.buttonPostComment.UseVisualStyleBackColor = true;
            this.buttonPostComment.Click += new System.EventHandler(this.buttonPostComment_Click);
            // 
            // labelCommentPhoto
            // 
            resources.ApplyResources(this.labelCommentPhoto, "labelCommentPhoto");
            this.labelCommentPhoto.Name = "labelCommentPhoto";
            // 
            // buttonlikePhto
            // 
            resources.ApplyResources(this.buttonlikePhto, "buttonlikePhto");
            this.buttonlikePhto.Name = "buttonlikePhto";
            this.buttonlikePhto.UseVisualStyleBackColor = true;
            this.buttonlikePhto.Click += new System.EventHandler(this.buttonlikePhto_Click);
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxComments, "listBoxComments");
            this.listBoxComments.Name = "listBoxComments";
            // 
            // labelListOfComments
            // 
            resources.ApplyResources(this.labelListOfComments, "labelListOfComments");
            this.labelListOfComments.Name = "labelListOfComments";
            // 
            // EventImagesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelListOfComments);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.buttonlikePhto);
            this.Controls.Add(this.labelCommentPhoto);
            this.Controls.Add(this.buttonPostComment);
            this.Controls.Add(this.textBoxCommentPhoto);
            this.Controls.Add(this.labelPhotosList);
            this.Controls.Add(this.labelEventImages);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonFetchEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EventImagesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageListEventImages;
        private System.Windows.Forms.Label labelEventImages;
        private System.Windows.Forms.Label labelPhotosList;
        private System.Windows.Forms.TextBox textBoxCommentPhoto;
        private System.Windows.Forms.Button buttonPostComment;
        private System.Windows.Forms.Label labelCommentPhoto;
        private System.Windows.Forms.Button buttonlikePhto;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label labelListOfComments;
    }
}