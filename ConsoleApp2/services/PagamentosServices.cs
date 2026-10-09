using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal.services
{
    public static class PagamentosServices
    {
        public static List <pagamentos> Pagamentos = new List <pagamentos>()
        {
            new pagamentos
            {
                Id = 1,
                ReservaId = 101,
                Valor = 150.00,
                FormaPagamento = 1.0,
                DataPagamento = new DateTime (2026, 10, 1),
                StatusPagamento = true
            },
            new pagamentos
            {
                Id = 2,
                ReservaId = 102,
                Valor = 250.00,
                FormaPagamento = 2.0,
                DataPagamento = new DateTime (2026, 10, 2),
                StatusPagamento = true
            },
            new pagamentos
            {
                Id = 3,
                ReservaId = 201,
                Valor = 180.00,
                FormaPagamento = 1.0,
                DataPagamento = new DateTime (2026, 10, 5),
                StatusPagamento = false
            },
            new pagamentos
            {
                Id = 4,
                ReservaId = 202,
                Valor = 320.00,
                FormaPagamento = 3.0,
                DataPagamento = new DateTime (2026, 10, 8),
                StatusPagamento = true
            }
        };
    }
}