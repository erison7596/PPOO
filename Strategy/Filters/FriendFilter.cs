namespace Strategy.Filters;
public class FriendFilter : IQueryFilter
{
    public bool ShouldNotify(string query) => query.ToLower().Contains("friend");
}