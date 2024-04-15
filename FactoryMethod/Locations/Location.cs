using FactoryMethod.Interfaces;

namespace FactoryMethod.Locations;
public abstract class Location
{
    public abstract IEnemy CreateEnemy();
}
