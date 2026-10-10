using System;

public class Pagamentos
{
    public int Id { get; set; }
    public int ReservaId { get; set; }
    public double Valor { get; set; }
    public double FormaPagamento { get; set; }
    public DateTime DataPagamento { get; set; }
    public bool StatusPagamento { get; set; }

}