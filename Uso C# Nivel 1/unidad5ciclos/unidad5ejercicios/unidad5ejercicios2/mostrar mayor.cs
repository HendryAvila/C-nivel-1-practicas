using System;

namespace unidad5ejercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
//Hacer un programa que solicite el ingreso de 10 números
//y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            int i, n1, mayor = 0;
            for(i= 0; i < 10; i++){
            Console.WriteLine("Ingrese su numero");
            n1 = int.Parse(Console.ReadLine());

            if(n1 > mayor){
                mayor = n1;

            }
            
            }
            Console.WriteLine("El numero mayor es: " + mayor);
        }
    }
}
