using FactoryMethod.Interfaces;

namespace FactoryMethod.Enemies;
public class MutantAnimal : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("O animal mutante ataca com fúria!");
    }
}
