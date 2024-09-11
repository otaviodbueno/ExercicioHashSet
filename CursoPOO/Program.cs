using System;
using System.Globalization;
using CursoPOO.Entities;

try
{
    Console.WriteLine("Entre com os dados da conta: ");
    Console.Write("Número: ");
    int numeroDaConta = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Saldo inicial: ");
    double saldoInicial = double.Parse(Console.ReadLine());
    Console.Write("Limite de saque da conta: ");
    int limiteSaque = int.Parse(Console.ReadLine());

    Console.Write("Valor desejado de saque: ");
    double saque = double.Parse(Console.ReadLine());

    ContaBancaria conta = new ContaBancaria(numeroDaConta, nome, saldoInicial, limiteSaque, saque);

    double saldoNovo = conta.RealizarSaque(saque);

    Console.WriteLine($"Novo saldo: {saldoNovo}");
}
catch(DomainException ex)
{
    Console.WriteLine("Erro no saque: " + ex.Message);
}