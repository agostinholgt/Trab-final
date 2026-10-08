using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class ReservaServices
    {
        public static List<Reserva> reservas = new List<Reserva>()
        {
            new Reserva
            {
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
                DataReserva = new DateTime(2026, 10, 5),
                DataCheckIn = new DateTime(2026, 12, 10),
                DataCheckOut = new DateTime(2026, 12, 15),
                QuantidadeHospedes = 6,
                ValorDiaria = 400.00m,
                ValorTotal = 2000.00m,
                Status = "Confirmada"
            }
        };
    }
}
