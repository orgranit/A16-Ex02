using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _523116184522448
{
    public partial class EventImagesForm : Form
    {
        protected const int k_NumOfImages = 5;
        private FBUtilities m_Utils;

        public FBUtilities FBUtilities 
        {
            set { m_Utils = value; }
        }

        public EventImagesForm()
        {
            InitializeComponent();
        }

        // button 'buttonFetchEvents' clicked
        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchCollection(listBoxEvents, m_Utils.Events, "Name");
            Cursor.Current = Cursors.Default;
            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        // new selected item in 'listBoxEvents'
        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Utils.ResetEventSelectedPhoto();
            listBoxComments.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            displaySelectedEventImages();
            Cursor.Current = Cursors.Default;
        }

        // new selected item in 'listView' (which contains the photos)
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                listBoxComments.Items.Clear();
                int selectedIndex = listView.SelectedItems[0].ImageIndex;
                m_Utils.EventSelectedPhoto = selectedIndex;
                fetchCollection(listBoxComments, m_Utils.EventPhotoComments, "Message");
                if (listBoxComments.Items.Count == 0)
                {
                    MessageBox.Show("No comments to retrieve :(");
                }
            }         
        }

        // button 'buttonlikePhoto' clicked
        private void buttonlikePhto_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            likeSelectedPhoto();
            Cursor.Current = Cursors.Default;
        }

        // button 'buttonPostComment' clicked
        private void buttonPostComment_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            postCommentOnSelectedPhoto();
            if (m_Utils.HasEventSelectedPhoto)
            {
                fetchCollection(listBoxComments, m_Utils.EventPhotoComments, "Message");
            }
           
            Cursor.Current = Cursors.Default;
        }

        // post text from 'textBoxCommentPhoto' as a comment to 'm_SelectedPhoto'
        private void postCommentOnSelectedPhoto()
        {
            if (m_Utils.HasEventSelectedPhoto)
            {
                if (!string.IsNullOrEmpty(textBoxCommentPhoto.Text))
                {
                    if (m_Utils.CommentOnEventSelctedPhoto(textBoxCommentPhoto.Text))
                    {
                        MessageBox.Show("Comment Succeded!");
                        textBoxCommentPhoto.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Try again please.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a Photo!");
            }
        }

        // like 'm_SelectedPhoto'
        private void likeSelectedPhoto()
        {
            if (m_Utils.HasEventSelectedPhoto)
            {
                if (m_Utils.HasEventSelectedPhotoLikedByUser)
                {
                    MessageBox.Show("You already like this photo");
                }
                else if (m_Utils.LikeEventSelectedPhoto())
                {
                    MessageBox.Show("Liked!");
                }
            }
            else
            {
                MessageBox.Show("Select a Photo!");
            }
        }

        // adds up to 'k_NumOfImages' random images from 'listBoxEvents.SelectedItem' ('selectedEvent')
        // to  'imageListEventImages'
        private void displaySelectedEventImages()
        {
            // Clear Images
            imageListEventImages.Images.Clear();
            listView.Items.Clear();

            // the event location is usually a FB page if not we cant show any photos
            if (m_Utils.HasAlbumsEvent(listBoxEvents.SelectedItem))
            {
                m_Utils.GenerateRandomPhotosEvent(listBoxEvents.SelectedItem, k_NumOfImages);
                displayPhotos(m_Utils.EventPhotosNames, m_Utils.EventPhotosUrls);
            }

            if (imageListEventImages.Images.Count == 0)
            {
                MessageBox.Show("No photos to display.");
            }
        }

        private void displayPhotos(List<string> i_SelectedEventPhotosNames, List<string> i_SelectedEventPhotosUrl)
        {
            for (int i = 0; i < i_SelectedEventPhotosUrl.Count; i++)
            {
                imageListEventImages.Images.Add(loadImage(i_SelectedEventPhotosUrl[i]));
                listView.Items.Add(i_SelectedEventPhotosNames[i], i);
            }
        }

        private void fetchCollection(ListBox i_Listbox, IEnumerable<object> i_Collection, string i_MemberToDisplay)
        {
            i_Listbox.Items.Clear();
            i_Listbox.DisplayMember = i_MemberToDisplay;
            foreach (object obj in i_Collection)
            {
                i_Listbox.Items.Add(obj);
            }
        }

        private Image loadImage(string i_Url)
        {
            System.Net.WebRequest request = System.Net.WebRequest.Create(i_Url);
            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream = response.GetResponseStream();
            Bitmap bmp = new Bitmap(responseStream);

            responseStream.Dispose();

            return bmp;
        }
    }
}
