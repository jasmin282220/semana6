using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            c = 0;
            Console.WriteLine("Ingrese un numero positivo");
            a = int.Parse(Console.ReadLine());

            for (b = 1; b < a; b++)
            {
                if(a%b==0)
                {
                    c = c + 1;
                }
    }
            if(c >2)
            {
                Console.WriteLine("El numero ingresado no es primo:", a);

            }
            else
            {
                Console.WriteLine("El numero ingresado es primo:", a);
            }
            Console.ReadKey();
        }
    }
}
