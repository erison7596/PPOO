using PadraoComposite.Interfaces;

namespace PadraoComposite.Componentes;
public class Capo : IComponente
{
    private double peso;

    public Capo(double peso)
    {
        this.peso = peso;
    }

    public double GetPeso()
    {
        return peso;
    }
}
