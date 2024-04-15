using Decorator.Cakes;
using Decorator.Decorators;
using Decorator.Order;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        order.AddCake(new ChocolateCake());
        order.AddCake(new SayingDecorator(new VanillaCake(), "PLAIN!"));
        order.AddCake(new SayingDecorator(new SprinklesDecorator(new VanillaCake()), "FANCY"));
        Cake complexCake = new SayingDecorator(new SayingDecorator(new SprinklesDecorator(new SprinklesDecorator(new MultiLayeredDecorator(new StrawberryCake()))), "One of"), "EVERYTHING");
        order.AddCake(complexCake);

        order.PrintOrder();
    }
}