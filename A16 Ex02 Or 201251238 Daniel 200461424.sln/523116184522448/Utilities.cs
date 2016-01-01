using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace _523116184522448
{
    public class Utilities
    {
        private User m_LoggedInUser;

        public Utilities(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }
    }
}
