using System;
using System.Globalization;
using CursoPOO.Entities;


List<Pessoa> listaDePessoas = new List<Pessoa>();

Console.Write("Digite o número de pagadores de imposto: ");
int numero = int.Parse(Console.ReadLine());

for  (int i = 1; i <= numero; i++)
{
    Console.WriteLine($"Dados do pagador de imposto {i}");
    Console.Write("Pessoa física ou jurídica? (f/j): ");
    string tipoPessoa = Console.ReadLine();

    if (tipoPessoa == "f")
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Renda anual: ");
        double rendaAnual = double.Parse(Console.ReadLine());
        Console.Write("Gastos com saúde: ");
        double gastoComSaude = double.Parse(Console.ReadLine());

        PessoaFisica pessoaFisica = new PessoaFisica(nome, rendaAnual, gastoComSaude);

        listaDePessoas.Add(pessoaFisica);
    }
    else
    {
        Console.Write("Nome da empresa: ");
        string nome = Console.ReadLine();
        Console.Write("Renda anual: ");
        double rendaAnual = double.Parse(Console.ReadLine());
        Console.Write("Número de funcionários: ");
        int funcionarios = int.Parse(Console.ReadLine());

        PessoaJuridica pessoaJuridica = new PessoaJuridica(nome, rendaAnual, funcionarios);

        listaDePessoas.Add((pessoaJuridica));
    }
}

foreach (Pessoa p in listaDePessoas)
{
    var retorno = p.CalculaImposto();
    Console.WriteLine($"{p.Nome}: ${retorno}");
}