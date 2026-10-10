using System;
using System.Collections.Generic;
using TrabalhoFinal.dominio;
using TrabalhoPaulo.Models;

namespace TrabalhoFinal.Services
{
    public static class ConsumoItemServices
    {
        public static List<ConsumoItem> ConsumoItens = new List<ConsumoItem>()
        {
            new ConsumoItem
            {
                Id = 1,
                TarifaId = 1,
                NomeItem = "Água",
                Quantidade = 2,
                ValorTotal = 5.00m,
                DataConsumo = new DateTime(2026, 10, 1)
            },

            new ConsumoItem
            {
                Id = 2,
                TarifaId = 2,
                NomeItem = "Refrigerante",
                Quantidade = 3,
                ValorTotal = 8.00m,
                DataConsumo = new DateTime(2026, 10, 2)
            },

            new ConsumoItem
            {
                Id = 3,
                TarifaId = 3,
                NomeItem = "Sanduíche",
                Quantidade = 1,
                ValorTotal = 15.00m,
                DataConsumo = new DateTime(2026, 10, 3)
            }
        };
    }
}