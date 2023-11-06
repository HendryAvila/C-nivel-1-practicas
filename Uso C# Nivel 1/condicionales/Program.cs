using System;

namespace condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo numero");
            d = int.Parse(Console.ReadLine());

               if(a > 100)
               Console.WriteLine("El primer valor: " + a + " Es mayor a 100");

               if(b > 100)
               Console.WriteLine("El segundo valor: " + b + " Es mayor a 100");

               if(c > 100)
               Console.WriteLine("El tercer valor: " + c + " Es mayor a 100");

               if(d > 100)
               Console.WriteLine("El cuarto valor: " + d + " Es mayor a 100");

        }
    }
}
