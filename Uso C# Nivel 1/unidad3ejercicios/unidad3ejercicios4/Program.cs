using System;

class Program
{
    static void Main(string[] args)
    {
    
     

    int a, b, c, d;
    

    Console.WriteLine("Ingrese su numero");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su numero");
    b = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su numero");
    c = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su numero");
    d = int.Parse(Console.ReadLine());

    int menor = a;

   if(b < menor){
    menor = b;

   } if (c < menor){
    menor = c;
   }if (d < menor){
    menor = d;
   }
   Console.WriteLine("El numero menor es: "+ menor);

    }
}
