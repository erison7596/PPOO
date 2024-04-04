using PadraoComposite.Componentes;

class Programa
{
    static void Main(string[] args)
    {
        Carro carro = new Carro();

        Carroceria carroceria = new Carroceria();
        carroceria.AdicionarComponente(new Paralama(50));
        carroceria.AdicionarComponente(new Porta(70));
        carroceria.AdicionarComponente(new Painel(40));
        carroceria.AdicionarComponente(new PortaMalas(30));
        carroceria.AdicionarComponente(new Capo(35));

        Chassi chassi = new Chassi();
        chassi.AdicionarComponente(new Suspensao(150));

        Motor motor = new Motor(200);
        Transmissao transmissao = new Transmissao(100);
        Diferencial diferencial = new Diferencial(80);

        chassi.AdicionarComponente(new TremDeForca(motor, transmissao, diferencial));

        chassi.AdicionarComponente(new Roda(20));
        chassi.AdicionarComponente(new Roda(20));
        chassi.AdicionarComponente(new Roda(20));
        chassi.AdicionarComponente(new Roda(20));

        carro.AdicionarComponente(carroceria);
        carro.AdicionarComponente(chassi);

        System.Console.WriteLine($"Peso total do carro: {carro.GetPeso()}");
    }
}
