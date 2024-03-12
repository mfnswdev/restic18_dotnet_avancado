// #region Exercicio1
// public class Lampada {
//     private bool ligada;

//     public Lampada(string onligada){
//         if(onligada == "on"){
//             ligada = true;
//         } else {
//             ligada = false;
//         }
       
//     }

//     public string imprimir() {
//         if(ligada){
//             return "Lâmpada está ligada";
//         } else {
//             return "Lâmpada está desligada";
//         }
        
//     }
//     public void Ligar() {
//         ligada = true;
//     }
//     public void Desligar() {
//         ligada = false;
//     }
  

     

//     public static void Main() {
//         Lampada lampada = new Lampada("on");
//         lampada.Ligar();
//         lampada.Desligar();
//         System.Console.WriteLine(lampada.imprimir());
//     }
// }
// #endregion

#region Exercicio2
public class Data {
    private int dia;
    private int mes;
    private int ano;
    private int hora;
    private int minutos;
    private int segundos;

    public static readonly int FORMATO_12H = 12;
    public static readonly int FORMATO_24H = 24;
    public Data(int dia, int mes, int ano){
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }

    public Data(int dia, int mes, int ano, int hora, int minutos, int segundos) : this(dia, mes, ano) {
        this.hora = hora;
        this.minutos = minutos;
        this.segundos = segundos;
    }
     public int Dia
    {
        get { return dia; }
    }

    public int Mes
    {
        get { return mes; }
    }

    public int Ano
    {
        get { return ano; }
    }

    public int Hora
    {
        get { return hora; }
    }

    public int Minutos
    {
        get { return minutos; }
    }

    public int Segundos
    {
        get { return segundos; }
    }

    
    public void imprimir(int formatoHora) {
        string data = $"{dia}/{mes}/{ano}";
        string horario = "";

        if (hora != 0 || minutos != 0 || segundos != 0)
        {
            if (formatoHora == FORMATO_12H)
            {
                string periodo = hora < 12 ? "AM" : "PM";
                horario = $"{hora % 12}:{minutos}:{segundos} {periodo}";
            }
            else
            {
                horario = $"{hora}:{minutos}:{segundos}";
            }
        }

        Console.WriteLine($"{data} {horario}");
    }

    public static void Main() {
        Data data = new Data(1, 1, 2023, 12, 0, 0);
        data.imprimir(Data.FORMATO_12H);
        data.imprimir(Data.FORMATO_24H);
    }

};

#endregion