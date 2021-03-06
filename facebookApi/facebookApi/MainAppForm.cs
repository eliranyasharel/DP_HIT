﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;
using static facebookApi.RunType;

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

        private IFacebookHandler m_FacebookHandler = FacebookHandlerFactory.Create(eRunType.Release);

        private string FullName
        {
            set
            {
                m_UserNameLabel.Text = value;
            }
        }

        private void runTypeChanged(eRunType i_RunType)
        {
            m_FacebookHandler = FacebookHandlerFactory.Create(i_RunType);
        }

        public MainAppForm()
        {
            InitializeComponent();

            Singleton<RunType>.Instance.SubscribeToRunTypeChanged(runTypeChanged);

            Utils.GenerateCheckBoxesAndAddToGroupBox(Enum.GetValues(typeof(User.eRelationshipStatus)).OfType<User.eRelationshipStatus>().ToList(), m_RelationshipStatusFilterGroupBox, new EventHandler(relationshipStatus_CheckedChanged));
            Utils.GenerateCheckBoxesAndAddToGroupBox(Enum.GetValues(typeof(eReligion)).OfType<eReligion>().ToList(), m_ReligionFilterGroupBox, new EventHandler(religion_CheckedChanged));
            Utils.GenerateCheckBoxesAndAddToGroupBox(Enum.GetValues(typeof(User.eGender)).OfType<User.eGender>().ToList(), m_GenderFilterGroupBox, new EventHandler(gender_CheckedChanged));

            foreach(eRunType runType in Enum.GetValues(typeof(eRunType)))
            {
                m_RunTypeComboBox.Items.Add(runType);
                m_RunTypeComboBox.SelectedIndex = 0;
            }
        }

        private void loginAndInit()
        {
            try
            {
                m_FacebookHandler.Login(k_ApplicationID, r_FaceboookPermissions);
                fillUserInfo();
                flipControls();
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Error with login: \n{0}", e.Message));
            }
        }

        private void fillUserInfo()
        {
            m_LoggedInUserPictureBox.LoadAsync(m_FacebookHandler.GetLoggedInUserPicture());

            List<Status> userStatuses = m_FacebookHandler.GetLoggedInUserStatuses();

            if (userStatuses != null && userStatuses.Count > 0)
            {
                m_LoggedInUserPictureBox.Text = userStatuses[0].Message;
            }

            FullName = string.Format("{0} {1}", m_FacebookHandler.GetLoggedInUserFirstName(), m_FacebookHandler.GetLoggedInUserLastName());
        }

        private void removeUserInfo()
        {
            m_LoggedInUserPictureBox.Image = null;
            m_LoggedInUserPictureBox.Text = null;
            FullName = null;
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

        private void logout()
        {
            m_FacebookHandler.Logout();
            removeUserInfo();
            removeFriendsInfo();
            flipControls();
        }

        private void searchFriends()
        {
            List<User> friends = m_FacebookHandler.FetchFriends();

            ISet<User> religionFilteredUsers = Utils.GetFilteredUsers<eReligion>(friends, r_ReligionsToPresent, (user, religion) => user.Religion.Equals(religion));
            ISet<User> genderFilteredUsers = Utils.GetFilteredUsers<User.eGender>(friends, r_GenderToPresent, (user, gender) => user.Gender.Equals(gender));
            ISet<User> relationshipStatusFilteredUsers = Utils.GetFilteredUsers<User.eRelationshipStatus>(friends, r_RelationshipStatusesToPresent, (user, relationshipStatus) => user.RelationshipStatus.Equals(relationshipStatus));

            m_FilteredFriends.Items.Clear();

            foreach (User friend in friends)
            {
                if (religionFilteredUsers.Contains(friend) && genderFilteredUsers.Contains(friend) && relationshipStatusFilteredUsers.Contains(friend))
                {
                    m_FilteredFriends.Items.Add(friend.Name);
                }
            }
        }

        private void loadPost()
        {
            try
            {
                Status postedStatus = m_FacebookHandler.LoadPost(m_PostTextBox.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void fetchFriends()
        {
            m_FriendsListBox.Items.Clear();
            m_FriendPictureBox.Image = null;
            m_FriendsListBox.DisplayMember = "Name";

            List<User> friends = m_FacebookHandler.FetchFriends();

            foreach (User friend in friends)
            {
                m_FriendsListBox.Items.Add(friend);
            }

            if (friends.Count == 0)
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
            logout();
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

        private void runTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Singleton<RunType>.Instance.RunTypeChanged((eRunType)m_RunTypeComboBox.SelectedItem);
        }

        #endregion
    }
}
