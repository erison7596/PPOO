using PadraoComposite.Interfaces;

namespace PadraoComposite.Componentes;
public class Roda : IComponente
{
    private double peso;

    public Roda(double peso)
    {
        this.peso = peso;
    }

    public double GetPeso()
    {
        return peso;
    }
}
