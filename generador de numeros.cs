﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace generador_de_numeros_aleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();


            for (int i = 0; i < 100; i++) ;
            int numero = rnd.Next(50, 100);

            Console.WriteLine("El numero generado es: " + numero);

            int opcion = 0;
            do
            {
                Console.WriteLine("Menu de Opciones");
                Console.WriteLine("\n" +
                    "\n 1.presione(1)si- ¿Desea generar otro numero?" +
                    "n  2.-presione (S) para salir");
                Console.WriteLine("Digite una opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("el numero generado es:"+numero);
                        break;
                    case 2:
                        Console.WriteLine("Saliendo de la aplicacion");
                        break;
                    default:
                        Console.WriteLine("Digite una opcion valida");
                        break;
                }


                Console.ReadKey();

            } while (opcion != 2);
        }
    }
}


