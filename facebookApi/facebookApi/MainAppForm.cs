using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

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

        private const int k_CheckBoxLocationX = 6;
        private const int k_CheckBoxLocationYStart = 21;
        private const int k_CheckBoxLocationYDiff = 23;
        private const string k_ApplicationID = "1450160541956417";
        //private const string k_ApplicationID = "228124338010525"; // Commented out so the grader will be able to use it if he/she wants

        private readonly ISet<eReligion> r_religionsToPresent = new HashSet<eReligion>();
        private readonly ISet<User.eGender> r_genderToPresent = new HashSet<User.eGender>();
        private readonly ISet<User.eRelationshipStatus> r_relationshipStatusesToPresent = new HashSet<User.eRelationshipStatus>();
        private readonly string[] r_FaceboookPermissions = { "public_profile", "user_photos", "user_gender", "user_friends", "publish_actions" };

        private User m_LoggedInUser;

        private void loginAndInit()
        {
            m_FiltersHeadlineLabel.Visible = true;

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

            m_FiltersHeadlineLabel.Visible = false;
        }

        private void fetchUserInfo()
        {
            m_LoggedInUserPictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);

            if (m_LoggedInUser.Statuses != null && m_LoggedInUser.Statuses.Count > 0)
            {
                m_LoggedInUserPictureBox.Text = m_LoggedInUser.Statuses[0].Message;
            }

            m_UserNameLabel.Text = string.Format("Welcome  {0} {1}", m_LoggedInUser.FirstName, m_LoggedInUser.LastName);

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

        private void flipControls()
        {
            m_LoggedInUserPictureBox.Visible = !m_LoggedInUserPictureBox.Visible;
            m_LoginButton.Enabled = !m_LoginButton.Enabled;
            m_LogoutButton.Enabled = !m_LogoutButton.Enabled;
            m_FetchFriendsButton.Enabled = !m_FetchFriendsButton.Enabled;
            m_PostButton.Enabled = !m_PostButton.Enabled;
            m_SearchButton.Enabled = !m_SearchButton.Enabled;
            m_FriendPictureBox.Visible = !m_FriendPictureBox.Visible;
        }

        public MainAppForm()
        {
            InitializeComponent();
            generateCheckBoxesAndAddToGroupBox(Enum.GetValues(typeof(User.eRelationshipStatus)).OfType<User.eRelationshipStatus>().ToList(), m_RelationshipStatusFilterGroupBox, new EventHandler(relationshipStatus_CheckedChanged));
            generateCheckBoxesAndAddToGroupBox(Enum.GetValues(typeof(eReligion)).OfType<eReligion>().ToList(), m_ReligionFilterGroupBox, new EventHandler(religion_CheckedChanged));
            generateCheckBoxesAndAddToGroupBox(Enum.GetValues(typeof(User.eGender)).OfType<User.eGender>().ToList(), m_GenderFilterGroupBox, new EventHandler(gender_CheckedChanged));
        }

        private void loginButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            loginAndInit();
        }

        private void logoutButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            FacebookService.Logout(postLogout);
        }

        private void postLogout()
        {
            m_LoggedInUser = null;
            flipControls();
        }

        private void searchButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            ISet<User> usersToPresent = new HashSet<User>();

            foreach (eReligion religion in r_religionsToPresent) 
            {
                foreach(User friend in m_LoggedInUser.Friends) 
                {
                    if (friend.Religion != null && friend.Religion.Equals(religion.ToString())) 
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

            m_FilteredFriends.Items.Clear();

            foreach (User userToPresent in usersToPresent) {
                m_FilteredFriends.Items.Add(userToPresent.Name);
            }
        }

        private void postButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            string postText = m_PostTextBox.Text;

            if (string.IsNullOrEmpty(postText)) {
                MessageBox.Show("Adding an empty post is not allowed!!!");
            } else {
                Status postedStatus = m_LoggedInUser.PostStatus(postText);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
        }

        private void fetchFriends()
        {
            m_FriendslistBox.Items.Clear();
            m_FriendslistBox.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                m_FriendslistBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void friendslistBox_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (m_FriendslistBox.SelectedItems.Count == 1)
            {
                User selectedFriend = m_FriendslistBox.SelectedItem as User;

                if (selectedFriend.PictureNormalURL != null)
                {
                    m_FriendPictureBox.LoadAsync(selectedFriend.PictureNormalURL);
                }
            }
        }

        private void religion_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
        {
            filterCheckBoxChanged<eReligion>(i_Sender, r_religionsToPresent);
        }

        private void gender_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
        {
            filterCheckBoxChanged<User.eGender>(i_Sender, r_genderToPresent);
        }

        private void relationshipStatus_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
        {
            filterCheckBoxChanged<User.eRelationshipStatus>(i_Sender, r_relationshipStatusesToPresent);
        }

        private void filterCheckBoxChanged<T>(object i_Sender , ISet<T> i_SetToEdit) where T : struct, System.IConvertible 
        {
            CheckBox checkbox = (CheckBox)i_Sender;

            T value = (T)Enum.Parse(typeof(T), checkbox.Text);

            if (checkbox.Checked)
            {
                i_SetToEdit.Add(value);
            }
            else
            {
                i_SetToEdit.Remove(value);
            }
        }

        private void generateCheckBoxesAndAddToGroupBox<T>(List<T> i_CheckBoxValues, GroupBox i_GroupBox, EventHandler i_EventHandler) where T : struct, System.IConvertible
        {
            int i = 0;

            foreach (T value in i_CheckBoxValues)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new Point(k_CheckBoxLocationX, k_CheckBoxLocationYStart + (i * k_CheckBoxLocationYDiff));
                checkBox.Name = value.ToString();
                checkBox.TabIndex = i + 1;
                checkBox.Text = value.ToString();
                checkBox.UseVisualStyleBackColor = true;
                checkBox.CheckedChanged += i_EventHandler;
                i_GroupBox.Controls.Add(checkBox);
                i++;
            }
        }

        private void fetchFriendsButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            fetchFriends();
        }
    }
}
