using PadraoComposite.Interfaces;

namespace PadraoComposite.Componentes;
public class TremDeForca : IComponente
{
    private List<IComponente> componentes = new List<IComponente>();

    public TremDeForca(Motor motor, Transmissao transmissao, Diferencial diferencial)
    {
        componentes.Add(motor);
        componentes.Add(transmissao);
        componentes.Add(diferencial);
    }

    public double GetPeso()
    {
        double pesoTotal = 0;

        foreach (var componente in componentes)
        {
            pesoTotal += componente.GetPeso();  
        }
        return pesoTotal;
    }
}
