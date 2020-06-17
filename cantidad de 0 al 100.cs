using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            string comparacion = "0";

            for (int x = 0; x < 101; x++)
            {
                Console.WriteLine(x);
                string cont = x.ToString();
                char[] conteo = cont.ToCharArray();

                for (int y = 0; y < conteo.Length; y++)
                {
                    string p = conteo[y].ToString();
                    if (p == comparacion)
                    {
                        contador = contador + 1;
                    }

                }
            }
            Console.WriteLine("La cantidad de (0) entre el 0 y el 100 es: " + contador);
            Console.ReadKey();

        }
    }
}
       
