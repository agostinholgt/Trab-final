// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Console.WriteLine("augusto");

Console.WriteLine("thalles");

Console.WriteLine("Igor");

Console.WriteLine("matheus henrique");

using ConsoleApp2.Services;

class Program
{
    static void Main(string[] args)
    {
        foreach (var suite in suiteServices.suites)
        {
            Console.WriteLine($"ID: {suite.Id}");
            Console.WriteLine($"Número: {suite.Numero}");
            Console.WriteLine($"Capacidade: {suite.Capacidade} pessoas");
            Console.WriteLine($"Diária: R$ {suite.Diaria:F2}");
            Console.WriteLine($"Disponível: {(suite.Disponivel ? "Sim" : "Não")}");
            Console.WriteLine("---------------------------");
        }
    }
}