using PadraoComposite.Interfaces;

namespace PadraoComposite.Componentes;
public class PortaMalas : IComponente
{
    private double peso;

    public PortaMalas(double peso)
    {
        this.peso = peso;
    }

    public double GetPeso()
    {
        return peso;
    }
}
