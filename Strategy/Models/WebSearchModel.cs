using Strategy.Filters;
using Strategy.Observers;

namespace Strategy.Models;
public class WebSearchModel
{
    private readonly FileInfo sourceFile;
    private readonly List<(IQueryFilter Filter, QueryObserver Observer)> observers = new();

    public WebSearchModel(FileInfo sourceFile)
    {
        this.sourceFile = sourceFile;
    }

    public void PretendToSearch()
    {
        try
        {
            using (StreamReader reader = new StreamReader(sourceFile.FullName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    NotifyAllObservers(line);
                }
            }
        }
        catch (IOException e)
        {
            Console.Error.WriteLine(e.Message);
        }
    }

    public void AddQueryObserver(IQueryFilter filter, QueryObserver observer)
    {
        observers.Add((filter, observer));
    }

    private void NotifyAllObservers(string query)
    {
        foreach (var (filter, observer) in observers)
        {
            if (filter.ShouldNotify(query))
            {
                observer.OnQuery(query);
            }
        }
    }
}