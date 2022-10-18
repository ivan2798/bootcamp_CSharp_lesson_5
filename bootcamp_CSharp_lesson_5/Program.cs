using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;

// Hello World! program
namespace bootcamp_CSharp_lesson_5
{
    class Program
    {
        // intellisense

        static void Main(string[] args)
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int miNumero = 101;

            int intentos = 0;

            Console.WriteLine("Introduce un n° entre 0 y 100");

            while (aleatorio != miNumero)
            {
                intentos++;

                miNumero = int.Parse(Console.ReadLine());

                if (miNumero > aleatorio) Console.WriteLine("El n° es más bajo");

                if (miNumero < aleatorio) Console.WriteLine("El n° es más alto");


            }

            Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

        }


    }
}