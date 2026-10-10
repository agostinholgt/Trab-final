
using TrabalhoFinal.dominio;

namespace TrabalhoFinal.Servicos
{
    public static class SuiteService
    {
        public static List<Suite> Suites { get; set; } = new List<Suite>()
        {
            new Suite() { Id = 1, Numero = "101", Capacidade = 2, Diaria = 150.00m, Disponivel = true },
            new Suite() { Id = 2, Numero = "102", Capacidade = 4, Diaria = 250.00m, Disponivel = true },
            new Suite() { Id = 3, Numero = "201", Capacidade = 2, Diaria = 180.00m, Disponivel = false },
            new Suite() { Id = 4, Numero = "202", Capacidade = 5, Diaria = 320.00m, Disponivel = true },
            new Suite() { Id = 5, Numero = "301", Capacidade = 3, Diaria = 220.00m, Disponivel = false },
            new Suite() { Id = 6, Numero = "302", Capacidade = 6, Diaria = 400.00m, Disponivel = true }
        };

        public static void Remover(int id)
        {
            Suite suite = Suites.Find(s => s.Id == id);

            if (suite != null)
            {
                Suites.Remove(suite);
                Console.WriteLine("Suíte removida com sucesso!");
                Listar();
            }
            else
            {
                Console.WriteLine("Não foi possível encontrar a suíte.");
            }
        }

        public static void Editar(int id, string novoNumero, int novaCapacidade, decimal novaDiaria, bool novaDisponibilidade)
        {
            Suite suite = Suites.Find(s => s.Id == id);

            if (suite != null)
            {
                suite.Numero = novoNumero;
                suite.Capacidade = novaCapacidade;
                suite.Diaria = novaDiaria;
                suite.Disponivel = novaDisponibilidade;

                Console.WriteLine("Suíte editada com sucesso!");
                Listar();
            }
            else
            {
                Console.WriteLine("Não foi possível encontrar a suíte.");
            }
        }

        public static void Adicionar(string numero, int capacidade, decimal diaria, bool disponivel)
        {
            Suite suite = new Suite();

            suite.Id = Suites.Count > 0
                ? Suites.Max(s => s.Id) + 1
                : 1;

            suite.Numero = numero;
            suite.Capacidade = capacidade;
            suite.Diaria = diaria;
            suite.Disponivel = disponivel;

            Suites.Add(suite);

            Console.WriteLine("Suíte adicionada com sucesso!");
        }

        public static void Listar()
        {
            foreach (Suite suite in Suites)
            {
                Console.WriteLine($"ID: {suite.Id}");
                Console.WriteLine($"Número: {suite.Numero}");
                Console.WriteLine($"Capacidade: {suite.Capacidade} pessoas");
                Console.WriteLine($"Diária: R$ {suite.Diaria:F2}");
                Console.WriteLine($"Disponível: {(suite.Disponivel ? "Sim" : "Não")}");
                Console.WriteLine("---------------------");
            }
        }

        public static void BuscarPorId(int id)
        {
            Suite suite = Suites.Find(s => s.Id == id);

            if (suite != null)
            {
                Console.WriteLine($"ID: {suite.Id}");
                Console.WriteLine($"Número: {suite.Numero}");
                Console.WriteLine($"Capacidade: {suite.Capacidade} pessoas");
                Console.WriteLine($"Diária: R$ {suite.Diaria:F2}");
                Console.WriteLine($"Disponível: {(suite.Disponivel ? "Sim" : "Não")}");
            }
            else
            {
                Console.WriteLine("Não foi possível encontrar a suíte.");
            }
        }
    }
}
