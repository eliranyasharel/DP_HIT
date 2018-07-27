using FacebookWrapper.ObjectModel;

namespace facebookApi
{
    public class RelationshipStatusUserFilterHelper : IUserFilterHelper<User.eRelationshipStatus>
    {
        public bool FilterApplies(User i_User, User.eRelationshipStatus i_RelationshipStatus)
        {
            return i_User.RelationshipStatus.Equals(i_RelationshipStatus);
        }
    }
}
