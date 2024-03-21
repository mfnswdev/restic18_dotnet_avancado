using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(new Worker().Work);
        Thread thread2 = new Thread(new Worker().Work);

        Console.WriteLine("Iniciando threads...");

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Trabalho concluído. Programa encerrado.");
    }

    class Worker
    {
        public void Work()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: Trabalho em progresso ({i}/5)");
                Thread.Sleep(1000); // Simula algum tipo de trabalho
            }
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: Trabalho concluído.");
        }
    }
}