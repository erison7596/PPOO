using PadraoComposite.Interfaces;

namespace PadraoComposite.Componentes;
public class Diferencial : IComponente
{
    private double peso;

    public Diferencial(double peso)
    {
        this.peso = peso;
    }

    public double GetPeso()
    {
        return peso;
    }
}
