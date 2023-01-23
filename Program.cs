
namespace Estacionamento;
class Program
{
    static void Main(string[] args)
    {
        List<string> carros = new List<string>();

        Console.Write("Seja bem vindo ao sistema de estacionamento!\n" + "Digite o preço inicial: ");
        decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Agora digite o preço por hora: ");
        decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());
        Menu(carros, precoInicial, precoPorHora);
    }
    static void Menu(List<string> carros, decimal precoInicial, decimal precoPorHora)
    {

        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Selecione uma opção:");
        Console.WriteLine("1. Adicionar carro");
        Console.WriteLine("2. Remover carro");
        Console.WriteLine("3. Ver lista de carros");
        Console.WriteLine("4. Sair");


        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: AdicionarCarro(carros, precoInicial, precoPorHora); break;
            case 2: RemoverCarro(carros, precoInicial, precoPorHora); break;
            case 3: ListaCarros(carros, precoInicial, precoPorHora); break;
            case 4: Sair(); break;
        }
    }
    static void AdicionarCarro(List<string> carros, decimal precoInicial, decimal precoPorHora)
    {
       
        Console.WriteLine("Digite a placa do carro:");
        string placa = Console.ReadLine();
        carros.Add(placa);
        Console.WriteLine("Carro adicionado com sucesso!");
        Thread.Sleep(2000);
        Menu(carros, precoInicial, precoPorHora);
    }
    static void RemoverCarro(List<string> carros, decimal precoInicial, decimal precoPorHora)
    {
        Console.WriteLine("Digite a placa do carro a ser removido:");
        string placa = Console.ReadLine();

        Console.WriteLine("Quantas horas o carro ficou estacionado?");
        int horagasta = int.Parse(Console.ReadLine());
        decimal valorTotal = precoInicial + (precoPorHora * horagasta);
        if (carros.Remove(placa))
        {

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Carro não encontrado!");
        }
        Menu(carros, precoInicial, precoPorHora);
    }
    static void ListaCarros(List<string> carros, decimal precoInicial, decimal precoPorHora)
    {   
        
        Console.WriteLine("Lista de carros:");
        foreach (string carro in carros)
        {
            Console.WriteLine(carro);

        }
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
        Menu(carros, precoInicial, precoPorHora);
    }

    static void Sair()
    {
        Console.WriteLine("Saindo do programa...");
        Console.ReadLine();
    }

}
