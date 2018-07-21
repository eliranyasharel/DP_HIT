using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Facebook;




namespace facebookApi
{
    public partial class Form1 : Form 
    {
        private User m_LoggedInUser;
        //private readonly string k_ApplicationID = "228124338010525";
        private readonly string k_ApplicationID = "1450160541956417";
        private readonly string[] r_FaceboookPermissions = { "user_photos", "user_gender", "user_friends" };

      

        private void loginAndInit()
        {

            this.label1.Visible = true;

            try
            {
                
                LoginResult result = FacebookWrapper.FacebookService.Login(k_ApplicationID, r_FaceboookPermissions);

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


            this.label1.Visible = false;

        }
        private void fetchUserInfo()
        {

            this.pictureBox1.LoadAsync(this.m_LoggedInUser.PictureNormalURL);
            if (this.m_LoggedInUser.Statuses != null && this.m_LoggedInUser.Statuses.Count > 0)
            {
                this.pictureBox1.Text = this.m_LoggedInUser.Statuses[0].Message;
            }

            this.userName.Text = string.Format("Welcome  {0} {1}", this.m_LoggedInUser.FirstName, this.m_LoggedInUser.LastName);
                   

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

      
        private void displayFilterdFriends()
        {
          

        }

        private void FilteredFrinds_SelectedIndexChanged(object sender, EventArgs e)
        {

         this.displayFilterdFriends();
        }








        private void enableControls()
        {
            this.pictureBox1.Visible = true;
            this.button1.Visible = false;
            this.pictureBoxFriend.Visible = true;
        }





        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Single_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

         

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.loginAndInit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
       

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriends();
        }


        private void fetchFriends()
        {
            listBoxFrineds.Items.Clear();
            listBoxFrineds.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                listBoxFrineds.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }





        private void listBoxFrineds_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (listBoxFrineds.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFrineds.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
              /*  else
                {
                    picture_smallPictureBox.Image = picture_smallPictureBox.ErrorImage;
                }*/
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {






        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
