using Strategy.Models;

namespace Strategy.Utilities;
public class Snooper
{
    public static void OnQuery(string query)
    {
        Console.WriteLine(query);
    }
}