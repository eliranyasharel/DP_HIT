﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace facebookApi
{
    public class FacebookHandlerWithPopupProxy : IFacebookHandler
    {
        private IFacebookHandler m_FacebookHandler = Singleton<FacebookHandler>.Instance;

        public List<User> FetchFriends()
        {
            MessageBox.Show("About to fetch friends");
            return m_FacebookHandler.FetchFriends();
        }

        public string GetLoggedInUserFirstName()
        {
            MessageBox.Show("About to get logged in user first name");
            return m_FacebookHandler.GetLoggedInUserFirstName();
        }

        public string GetLoggedInUserLastName()
        {
            MessageBox.Show("About to get logged in user last name");
            return m_FacebookHandler.GetLoggedInUserLastName();
        }

        public string GetLoggedInUserPicture()
        {
            MessageBox.Show("About to get logged in user picture");
            return m_FacebookHandler.GetLoggedInUserPicture();
        }

        public List<Status> GetLoggedInUserStatuses()
        {
            MessageBox.Show("About to get logged in user statuses");
            return m_FacebookHandler.GetLoggedInUserStatuses();
        }

        public Status LoadPost(string i_PostText)
        {
            MessageBox.Show("About to load post " + i_PostText);
            return m_FacebookHandler.LoadPost(i_PostText);
        }

        public void Login(string i_ApplicationID, string[] i_FaceboookPermissions)
        {
            MessageBox.Show("About to login with app ID" + i_ApplicationID);
            m_FacebookHandler.Login(i_ApplicationID, i_FaceboookPermissions);
        }

        public void Logout()
        {
            MessageBox.Show("About to logout");
            m_FacebookHandler.Logout();
        }
    }
}