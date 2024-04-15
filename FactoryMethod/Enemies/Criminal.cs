using FactoryMethod.Interfaces;

namespace FactoryMethod.Enemies;
public class Criminal : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("O criminoso rouba você para tomar uma cervejinha!");
    }
}
