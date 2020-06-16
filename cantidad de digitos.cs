using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

          int Num;
            string OP;
        

        Random ran = new Random();
            do
            {
                do
                {
                    Num = Convert.ToInt32(ran.Next(100));
                } while (!(((Num >= 10) & (Num <= 30))));
                Console.WriteLine("SE GENERO EL " + Num);
                Console.Write("GENERA OTRO NÚMERO S/N:"); OP = Console.ReadLine();
                OP = OP.ToUpper();
            } while (OP == "S");
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}