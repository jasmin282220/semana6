using System;

namespace cantidad__de__digitos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, digito = 0;
            Console.WriteLine("Ingrese un numero positivo:");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                num = num / 10;
                digito = digito + 1;
            } while (num > 0);
            Console.WriteLine("El numero ingresado tiene:" +  digito +  "digitos");
            Console.ReadLine();
    }
}
}
