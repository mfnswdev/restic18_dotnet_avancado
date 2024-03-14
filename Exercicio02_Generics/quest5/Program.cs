public struct Ponto<T>
{
    public T X { get; set; }
    public T Y { get; set; }
    public T Z { get; set; }

    public Ponto(T x, T y, T z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}

public struct Triangulo<T>
{
    public Ponto<T> P1 { get; set; }
    public Ponto<T> P2 { get; set; }
    public Ponto<T> P3 { get; set; }

    public Triangulo(Ponto<T> p1, Ponto<T> p2, Ponto<T> p3)
    {
        P1 = p1;
        P2 = p2;
        P3 = p3;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Ponto<int> ponto1 = new Ponto<int>(0, 0, 0);
        Ponto<int> ponto2 = new Ponto<int>(1, 0, 0);
        Ponto<int> ponto3 = new Ponto<int>(0, 1, 0);

        Triangulo<int> triangulo = new Triangulo<int>(ponto1, ponto2, ponto3);

        Console.WriteLine("Pontos do triângulo:");
        Console.WriteLine($"P1: ({triangulo.P1.X}, {triangulo.P1.Y}, {triangulo.P1.Z})");
        Console.WriteLine($"P2: ({triangulo.P2.X}, {triangulo.P2.Y}, {triangulo.P2.Z})");
        Console.WriteLine($"P3: ({triangulo.P3.X}, {triangulo.P3.Y}, {triangulo.P3.Z})");
    }
}
