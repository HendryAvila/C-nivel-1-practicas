using System;

namespace unidad5ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
    // Hacer un programa que solicite 20 edades 
    //y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            int edad, i, acu = 0;
            float promedio;
            float con = 0;

            for(i = 0; i < 20; i++){
            Console.WriteLine("ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            if(edad > 18){
                acu += edad;
                con++;
                
            }

            }

         promedio = acu/con;

         Console.WriteLine("El promedio de edades mayores a 18 es: " + promedio);

        }
    }
}
