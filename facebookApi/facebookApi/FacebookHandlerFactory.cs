using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facebookApi
{
    public static class FacebookHandlerFactory
    {
        public enum eRunType
        {
            Debug,
            Release
        }

        public static IFacebookHandler Create(eRunType i_RunType)
        {
            IFacebookHandler facebookHandlerToReturn;

            switch(i_RunType)
            {
                case eRunType.Debug:
                    facebookHandlerToReturn = new FacebookHandlerWithPopupProxy();
                    break;
                case eRunType.Release:
                    facebookHandlerToReturn = Singleton<FacebookHandler>.Instance;
                    break;
                default:
                    throw new Exception("Ïnvalid value for run type!!");
            }

            return facebookHandlerToReturn;
        }
    }
}
