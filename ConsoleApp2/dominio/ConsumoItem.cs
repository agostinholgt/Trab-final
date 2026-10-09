using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabalhoFinal.dominio
{ 
    public
        class ConsumoItem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public ConsumoItem(int id, string nome, decimal valor, int quantidade)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }
        public decimal CalcularTotal()
        {
            return Valor * Quantidade;
        }
    }
}

