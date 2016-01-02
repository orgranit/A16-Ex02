using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using _EventFullyApp;

namespace _523116184522448
{
    public partial class EventImagesForm : Form
    {
        protected const int k_NumOfImages = 5;
        private FBAdapter m_FBAdapter;
        private ImageContinerFacade m_imageContainerFacade; 

        public FBAdapter FBUtilities
        {
            set { m_FBAdapter = value; }
        }

        public EventImagesForm()
        {
            InitializeComponent();
            m_imageContainerFacade = new ImageContinerFacade { ImageList = imageListEventImages, ListView = listView };
        }

        // button 'buttonFetchEvents' clicked
        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                m_FBAdapter.fetchCollectionAsync(listBoxEvents, m_FBAdapter.Events, "Name");
            }
           );
            thread.Start();

        }

        // new selected item in 'listBoxEvents'
        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_FBAdapter.ResetEventSelectedPhoto();
            listBoxComments.Items.Clear();
            displaySelectedEventImages();
        }

        // new selected item in 'listView' (which contains the photos)
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = m_imageContainerFacade.SelectedItemChanged();
            if (selectedIndex > 0)
            {
                listBoxComments.Items.Clear();
                m_FBAdapter.EventSelectedPhoto = selectedIndex;
                new Thread(
                    () => m_FBAdapter.fetchCollectionAsync(listBoxComments, m_FBAdapter.EventPhotoComments, "Message")
                    ).Start();
            }      
        }

        // button 'buttonlikePhoto' clicked
        private void buttonlikePhto_Click(object sender, EventArgs e)
        {
            new Thread(() => likeSelectedPhoto()).Start();
        }

        // button 'buttonPostComment' clicked
        private void buttonPostComment_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                postCommentOnSelectedPhoto();
                if (m_FBAdapter.HasEventSelectedPhoto)
                {
                    m_FBAdapter.fetchCollectionAsync(listBoxComments, m_FBAdapter.EventPhotoComments, "Message");
                }
            });
            thread.Start();
        }

        // post text from 'textBoxCommentPhoto' as a comment to 'm_SelectedPhoto'
        private void postCommentOnSelectedPhoto()
        {
            if (m_FBAdapter.HasEventSelectedPhoto)
            {
                if (!string.IsNullOrEmpty(textBoxCommentPhoto.Text))
                {
                    if (m_FBAdapter.CommentOnEventSelctedPhoto(textBoxCommentPhoto.Text))
                    {
                        MessageBox.Show("Comment Succeded!");
                        textBoxCommentPhoto.Invoke(new Action(() => textBoxCommentPhoto.Clear()));
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
            if (m_FBAdapter.HasEventSelectedPhoto)
            {
                if (m_FBAdapter.HasEventSelectedPhotoLikedByUser)
                {
                    MessageBox.Show("You already like this photo");
                }
                else if (m_FBAdapter.LikeEventSelectedPhoto())
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

            // the event location is usually a FB page if not we cant show any photos
            object selctedItem = listBoxEvents.SelectedItem;
            // Clear Old Images
            m_imageContainerFacade.ImagesClear();
            if (m_FBAdapter.HasAlbumsEvent(selctedItem))
            {
                Thread thread = new Thread(() =>
                {
                    m_FBAdapter.GenerateRandomPhotosEvent(selctedItem, k_NumOfImages);
                    displayPhotosAsync(m_FBAdapter.EventPhotosNames, m_FBAdapter.EventPhotosUrls);
                }
                );
                thread.Start();
            }
            else
            {
                m_imageContainerFacade.ImagesClear();
                MessageBox.Show("No items to display.");
            }
        }

        private void displayPhotosAsync(List<string> i_SelectedEventPhotosNames, List<string> i_SelectedEventPhotosUrl)
        {

            for (int i = 0; i < i_SelectedEventPhotosUrl.Count; i++)
            {
                // Add new Images
                m_imageContainerFacade.InvokeImagesAdd(loadImage(i_SelectedEventPhotosUrl[i]), i_SelectedEventPhotosNames[i], i);
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
