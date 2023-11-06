using System;

class Programa{
    static void Main(string[] args)
    //Hacer un programa para ingresar un número
    // y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero,
    // “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
    {
      int a;

      Console.WriteLine("Ingrese su numero");
      a = int.Parse(Console.ReadLine());

      //Aqui empiezan las condiciones//

      if(a > 0){
        Console.WriteLine("Positivo");
      } if (a < 0){
        Console.WriteLine("Negativo");
      }if (a == 0){
        Console.WriteLine("Cero");
      }

      Console.WriteLine("El resultado es: " + a);






        
    } 
}