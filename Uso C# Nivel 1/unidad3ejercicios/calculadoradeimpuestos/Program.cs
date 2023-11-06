using System;

class programa
{
    static void Main(string[] args)
// El cuerpo del método Main comienza aquí
//Calculadora de Impuestos:
//Escribe un programa que calcule el impuesto a pagar en función del ingreso anual.
//Define rangos de ingresos y tasas de impuestos (por ejemplo, 0% para ingresos menores a $10,000, 10% para ingresos entre $10,000 y $30,000, etc.).
//Solicita al usuario que ingrese su ingreso anual y muestra la cantidad de impuestos a
    {
        
     float ingresoanual;
    //Pedir el ingreso anual://
     Console.WriteLine("Ingrese su ingreso anual");
     ingresoanual = float.Parse(Console.ReadLine());

     // Agregar condiciones//
     if(ingresoanual >= 10000){
        if(ingresoanual > 30000){
            ingresoanual = ingresoanual * 0.90f;
            Console.WriteLine("Los impuestos a pagar en base a tu ingreso anual del 15%: " + ingresoanual);
        }else{
            ingresoanual= ingresoanual * 0.75f;
            Console.WriteLine("Los impuestos a pagar en base a tu ingreso anual del 10%: " + ingresoanual);
        }
     }

     

     
    } // El cuerpo del método Main termina aquí
}
