using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
             Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            */

            int n1, con = 0, resultado = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese 20 numero");
                Console.WriteLine("ingrese un numero");
                n1 = int.Parse(Console.ReadLine());
                resultado = buscarpar(n1);
                if (resultado == 1)
                {
                    con++;
                }
                
            }
            Console.WriteLine("La cantidad de numeros pares es: " + con );
            
            }
            static int buscarpar(int n1){
            
            
             if (n1 % 2 == 0)
            {
                n1 = 1;
            
                return n1;
                
            }

            else
            {
                n1 = 0;
                return n1;
            }
             

        }

        
        
        }
    }

