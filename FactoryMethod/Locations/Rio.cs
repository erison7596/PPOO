using FactoryMethod.Enemies;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Locations;
internal class Rio : Location
{
    public override IEnemy CreateEnemy()
    {
        return new Criminal();
    }
}
