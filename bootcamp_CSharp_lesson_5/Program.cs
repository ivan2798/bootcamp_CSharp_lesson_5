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
            Console.WriteLine("¡Deseas entrar en el bucle while?");

            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("estás ejecutando el interior del bucle while");

                Console.WriteLine("Introduce tu nombre, por favor");

                string nombre = Console.ReadLine();

                Console.WriteLine($"Saldrás del bucle {nombre} cuando respondas 'no' a la pregunta");

                Console.WriteLine("¿Deseas repetir otra vez?");

                respuesta = Console.ReadLine(); 

            }

            Console.WriteLine("Has salido del bucle");
            

        }


    }
}