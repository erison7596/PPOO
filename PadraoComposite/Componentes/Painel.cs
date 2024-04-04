using PadraoComposite.Interfaces;

namespace PadraoComposite.Componentes;
public class Painel : IComponente
{
    private double peso;

    public Painel(double peso)
    {
        this.peso = peso;
    }

    public double GetPeso()
    {
        return peso;
    }
}
