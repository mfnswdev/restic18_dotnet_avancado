using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Task task1 = DoWorkAsync("Tarefa 1");
        Task task2 = DoWorkAsync("Tarefa 2");

        await Task.WhenAll(task1, task2);


        Console.WriteLine("Ambas as tarefas foram concluídas.");
    }

    static async Task DoWorkAsync(string taskName)
    {
        for (int i = 1; i <= 5; i++) 
        {
            Console.WriteLine($"Executando {taskName}, Iteração {i}");
            await Task.Delay(1000); 
        }
    }
}
