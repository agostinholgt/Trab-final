using System;

namespace TrabalhoPaulo.Models
{
    public class Tarifas
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public DateTime DataVigencia { get; set; }
        public bool Ativo { get; set; }

        public Tarifas ()
        {
            DataVigencia = DateTime.Now;
            Ativo = true;
        }
    }
}