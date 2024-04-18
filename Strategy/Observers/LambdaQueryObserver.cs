using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Observers;
public class LambdaQueryObserver : QueryObserver
{
    private readonly Action<string> _onQueryAction;

    public LambdaQueryObserver(Action<string> onQueryAction)
    {
        _onQueryAction = onQueryAction;
    }

    public void OnQuery(string query)
    {
        _onQueryAction(query);
    }
}