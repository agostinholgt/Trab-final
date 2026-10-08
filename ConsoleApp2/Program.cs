// See https://aka.ms/new-console-template for more information
using ConsoleApp2.Services;

Console.WriteLine("augusto");

Console.WriteLine("thalles");

Console.WriteLine("Igor");

Console.WriteLine("matheus henrique");


foreach (var reserva in ReservaServices.reservas)
{
    Console.WriteLine("Data: " + reserva.DataReserva);
    Console.WriteLine("Check-in: " + reserva.DataCheckIn);
    Console.WriteLine("Check-out: " + reserva.DataCheckOut);
    Console.WriteLine("Hospedes: " + reserva.QuantidadeHospedes);
    Console.WriteLine("Diaria: " + reserva.ValorDiaria);
    Console.WriteLine("Total: " + reserva.ValorTotal);
    Console.WriteLine("Status: " + reserva.Status);
    Console.WriteLine("---------------------");
}

foreach (var suite in SuiteServices.Suites)

{
    Console.WriteLine("ID: " + suite.Id);
    Console.WriteLine("Número: " + suite.Numero);
    Console.WriteLine("Capacidade: " + suite.Capacidade);
    Console.WriteLine("Diária: " + suite.Diaria);
    Console.WriteLine("Disponível: " + suite.Disponivel);
    Console.WriteLine("--------------------");

}