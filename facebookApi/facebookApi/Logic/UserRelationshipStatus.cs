using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;


namespace facebookApi.Logic
{
    public class UserRelationshipStatus : FacebookUser
    {

        private User m_User;


        public string GetUserRelationshipStatus()
        {
            string relation_status = null;
            relation_status = m_User.RelationshipStatus.ToString();
            return relation_status;

        }






    }
}
