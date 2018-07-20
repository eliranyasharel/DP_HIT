using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace facebookApi.Logic
{
   public class UesrReligion : FacebookUser
    {


        private User m_User;

        public string GetUesrReligion()
        {
            string religion = null;
            religion = m_User.Religion.ToString();
            return religion;
        }



    

    }
}
