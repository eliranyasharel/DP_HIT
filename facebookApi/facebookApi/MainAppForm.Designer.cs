using System;
using System.Windows.Forms;
using System.Drawing;
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
            this.m_components = new Container();
            this.m_loginButton = new Button();
            this.m_userDetailsBox = new GroupBox();
            this.m_userNameLabel = new Label();
            this.m_loggedInUserPictureBox = new PictureBox();
            this.m_filteredFriends = new ListBox();
            this.m_filtersHeadlineLabel = new Label();
            this.m_searchButton = new Button();
            this.m_relationshipStatusFilterGroupBox = new GroupBox();
            this.m_religionFilterGroupBox = new GroupBox();
            this.m_genderFilterGroupBox = new GroupBox();
            this.m_friendsBindingSource = new BindingSource(this.m_components);
            this.m_friendPictureBox = new PictureBox();
            this.m_friendslistBox = new ListBox();
            this.m_resultsLabel = new Label();
            this.m_userDetailsBox.SuspendLayout();
            ((ISupportInitialize)(this.m_loggedInUserPictureBox)).BeginInit();
            this.m_relationshipStatusFilterGroupBox.SuspendLayout();
            this.m_religionFilterGroupBox.SuspendLayout();
            this.m_genderFilterGroupBox.SuspendLayout();
            ((ISupportInitialize)(this.m_friendsBindingSource)).BeginInit();
            ((ISupportInitialize)(this.m_friendPictureBox)).BeginInit();
            this.SuspendLayout();

            // 
            // loginButton
            // 
            this.m_loginButton.Location = new Point(14, 16);
            this.m_loginButton.Name = "loginButton";
            this.m_loginButton.AutoSize = true;
            this.m_loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.m_loginButton.TabIndex = 0;
            this.m_loginButton.Text = "Login";
            this.m_loginButton.UseVisualStyleBackColor = true;
            this.m_loginButton.Click += new EventHandler(this.loginButton_Click);

            // 
            // userDetailsBox
            // 
            this.m_userDetailsBox.BackColor = SystemColors.Window;
            this.m_userDetailsBox.Controls.Add(this.m_userNameLabel);
            this.m_userDetailsBox.Controls.Add(this.m_loggedInUserPictureBox);
            this.m_userDetailsBox.Controls.Add(this.m_loginButton);
            this.m_userDetailsBox.Location = new Point(34, 21);
            this.m_userDetailsBox.Name = "userDetailsBox";
            this.m_userDetailsBox.Size = new Size(127, 177);
            this.m_userDetailsBox.TabIndex = 1;
            this.m_userDetailsBox.TabStop = false;
            this.m_userDetailsBox.Text = "User Details";

            // 
            // userName
            // 
            this.m_userNameLabel.AutoSize = true;
            this.m_userNameLabel.Location = new Point(6, 42);
            this.m_userNameLabel.Name = "userNameLabel";
            this.m_userNameLabel.Size = new Size(60, 13);
            this.m_userNameLabel.TabIndex = 2;
            this.m_userNameLabel.Text = "User Name";

            // 
            // loggedInUserPictureBox
            // 
            this.m_loggedInUserPictureBox.Location = new Point(14, 58);
            this.m_loggedInUserPictureBox.Name = "loggedInUserPictureBox";
            this.m_loggedInUserPictureBox.Size = new Size(100, 109);
            this.m_loggedInUserPictureBox.TabIndex = 1;
            this.m_loggedInUserPictureBox.TabStop = false;

            // 
            // filteredFrinds
            // 
            this.m_filteredFriends.FormattingEnabled = true;
            this.m_filteredFriends.Location = new Point(560, 370);
            this.m_filteredFriends.Name = "filteredFrinds";
            this.m_filteredFriends.Size = new Size(95, 160);
            this.m_filteredFriends.TabIndex = 2;

            // 
            // filtersHeadlineLabel
            // 
            this.m_filtersHeadlineLabel.AutoSize = true;
            this.m_filtersHeadlineLabel.Location = new Point(482, 21);
            this.m_filtersHeadlineLabel.Name = "filtersHeadlineLabel";
            this.m_filtersHeadlineLabel.TabIndex = 3;
            this.m_filtersHeadlineLabel.Text = "Please select your filter";

            // 
            // searchButton
            // 
            this.m_searchButton.Location = new Point(412, 260);
            this.m_searchButton.Name = "searchButton";
            this.m_searchButton.AutoSize = true;
            this.m_searchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.m_searchButton.TabIndex = 6;
            this.m_searchButton.Text = "Search";
            this.m_searchButton.UseVisualStyleBackColor = true;
            this.m_searchButton.Click += new EventHandler(this.searchButton_Click);

            // 
            // relationshipStatusFilterGroupBox
            // 
            this.m_relationshipStatusFilterGroupBox.BackColor = SystemColors.Window;
            this.m_relationshipStatusFilterGroupBox.Location = new Point(560, 37);
            this.m_relationshipStatusFilterGroupBox.Name = "relationshipStatusFilterGroupBox";
            this.m_relationshipStatusFilterGroupBox.AutoSize = true;
            this.m_relationshipStatusFilterGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.m_relationshipStatusFilterGroupBox.TabIndex = 11;
            this.m_relationshipStatusFilterGroupBox.TabStop = false;
            this.m_relationshipStatusFilterGroupBox.Text = "Relationship Status Filter";

            // 
            // religionFilterGroupBox
            // 
            this.m_religionFilterGroupBox.BackColor = SystemColors.Window;
            this.m_religionFilterGroupBox.Location = new Point(412, 37);
            this.m_religionFilterGroupBox.Name = "religionFilterGroupBox";
            this.m_religionFilterGroupBox.AutoSize = true;
            this.m_religionFilterGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.m_religionFilterGroupBox.TabIndex = 12;
            this.m_religionFilterGroupBox.TabStop = false;
            this.m_religionFilterGroupBox.Text = "Religion Filter";

            // 
            // genderFilterGroupBox
            // 
            this.m_genderFilterGroupBox.BackColor = SystemColors.Window;
            this.m_genderFilterGroupBox.Location = new Point(412, 154);
            this.m_genderFilterGroupBox.Name = "genderFilterGroupBox";
            this.m_genderFilterGroupBox.AutoSize = true;
            this.m_genderFilterGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.m_genderFilterGroupBox.TabIndex = 13;
            this.m_genderFilterGroupBox.TabStop = false;
            this.m_genderFilterGroupBox.Text = "Gender Filter";

            // 
            // friendPictureBox
            // 
            this.m_friendPictureBox.BackColor = SystemColors.Window;
            this.m_friendPictureBox.Location = new Point(285, 21);
            this.m_friendPictureBox.Name = "friendPictureBox";
            this.m_friendPictureBox.Size = new Size(105, 93);
            this.m_friendPictureBox.TabIndex = 15;
            this.m_friendPictureBox.TabStop = false;

            // 
            // friendslistBox
            // 
            this.m_friendslistBox.FormattingEnabled = true;
            this.m_friendslistBox.Location = new Point(184, 21);
            this.m_friendslistBox.Name = "friendslistBox";
            this.m_friendslistBox.Size = new Size(95, 147);
            this.m_friendslistBox.TabIndex = 17;
            this.m_friendslistBox.SelectedIndexChanged += new EventHandler(this.friendslistBox_SelectedIndexChanged);

            // 
            // resultsLabel
            // 
            this.m_resultsLabel.AutoSize = true;
            this.m_resultsLabel.Location = new Point(582, 350);
            this.m_resultsLabel.Name = "resultsLabel";
            this.m_resultsLabel.Size = new Size(42, 13);
            this.m_resultsLabel.TabIndex = 18;
            this.m_resultsLabel.Text = "Results";

            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(729, 388);
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
            this.Name = "MainAppForm";
            this.Text = "MainAppForm";
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.m_userDetailsBox.ResumeLayout(false);
            this.m_userDetailsBox.PerformLayout();
            ((ISupportInitialize)(this.m_loggedInUserPictureBox)).EndInit();
            this.m_relationshipStatusFilterGroupBox.ResumeLayout(false);
            this.m_relationshipStatusFilterGroupBox.PerformLayout();
            this.m_religionFilterGroupBox.ResumeLayout(false);
            this.m_religionFilterGroupBox.PerformLayout();
            ((ISupportInitialize)(this.m_friendsBindingSource)).EndInit();
            ((ISupportInitialize)(this.m_friendPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button m_loginButton;
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
    }
}

