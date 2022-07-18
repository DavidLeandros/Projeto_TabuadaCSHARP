using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero da tabuada: ");
            int tabu = int.Parse(Console.ReadLine());
            int result = 0;

            Console.WriteLine("\n" + "A tabuada do " + tabu + " é: \n" );

            for(int x = 0; x < 11; x++)
            {
                result = tabu * x;

                Console.WriteLine(tabu + "x" + x + " = " + result + "\n");

            }
        }
    }
}
