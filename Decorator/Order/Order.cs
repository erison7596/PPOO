using Decorator.Cakes;

namespace Decorator.Order;
public class Order
{
    private List<Cake> cakes = new List<Cake>();

    public void AddCake(Cake cake)
    {
        cakes.Add(cake);
    }

    public void PrintOrder()
    {
        foreach (Cake cake in cakes)
        {
            Console.WriteLine($"  {cake.GetCost(),2} {cake.GetDescription()}");
        }
    }
}