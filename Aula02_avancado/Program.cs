#region Exercio 1

public class Lampada
{
    private bool ligada;

    public Lampada(string estado)
    {
        if (estado == "ligada")
        {
            ligada = true;
        }
        else
        {
            ligada = false;
        }
    }

    public void Ligar()
    {
        ligada = true;
    }
    public void Desligar()
    {
        ligada = false;
    }

    public string ImprimirEstado()
    {
        if (ligada)
        {
            return "A lampada está ligada";
        }
        else
        {
            return "A lampada está desligada";
        }
    }

}

class Program
{
    static void Main()
    {
        Lampada lampada = new Lampada("ligada");
        System.Console.WriteLine(lampada.ImprimirEstado());
        lampada.Desligar();
        System.Console.WriteLine(lampada.ImprimirEstado());
    }
}


#endregion

#region Exercicio 2

public class Data
{
    private int dia;
    private int mes;
    private int ano;
    private int hora;
    private int minuto;
    private int segundo;
    private bool temHora;

    public static readonly int HORA12 = 12;
    public static readonly int HORA24 = 24;
    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
        temHora = false;
    }

    public Data(int dia, int mes, int ano, int hora, int minuto, int segundo)
    {
        temHora = true;
        new Data(dia, mes, ano);
        if (hora < 0 || hora > 23)
        {
            this.hora = 0;
        }
        else
        {
            this.hora = hora;
        }

        this.minuto = minuto;
        this.segundo = segundo;
    }



    public void ImprimirData(int formato)
    {
        if (temHora) {

            if (formato == HORA12)
            {
                if (hora > 12)
                {
                    System.Console.WriteLine($"{dia}/{mes}/{ano} {hora - 12}:{minuto}:{segundo} PM");
                }
                else
                {
                    System.Console.WriteLine($"{dia}/{mes}/{ano} {hora}:{minuto}:{segundo} AM");
                }
            }
            else if (formato == HORA24)
            {
                System.Console.WriteLine($"{dia}/{mes}/{ano} {hora}:{minuto}:{segundo}");
            }
        }
        else
        {
            System.Console.WriteLine($"{dia}/{mes}/{ano}");
        }
           
    }
}

class Program2
{
    static void Main()
    {
        Data data = new Data(1, 1, 2021);
        data.ImprimirData(Data.HORA24);
        Data data2 = new Data(1, 1, 2021, 13, 30, 30);
        data2.ImprimirData(Data.HORA12);
    }
}

#endregion
