using System;
using System.Diagnostics;

namespace cortedecontrol
{
    class Program
    {
        static void Main(string[] args)
        { 
          int promedio, acu = 0, con = 0, ns, su, edad, nsact = 0; //variables a usar
          string np, se;  
          //pido las  4 variables//
          Console.WriteLine("Ingrese el nombre de su personaje: ");
          np = Console.ReadLine();
          Console.WriteLine("Ingrese el nombre de la serie: ");
          se = Console.ReadLine();
          Console.WriteLine("Ingrese el numero de serie: ");
          ns = int.Parse(Console.ReadLine());
          Console.WriteLine("Ingrese el monto de su sueldo: ");
          su = int.Parse(Console.ReadLine());
          Console.WriteLine("Ingrese la edad de su personaje: ");
          edad = int.Parse(Console.ReadLine());
          //hago la primera condicion con while//
          while (ns != 0)
          {//aqui va el corte de control//
            nsact = ns;// quiero actualizar aqui el numero de serie cuando entre en el loop
            while (ns ==  nsact)// siempre que ns sea el actual quiero entrar en el ciclo para que cuando no sea el mismo me de un gp distinto.
            {

                //aqui dentro pido el siguiente personaje//
          Console.WriteLine("Ingrese el nombre de su personaje: ");
          np = Console.ReadLine();
          Console.WriteLine("Ingrese el nombre de la serie: ");
          se = Console.ReadLine();
          Console.WriteLine("Ingrese el monto de su sueldo: ");
          su = int.Parse(Console.ReadLine());
          Console.WriteLine("Ingrese la edad de su personaje: ");
          edad = int.Parse(Console.ReadLine());
          Console.WriteLine("Ingrese el numero de serie: ");
          ns = int.Parse(Console.ReadLine());

              
                
            }//while de adentro termina aca
           

            
          }//primer while

          //aqui promedio total
            
        }//aqui termina el main
    }
}
