class EXE2
{
    static void Main(string[] args)
    {
        Data d1 = new Data(10, 03, 2000, 10, 30, 10);
        d1.imprimir(Data.FORMATO_12H);
        d1.imprimir(Data.FORMATO_24H);

        Data d2 = new Data(15, 06, 2000, 23, 15, 20);
        d2.imprimir(Data.FORMATO_12H);
        d2.imprimir(Data.FORMATO_24H);

        Data d3 = new Data(5, 10, 2005);
        d3.imprimir(Data.FORMATO_12H);
        d3.imprimir(Data.FORMATO_24H);
    }

    public class Data{
        private int dia;
        private int mes;
        private int ano;
        private int hora;
        private int minuto;
        private int segundo;
        
        public static string FORMATO_12H = "hh:mm:ss tt";
        public static string FORMATO_24H = "hh:mm:ss";
        
        public Data(int dia, int mes, int ano){
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public Data(int dia, int mes, int ano, int hora, int minuto, int segundo) : this(dia, mes, ano){
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = segundo;
        }

        public void imprimir(){
            Console.WriteLine($"{this.dia}/{this.mes}/{this.ano}");
        }

        public void imprimir(string timeFormat){
            if(timeFormat == Data.FORMATO_12H){
                int horaFormatada;
                string daytime;

                if(this.hora >= 12){
                    horaFormatada = this.hora - 12;
                    daytime = "PM";
                }
                else {
                    horaFormatada = this.hora;
                    daytime = "AM";
                }

                Console.WriteLine($"{this.dia}/{this.mes}/{this.ano} {horaFormatada}:{this.minuto}:{this.segundo} {daytime}");
            }

            else if(timeFormat == Data.FORMATO_24H)
                Console.WriteLine($"{this.dia}/{this.mes}/{this.ano} {this.hora}:{this.minuto}:{this.segundo}");
            
            else
                Console.WriteLine("Formato inválido, utilize as constantes fornecidas pela classe data");
        }
    }
}












MSBuild version 17.4.8+6918b863a for .NET
  Determining projects to restore...
  All projects are up-to-date for restore.
/home/Program.cs(46,30): error CS0176: Member 'EXE2.Data.FORMATO_12H' cannot be accessed with an instance reference; qualify it with a type name instead [/home/home.csproj]
/home/Program.cs(62,35): error CS0176: Member 'EXE2.Data.FORMATO_24H' cannot be accessed with an instance reference; qualify it with a type name instead [/home/home.csproj]

Build FAILED.

/home/Program.cs(46,30): error CS0176: Member 'EXE2.Data.FORMATO_12H' cannot be accessed with an instance reference; qualify it with a type name instead [/home/home.csproj]
/home/Program.cs(62,35): error CS0176: Member 'EXE2.Data.FORMATO_24H' cannot be accessed with an instance reference; qualify it with a type name instead [/home/home.csproj]
    0 Warning(s)
    2 Error(s)
