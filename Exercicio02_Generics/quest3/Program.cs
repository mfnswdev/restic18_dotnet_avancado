﻿enum Exercicio
{
    academia = 1,
    luta = 2,
    corrida = 3

}

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Opções de exercícios disponíveis:");
        foreach (Exercicio exercicio in Enum.GetValues(typeof(Exercicio)))
        {
            Console.WriteLine($"{(int)exercicio}: {exercicio}");
        }

        Console.WriteLine("\nDigite o número correspondente ao exercício desejado:");
        string input = Console.ReadLine() ?? string.Empty;

        try
        {
           
            int exercicioEscolhido = int.Parse(input);
            if (Enum.IsDefined(typeof(Exercicio), exercicioEscolhido))
            {
                Exercicio exercicioSelecionado = (Exercicio)exercicioEscolhido;
                Console.WriteLine($"\nVocê selecionou o exercício: {exercicioSelecionado}");
            }
            else
            {
                Console.WriteLine("\nOpção inválida. Por favor, selecione um número válido.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("\nEntrada inválida. Por favor, digite um número inteiro.");
        }
    }
}
