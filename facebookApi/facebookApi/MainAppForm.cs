using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace facebookApi
{
    public partial class MainAppForm : Form
    {
        public enum eReligion
        {
            Christian,
            Muslim,
            Jewish
        }

        // private const string k_ApplicationID = "228124338010525"; // Commented out so the grader will be able to use it if he/she wants
        private const string k_ApplicationID = "1450160541956417";

        private readonly ISet<eReligion> r_ReligionsToPresent = new HashSet<eReligion>();
        private readonly ISet<User.eGender> r_GenderToPresent = new HashSet<User.eGender>();
        private readonly ISet<User.eRelationshipStatus> r_RelationshipStatusesToPresent = new HashSet<User.eRelationshipStatus>();
        private readonly string[] r_FaceboookPermissions = { "public_profile", "user_photos", "user_gender", "user_friends", "publish_actions" };

        private User m_LoggedInUser;

        public MainAppForm()
        {
            InitializeComponent();
            Utils.GenerateCheckBoxesAndAddToGroupBox(Enum.GetValues(typeof(User.eRelationshipStatus)).OfType<User.eRelationshipStatus>().ToList(), m_RelationshipStatusFilterGroupBox, new EventHandler(relationshipStatus_CheckedChanged));
            Utils.GenerateCheckBoxesAndAddToGroupBox(Enum.GetValues(typeof(eReligion)).OfType<eReligion>().ToList(), m_ReligionFilterGroupBox, new EventHandler(religion_CheckedChanged));
            Utils.GenerateCheckBoxesAndAddToGroupBox(Enum.GetValues(typeof(User.eGender)).OfType<User.eGender>().ToList(), m_GenderFilterGroupBox, new EventHandler(gender_CheckedChanged));
        }

        private void loginAndInit()
        {
            try
            {
                LoginResult result = FacebookService.Login(k_ApplicationID, r_FaceboookPermissions);

                if (!string.IsNullOrEmpty(result.AccessToken))
                {
                    m_LoggedInUser = result.LoggedInUser;
                    fetchUserInfo();
                    flipControls();
                }
                else
                {
                    MessageBox.Show(string.Format("Error with login: \n{0}", result.ErrorMessage));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Error with login: \n{0}", e.Message));
            }
        }

        private void fetchUserInfo()
        {
            m_LoggedInUserPictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);

            if (m_LoggedInUser.Statuses != null && m_LoggedInUser.Statuses.Count > 0)
            {
                m_LoggedInUserPictureBox.Text = m_LoggedInUser.Statuses[0].Message;
            }

            m_UserNameLabel.Text = string.Format("{0} {1}", m_LoggedInUser.FirstName, m_LoggedInUser.LastName);
        }

        private void removeUserInfo()
        {
            m_LoggedInUserPictureBox.Image = null;
            m_LoggedInUserPictureBox.Text = null;
            m_UserNameLabel.Text = null;
        }

        private void removeFriendsInfo()
        {
            m_FriendsListBox.Items.Clear();
            m_FriendPictureBox.Image = null;
            m_FilteredFriends.Items.Clear();
        }

        private void flipControls()
        {
            m_LoginButton.Enabled = !m_LoginButton.Enabled;
            m_LogoutButton.Enabled = !m_LogoutButton.Enabled;
            m_FetchFriendsButton.Enabled = !m_FetchFriendsButton.Enabled;
            m_PostButton.Enabled = !m_PostButton.Enabled;
            m_SearchButton.Enabled = !m_SearchButton.Enabled;
        }

        private void postLogout()
        {
            // Workaround for a BUG in FacebookService.Logout which causes the callback to run twice
            if (m_LoggedInUser != null)
            {
                m_LoggedInUser = null;
                removeUserInfo();
                removeFriendsInfo();
                flipControls();
            }
        }

        private void searchFriends()
        {
            ISet<User> usersToPresent = new HashSet<User>();

            ISet<User> religionFilteredUsers = Utils.GetFilteredUsers<eReligion>(m_LoggedInUser.Friends, r_ReligionsToPresent, new ReligionUserFilterHelper());
            ISet<User> genderFilteredUsers = Utils.GetFilteredUsers<User.eGender>(m_LoggedInUser.Friends, r_GenderToPresent, new GenderUserFilterHelper());
            ISet<User> relationshipStatusFilteredUsers = Utils.GetFilteredUsers<User.eRelationshipStatus>(m_LoggedInUser.Friends, r_RelationshipStatusesToPresent, new RelationshipStatusUserFilterHelper());

            m_FilteredFriends.Items.Clear();

            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (religionFilteredUsers.Contains(friend) && genderFilteredUsers.Contains(friend) && relationshipStatusFilteredUsers.Contains(friend))
                {
                    m_FilteredFriends.Items.Add(friend.Name);
                }
            }
        }

        private void loadPost()
        {
            string postText = m_PostTextBox.Text;

            if (string.IsNullOrEmpty(postText))
            {
                MessageBox.Show("Adding an empty post is not allowed!!!");
            }
            else
            {
                Status postedStatus = m_LoggedInUser.PostStatus(postText);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
        }

        private void fetchFriends()
        {
            m_FriendsListBox.Items.Clear();
            m_FriendPictureBox.Image = null;
            m_FriendsListBox.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                m_FriendsListBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void displaySelectedFriend()
        {
            if (m_FriendsListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = m_FriendsListBox.SelectedItem as User;

                if (selectedFriend.PictureNormalURL != null)
                {
                    m_FriendPictureBox.LoadAsync(selectedFriend.PictureNormalURL);
                }
            }
        }

        #region UI Event Handlers

        private void loginButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            loginAndInit();
        }

        private void logoutButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            FacebookService.Logout(postLogout);
        }

        private void searchButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            searchFriends();
        }

        private void postButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            loadPost();
        }

        private void friendslistBox_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            displaySelectedFriend();
        }

        private void religion_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
        {
            Utils.CheckBoxChanged<eReligion>((CheckBox)i_Sender, r_ReligionsToPresent);
        }

        private void gender_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
        {
            Utils.CheckBoxChanged<User.eGender>((CheckBox)i_Sender, r_GenderToPresent);
        }

        private void relationshipStatus_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
        {
            Utils.CheckBoxChanged<User.eRelationshipStatus>((CheckBox)i_Sender, r_RelationshipStatusesToPresent);
        }

        private void fetchFriendsButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            fetchFriends();
        }

        #endregion
    }
}
