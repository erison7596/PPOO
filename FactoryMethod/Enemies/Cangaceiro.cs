using FactoryMethod.Interfaces;

namespace FactoryMethod.Enemies;
public class Cangaceiro : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("O cangaceiro ataca com seu rifle!");
    }
}
