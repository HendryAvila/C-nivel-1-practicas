using System;

namespace ejercicio5
{
    class Program
    {
        private static void Main(string[] args)
        {
            int a, b, c;
            int notafinal;

            Console.WriteLine("Ingrese Su primera nota");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Su primera nota");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Su primera nota");
            c = int.Parse(Console.ReadLine());

            notafinal = (a + b + c)/3;

            Console.WriteLine("El Promedio final de las 3 notas es: " + notafinal);

            
        }
    
       //Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno 
       //y luego calcule y emita por pantalla el promedio final

    }
    }

