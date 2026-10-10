using System;

namespace TrabalhoFinal.dominio
{
    public class ConsumoItem
    {
        public int Id { get; set; }
        public int TarifaId { get; set; }
        public string NomeItem { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataConsumo { get; set; }

        public ConsumoItem()
        {
            DataConsumo = DateTime.Now;
        }
    }
}