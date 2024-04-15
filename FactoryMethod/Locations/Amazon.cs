using FactoryMethod.Enemies;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Locations;
public class Amazon : Location
{
    public override IEnemy CreateEnemy()
    {
        return new MutantAnimal();
    }
}
