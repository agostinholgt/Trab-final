// See https://aka.ms/new-console-template for more information
using ConsoleApp2;
using ConsoleApp2.services;

Console.WriteLine("augusto");

Console.WriteLine("thalles");

Console.WriteLine("Igor");

Console.WriteLine("matheus henrique");

        foreach (var suite in suiteServices)
        {
            Console.WriteLine("ID: " + suite.Id);
            Console.WriteLine("Número: " + suite.Numero);
            Console.WriteLine("Capacidade: " + suite.Capacidade);
            Console.WriteLine("Diária: " + suite.Diaria);
            Console.WriteLine("Disponível: " + suite.Disponivel);
            Console.WriteLine("--------------------");
        }