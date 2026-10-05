using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Reserva
    {
        public DateTime DataReserva { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public int QuantidadeHospedes { get; set; }

        public decimal ValorDiaria { get; set; }
        public decimal ValorTotal { get; set; }

        public string Status { get; set; }

    }

}
