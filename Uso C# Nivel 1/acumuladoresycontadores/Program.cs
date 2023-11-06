using System;

class Program
{
    static void Main(string[] args)
    // El cuerpo del método Main comienza aquí
    {
        //Acumuladores y contadores//
        //operadores: ++/--/+=/-=/

        int contador = 0;
        int acumulador = 0;
        int promedio;
         int e1 = 30;
         int e2 = 20;
         int e3 = 15;

        if(e1 > 18)
        contador++;
        acumulador+= e1;

        if(e2 > 18)

        contador++;
        acumulador+= e2;

        if(e3 > 18)
            
        contador++;
        acumulador+= e3;

       promedio = acumulador/contador;
        

        Console.WriteLine("El resultado es: " + promedio);




        
    } // El cuerpo del método Main termina aquí
}
