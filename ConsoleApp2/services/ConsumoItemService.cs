
using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhoFinal.dominio;
using TrabalhoPaulo.Models;

namespace TrabalhoFinal.Services
{
    public static class ConsumoItemServices
    {
        public static List<ConsumoItem> ConsumoItens { get; set; }
            = new List<ConsumoItem>()
        {
            new ConsumoItem
            {
                Id = 1,
                TarifaId = 1,
                NomeItem = "Água",
                Quantidade = 2,
                ValorTotal = 10.00m
            },

            new ConsumoItem
            {
                Id = 2,
                TarifaId = 2,
                NomeItem = "Refrigerante",
                Quantidade = 3,
                ValorTotal = 24.00m
            },

            new ConsumoItem
            {
                Id = 3,
                TarifaId = 3,
                NomeItem = "Sanduíche",
                Quantidade = 1,
                ValorTotal = 15.00m
            },

            new ConsumoItem
            {
                Id = 4,
                TarifaId = 4,
                NomeItem = "Chocolate",
                Quantidade = 2,
                ValorTotal = 13.00m
            }
        };

        public static void Listar()
        {
            foreach (ConsumoItem item in ConsumoItens)
            {
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"Tarifa ID: {item.TarifaId}");
                Console.WriteLine($"Item: {item.NomeItem}");
                Console.WriteLine($"Quantidade: {item.Quantidade}");
                Console.WriteLine($"Valor total: R$ {item.ValorTotal:F2}");
                Console.WriteLine($"Data do consumo: {item.DataConsumo:dd/MM/yyyy HH:mm}");
                Console.WriteLine("-----------------------------");
            }
        }

        public static void BuscarPorId(int id)
        {
            ConsumoItem item = ConsumoItens.Find(i => i.Id == id);

            if (item != null)
            {
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"Tarifa ID: {item.TarifaId}");
                Console.WriteLine($"Item: {item.NomeItem}");
                Console.WriteLine($"Quantidade: {item.Quantidade}");
                Console.WriteLine($"Valor total: R$ {item.ValorTotal:F2}");
                Console.WriteLine($"Data do consumo: {item.DataConsumo:dd/MM/yyyy HH:mm}");
            }
            else
            {
                Console.WriteLine("Consumo não encontrado.");
            }
        }

        public static void Adicionar(
            int tarifaId,
            string nomeItem,
            decimal quantidade,
            decimal valorUnitario)
        {
            ConsumoItem item = new ConsumoItem();

            item.Id = ConsumoItens.Count > 0
                ? ConsumoItens.Max(i => i.Id) + 1
                : 1;

            item.TarifaId = tarifaId;
            item.NomeItem = nomeItem;
            item.Quantidade = quantidade;
            item.ValorTotal = quantidade * valorUnitario;

            ConsumoItens.Add(item);

            Console.WriteLine("Consumo adicionado com sucesso!");
        }

        public static void Editar(
            int id,
            int novaTarifaId,
            string novoNomeItem,
            decimal novaQuantidade,
            decimal novoValorUnitario)
        {
            ConsumoItem item = ConsumoItens.Find(i => i.Id == id);

            if (item != null)
            {
                item.TarifaId = novaTarifaId;
                item.NomeItem = novoNomeItem;
                item.Quantidade = novaQuantidade;
                item.ValorTotal = novaQuantidade * novoValorUnitario;

                Console.WriteLine("Consumo editado com sucesso!");
                Listar();
            }
            else
            {
                Console.WriteLine("Consumo não encontrado.");
            }
        }

        public static void Remover(int id)
        {
            ConsumoItem item = ConsumoItens.Find(i => i.Id == id);

            if (item != null)
            {
                ConsumoItens.Remove(item);

                Console.WriteLine("Consumo removido com sucesso!");
                Listar();
            }
            else
            {
                Console.WriteLine("Consumo não encontrado.");
            }
        }
    }
}