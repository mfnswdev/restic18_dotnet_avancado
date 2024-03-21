using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public class ItemMercado
    {
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public double Preco { get; set; }
    }

    public enum Tipo { Comida, Bebida, Higiene, Limpeza };

    static void Main(string[] args)
    {
        List<ItemMercado> ListaMercado = new List<ItemMercado> {
            new ItemMercado { Nome = "Arroz", Tipo = Tipo.Comida, Preco = 3.90 },
            new ItemMercado { Nome = "Azeite", Tipo = Tipo.Comida, Preco = 2.50 },
            new ItemMercado { Nome = "Macarrao", Tipo = Tipo.Comida, Preco = 3.90 },
            new ItemMercado { Nome = "Cerveja", Tipo = Tipo.Bebida, Preco = 22.90 },
            new ItemMercado { Nome = "Refrigerante", Tipo = Tipo.Bebida, Preco = 5.50 },
            new ItemMercado { Nome = "Shampoo", Tipo = Tipo.Higiene, Preco = 7.00 },
            new ItemMercado { Nome = "Sabonete", Tipo = Tipo.Higiene, Preco = 2.40 },
            new ItemMercado { Nome = "Cotonete", Tipo = Tipo.Higiene, Preco = 5.70 },
            new ItemMercado { Nome = "Sabão em Pó", Tipo = Tipo.Limpeza, Preco = 8.20 },
            new ItemMercado { Nome = "Detergente", Tipo = Tipo.Limpeza, Preco = 2.60 },
            new ItemMercado { Nome = "Amaciante", Tipo = Tipo.Limpeza, Preco = 6.40 },
        };

        ListaMercado.Where(x => x.Tipo == Tipo.Higiene).OrderByDescending(x => x.Preco).ToList().ForEach(x => Console.WriteLine($"Nome: {x.Nome} | Tipo: {x.Tipo} | Preço: {x.Preco}"));
        ListaMercado.Where(valor => valor.Preco >= 5.00).OrderBy(x => x.Preco).ToList().ForEach(x => Console.WriteLine($"Nome: {x.Nome} | Tipo: {x.Tipo} | Preço: {x.Preco}"));
        ListaMercado.Where(tipo => tipo.Tipo == Tipo.Bebida || tipo.Tipo == Tipo.Comida).OrderBy(x => x.Nome).ToList().ForEach(x => Console.WriteLine($"Nome: {x.Nome} | Tipo: {x.Tipo} | Preço: {x.Preco}"));
        ListaMercado.GroupBy(item => item.Tipo).Select(group => new { Tipo = group.Key, Quantidade = group.Count() }).ToList().ForEach(x => Console.WriteLine($"Tipo: {x.Tipo} | Quantidade: {x.Quantidade}"));
        ListaMercado.GroupBy(item => item.Tipo).Select(group => new
        {
            Tipo = group.Key,
            PrecoMaximo = group.Max(item => item.Preco),
            PrecoMinimo = group.Min(item => item.Preco),
            PrecoMedio = group.Average(item => item.Preco)
        }).ToList().ForEach(x => Console.WriteLine($"Tipo: {x.Tipo} | Preco Maximo: {x.PrecoMaximo} | Preco Minimo: {x.PrecoMinimo} | Preco Medio: {x.PrecoMedio}"));
    }
}