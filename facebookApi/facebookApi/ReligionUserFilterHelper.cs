using FacebookWrapper.ObjectModel;

namespace facebookApi
{
    public class ReligionUserFilterHelper : IUserFilterHelper<MainAppForm.eReligion>
    {
        public bool FilterApplies(User i_User, MainAppForm.eReligion i_Religion)
        {
            return i_User.Religion.Equals(i_Religion);
        }
    }
}
