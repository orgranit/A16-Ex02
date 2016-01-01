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
        private FBUtilities m_utils;

        public MainForm()
        {
            m_utils = new FBUtilities();
            InitializeComponent();
            buttonEventsImages.Enabled = false;
            buttonEventsLocations.Enabled = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool isLoggedIn = false;
            isLoggedIn = m_utils.Login();
            if (isLoggedIn)
            {
                fetchUserInfo();
                buttonLogin.Enabled = false;
                buttonEventsImages.Enabled = true;
                buttonEventsLocations.Enabled = true;
            }
            else
            {
                MessageBox.Show(m_utils.LoggedInError());
            }
        }

        private void fetchUserInfo()
        {
            picture_profilePictureBox.LoadAsync(m_utils.UserPictureUrl());
        }

        private void buttonEventLocations_Click(object sender, EventArgs e)
        {
            m_EventLocationForm = new EventLocationsForm();
            m_EventLocationForm.FBUtilities = m_utils;
            m_EventLocationForm.Show();
        }

        private void buttonEventImages_Click(object sender, EventArgs e)
        {
            m_ImagesFromEventsFrom = new EventImagesForm();
            m_ImagesFromEventsFrom.FBUtilities = m_utils;
            m_ImagesFromEventsFrom.Show();
        }
    }
}
