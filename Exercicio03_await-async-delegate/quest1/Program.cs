class Program
{

    static void Main(string[] args)
    {
        List<double> Lista = new List<double> { 3, 7, 4, 2, 6 };
        List<double> novaLista = new List<double>();

        novaLista = Lista.ConvertAll(x => x / 2);

        novaLista.ForEach(x => Console.WriteLine(x));

    }

}