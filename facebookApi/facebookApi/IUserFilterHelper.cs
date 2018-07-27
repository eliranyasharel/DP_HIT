using FacebookWrapper.ObjectModel;

namespace facebookApi
{
    public interface IUserFilterHelper<T>
    {
        /// <summary>
        /// Checks if a filter applies to a user
        /// </summary>
        /// <param name="i_User"></param>
        /// <param name="i_Filter"></param>
        /// <returns></returns>
        bool FilterApplies(User i_User, T i_Filter);
    }
}
