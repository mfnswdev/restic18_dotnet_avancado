﻿namespace Aula3_Exercicio2;

public class NullException : Exception
{
    public NullException(string mensagem) : base(mensagem)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        object? o = null;
        try
        {
            if (o == null)
            {
                throw new NullException("O objeto informado é nulo");
            }
            o.ToString();
        }
        catch (NullException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}
