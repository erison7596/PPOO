using PadraoComposite.Interfaces;

namespace PadraoComposite.Componentes;
public class Chassi : IComponente
{
    private List<IComponente> componentes = new List<IComponente>();

    public void AdicionarComponente(IComponente componente)
    {
        componentes.Add(componente);
    }

    public double GetPeso()
    {
        double pesoTotal = 0;
        int tam = componentes.Count;
        int i = 0;
        Console.WriteLine("-----------------------------------------------------------\nChassi");
        foreach (var componente in componentes)
        {
            pesoTotal += componente.GetPeso();
            Console.WriteLine($"Adicionado: {componente.GetType().Name}, com Peso: {componente.GetPeso()}");
            i++;
            if (tam == i)
            {
                Console.WriteLine($"Peso Parcial: {pesoTotal}");
            }
            else
            {
                Console.WriteLine($"Peso Parcial: {pesoTotal}\n");
            }
        }
        return pesoTotal;
    }
}
