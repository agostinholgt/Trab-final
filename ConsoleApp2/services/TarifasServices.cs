using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhoPaulo.Models;

namespace TrabalhoPaulo.Services
{
    public class TarifasServices
    {   
        private readonly List<Tarifas> _tarifasList;

        public TarifasServices()
        {
            _tarifasList = new List<Tarifas>();
        }

        public void AdicionarTarifa(Tarifas tarifa)
        {
            if (tarifa.ValorUnitario <= 0)
            {
                throw new ArgumentException("O valor da tarifa deve ser maior que zero.");
            }

            tarifa.Id = _tarifasList.Count > 0 ? _tarifasList.Max(t => t.Id) + 1 : 1;
            _tarifasList.Add(tarifa);
        }

        public List<Tarifas> ListarTodas()
        {
            return _tarifasList;
        }

        public Tarifas ObterPorId(int id)
        {
            return _tarifasList.FirstOrDefault(t => t.Id == id);
        }

        public void DesativarTarifa(int id)
        {
            var tarifa = ObterPorId(id);
            if (tarifa != null)
            {
                tarifa.Ativo = false;
            }
        }
    }
}