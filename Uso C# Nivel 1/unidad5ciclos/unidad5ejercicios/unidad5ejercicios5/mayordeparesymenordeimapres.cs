using System;

namespace unidad5ejercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números
            // y luego emitir por pantalla el máximo de los números pares
            // y el mínimo de los números impares.
            
            int numero = 0, i, mayor = 0, menor = 0, conpar = 0, conimpar =  0;

            for(i = 0; i < 20; i++){
         Console.WriteLine("ingrese su numero");
         numero = int.Parse(Console.ReadLine());
           if(numero % 2 == 0){ //si resto dividido entre 2 me da 0 es par aqui estamos depurando para buscar el par
            conpar++;// aqui sumamos al contador par para llevar un cuenta de cual es el primer par

            if(conpar == 1)
              mayor = numero;
            else if(numero > mayor)//aqui actualizamos valores a medida que se ingresa
            mayor = numero; 

            //aqui busco pares
           }else{
            conimpar++;
            if(conimpar == 1)
            menor = numero;
            else if( numero < menor)
            menor = numero;
            //aqui busco impares
           }

    
            }
            Console.WriteLine("El mayor de los pares es: " + mayor);
             Console.WriteLine("El menor de los impares es: " + menor);
        }
    }}

