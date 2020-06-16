using System;

namespace Recorrido_1_50_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            Console.WriteLine("Holis, a continuacion haremos un recorrido del 1 al 50");
            for (numeros= 1; numeros <= 50; numeros++)
            {
                Console.Write(numeros);
                Console.Write("-");
            }
            Console.ReadKey();
        }
    }
}
       