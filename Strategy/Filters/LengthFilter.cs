namespace Strategy.Filters;
public class LengthFilter : IQueryFilter
{
    public bool ShouldNotify(string query) => query.Length > 60;
}