using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhoPaulo.Models;

namespace TrabalhoPaulo.Services
{
    public class ConsumoitemServices
    {
        private readonly List<ConsumoItem> _consumoList;
        private readonly TarifasServices _tarifasServices;

        public ConsumoitemServices(TarifasServices tarifasServices)
        {
            _consumoList = new List<ConsumoItem>();
            _tarifasServices = tarifasServices;
        }

        public void RegistrarConsumo(ConsumoItem consumo)
        {
            var tarifa = _tarifasServices.ObterPorId(consumo.TarifaId);

            if (tarifa == null || !tarifa.Ativo)
            {
                throw new Exception("Tarifa inválida ou inativa.");
            }

            consumo.ValorTotal = consumo.Quantidade * tarifa.ValorUnitario;

            consumo.Id = _consumoList.Count > 0 ? _consumoList.Max(c => c.Id) + 1 : 1;
            _consumoList.Add(consumo);
        }

        public List<ConsumoItem> ListarConsumos()
        {
            return _consumoList;
        }

        public decimal CalcularTotalGeral()
        {
            return _consumoList.Sum(c => c.ValorTotal);
        }
    }
}