using PadraoComposite.Interfaces;

namespace PadraoComposite.Componentes;
public class Suspensao : IComponente
{
    private double peso;

    public Suspensao(double peso)
    {
        this.peso = peso;
    }

    public double GetPeso()
    {
        return peso;
    }
}
