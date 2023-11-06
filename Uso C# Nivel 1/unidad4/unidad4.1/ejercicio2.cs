using System;

namespace ejercicio2
{
    class Program
    {
//Hacer un programa para ingresar tres números
// y emitir un cartel aclaratorio 
//si la suma de los dos primeros es mayor al producto del segundo con el tercero.
        static void Main(string[] args)
        {//empieza el main
        int n1, n2, n3, suma, producto;
     //pido los 3 numeros a ingreasar
     Console.WriteLine("Ingresa el primer numeri");
     n1 = int.Parse(Console.ReadLine());
     Console.WriteLine("Ingresa el segundo numeri");
     n2 = int.Parse(Console.ReadLine());
     Console.WriteLine("Ingresa el tercer numeri");
     n3 = int.Parse(Console.ReadLine());

    //aqui empiezan las condiciones//

    suma = n1 + n2;
    producto = n2 * n3;

    if(suma > producto){
        Console.WriteLine("La suma del primero con el segundo es mayor al producto del segundo con el tercero");
    }else{
        Console.WriteLine("La suma del primero con el segundo no es mayor al producto del segundo con el tercero");
    }

    
     


    

    
    


     
     }//finaliza el main
   

    } //namespace
    
    } //using  

    
    