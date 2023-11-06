using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
             Hacer un programa para ingresar números. 
            El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.*/
            int n1, r;
            float promedio = 0, con = 0, acu = 0;
            Console.WriteLine("Ingresa un numero y corta con 0");
            n1 = int.Parse(Console.ReadLine());
            while ( n1 != 0)
            {
            r = primo(n1);
            if (r == 1)
            {
                con++;
                acu += n1;
            }
            Console.WriteLine("Ingresa un numero y corta con 0");
            n1 = int.Parse(Console.ReadLine());
            }

           promedio = acu/con;
           Console.WriteLine("El promedio teniendo en cuenta solo los numeros primos es: " + promedio);

        }

        static int primo(int n1){
            int con;
            if (n1 <= 1)
    {
        return 0; // Los números menores o iguales a 1 no son primos      
                con = 0;

                for (int i = 1; i < n1; i++)
                {
                    if (n1 % i == 0)
                    {
                    
                        con++;
                    }
                } if (con == 2)
                {
                    
                    return 1;
                }else
                {
                    
                    return 0;
                }
            
        }
    }
}
