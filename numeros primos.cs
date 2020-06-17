using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, numero, resi;
            string linea;
            x = 2;
            numero = 0;
            Console.WriteLine("numeros primos");
            Console.WriteLine();
            Console.Write("Ingrese el numero:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x < n && numero == 0)
            {
                resi = n % x;
                if (resi == 0)
                {
                    numero = 1;
                }
                else
                {
                    x = x + 1;
                }
            }
            if (numero == 0)
            {
                Console.WriteLine();
                Console.WriteLine("El numero ingresado es primo");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("El numero ingresado no es primo");
            }
            Console.ReadKey();
        }
    }
}
