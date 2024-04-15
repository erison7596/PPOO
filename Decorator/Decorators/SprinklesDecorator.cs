using Decorator.Cakes;

namespace Decorator.Decorators;
public class SprinklesDecorator : CakeDecorator
{
    public SprinklesDecorator(Cake cake) : base(cake) { }

    public override int GetCost()
    {
        return base.GetCost() + 2;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + " with sprinkles";
    }
}