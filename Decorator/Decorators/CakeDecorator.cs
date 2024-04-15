using Decorator.Cakes;

namespace Decorator.Decorators;
public abstract class CakeDecorator : Cake
{
    protected Cake baseCake;

    public CakeDecorator(Cake cake)
    {
        this.baseCake = cake;
    }

    public override int GetCost()
    {
        return baseCake.GetCost();
    }

    public override string GetDescription()
    {
        return baseCake.GetDescription();
    }
}
