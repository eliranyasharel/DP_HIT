using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace facebookApi
{
    public interface IFacebookHandler
    {
        void Login(string i_ApplicationID, string[] i_FaceboookPermissions);

        void Logout();

        Status LoadPost(string i_PostText);

        List<User> FetchFriends();

        string GetLoggedInUserPicture();

        List<Status> GetLoggedInUserStatuses();

        string GetLoggedInUserFirstName();

        string GetLoggedInUserLastName();
    }
}