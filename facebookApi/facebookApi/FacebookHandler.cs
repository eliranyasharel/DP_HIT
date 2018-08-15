using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace facebookApi
{
    public class FacebookHandler : IFacebookHandler
    {
        private User m_LoggedInUser;

        private FacebookHandler()
        {
        }

        public void Login(string i_ApplicationID, string[] i_FaceboookPermissions)
        {
            LoginResult result = FacebookService.Login(i_ApplicationID, i_FaceboookPermissions);

            if (string.IsNullOrEmpty(result.AccessToken))
            {
                throw new Exception("Login to Facebook failed");
            }

            m_LoggedInUser = result.LoggedInUser;
        }

        public void Logout()
        {
            FacebookService.Logout(postLogout);
        }

        private void postLogout()
        {
            // Workaround for a BUG in FacebookService.Logout which causes the callback to run twice
            if (m_LoggedInUser != null)
            {
                m_LoggedInUser = null;
            }
        }

        public Status LoadPost(string i_PostText)
        {
            if (string.IsNullOrEmpty(i_PostText))
            {
                throw new Exception("Adding an empty post is not allowed!!!");
            }

            return m_LoggedInUser.PostStatus(i_PostText);
        }

        public List<User> FetchFriends()
        {
            List<Thread> fetchFriendsThreads = new List<Thread>();

            foreach (User friend in m_LoggedInUser.Friends)
            {
                fetchFriendsThreads.Add(new Thread(() =>
                {
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }));
            }

            foreach (Thread fetchFriendsThread in fetchFriendsThreads)
            {
                fetchFriendsThread.Start();
            }

            foreach (Thread fetchFriendsThread in fetchFriendsThreads)
            {
                fetchFriendsThread.Join();
            }

            return m_LoggedInUser.Friends.ToList<User>();
        }

        public string GetLoggedInUserPicture()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        public List<Status> GetLoggedInUserStatuses()
        {
            return m_LoggedInUser.Statuses.ToList<Status>();
        }

        public string GetLoggedInUserFirstName()
        {
            return m_LoggedInUser.FirstName;
        }

        public string GetLoggedInUserLastName()
        {
            return m_LoggedInUser.LastName;
        }
    }
}
