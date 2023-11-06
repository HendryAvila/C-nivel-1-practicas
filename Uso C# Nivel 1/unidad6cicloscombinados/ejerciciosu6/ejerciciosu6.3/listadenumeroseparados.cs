using System;

namespace ejerciciosu6._3
{

//. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
// El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista  
    class Program
    {
        static void Main(string[] args)
        {//main
        int n = 1 , con = 0, acu = 0, conl = 0;
        

         while (n >0)
         {//While de afuera
        Console.WriteLine("Ingrese un numero");
         n = int.Parse(Console.ReadLine());
        acu = 0;    
        while (n != 0)
        {//while de adentro
        acu += n;
        conl++;
        Console.WriteLine("Ingrese un numero");
         n = int.Parse(Console.ReadLine());
        }//while de adentro
        con++;
        Console.WriteLine("La lista numero " + con + " tiene " + conl + " numeros, " + "acumulando un total de" + acu + " numeros.");
        }//while de afuera   

        }//main
    }
}
