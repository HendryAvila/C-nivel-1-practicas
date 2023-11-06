using System;

namespace funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            n2 = int.Parse(Console.ReadLine());

            resultado = suma(n1,n2);

            Console.WriteLine("EL resultado del producto  es " + resultado);
        }

        static int suma(int numero1, int numero2){
          int  resultado;
          resultado = numero1 * numero2;
          return resultado;
        }
    }
}
