using FactoryMethod.Enemies;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Locations;
public class Sertao : Location
{
    public override IEnemy CreateEnemy()
    {
        return new Cangaceiro();
    }
}
