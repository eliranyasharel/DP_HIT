using FacebookWrapper.ObjectModel;

namespace facebookApi
{
    public class GenderUserFilterHelper : IUserFilterHelper<User.eGender>
    {
        public bool FilterApplies(User i_User, User.eGender i_Gender)
        {
            return i_User.Gender.Equals(i_Gender);
        }
    }
}
