using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Facebook;

namespace _523116184522448
{
    public partial class MainForm : Form
    {
        private EventImagesForm m_ImagesFromEventsFrom;
        private EventLocationsForm m_EventLocationForm;
        private FBAdapter m_FBAdapter;

        public MainForm()
        {
            m_FBAdapter = FBAdapter.Instance;
            InitializeComponent();
            buttonEventsImages.Enabled = false;
            buttonEventsLocations.Enabled = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool isLoggedIn = false;
            isLoggedIn = m_FBAdapter.Login();
            if (isLoggedIn)
            {
                fetchUserInfo();
                buttonLogin.Enabled = false;
                buttonEventsImages.Enabled = true;
                buttonEventsLocations.Enabled = true;
            }
            else
            {
                MessageBox.Show(m_FBAdapter.LoggedInError());
            }
        }

        private void fetchUserInfo()
        {
            userProfilePicturePictureBox.LoadAsync(m_FBAdapter.UserPictureUrl());
            userNameLabel1.Text = m_FBAdapter.UserName;
            fetchEvents();
        }

        private void fetchEvents()
        {
            this.eventsLabel.Visible = true;
            this.eventsListBox.Visible = true;
            this.descriptionTextBox.Visible = true;
            this.descriptionTextBox.SelectionLength = 0;
            eventBindingSource.DataSource = m_FBAdapter.Events;
        }

        private void buttonEventLocations_Click(object sender, EventArgs e)
        {
            m_EventLocationForm = new EventLocationsForm();
            m_EventLocationForm.FBUtilities = m_FBAdapter;
            m_EventLocationForm.Show();
        }

        private void buttonEventImages_Click(object sender, EventArgs e)
        {
            m_ImagesFromEventsFrom = new EventImagesForm();
            m_ImagesFromEventsFrom.FBUtilities = m_FBAdapter;
            m_ImagesFromEventsFrom.Show();
        }
    }
}
