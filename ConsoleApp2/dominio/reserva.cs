
using System;

namespace TrabalhoFinal.dominio
{
    public class Reserva
    {
        public int Id { get; set; }

        public DateTime DataReserva { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int QuantidadeHospedes { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal ValorTotal { get; set; }

        public string Status { get; set; } = "";

    }
}
