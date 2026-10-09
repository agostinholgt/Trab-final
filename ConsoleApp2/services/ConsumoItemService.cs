using System.Collections.Generic;
using TrabalhoFinal.dominio;

namespace TrabalhoFinal.dominio
{
    public static class ConsumoItemServices
    {
        public static List<ConsumoItem> ConsumoItens = new List<ConsumoItem>()
        {
            new ConsumoItem
            {
                Id = 1,
                Nome = "Água",
                Valor = 5.00m,
                Quantidade = 2
            },
            new ConsumoItem
            {
                Id = 2,
                Nome = "Refrigerante",
                Valor = 8.00m,
                Quantidade = 3
            },
            new ConsumoItem
            {
                Id = 3,
                Nome = "Sanduíche",
                Valor = 15.00m,
                Quantidade = 1
            },
            new ConsumoItem
            {
                Id = 4,
                Nome = "Chocolate",
                Valor = 6.50m,
                Quantidade = 2
            }
        };
    }
}
