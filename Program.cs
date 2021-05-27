using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, auxiliar, i, n;
            bool validaNum;

            a = 0;
            b = 1;
            i = 0;

            Console.WriteLine("----Sequência de Fibonacci----");
            Console.Write("Digite um número: ");
            validaNum = Int32.TryParse(Console.ReadLine(), out n);

            if (validaNum == true)
            {
                Console.Write("\nSérie de Fibonacci:\n\n");
                Console.WriteLine($"{a} \n{b}");

                while (i == 0 || i <= n)
                {
                    auxiliar = a + b;
                    a = b;
                    b = auxiliar;
                    i++;

                    Console.WriteLine($"{auxiliar}");
                }
            }

            else
            {

                Console.WriteLine("Digite um número válido.");

            }
        }
    }
}