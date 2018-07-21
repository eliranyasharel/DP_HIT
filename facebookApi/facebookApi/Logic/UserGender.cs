using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;


namespace facebookApi.Logic
{
    public class UserGender : FacebookUser
    {


        private User m_User;
        
                public string GetUserGender()
        {

             string gender = null;
             gender = m_User.Gender.ToString();
             return gender;
        }




    }
}
