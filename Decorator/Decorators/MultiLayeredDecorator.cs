using Decorator.Cakes;

namespace Decorator.Decorators;
public class MultiLayeredDecorator : CakeDecorator
{
    public MultiLayeredDecorator(Cake cake) : base(cake) { }

    public override int GetCost()
    {
        return base.GetCost() + 5;
    }

    public override string GetDescription()
    {
        return "Multi-layered " + base.GetDescription();
    }
}