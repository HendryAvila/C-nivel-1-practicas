using System;

namespace unidad4
{
    class Program
    {
//Una tienda de electrónicos vende televisores con diferentes características y precios.
// Elige al menos tres características (por ejemplo, tamaño de pantalla, tipo de resolución, tipo de pantalla)
// y crea una escala de precios basada en las opciones seleccionadas. 
//Luego, desarrolla un programa que solicite al usuario las opciones de características, 
//calcule el precio total y lo muestre por pantalla.
//Tamaño de pantalla:
//32 pulgadas (1) - USD 300
//42 pulgadas (2) - USD 500
//55 pulgadas (3) - USD 800
//Tipo de resolución:
//Full HD (1) - USD 0 (sin costo adicional)
//4K Ultra HD (2) - USD 200
//Tipo de pantalla:
//LED (1) - USD 0 (sin costo adicional)
//OLED (2) - USD 400
        static void Main(string[] args)
        {//empieza el main
    // variables a utilizar//
    int pantalla, resolucion, tpantalla;
    float precio = 0;
    //pedimos los datos//
    Console.WriteLine("Elija el tamaño de su pantalla");
    pantalla = int.Parse(Console.ReadLine());
     //aqui pedimos resolucion
    Console.WriteLine("Elija la resolucion  de su pantalla");
    resolucion = int.Parse(Console.ReadLine());
     //aqui pedimos tipo de pantalla//
    Console.WriteLine("Elija el tipo de su pantalla");
    tpantalla = int.Parse(Console.ReadLine());

    //aqui empezamos las condicion o casos//

    switch(pantalla){
        case 1:
          precio += 300;
          Console.WriteLine("32 pulgadas");
          break;
        case 2:
           precio +=  500;
           Console.WriteLine("42 pulgadas");
           break;
        case 3:
           precio += 800;
           Console.WriteLine("55 pulgadas");   
           break;
        }

        switch (resolucion){
            case 1:
               precio += 0;
               Console.WriteLine("Full HD  (Sin costo adicional) ");
               break;
            case 2:
               precio += 200;
               Console.WriteLine("4K Ultra HD");  
               break; 


        }

        switch(tpantalla){
            case 1:
               precio += 0;
               Console.WriteLine("LED (Sin costo adicional)");
               break;
            case 2:
               precio += 400;
               Console.WriteLine("OLED") ;
               break;  
        }

        Console.WriteLine("El total de su compra es: " + precio);



     
     }//finaliza el main
   

    } //namespace
    
    } //using  

    
    
        
        
    


