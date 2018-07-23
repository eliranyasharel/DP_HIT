using System.Windows.Forms;
using System.ComponentModel;

using System.Linq;

namespace facebookApi
{
    partial class MainAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer m_components = null;

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
            this.m_loginButton = new System.Windows.Forms.Button();
            this.m_logoutButton = new System.Windows.Forms.Button();
            this.m_userDetailsBox = new System.Windows.Forms.GroupBox();
            this.m_userNameLabel = new System.Windows.Forms.Label();
            this.m_loggedInUserPictureBox = new System.Windows.Forms.PictureBox();
            this.m_filteredFriends = new System.Windows.Forms.ListBox();
            this.m_filtersHeadlineLabel = new System.Windows.Forms.Label();
            this.m_searchButton = new System.Windows.Forms.Button();
            this.m_relationshipStatusFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.m_religionFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.m_genderFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.m_friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_friendPictureBox = new System.Windows.Forms.PictureBox();
            this.m_friendslistBox = new System.Windows.Forms.ListBox();
            this.m_resultsLabel = new System.Windows.Forms.Label();
            this.m_postLabel = new System.Windows.Forms.Label();
            this.m_postTextBox = new System.Windows.Forms.TextBox();
            this.m_postButton = new System.Windows.Forms.Button();
            this.m_userDetailsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_loggedInUserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_friendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_friendPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_loginButton
            // 
            this.m_loginButton.AutoSize = true;
            this.m_loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_loginButton.Location = new System.Drawing.Point(23, 26);
            this.m_loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_loginButton.Name = "m_loginButton";
            this.m_loginButton.Size = new System.Drawing.Size(53, 27);
            this.m_loginButton.TabIndex = 0;
            this.m_loginButton.Text = "Login";
            this.m_loginButton.UseVisualStyleBackColor = true;
            this.m_loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // m_logoutButton
            // 
            this.m_logoutButton.AutoSize = true;
            this.m_logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_logoutButton.Enabled = false;
            this.m_logoutButton.Location = new System.Drawing.Point(23, 61);
            this.m_logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_logoutButton.Name = "m_logoutButton";
            this.m_logoutButton.Size = new System.Drawing.Size(62, 27);
            this.m_logoutButton.TabIndex = 0;
            this.m_logoutButton.Text = "Logout";
            this.m_logoutButton.UseVisualStyleBackColor = true;
            this.m_logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // m_userDetailsBox
            // 
            this.m_userDetailsBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_userDetailsBox.Controls.Add(this.m_userNameLabel);
            this.m_userDetailsBox.Controls.Add(this.m_loggedInUserPictureBox);
            this.m_userDetailsBox.Location = new System.Drawing.Point(95, 26);
            this.m_userDetailsBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_userDetailsBox.Name = "m_userDetailsBox";
            this.m_userDetailsBox.Padding = new System.Windows.Forms.Padding(4);
            this.m_userDetailsBox.Size = new System.Drawing.Size(169, 218);
            this.m_userDetailsBox.TabIndex = 1;
            this.m_userDetailsBox.TabStop = false;
            this.m_userDetailsBox.Text = "User Details";
            // 
            // m_userNameLabel
            // 
            this.m_userNameLabel.AutoSize = true;
            this.m_userNameLabel.Location = new System.Drawing.Point(8, 52);
            this.m_userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_userNameLabel.Name = "m_userNameLabel";
            this.m_userNameLabel.Size = new System.Drawing.Size(79, 17);
            this.m_userNameLabel.TabIndex = 2;
            this.m_userNameLabel.Text = "User Name";
            // 
            // m_loggedInUserPictureBox
            // 
            this.m_loggedInUserPictureBox.Location = new System.Drawing.Point(19, 71);
            this.m_loggedInUserPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_loggedInUserPictureBox.Name = "m_loggedInUserPictureBox";
            this.m_loggedInUserPictureBox.Size = new System.Drawing.Size(133, 134);
            this.m_loggedInUserPictureBox.TabIndex = 1;
            this.m_loggedInUserPictureBox.TabStop = false;
            // 
            // m_filteredFriends
            // 
            this.m_filteredFriends.FormattingEnabled = true;
            this.m_filteredFriends.ItemHeight = 16;
            this.m_filteredFriends.Location = new System.Drawing.Point(747, 455);
            this.m_filteredFriends.Margin = new System.Windows.Forms.Padding(4);
            this.m_filteredFriends.Name = "m_filteredFriends";
            this.m_filteredFriends.Size = new System.Drawing.Size(125, 196);
            this.m_filteredFriends.TabIndex = 2;
            // 
            // m_filtersHeadlineLabel
            // 
            this.m_filtersHeadlineLabel.AutoSize = true;
            this.m_filtersHeadlineLabel.Location = new System.Drawing.Point(643, 26);
            this.m_filtersHeadlineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_filtersHeadlineLabel.Name = "m_filtersHeadlineLabel";
            this.m_filtersHeadlineLabel.Size = new System.Drawing.Size(155, 17);
            this.m_filtersHeadlineLabel.TabIndex = 3;
            this.m_filtersHeadlineLabel.Text = "Please select your filter";
            // 
            // m_searchButton
            // 
            this.m_searchButton.AutoSize = true;
            this.m_searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_searchButton.Location = new System.Drawing.Point(606, 320);
            this.m_searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_searchButton.Name = "m_searchButton";
            this.m_searchButton.Size = new System.Drawing.Size(63, 27);
            this.m_searchButton.TabIndex = 6;
            this.m_searchButton.Text = "Search";
            this.m_searchButton.UseVisualStyleBackColor = true;
            this.m_searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // m_relationshipStatusFilterGroupBox
            // 
            this.m_relationshipStatusFilterGroupBox.AutoSize = true;
            this.m_relationshipStatusFilterGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_relationshipStatusFilterGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_relationshipStatusFilterGroupBox.Location = new System.Drawing.Point(747, 46);
            this.m_relationshipStatusFilterGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_relationshipStatusFilterGroupBox.MinimumSize = new System.Drawing.Size(180, 123);
            this.m_relationshipStatusFilterGroupBox.Name = "m_relationshipStatusFilterGroupBox";
            this.m_relationshipStatusFilterGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.m_relationshipStatusFilterGroupBox.Size = new System.Drawing.Size(180, 123);
            this.m_relationshipStatusFilterGroupBox.TabIndex = 11;
            this.m_relationshipStatusFilterGroupBox.TabStop = false;
            this.m_relationshipStatusFilterGroupBox.Text = "Relationship Status Filter";
            // 
            // m_religionFilterGroupBox
            // 
            this.m_religionFilterGroupBox.AutoSize = true;
            this.m_religionFilterGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_religionFilterGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_religionFilterGroupBox.Location = new System.Drawing.Point(606, 46);
            this.m_religionFilterGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_religionFilterGroupBox.MinimumSize = new System.Drawing.Size(120, 123);
            this.m_religionFilterGroupBox.Name = "m_religionFilterGroupBox";
            this.m_religionFilterGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.m_religionFilterGroupBox.Size = new System.Drawing.Size(120, 123);
            this.m_religionFilterGroupBox.TabIndex = 12;
            this.m_religionFilterGroupBox.TabStop = false;
            this.m_religionFilterGroupBox.Text = "Religion Filter";
            // 
            // m_genderFilterGroupBox
            // 
            this.m_genderFilterGroupBox.AutoSize = true;
            this.m_genderFilterGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_genderFilterGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_genderFilterGroupBox.Location = new System.Drawing.Point(606, 189);
            this.m_genderFilterGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_genderFilterGroupBox.MinimumSize = new System.Drawing.Size(120, 123);
            this.m_genderFilterGroupBox.Name = "m_genderFilterGroupBox";
            this.m_genderFilterGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.m_genderFilterGroupBox.Size = new System.Drawing.Size(120, 123);
            this.m_genderFilterGroupBox.TabIndex = 13;
            this.m_genderFilterGroupBox.TabStop = false;
            this.m_genderFilterGroupBox.Text = "Gender Filter";
            // 
            // m_friendPictureBox
            // 
            this.m_friendPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_friendPictureBox.Location = new System.Drawing.Point(446, 26);
            this.m_friendPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_friendPictureBox.Name = "m_friendPictureBox";
            this.m_friendPictureBox.Size = new System.Drawing.Size(140, 114);
            this.m_friendPictureBox.TabIndex = 15;
            this.m_friendPictureBox.TabStop = false;
            // 
            // m_friendslistBox
            // 
            this.m_friendslistBox.FormattingEnabled = true;
            this.m_friendslistBox.ItemHeight = 16;
            this.m_friendslistBox.Location = new System.Drawing.Point(301, 26);
            this.m_friendslistBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_friendslistBox.Name = "m_friendslistBox";
            this.m_friendslistBox.Size = new System.Drawing.Size(125, 180);
            this.m_friendslistBox.TabIndex = 17;
            this.m_friendslistBox.SelectedIndexChanged += new System.EventHandler(this.friendslistBox_SelectedIndexChanged);
            // 
            // m_resultsLabel
            // 
            this.m_resultsLabel.AutoSize = true;
            this.m_resultsLabel.Location = new System.Drawing.Point(776, 431);
            this.m_resultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_resultsLabel.Name = "m_resultsLabel";
            this.m_resultsLabel.Size = new System.Drawing.Size(55, 17);
            this.m_resultsLabel.TabIndex = 18;
            this.m_resultsLabel.Text = "Results";
            // 
            // m_postLabel
            // 
            this.m_postLabel.AutoSize = true;
            this.m_postLabel.Location = new System.Drawing.Point(95, 270);
            this.m_postLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_postLabel.Name = "m_postLabel";
            this.m_postLabel.Size = new System.Drawing.Size(55, 17);
            this.m_postLabel.TabIndex = 19;
            this.m_postLabel.Text = "Post text";
            // 
            // m_postTextBox
            // 
            this.m_postTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_postTextBox.Location = new System.Drawing.Point(95, 290);
            this.m_postTextBox.Name = "m_postTextBox";
            this.m_postTextBox.Size = new System.Drawing.Size(300, 300);
            this.m_postTextBox.Multiline = true;
            this.m_postTextBox.TabIndex = 20;
            this.m_postTextBox.TabStop = false;
            // 
            // m_postButton
            // 
            this.m_postButton.AutoSize = true;
            this.m_postButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_postButton.Location = new System.Drawing.Point(95, 600);
            this.m_postButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_postButton.Name = "m_postButton";
            this.m_postButton.Size = new System.Drawing.Size(53, 27);
            this.m_postButton.TabIndex = 0;
            this.m_postButton.Text = "Post";
            this.m_postButton.UseVisualStyleBackColor = true;
            this.m_postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(972, 478);
            this.Controls.Add(this.m_loginButton);
            this.Controls.Add(this.m_logoutButton);
            this.Controls.Add(this.m_resultsLabel);
            this.Controls.Add(this.m_friendslistBox);
            this.Controls.Add(this.m_friendPictureBox);
            this.Controls.Add(this.m_religionFilterGroupBox);
            this.Controls.Add(this.m_relationshipStatusFilterGroupBox);
            this.Controls.Add(this.m_genderFilterGroupBox);
            this.Controls.Add(this.m_searchButton);
            this.Controls.Add(this.m_filtersHeadlineLabel);
            this.Controls.Add(this.m_filteredFriends);
            this.Controls.Add(this.m_userDetailsBox);
            this.Controls.Add(this.m_postLabel);
            this.Controls.Add(this.m_postTextBox);
            this.Controls.Add(this.m_postButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainAppForm";
            this.Text = "MainAppForm";
            this.m_userDetailsBox.ResumeLayout(false);
            this.m_userDetailsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_loggedInUserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_friendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_friendPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button m_loginButton;
        private Button m_logoutButton;
        private GroupBox m_userDetailsBox;
        private PictureBox m_loggedInUserPictureBox;
        private ListBox m_filteredFriends;
        private Label m_filtersHeadlineLabel;
        private Button m_searchButton;
        private GroupBox m_relationshipStatusFilterGroupBox;
        private GroupBox m_religionFilterGroupBox;
        private GroupBox m_genderFilterGroupBox;
        private Label m_userNameLabel;
        private BindingSource m_friendsBindingSource;
        private PictureBox m_friendPictureBox;
        private ListBox m_friendslistBox;
        private Label m_resultsLabel;
        private Label m_postLabel;
        private TextBox m_postTextBox;
        private Button m_postButton;
        private IContainer components;
    }
}

