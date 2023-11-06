using System;
using System.Diagnostics.Contracts;

namespace unidad5ejercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
     //Hacer un programa que solicite UN número y 
     //luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. 
     // Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.     
     float numero;
     float i;
     int con = 0;
     Console.WriteLine("Ingrese un numero");
     numero = int.Parse(Console.ReadLine());

     for(i = 1; i <= numero; i++){
        if(numero%i == 0){
            con++;
        }
        
     }if(con == 2){
        Console.WriteLine("Es primo");

     }else{
        Console.WriteLine("No es primo");
     }


      
        

     

        }//finaliza el main
    }
}
