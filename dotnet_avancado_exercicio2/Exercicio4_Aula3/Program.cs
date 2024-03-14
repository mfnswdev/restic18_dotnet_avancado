public interface IServico
{
    void Executar();
}
public class ServicoFabrica<T> where T : IServico, new()
{

    public void Executar()
    {
        System.Console.WriteLine("Executando o servico");
    }

    public T NovaInstancia()
    {
        return new T();
    }
}