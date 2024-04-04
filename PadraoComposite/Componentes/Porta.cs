using PadraoComposite.Interfaces;

namespace PadraoComposite.Componentes;
public class Porta : IComponente
{
    private double peso;

    public Porta(double peso)
    {
        this.peso = peso;
    }

    public double GetPeso()
    {
        return peso;
    }
}
