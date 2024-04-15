using FactoryMethod.Interfaces;
using FactoryMethod.Locations;
class Programa
{
    static void Main()
    {
        Location location = new Amazon();
        IEnemy enemy = location.CreateEnemy();
        enemy.Attack();

        location = new Sertao();
        enemy = location.CreateEnemy();
        enemy.Attack();

        location = new Rio();
        enemy = location.CreateEnemy();
        enemy.Attack();
    }
}
