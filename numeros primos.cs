using System;

namespace numero_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("ingrese un numero positivo:");
            numero = int.Parse(Console.ReadLine());


            if (numero % 1 == 0)
            {
                Console.WriteLine("El numero ingresado es primo");
            }
            else
            {
                Console.WriteLine("El numero ingresado no es primo :(");
            }

        }
    }
}
       