namespace ConsoleApp2.Services
{
    public static class suiteServices

	{
	public List<suite> suites = new List<suite>()
{
	new suite
	{
		Id = 1,
		Numero = "101",
		Capacidade = 2,
		Diaria = 150.00m,
		Disponivel = true
	},

	new suite
	{
		Id = 2,
		Numero = "102",
		Capacidade = 4,
		Diaria = 250.00m,
		Disponivel = true
	},

	new suite
	{
		Id = 3,
		Numero = "201",
		Capacidade = 2,
		Diaria = 180.00m,
		Disponivel = false
	},

	new suite
	{
		Id = 4,
		Numero = "202",
		Capacidade = 5,
		Diaria = 320.00m,
		Disponivel = true
	},

	new suite
	{
		Id = 5,
		Numero = "301",
		Capacidade = 3,
		Diaria = 220.00m,
		Disponivel = false
	},

	new suite
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
