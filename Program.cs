using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.Write("Digite um Número: ");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < valor; i = i + 2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
