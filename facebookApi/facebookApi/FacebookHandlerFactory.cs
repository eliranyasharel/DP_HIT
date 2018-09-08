using System;
using static facebookApi.RunType;

namespace facebookApi
{
    public static class FacebookHandlerFactory
    {
        public static IFacebookHandler Create(eRunType i_RunType)
        {
            IFacebookHandler facebookHandlerToReturn;

            switch(i_RunType)
            {
                case eRunType.Debug:
                    facebookHandlerToReturn = new FacebookHandlerWithPopupDecorator(Singleton<FacebookHandler>.Instance);
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
