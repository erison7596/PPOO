using PadraoComposite.Interfaces;

namespace PadraoComposite.Componentes;
public class Motor : IComponente
{
    private double peso;

    public Motor(double peso)
    {
        this.peso = peso;
    }

    public double GetPeso()
    {
        return peso;
    }
}
