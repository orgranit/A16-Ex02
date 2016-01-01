using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace _523116184522448
{
    public class FBUtilities
    {
        private User m_LoggedInUser;
        private LoginResult m_result;
        private List<Photo> m_EventPhotos;
        private Photo m_EventSelectedPhoto;

        public FBUtilities()
        {
        }

        internal bool Login()
        {
            bool isLoggedIn = false;

            // Login
            m_result = FacebookService.Login(
                "523116184522448",
                "public_profile",
                "user_posts",
                "user_photos", 
                "user_events");

            // Verify input
            if (!string.IsNullOrEmpty(m_result.AccessToken))
            {
                isLoggedIn = true;
                m_LoggedInUser = m_result.LoggedInUser;
            }

            return isLoggedIn;
        }

        internal string LoggedInError()
        {
            return m_result.ErrorMessage;
        }

        internal string UserPictureUrl()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        public IEnumerable<Event> Events 
        {
            get { return m_LoggedInUser.Events; }     
        }

        internal bool HasAlbumsEvent(object i_Event)
        {
            bool hasAlbums = false;
            Event selectedEvent = i_Event as Event;
            Page location = selectedEvent.Place;
            FacebookObjectCollection<Album> locationAlbums;

            if (location != null)
            {
                try
                {
                    locationAlbums = location.Albums;
                    if (locationAlbums != null)
                    {
                        hasAlbums = locationAlbums.Count > 0;
                    }
                }
                catch (Facebook.FacebookApiException)
                {
                    // in some pages when trying to get to their albums facebook api throws an exception
                }
            }

            return hasAlbums;
        }

        internal void GenerateRandomPhotosEvent(object i_Event, int i_NumOfImages)
        {
            Event selectedEvent = i_Event as Event;
            FacebookObjectCollection<Album> locationAlbums = selectedEvent.Place.Albums;
            m_EventPhotos = new List<Photo>();

            for (int i = 0; i < i_NumOfImages; i++)
            {
                Random rnd = new Random();
                int albumNum = rnd.Next(locationAlbums.Count);
                if (locationAlbums[albumNum].Count > 0)
                {
                    int photoNum = rnd.Next(locationAlbums[albumNum].Photos.Count);
                    Photo selectedPhoto = locationAlbums[albumNum].Photos[photoNum];
                    m_EventPhotos.Add(selectedPhoto);
                }

                m_EventPhotos = m_EventPhotos.Distinct().ToList();
            }
        }

        public List<string> EventPhotosNames 
        { 
            get 
            { 
                List<string> names = new List<string>();
                foreach (Photo photo in m_EventPhotos)
                {
                    names.Add(photo.Name);
                }

                return names;
            } 
        }

        public List<string> EventPhotosUrls
        {
            get
            {
                List<string> urls = new List<string>();
                foreach (Photo photo in m_EventPhotos)
                {
                    urls.Add(photo.PictureNormalURL);
                }

                return urls;
            }
        }

        public object EventSelectedPhoto 
        { 
            set 
            {
                m_EventSelectedPhoto = m_EventPhotos[(int) value];
            } 
        }

        public IEnumerable<object> EventPhotoComments 
        { 
            get 
            { 
                return m_EventSelectedPhoto.Comments; 
            } 
        }

        internal void ResetEventSelectedPhoto()
        {
            m_EventSelectedPhoto = null;
        }

        public bool HasEventSelectedPhoto 
        { 
            get 
            { 
                return m_EventSelectedPhoto != null; 
            } 
        }

        internal bool CommentOnEventSelctedPhoto(string i_Comment)
        {
            Comment comment = m_EventSelectedPhoto.Comment(i_Comment);
            return comment != null;
        }

        public bool HasEventSelectedPhotoLikedByUser 
        { 
            get 
            { 
                return m_EventSelectedPhoto.LikedBy.Contains(m_LoggedInUser); 
            } 
        }

        internal bool LikeEventSelectedPhoto()
        {
            return m_EventSelectedPhoto.Like();
        }

        internal bool HasLocationEvent(object i_Event)
        {
            Event selectedEvent = i_Event as Event;
            Page page = selectedEvent.Place;

            if (page != null) 
            {
                return page.Location != null;
            }
            else
            {
                return false;
            }
        }

        internal PointD GetLatLong(object i_Event)
        {
            PointD point = new PointD();
            Event selectedEvent = i_Event as Event;
            Location location = selectedEvent.Place.Location;
            if (location != null)
            {
                point.X = location.Latitude.Value;
                point.Y = location.Longitude.Value;
            }

            return point;            
        }

        internal string GetEventName(object i_Event)
        {
            Event selectedEvent = i_Event as Event;
            return selectedEvent.Name;
        }
    }

    public struct PointD
    {
        public double X;
        public double Y;
    }
}
