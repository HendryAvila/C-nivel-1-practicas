using System;

internal class Programa
{
    static void Main(string[] args)
    {
    
    //Hacer un programa para ingresar cuatro números
    // y luego mostrar por pantalla cuáles son mayores a 100
    int a, b, c, d, con = 0;
    

    Console.WriteLine("Ingrese su numero");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su numero");
    b = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su numero");
    c = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su numero");
    d = int.Parse(Console.ReadLine());

    if(a>100){
        Console.WriteLine("El primer valor mayor a 100 es: " + a);
        con++;
    } if(b > 100){
        Console.WriteLine("El segundo valor mayor a 100 es: " + b);
        con++;
    }if(c > 100){
        Console.WriteLine("El tercer valor mayor a 100 es: " + c);
        con++;
    } if(d > 100){
        Console.WriteLine("El cuarto valor mayor a 100 es: " + d);
        con++;
    }
    if(con != 0)
         Console.WriteLine("Son mayores a 100...");

         Console.WriteLine("Aqui termina el programa");

    }
}
