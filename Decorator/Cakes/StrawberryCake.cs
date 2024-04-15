namespace Decorator.Cakes;
public class StrawberryCake : Cake
{
    public StrawberryCake()
    {
        cost = 20; // Altera o valor no construtor pq custa o dobro do bolo padrão
    }

    public override string GetDescription()
    {
        return "Boulo de murango, hm hm";
    }
}
