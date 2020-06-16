using System;

namespace numero_positivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("ingrese un numero positivo:");
            numero = int.Parse(Console.ReadLine());


            if (numero % 2 == 0) {
                Console.WriteLine("El numero ingresado es par");
            }
             else{
                Console.WriteLine("El numero ingresado es impar");
            }

        }
    }
}
