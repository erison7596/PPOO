namespace Decorator.Cakes;
public abstract class Cake
{
    protected int cost = 10;

    public virtual int GetCost()
    {
        return cost;
    }

    public abstract string GetDescription();
}

