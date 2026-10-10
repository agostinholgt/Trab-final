
using System;
using TrabalhoFinal.Services;

Console.WriteLine("Integrantes do grupo:");
Console.WriteLine("Augusto");
Console.WriteLine("Thalles");
Console.WriteLine("Igor");
Console.WriteLine("Matheus Henrique");

Console.WriteLine("\n========== RESERVAS ==========");

ReservaServices.Listar();

Console.WriteLine("\n========== SUÍTES ==========");

SuiteService.Listar();

Console.WriteLine("\n========== TESTE DE SUÍTES ==========");

// Buscar suíte pelo ID
Console.WriteLine("\nBuscando suíte de ID 2:");
SuiteService.BuscarPorId(2);

// Adicionar uma suíte
Console.WriteLine("\nAdicionando uma nova suíte:");
SuiteService.Adicionar("401", 4, 280.00m, true);

// Editar uma suíte
Console.WriteLine("\nEditando a suíte de ID 1:");
SuiteService.Editar(1, "101", 3, 190.00m, true);

// Remover uma suíte
Console.WriteLine("\nRemovendo a suíte de ID 3:");
SuiteService.Remover(3);

Console.WriteLine("\n========== RESERVAS ==========");

// Buscar reserva pelo ID
Console.WriteLine("\nBuscando reserva de ID 1:");
ReservaServices.BuscarPorId(1);

// Adicionar uma reserva
Console.WriteLine("\nAdicionando uma nova reserva:");
ReservaServices.Adicionar(
    new DateTime(2026, 12, 20),
    new DateTime(2026, 12, 25),
    2,
    150.00m,
    "Pendente"
);

Console.WriteLine("\n========== LISTA ATUALIZADA DE RESERVAS ==========");

ReservaServices.Listar();

Console.WriteLine("\nFim da execução.");
