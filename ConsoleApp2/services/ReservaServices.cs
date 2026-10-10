
using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhoFinal.dominio;

namespace TrabalhoFinal.Services
{
    public static class ReservaServices
    {
        public static List<Reserva> reservas = new List<Reserva>()
        {
            new Reserva
            {
                Id = 1,
                DataReserva = new DateTime(2026, 10, 1),
                DataCheckIn = new DateTime(2026, 10, 10),
                DataCheckOut = new DateTime(2026, 10, 15),
                QuantidadeHospedes = 2,
                ValorDiaria = 150.00m,
                ValorTotal = 750.00m,
                Status = "Confirmada"
            },

            new Reserva
            {
                Id = 2,
                DataReserva = new DateTime(2026, 10, 2),
                DataCheckIn = new DateTime(2026, 10, 20),
                DataCheckOut = new DateTime(2026, 10, 23),
                QuantidadeHospedes = 4,
                ValorDiaria = 250.00m,
                ValorTotal = 750.00m,
                Status = "Confirmada"
            },

            new Reserva
            {
                Id = 3,
                DataReserva = new DateTime(2026, 10, 3),
                DataCheckIn = new DateTime(2026, 11, 5),
                DataCheckOut = new DateTime(2026, 11, 10),
                QuantidadeHospedes = 2,
                ValorDiaria = 180.00m,
                ValorTotal = 900.00m,
                Status = "Pendente"
            },

            new Reserva
            {
                Id = 4,
                DataReserva = new DateTime(2026, 10, 4),
                DataCheckIn = new DateTime(2026, 11, 15),
                DataCheckOut = new DateTime(2026, 11, 18),
                QuantidadeHospedes = 5,
                ValorDiaria = 320.00m,
                ValorTotal = 960.00m,
                Status = "Confirmada"
            },

            new Reserva
            {
                Id = 5,
                DataReserva = new DateTime(2026, 10, 5),
                DataCheckIn = new DateTime(2026, 12, 1),
                DataCheckOut = new DateTime(2026, 12, 4),
                QuantidadeHospedes = 3,
                ValorDiaria = 220.00m,
                ValorTotal = 660.00m,
                Status = "Cancelada"
            },

            new Reserva
            {
                Id = 6,
                DataReserva = new DateTime(2026, 10, 5),
                DataCheckIn = new DateTime(2026, 12, 10),
                DataCheckOut = new DateTime(2026, 12, 15),
                QuantidadeHospedes = 6,
                ValorDiaria = 400.00m,
                ValorTotal = 2000.00m,
                Status = "Confirmada"
            }
        };

        public static void Listar()
        {
            foreach (Reserva reserva in reservas)
            {
                Console.WriteLine($"ID: {reserva.Id}");
                Console.WriteLine($"Data da reserva: {reserva.DataReserva:dd/MM/yyyy}");
                Console.WriteLine($"Check-in: {reserva.DataCheckIn:dd/MM/yyyy}");
                Console.WriteLine($"Check-out: {reserva.DataCheckOut:dd/MM/yyyy}");
                Console.WriteLine($"Hóspedes: {reserva.QuantidadeHospedes}");
                Console.WriteLine($"Valor da diária: R$ {reserva.ValorDiaria:F2}");
                Console.WriteLine($"Valor total: R$ {reserva.ValorTotal:F2}");
                Console.WriteLine($"Status: {reserva.Status}");
                Console.WriteLine("-----------------------------");
            }
        }

        public static void BuscarPorId(int id)
        {
            Reserva reserva = reservas.Find(r => r.Id == id);

            if (reserva != null)
            {
                Console.WriteLine($"ID: {reserva.Id}");
                Console.WriteLine($"Data da reserva: {reserva.DataReserva:dd/MM/yyyy}");
                Console.WriteLine($"Check-in: {reserva.DataCheckIn:dd/MM/yyyy}");
                Console.WriteLine($"Check-out: {reserva.DataCheckOut:dd/MM/yyyy}");
                Console.WriteLine($"Hóspedes: {reserva.QuantidadeHospedes}");
                Console.WriteLine($"Valor da diária: R$ {reserva.ValorDiaria:F2}");
                Console.WriteLine($"Valor total: R$ {reserva.ValorTotal:F2}");
                Console.WriteLine($"Status: {reserva.Status}");
            }
            else
            {
                Console.WriteLine("Reserva não encontrada.");
            }
        }

        public static void Remover(int id)
        {
            Reserva reserva = reservas.Find(r => r.Id == id);

            if (reserva != null)
            {
                reservas.Remove(reserva);
                Console.WriteLine("Reserva removida com sucesso!");
                Listar();
            }
            else
            {
                Console.WriteLine("Reserva não encontrada.");
            }
        }

        public static void Adicionar(
            DateTime dataCheckIn,
            DateTime dataCheckOut,
            int quantidadeHospedes,
            decimal valorDiaria,
            string status)
        {
            Reserva reserva = new Reserva();

            reserva.Id = reservas.Count > 0
                ? reservas.Max(r => r.Id) + 1
                : 1;

            reserva.DataReserva = DateTime.Now;
            reserva.DataCheckIn = dataCheckIn;
            reserva.DataCheckOut = dataCheckOut;
            reserva.QuantidadeHospedes = quantidadeHospedes;
            reserva.ValorDiaria = valorDiaria;

            int dias = (dataCheckOut - dataCheckIn).Days;
            reserva.ValorTotal = dias * valorDiaria;

            reserva.Status = status;

            reservas.Add(reserva);

            Console.WriteLine("Reserva adicionada com sucesso!");
        }

        public static void Editar(
            int id,
            DateTime novoCheckIn,
            DateTime novoCheckOut,
            int novaQuantidadeHospedes,
            decimal novaDiaria,
            string novoStatus)
        {
            Reserva reserva = reservas.Find(r => r.Id == id);

            if (reserva != null)
            {
                reserva.DataCheckIn = novoCheckIn;
                reserva.DataCheckOut = novoCheckOut;
                reserva.QuantidadeHospedes = novaQuantidadeHospedes;
                reserva.ValorDiaria = novaDiaria;

                int dias = (novoCheckOut - novoCheckIn).Days;
                reserva.ValorTotal = dias * novaDiaria;

                reserva.Status = novoStatus;

                Console.WriteLine("Reserva editada com sucesso!");
                Listar();
            }
            else
            {
                Console.WriteLine("Reserva não encontrada.");
            }
        }
    }
}
