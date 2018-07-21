namespace facebookApi
{
    partial class MainAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer m_components = null;

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
            this.m_components = new System.ComponentModel.Container();
            this.m_loginButton = new System.Windows.Forms.Button();
            this.m_userDetailsBox = new System.Windows.Forms.GroupBox();
            this.m_userNameLabel = new System.Windows.Forms.Label();
            this.m_loggedInUserPictureBox = new System.Windows.Forms.PictureBox();
            this.m_filteredFriends = new System.Windows.Forms.ListBox();
            this.m_filtersHeadlineLabel = new System.Windows.Forms.Label();
            this.m_searchButton = new System.Windows.Forms.Button();
            this.m_relationshipStatusFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.m_inRelationshipCheckBox = new System.Windows.Forms.CheckBox();
            this.m_singleCheckBox = new System.Windows.Forms.CheckBox();
            this.m_marriedCheckBox = new System.Windows.Forms.CheckBox();
            this.m_religionFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.m_christianCheckBox = new System.Windows.Forms.CheckBox();
            this.m_muslimCheckBox = new System.Windows.Forms.CheckBox();
            this.m_jewishCheckBox = new System.Windows.Forms.CheckBox();
            this.m_FemaleCheckBox = new System.Windows.Forms.CheckBox();
            this.m_maleCheckBox = new System.Windows.Forms.CheckBox();
            this.m_optionalsLabel = new System.Windows.Forms.Label();
            this.FriendsbindingSource = new System.Windows.Forms.BindingSource(this.m_components);
            this.m_friendPictureBox = new System.Windows.Forms.PictureBox();
            this.m_friendslistBox = new System.Windows.Forms.ListBox();
            this.m_resultsLabel = new System.Windows.Forms.Label();
            this.m_userDetailsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_loggedInUserPictureBox)).BeginInit();
            this.m_relationshipStatusFilterGroupBox.SuspendLayout();
            this.m_religionFilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_friendPictureBox)).BeginInit();
            this.SuspendLayout();

            // 
            // loginButton
            // 
            this.m_loginButton.Location = new System.Drawing.Point(14, 16);
            this.m_loginButton.Name = "loginButton";
            this.m_loginButton.Size = new System.Drawing.Size(102, 23);
            this.m_loginButton.TabIndex = 0;
            this.m_loginButton.Text = "Login";
            this.m_loginButton.UseVisualStyleBackColor = true;
            this.m_loginButton.Click += new System.EventHandler(this.loginButton_Click);

            // 
            // userDetailsBox
            // 
            this.m_userDetailsBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_userDetailsBox.Controls.Add(this.m_userNameLabel);
            this.m_userDetailsBox.Controls.Add(this.m_loggedInUserPictureBox);
            this.m_userDetailsBox.Controls.Add(this.m_loginButton);
            this.m_userDetailsBox.Location = new System.Drawing.Point(34, 21);
            this.m_userDetailsBox.Name = "userDetailsBox";
            this.m_userDetailsBox.Size = new System.Drawing.Size(127, 177);
            this.m_userDetailsBox.TabIndex = 1;
            this.m_userDetailsBox.TabStop = false;
            this.m_userDetailsBox.Text = "User Details";

            // 
            // userName
            // 
            this.m_userNameLabel.AutoSize = true;
            this.m_userNameLabel.Location = new System.Drawing.Point(6, 42);
            this.m_userNameLabel.Name = "userNameLabel";
            this.m_userNameLabel.Size = new System.Drawing.Size(60, 13);
            this.m_userNameLabel.TabIndex = 2;
            this.m_userNameLabel.Text = "User Name";

            // 
            // loggedInUserPictureBox
            // 
            this.m_loggedInUserPictureBox.Location = new System.Drawing.Point(14, 58);
            this.m_loggedInUserPictureBox.Name = "loggedInUserPictureBox";
            this.m_loggedInUserPictureBox.Size = new System.Drawing.Size(100, 109);
            this.m_loggedInUserPictureBox.TabIndex = 1;
            this.m_loggedInUserPictureBox.TabStop = false;

            // 
            // filteredFrinds
            // 
            this.m_filteredFriends.FormattingEnabled = true;
            this.m_filteredFriends.Location = new System.Drawing.Point(560, 193);
            this.m_filteredFriends.Name = "filteredFrinds";
            this.m_filteredFriends.Size = new System.Drawing.Size(95, 160);
            this.m_filteredFriends.TabIndex = 2;

            // 
            // filtersHeadlineLabel
            // 
            this.m_filtersHeadlineLabel.AutoSize = true;
            this.m_filtersHeadlineLabel.Location = new System.Drawing.Point(482, 21);
            this.m_filtersHeadlineLabel.Name = "filtersHeadlineLabel";
            this.m_filtersHeadlineLabel.Size = new System.Drawing.Size(118, 13);
            this.m_filtersHeadlineLabel.TabIndex = 3;
            this.m_filtersHeadlineLabel.Text = "Please select your filter";

            // 
            // searchButton
            // 
            this.m_searchButton.Location = new System.Drawing.Point(412, 216);
            this.m_searchButton.Name = "searchButton";
            this.m_searchButton.Size = new System.Drawing.Size(101, 36);
            this.m_searchButton.TabIndex = 6;
            this.m_searchButton.Text = "Search";
            this.m_searchButton.UseVisualStyleBackColor = true;
            this.m_searchButton.Click += new System.EventHandler(this.searchButton_Click);

            // 
            // relationshipStatusFilterGroupBox
            // 
            this.m_relationshipStatusFilterGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_relationshipStatusFilterGroupBox.Controls.Add(this.m_singleCheckBox);
            this.m_relationshipStatusFilterGroupBox.Controls.Add(this.m_inRelationshipCheckBox);
            this.m_relationshipStatusFilterGroupBox.Controls.Add(this.m_marriedCheckBox);
            this.m_relationshipStatusFilterGroupBox.Location = new System.Drawing.Point(554, 37);
            this.m_relationshipStatusFilterGroupBox.Name = "relationshipStatusFilterGroupBox";
            this.m_relationshipStatusFilterGroupBox.Size = new System.Drawing.Size(118, 92);
            this.m_relationshipStatusFilterGroupBox.TabIndex = 11;
            this.m_relationshipStatusFilterGroupBox.TabStop = false;
            this.m_relationshipStatusFilterGroupBox.Text = "Relationship Status Filter";

            // 
            // single
            // 
            this.m_singleCheckBox.AutoSize = true;
            this.m_singleCheckBox.Location = new System.Drawing.Point(6, 44);
            this.m_singleCheckBox.Name = "single";
            this.m_singleCheckBox.Size = new System.Drawing.Size(63, 17);
            this.m_singleCheckBox.TabIndex = 1;
            this.m_singleCheckBox.Text = FacebookWrapper.ObjectModel.User.eRelationshipStatus.Single.ToString();
            this.m_singleCheckBox.UseVisualStyleBackColor = true;
            this.m_singleCheckBox.CheckedChanged += new System.EventHandler(this.relationshipStatus_CheckedChanged);

            // 
            // inRelationshipCheckBox
            // 
            this.m_inRelationshipCheckBox.AutoSize = true;
            this.m_inRelationshipCheckBox.Location = new System.Drawing.Point(6, 67);
            this.m_inRelationshipCheckBox.Name = "inRelationshipCheckBox";
            this.m_inRelationshipCheckBox.Size = new System.Drawing.Size(90, 17);
            this.m_inRelationshipCheckBox.TabIndex = 2;
            this.m_inRelationshipCheckBox.Text = FacebookWrapper.ObjectModel.User.eRelationshipStatus.InARelationship.ToString();
            this.m_inRelationshipCheckBox.UseVisualStyleBackColor = true;
            this.m_inRelationshipCheckBox.CheckedChanged += new System.EventHandler(this.relationshipStatus_CheckedChanged);

            // 
            // marriedCheckBox
            // 
            this.m_marriedCheckBox.AutoSize = true;
            this.m_marriedCheckBox.Location = new System.Drawing.Point(6, 21);
            this.m_marriedCheckBox.Name = "marriedCheckBox";
            this.m_marriedCheckBox.Size = new System.Drawing.Size(58, 17);
            this.m_marriedCheckBox.TabIndex = 0;
            this.m_marriedCheckBox.Text = FacebookWrapper.ObjectModel.User.eRelationshipStatus.Married.ToString();
            this.m_marriedCheckBox.UseVisualStyleBackColor = true;
            this.m_marriedCheckBox.CheckedChanged += new System.EventHandler(this.relationshipStatus_CheckedChanged);

            // 
            // religionFilterGroupBox
            // 
            this.m_religionFilterGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_religionFilterGroupBox.Controls.Add(this.m_christianCheckBox);
            this.m_religionFilterGroupBox.Controls.Add(this.m_muslimCheckBox);
            this.m_religionFilterGroupBox.Controls.Add(this.m_jewishCheckBox);
            this.m_religionFilterGroupBox.Location = new System.Drawing.Point(412, 37);
            this.m_religionFilterGroupBox.Name = "religionFilterGroupBox";
            this.m_religionFilterGroupBox.Size = new System.Drawing.Size(118, 92);
            this.m_religionFilterGroupBox.TabIndex = 12;
            this.m_religionFilterGroupBox.TabStop = false;
            this.m_religionFilterGroupBox.Text = "Religion Filter";

            // 
            // christianCheckBox
            // 
            this.m_christianCheckBox.AutoSize = true;
            this.m_christianCheckBox.Location = new System.Drawing.Point(6, 67);
            this.m_christianCheckBox.Name = "christianCheckBox";
            this.m_christianCheckBox.Size = new System.Drawing.Size(66, 17);
            this.m_christianCheckBox.TabIndex = 2;
            this.m_christianCheckBox.Text = eReligion.Christian.ToString();
            this.m_christianCheckBox.UseVisualStyleBackColor = true;
            this.m_christianCheckBox.CheckedChanged += new System.EventHandler(this.religion_CheckedChanged);

            // 
            // muslimCheckBox
            // 
            this.m_muslimCheckBox.AutoSize = true;
            this.m_muslimCheckBox.Location = new System.Drawing.Point(6, 44);
            this.m_muslimCheckBox.Name = "muslimCheckBox";
            this.m_muslimCheckBox.Size = new System.Drawing.Size(58, 17);
            this.m_muslimCheckBox.TabIndex = 1;
            this.m_muslimCheckBox.Text = eReligion.Muslim.ToString();
            this.m_muslimCheckBox.UseVisualStyleBackColor = true;
            this.m_muslimCheckBox.CheckedChanged += new System.EventHandler(this.religion_CheckedChanged);

            // 
            // jewishCheckBox
            // 
            this.m_jewishCheckBox.AutoSize = true;
            this.m_jewishCheckBox.Location = new System.Drawing.Point(6, 21);
            this.m_jewishCheckBox.Name = "jewishCheckBox";
            this.m_jewishCheckBox.Size = new System.Drawing.Size(58, 17);
            this.m_jewishCheckBox.TabIndex = 0;
            this.m_jewishCheckBox.Text = eReligion.Jewish.ToString();
            this.m_jewishCheckBox.UseVisualStyleBackColor = true;
            this.m_jewishCheckBox.CheckedChanged += new System.EventHandler(this.religion_CheckedChanged);

            // 
            // femaleCheckBox
            // 
            this.m_FemaleCheckBox.AutoSize = true;
            this.m_FemaleCheckBox.Location = new System.Drawing.Point(418, 171);
            this.m_FemaleCheckBox.Name = "femaleCheckBox";
            this.m_FemaleCheckBox.Size = new System.Drawing.Size(60, 17);
            this.m_FemaleCheckBox.TabIndex = 7;
            this.m_FemaleCheckBox.Text = FacebookWrapper.ObjectModel.User.eGender.female.ToString();
            this.m_FemaleCheckBox.UseVisualStyleBackColor = true;
            this.m_FemaleCheckBox.CheckedChanged += new System.EventHandler(this.gender_CheckedChanged);

            // 
            // maleCheckBox
            // 
            this.m_maleCheckBox.AutoSize = true;
            this.m_maleCheckBox.Location = new System.Drawing.Point(418, 193);
            this.m_maleCheckBox.Name = "maleCheckBox";
            this.m_maleCheckBox.Size = new System.Drawing.Size(46, 17);
            this.m_maleCheckBox.TabIndex = 6;
            this.m_maleCheckBox.Text = FacebookWrapper.ObjectModel.User.eGender.male.ToString();
            this.m_maleCheckBox.UseVisualStyleBackColor = true;
            this.m_maleCheckBox.CheckedChanged += new System.EventHandler(this.gender_CheckedChanged);

            // 
            // optionalsLabel
            // 
            this.m_optionalsLabel.AutoSize = true;
            this.m_optionalsLabel.Location = new System.Drawing.Point(423, 154);
            this.m_optionalsLabel.Name = "optionalsLabel";
            this.m_optionalsLabel.Size = new System.Drawing.Size(49, 13);
            this.m_optionalsLabel.TabIndex = 4;
            this.m_optionalsLabel.Text = "Optionals";

            // 
            // friendPictureBox
            // 
            this.m_friendPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.m_friendPictureBox.Location = new System.Drawing.Point(285, 21);
            this.m_friendPictureBox.Name = "friendPictureBox";
            this.m_friendPictureBox.Size = new System.Drawing.Size(105, 93);
            this.m_friendPictureBox.TabIndex = 15;
            this.m_friendPictureBox.TabStop = false;

            // 
            // friendslistBox
            // 
            this.m_friendslistBox.FormattingEnabled = true;
            this.m_friendslistBox.Location = new System.Drawing.Point(184, 21);
            this.m_friendslistBox.Name = "friendslistBox";
            this.m_friendslistBox.Size = new System.Drawing.Size(95, 147);
            this.m_friendslistBox.TabIndex = 17;
            this.m_friendslistBox.SelectedIndexChanged += new System.EventHandler(this.friendslistBox_SelectedIndexChanged);

            // 
            // resultsLabel
            // 
            this.m_resultsLabel.AutoSize = true;
            this.m_resultsLabel.Location = new System.Drawing.Point(582, 174);
            this.m_resultsLabel.Name = "resultsLabel";
            this.m_resultsLabel.Size = new System.Drawing.Size(42, 13);
            this.m_resultsLabel.TabIndex = 18;
            this.m_resultsLabel.Text = "Results";

            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 388);
            this.Controls.Add(this.m_resultsLabel);
            this.Controls.Add(this.m_friendslistBox);
            this.Controls.Add(this.m_friendPictureBox);
            this.Controls.Add(this.m_FemaleCheckBox);
            this.Controls.Add(this.m_maleCheckBox);
            this.Controls.Add(this.m_religionFilterGroupBox);
            this.Controls.Add(this.m_optionalsLabel);
            this.Controls.Add(this.m_relationshipStatusFilterGroupBox);
            this.Controls.Add(this.m_searchButton);
            this.Controls.Add(this.m_filtersHeadlineLabel);
            this.Controls.Add(this.m_filteredFriends);
            this.Controls.Add(this.m_userDetailsBox);
            this.Name = "MainAppForm";
            this.Text = "MainAppForm";
            this.m_userDetailsBox.ResumeLayout(false);
            this.m_userDetailsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_loggedInUserPictureBox)).EndInit();
            this.m_relationshipStatusFilterGroupBox.ResumeLayout(false);
            this.m_relationshipStatusFilterGroupBox.PerformLayout();
            this.m_religionFilterGroupBox.ResumeLayout(false);
            this.m_religionFilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_friendPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_loginButton;
        private System.Windows.Forms.GroupBox m_userDetailsBox;
        private System.Windows.Forms.PictureBox m_loggedInUserPictureBox;
        private System.Windows.Forms.ListBox m_filteredFriends;
        private System.Windows.Forms.Label m_filtersHeadlineLabel;
        private System.Windows.Forms.Button m_searchButton;
        private System.Windows.Forms.GroupBox m_relationshipStatusFilterGroupBox;
        private System.Windows.Forms.CheckBox m_singleCheckBox;
        private System.Windows.Forms.CheckBox m_inRelationshipCheckBox;
        private System.Windows.Forms.CheckBox m_marriedCheckBox;
        private System.Windows.Forms.GroupBox m_religionFilterGroupBox;
        private System.Windows.Forms.CheckBox m_christianCheckBox;
        private System.Windows.Forms.CheckBox m_muslimCheckBox;
        private System.Windows.Forms.CheckBox m_jewishCheckBox;
        private System.Windows.Forms.CheckBox m_FemaleCheckBox;
        private System.Windows.Forms.CheckBox m_maleCheckBox;
        private System.Windows.Forms.Label m_optionalsLabel;
        private System.Windows.Forms.Label m_userNameLabel;
        private System.Windows.Forms.BindingSource FriendsbindingSource;
        private System.Windows.Forms.PictureBox m_friendPictureBox;
        private System.Windows.Forms.ListBox m_friendslistBox;
        private System.Windows.Forms.Label m_resultsLabel;
    }
}

