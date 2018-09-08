using System.Windows.Forms;
using System.ComponentModel;

namespace facebookApi
{
    public partial class MainAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer m_components = null;
        private Button m_LoginButton;
        private Button m_LogoutButton;
        private GroupBox m_UserDetailsBox;
        private PictureBox m_LoggedInUserPictureBox;
        private ListBox m_FilteredFriends;
        private Label m_FiltersHeadlineLabel;
        private Button m_SearchButton;
        private GroupBox m_RelationshipStatusFilterGroupBox;
        private GroupBox m_ReligionFilterGroupBox;
        private GroupBox m_GenderFilterGroupBox;
        private Label m_UserNameLabel;
        private BindingSource m_FriendsBindingSource;
        private PictureBox m_FriendPictureBox;
        private ListBox m_FriendsListBox;
        private Label m_ResultsLabel;
        private Label m_PostLabel;
        private TextBox m_PostTextBox;
        private Button m_PostButton;
        private Button m_FetchFriendsButton;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (m_components != null))
            {
                m_components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.m_LoginButton = new System.Windows.Forms.Button();
            this.m_LogoutButton = new System.Windows.Forms.Button();
            this.m_UserDetailsBox = new System.Windows.Forms.GroupBox();
            this.m_UserNameLabel = new System.Windows.Forms.Label();
            this.m_LoggedInUserPictureBox = new System.Windows.Forms.PictureBox();
            this.m_FilteredFriends = new System.Windows.Forms.ListBox();
            this.m_FiltersHeadlineLabel = new System.Windows.Forms.Label();
            this.m_SearchButton = new System.Windows.Forms.Button();
            this.m_RelationshipStatusFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.m_ReligionFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.m_GenderFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.m_FriendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_FriendPictureBox = new System.Windows.Forms.PictureBox();
            this.m_FriendsListBox = new System.Windows.Forms.ListBox();
            this.m_ResultsLabel = new System.Windows.Forms.Label();
            this.m_PostLabel = new System.Windows.Forms.Label();
            this.m_PostTextBox = new System.Windows.Forms.TextBox();
            this.m_PostButton = new System.Windows.Forms.Button();
            this.m_FetchFriendsButton = new System.Windows.Forms.Button();
            this.m_RunTypeComboBox = new System.Windows.Forms.ComboBox();
            this.m_UserDetailsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_LoggedInUserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_FriendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_FriendPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LoginButton
            // 
            this.m_LoginButton.AutoSize = true;
            this.m_LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_LoginButton.Location = new System.Drawing.Point(23, 26);
            this.m_LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_LoginButton.Name = "m_LoginButton";
            this.m_LoginButton.Size = new System.Drawing.Size(53, 27);
            this.m_LoginButton.TabIndex = 0;
            this.m_LoginButton.Text = "Login";
            this.m_LoginButton.UseVisualStyleBackColor = true;
            this.m_LoginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // m_LogoutButton
            // 
            this.m_LogoutButton.AutoSize = true;
            this.m_LogoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_LogoutButton.Enabled = false;
            this.m_LogoutButton.Location = new System.Drawing.Point(23, 61);
            this.m_LogoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_LogoutButton.Name = "m_LogoutButton";
            this.m_LogoutButton.Size = new System.Drawing.Size(62, 27);
            this.m_LogoutButton.TabIndex = 1;
            this.m_LogoutButton.Text = "Logout";
            this.m_LogoutButton.UseVisualStyleBackColor = true;
            this.m_LogoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // m_UserDetailsBox
            // 
            this.m_UserDetailsBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_UserDetailsBox.Controls.Add(this.m_UserNameLabel);
            this.m_UserDetailsBox.Controls.Add(this.m_LoggedInUserPictureBox);
            this.m_UserDetailsBox.Location = new System.Drawing.Point(150, 26);
            this.m_UserDetailsBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_UserDetailsBox.Name = "m_UserDetailsBox";
            this.m_UserDetailsBox.Padding = new System.Windows.Forms.Padding(4);
            this.m_UserDetailsBox.Size = new System.Drawing.Size(169, 218);
            this.m_UserDetailsBox.TabIndex = 10;
            this.m_UserDetailsBox.TabStop = false;
            this.m_UserDetailsBox.Text = "User Details";
            // 
            // m_UserNameLabel
            // 
            this.m_UserNameLabel.AutoSize = true;
            this.m_UserNameLabel.Location = new System.Drawing.Point(8, 52);
            this.m_UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_UserNameLabel.Name = "m_UserNameLabel";
            this.m_UserNameLabel.Size = new System.Drawing.Size(0, 17);
            this.m_UserNameLabel.TabIndex = 0;
            // 
            // m_LoggedInUserPictureBox
            // 
            this.m_LoggedInUserPictureBox.Location = new System.Drawing.Point(19, 71);
            this.m_LoggedInUserPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_LoggedInUserPictureBox.Name = "m_LoggedInUserPictureBox";
            this.m_LoggedInUserPictureBox.Size = new System.Drawing.Size(133, 134);
            this.m_LoggedInUserPictureBox.TabIndex = 1;
            this.m_LoggedInUserPictureBox.TabStop = false;
            // 
            // m_FilteredFriends
            // 
            this.m_FilteredFriends.FormattingEnabled = true;
            this.m_FilteredFriends.ItemHeight = 16;
            this.m_FilteredFriends.Location = new System.Drawing.Point(827, 455);
            this.m_FilteredFriends.Margin = new System.Windows.Forms.Padding(4);
            this.m_FilteredFriends.Name = "m_FilteredFriends";
            this.m_FilteredFriends.Size = new System.Drawing.Size(125, 196);
            this.m_FilteredFriends.TabIndex = 9;
            this.m_FilteredFriends.TabStop = false;
            // 
            // m_FiltersHeadlineLabel
            // 
            this.m_FiltersHeadlineLabel.AutoSize = true;
            this.m_FiltersHeadlineLabel.Location = new System.Drawing.Point(783, 26);
            this.m_FiltersHeadlineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_FiltersHeadlineLabel.Name = "m_FiltersHeadlineLabel";
            this.m_FiltersHeadlineLabel.Size = new System.Drawing.Size(155, 17);
            this.m_FiltersHeadlineLabel.TabIndex = 8;
            this.m_FiltersHeadlineLabel.Text = "Please select your filter";
            // 
            // m_SearchButton
            // 
            this.m_SearchButton.AutoSize = true;
            this.m_SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_SearchButton.Enabled = false;
            this.m_SearchButton.Location = new System.Drawing.Point(646, 320);
            this.m_SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_SearchButton.Name = "m_SearchButton";
            this.m_SearchButton.Size = new System.Drawing.Size(63, 27);
            this.m_SearchButton.TabIndex = 3;
            this.m_SearchButton.Text = "Search";
            this.m_SearchButton.UseVisualStyleBackColor = true;
            this.m_SearchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // m_RelationshipStatusFilterGroupBox
            // 
            this.m_RelationshipStatusFilterGroupBox.AutoSize = true;
            this.m_RelationshipStatusFilterGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_RelationshipStatusFilterGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_RelationshipStatusFilterGroupBox.Location = new System.Drawing.Point(827, 46);
            this.m_RelationshipStatusFilterGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_RelationshipStatusFilterGroupBox.MinimumSize = new System.Drawing.Size(180, 123);
            this.m_RelationshipStatusFilterGroupBox.Name = "m_RelationshipStatusFilterGroupBox";
            this.m_RelationshipStatusFilterGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.m_RelationshipStatusFilterGroupBox.Size = new System.Drawing.Size(180, 123);
            this.m_RelationshipStatusFilterGroupBox.TabIndex = 6;
            this.m_RelationshipStatusFilterGroupBox.TabStop = false;
            this.m_RelationshipStatusFilterGroupBox.Text = "Relationship Status Filter";
            // 
            // m_ReligionFilterGroupBox
            // 
            this.m_ReligionFilterGroupBox.AutoSize = true;
            this.m_ReligionFilterGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_ReligionFilterGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_ReligionFilterGroupBox.Location = new System.Drawing.Point(646, 46);
            this.m_ReligionFilterGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_ReligionFilterGroupBox.MinimumSize = new System.Drawing.Size(120, 123);
            this.m_ReligionFilterGroupBox.Name = "m_ReligionFilterGroupBox";
            this.m_ReligionFilterGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.m_ReligionFilterGroupBox.Size = new System.Drawing.Size(120, 123);
            this.m_ReligionFilterGroupBox.TabIndex = 5;
            this.m_ReligionFilterGroupBox.TabStop = false;
            this.m_ReligionFilterGroupBox.Text = "Religion Filter";
            // 
            // m_GenderFilterGroupBox
            // 
            this.m_GenderFilterGroupBox.AutoSize = true;
            this.m_GenderFilterGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_GenderFilterGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_GenderFilterGroupBox.Location = new System.Drawing.Point(646, 189);
            this.m_GenderFilterGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_GenderFilterGroupBox.MinimumSize = new System.Drawing.Size(120, 123);
            this.m_GenderFilterGroupBox.Name = "m_GenderFilterGroupBox";
            this.m_GenderFilterGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.m_GenderFilterGroupBox.Size = new System.Drawing.Size(120, 123);
            this.m_GenderFilterGroupBox.TabIndex = 7;
            this.m_GenderFilterGroupBox.TabStop = false;
            this.m_GenderFilterGroupBox.Text = "Gender Filter";
            // 
            // m_FriendPictureBox
            // 
            this.m_FriendPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_FriendPictureBox.Location = new System.Drawing.Point(486, 26);
            this.m_FriendPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_FriendPictureBox.Name = "m_FriendPictureBox";
            this.m_FriendPictureBox.Size = new System.Drawing.Size(140, 114);
            this.m_FriendPictureBox.TabIndex = 4;
            this.m_FriendPictureBox.TabStop = false;
            // 
            // m_FriendsListBox
            // 
            this.m_FriendsListBox.FormattingEnabled = true;
            this.m_FriendsListBox.ItemHeight = 16;
            this.m_FriendsListBox.Location = new System.Drawing.Point(341, 26);
            this.m_FriendsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_FriendsListBox.Name = "m_FriendsListBox";
            this.m_FriendsListBox.Size = new System.Drawing.Size(125, 180);
            this.m_FriendsListBox.TabIndex = 3;
            this.m_FriendsListBox.TabStop = false;
            this.m_FriendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendslistBox_SelectedIndexChanged);
            // 
            // m_ResultsLabel
            // 
            this.m_ResultsLabel.AutoSize = true;
            this.m_ResultsLabel.Location = new System.Drawing.Point(862, 431);
            this.m_ResultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_ResultsLabel.Name = "m_ResultsLabel";
            this.m_ResultsLabel.Size = new System.Drawing.Size(55, 17);
            this.m_ResultsLabel.TabIndex = 2;
            this.m_ResultsLabel.Text = "Results";
            // 
            // m_PostLabel
            // 
            this.m_PostLabel.AutoSize = true;
            this.m_PostLabel.Location = new System.Drawing.Point(150, 270);
            this.m_PostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_PostLabel.Name = "m_PostLabel";
            this.m_PostLabel.Size = new System.Drawing.Size(62, 17);
            this.m_PostLabel.TabIndex = 11;
            this.m_PostLabel.Text = "Post text";
            // 
            // m_PostTextBox
            // 
            this.m_PostTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_PostTextBox.Location = new System.Drawing.Point(150, 290);
            this.m_PostTextBox.Multiline = true;
            this.m_PostTextBox.Name = "m_PostTextBox";
            this.m_PostTextBox.Size = new System.Drawing.Size(300, 300);
            this.m_PostTextBox.TabIndex = 4;
            // 
            // m_PostButton
            // 
            this.m_PostButton.AutoSize = true;
            this.m_PostButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_PostButton.Enabled = false;
            this.m_PostButton.Location = new System.Drawing.Point(150, 600);
            this.m_PostButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_PostButton.Name = "m_PostButton";
            this.m_PostButton.Size = new System.Drawing.Size(46, 27);
            this.m_PostButton.TabIndex = 5;
            this.m_PostButton.Text = "Post";
            this.m_PostButton.UseVisualStyleBackColor = true;
            this.m_PostButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // m_FetchFriendsButton
            // 
            this.m_FetchFriendsButton.AutoSize = true;
            this.m_FetchFriendsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_FetchFriendsButton.Enabled = false;
            this.m_FetchFriendsButton.Location = new System.Drawing.Point(23, 96);
            this.m_FetchFriendsButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_FetchFriendsButton.Name = "m_FetchFriendsButton";
            this.m_FetchFriendsButton.Size = new System.Drawing.Size(104, 27);
            this.m_FetchFriendsButton.TabIndex = 2;
            this.m_FetchFriendsButton.Text = "Fetch Friends";
            this.m_FetchFriendsButton.UseVisualStyleBackColor = true;
            this.m_FetchFriendsButton.Click += new System.EventHandler(this.fetchFriendsButton_Click);
            // 
            // m_RunTypeComboBox
            // 
            this.m_RunTypeComboBox.FormattingEnabled = true;
            this.m_RunTypeComboBox.Location = new System.Drawing.Point(23, 143);
            this.m_RunTypeComboBox.Name = "runTypeComboBoxcomboBox";
            this.m_RunTypeComboBox.Size = new System.Drawing.Size(88, 24);
            this.m_RunTypeComboBox.TabIndex = 12;
            this.m_RunTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.runTypeComboBox_SelectedIndexChanged);
            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1052, 478);
            this.Controls.Add(this.m_RunTypeComboBox);
            this.Controls.Add(this.m_LoginButton);
            this.Controls.Add(this.m_LogoutButton);
            this.Controls.Add(this.m_ResultsLabel);
            this.Controls.Add(this.m_FriendsListBox);
            this.Controls.Add(this.m_FriendPictureBox);
            this.Controls.Add(this.m_ReligionFilterGroupBox);
            this.Controls.Add(this.m_RelationshipStatusFilterGroupBox);
            this.Controls.Add(this.m_GenderFilterGroupBox);
            this.Controls.Add(this.m_SearchButton);
            this.Controls.Add(this.m_FiltersHeadlineLabel);
            this.Controls.Add(this.m_FilteredFriends);
            this.Controls.Add(this.m_UserDetailsBox);
            this.Controls.Add(this.m_PostLabel);
            this.Controls.Add(this.m_PostTextBox);
            this.Controls.Add(this.m_PostButton);
            this.Controls.Add(this.m_FetchFriendsButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainAppForm";
            this.Text = "MainAppForm";
            this.m_UserDetailsBox.ResumeLayout(false);
            this.m_UserDetailsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_LoggedInUserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_FriendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_FriendPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IContainer components;
        private ComboBox m_RunTypeComboBox;
    }
}