namespace Strategy.Filters;
public interface IQueryFilter
{
    bool ShouldNotify(string query);
}