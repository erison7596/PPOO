using PadraoComposite.Interfaces;
using System;

namespace PadraoComposite.Componentes;
public class Carro : IComponente
{
    private List<IComponente> componentes = new List<IComponente>();

    public void AdicionarComponente(IComponente componente)
    {
        componentes.Add(componente);
    }

    public double GetPeso()
    {
        double pesoTotal = 0;

        foreach (var componente in componentes)
        {
            double peso = componente.GetPeso();
            pesoTotal += peso;
            Console.WriteLine($"Componente: {componente.GetType().Name}, Peso: {peso}\n");
            Console.WriteLine("---------------------------------------------------------------------");
        }
        return pesoTotal;
    }
}
