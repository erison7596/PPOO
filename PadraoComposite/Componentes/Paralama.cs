using PadraoComposite.Interfaces;

namespace PadraoComposite.Componentes;
public class Paralama : IComponente
{
    private double peso;

    public Paralama(double peso)
    {
        this.peso = peso;
    }

    public double GetPeso()
    {
        return peso;
    }
}
