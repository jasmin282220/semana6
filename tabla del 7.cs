using System;

namespace tabla_del_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 0;
            int c = 0;

            Console.WriteLine("Digite el numero 7 de la tabla a mostrar:");
            b = int.Parse(Console.ReadLine());

            while (a <= 12) 
            {

                c = a * b;
                Console.WriteLine
                    (a + "X" + b + "==" + c);
                a = a + 1;

            }
            Console.ReadKey();
    }
}
}

