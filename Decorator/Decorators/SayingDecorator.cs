using Decorator.Cakes;

namespace Decorator.Decorators;
public class SayingDecorator : CakeDecorator
{
    private string saying;

    public SayingDecorator(Cake cake, string saying) : base(cake)
    {
        this.saying = saying;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $" with saying '{saying}'";
    }
}