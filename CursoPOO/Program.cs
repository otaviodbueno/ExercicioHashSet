using System;
using System.Globalization;

HashSet<int> codigos = new HashSet<int>();

Console.WriteLine("Quantos cursos o professor leciona: ");
int q = int.Parse(Console.ReadLine());

for (int i = 0; i < q; i++)
{
    Console.WriteLine($"Quantos estudantes no curso {i+1}?");

    int n = int.Parse(Console.ReadLine());

    for (int j = 0; j < n; j++)
    {
        Console.Write("Digite o código do estudante: ");
        int codigoEstudante = int.Parse(Console.ReadLine());

        codigos.Add(codigoEstudante);
    }

}

Console.Write("TOTAL: ");
Console.WriteLine(codigos.Count);