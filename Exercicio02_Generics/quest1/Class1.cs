﻿namespace Aula3_Exercicio1;

public class ContaBancaria
{
    private double Saldo { get; set; }

    public string Sacar(double valor)
    {
        try{
        if (valor > this.Saldo)
        {
            throw new SaldoInsuficienteExeption(this);
        }
        else
        {
            this.Saldo -= valor;
            System.Console.WriteLine($"Saque de R${valor} efetuado com sucesso, saldo atual de R${this.Saldo}"); 
            return $"Saque de R${valor} efetuado com sucesso, saldo atual de R${this.Saldo}";
        }
        } catch (SaldoInsuficienteExeption ex)
        {
            System.Console.WriteLine(ex.mensagemDeErro);
            return ex.mensagemDeErro;
        }
    }

    public string Depositar(double valor)
    {
        try
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoExeption(valor);
            }
            else
            {
                this.Saldo += valor;
                System.Console.WriteLine($"Deposito de R${valor} efetuado com sucesso, saldo atualizado de R${this.Saldo}");
                return $"Deposito de R${valor} efetuado com sucesso, saldo atualizado de R${this.Saldo}";       
            }
        }
        catch (ValorInvalidoExeption ex)
        {
            System.Console.WriteLine(ex.mensagemDeErro);
            return ex.mensagemDeErro;
        }
    }


    public string Transferir(double valor, ContaBancaria conta)
    {
        try
        {
            if (conta == null)
            {
                return "Conta inexistente";
            }
            else if (this.Saldo < valor)
            {
                throw new SaldoInsuficienteExeption(this);
            }
            else
            {
                this.Saldo -= valor;
                conta.Saldo += valor;
                System.Console.WriteLine($"Transferencia de R${valor} efetuada com sucesso, saldo atual de sua conta é R${this.Saldo}");
                return $"Transferencia de R${valor} efetuada com sucesso, saldo atual de sua conta é R${this.Saldo}";
            }
        }
        catch (SaldoInsuficienteExeption ex)
        {
            System.Console.WriteLine(ex.mensagemDeErro);
            return ex.mensagemDeErro;
        }
    }

    public class SaldoInsuficienteExeption : Exception
    {
        public string mensagemDeErro { get; }
        public SaldoInsuficienteExeption(ContaBancaria conta)
        {
            mensagemDeErro = $"Saldo insuficiente para realizar a operação, seu saldo atual de R${conta.Saldo}";
        }

    }
    public class ValorInvalidoExeption : Exception
    {
        public string mensagemDeErro { get; }

        public ValorInvalidoExeption(double valor)
        {
            mensagemDeErro = $"O valor informado deve válido, o valor informado de R${valor} não é válido";

        }
    }

}

class Program{
    static void Main(string[] args)
    {
       ContaBancaria c1 = new ContaBancaria();
       ContaBancaria c2 = new ContaBancaria();

       c1.Depositar(200);
       c2.Depositar(500);

       c1.Sacar(75);
       c1.Transferir(75, c2);

       c2.Sacar(150);
       c2.Transferir(501, c1);
       c1.Sacar(100);
    }
}
