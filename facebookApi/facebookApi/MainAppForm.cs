using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections.Generic;
using System.Collections;

namespace facebookApi
{
    public partial class MainAppForm : Form 
    {
        public enum eReligion
        {
            Christian, Muslim, Jewish
        }

        private readonly ISet<eReligion> r_religionsToPresent = new HashSet<eReligion>();
        private readonly ISet<User.eGender> r_genderToPresent = new HashSet<User.eGender>();
        private readonly ISet<User.eRelationshipStatus> r_relationshipStatusesToPresent = new HashSet<User.eRelationshipStatus>();

        private User m_LoggedInUser;
        //private readonly string k_ApplicationID = "228124338010525";
        private readonly string k_ApplicationID = "1450160541956417";
        private readonly string[] r_FaceboookPermissions = {"public_profile", "user_photos", "user_gender", "user_friends" };

        private void loginAndInit()
        {
            this.m_filtersHeadlineLabel.Visible = true;

            try
            {
                User.eRelationshipStatus a = (User.eRelationshipStatus)m_LoggedInUser.RelationshipStatus;

                LoginResult result = FacebookService.Login(k_ApplicationID, r_FaceboookPermissions);

                if (!string.IsNullOrEmpty(result.AccessToken))
                {
                    this.m_LoggedInUser = result.LoggedInUser;
                    this.fetchUserInfo();
                    this.enableControls();
                    this.fetchFriends();
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

            this.m_filtersHeadlineLabel.Visible = false;
        }

        private void fetchUserInfo()
        {
            this.m_loggedInUserPictureBox.LoadAsync(this.m_LoggedInUser.PictureNormalURL);

            if (this.m_LoggedInUser.Statuses != null && this.m_LoggedInUser.Statuses.Count > 0)
            {
                this.m_loggedInUserPictureBox.Text = this.m_LoggedInUser.Statuses[0].Message;
            }

            this.m_userNameLabel.Text = string.Format("Welcome  {0} {1}", this.m_LoggedInUser.FirstName, this.m_LoggedInUser.LastName);
            this.enableControls();

        }

        private void displayAllFriends()
        {
            foreach (User friend in m_LoggedInUser.Friends)
            {
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void enableControls()
        {
            this.m_loggedInUserPictureBox.Visible = true;
            this.m_loginButton.Visible = false;
            this.m_friendPictureBox.Visible = true;
        }

        public MainAppForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.loginAndInit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ISet<User> usersToPresent = new HashSet<User>();

            foreach (eReligion religion in r_religionsToPresent) 
            {
                foreach(User friend in m_LoggedInUser.Friends) 
                {
                    if (friend.Religion.Equals(religion.ToString())) 
                    {
                        usersToPresent.Add(friend);
                    }
                }
            }

            foreach (User.eGender gender in r_genderToPresent)
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    if (friend.Gender.Equals(gender))
                    {
                        usersToPresent.Add(friend);
                    }
                }
            }

            foreach (User.eRelationshipStatus relationshipStatus in r_relationshipStatusesToPresent)
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    if (friend.RelationshipStatus.Equals(relationshipStatus))
                    {
                        usersToPresent.Add(friend);
                    }
                }
            }

            m_filteredFriends.Items.Clear();

            foreach (User userToPresent in usersToPresent) {
                m_filteredFriends.Items.Add(userToPresent.Name);
            }
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            m_friendslistBox.Items.Clear();
            m_friendslistBox.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                m_friendslistBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void friendslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (m_friendslistBox.SelectedItems.Count == 1)
            {
                User selectedFriend = m_friendslistBox.SelectedItem as User;

                if (selectedFriend.PictureNormalURL != null)
                {
                    m_friendPictureBox.LoadAsync(selectedFriend.PictureNormalURL);
                }
            }
        }

        private void religion_CheckedChanged(object sender, EventArgs e)
        {
            filterCheckBoxChanged<eReligion>(sender, r_religionsToPresent);
        }

        private void gender_CheckedChanged(object sender, EventArgs e)
        {
            filterCheckBoxChanged<User.eGender>(sender, r_genderToPresent);
        }

        private void relationshipStatus_CheckedChanged(object sender, EventArgs e)
        {
            filterCheckBoxChanged<User.eRelationshipStatus>(sender, r_relationshipStatusesToPresent);
        }

        private void filterCheckBoxChanged<T>(object sender , ISet<T> setToEdit)
        {
            CheckBox checkbox = (CheckBox)sender;

            T value = (T)Enum.Parse(typeof(T), checkbox.Text);

            if (checkbox.Checked)
            {
                setToEdit.Add(value);
            }
            else
            {
                setToEdit.Remove(value);
            }
        }
    }
}
