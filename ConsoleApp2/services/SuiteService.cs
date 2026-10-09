using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.dominio;

namespace TrabalhoFinal.Services
{
    public static class SuiteServices
    {
        public static List <Suite> Suites = new List <Suite>()
        {
            new Suite
            {
                Id = 1,
                Numero = "101",
                Capacidade = 2,
                Diaria = 150.00m,
                Disponivel = true
            },

            new Suite
            {
                Id = 2,
                Numero = "102",
                Capacidade = 4,
                Diaria = 250.00m,
                Disponivel = true
            },

            new Suite
            {
                Id = 3,
                Numero = "201",
                Capacidade = 2,
                Diaria = 180.00m,
                Disponivel = false
            },

            new Suite
            {
                Id = 4,
                Numero = "202",
                Capacidade = 5,
                Diaria = 320.00m,
                Disponivel = true
            },

            new Suite
            {
                Id = 5,
                Numero = "301",
                Capacidade = 3,
                Diaria = 220.00m,
                Disponivel = false
            },

            new Suite
            {
                Id = 6,
                Numero = "302",
                Capacidade = 6,
                Diaria = 400.00m,
                Disponivel = true
            }
        };
    }
}
