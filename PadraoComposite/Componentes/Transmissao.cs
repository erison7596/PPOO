using PadraoComposite.Interfaces;

namespace PadraoComposite.Componentes;
public class Transmissao : IComponente
{
    private double peso;

    public Transmissao(double peso)
    {
        this.peso = peso;
    }

    public double GetPeso()
    {
        return peso;
    }
}
