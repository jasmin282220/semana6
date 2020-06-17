using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero positivo:");
            int numero = Convert.ToInt32(Console.ReadLine());

            int i; int a = 0;

            for (i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    a++;
                    i = numero;
                    i++;
                }
                if (a == 0)
                {
                    Console.WriteLine(numero + "si es un numero primo");
                }
                else
                {
                    Console.WriteLine(numero + "no es un  numero primo");
                }
                Console.ReadKey();
            }
        }
    }
}
        