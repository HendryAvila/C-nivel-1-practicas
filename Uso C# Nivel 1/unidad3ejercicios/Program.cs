using System;

class Program{
    public Program()
    {
    }

    static void Main(string[] args)
    // 1=Hacer un programa para ingresar un número
    //2=y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
    {
        int a;

        Console.WriteLine("Ingrese su número");
        a = int.Parse(Console.ReadLine());

        if(a > 10){
            Console.WriteLine("Es mayor a 10");
        }else{
            Console.WriteLine("No es mayor a 10");
        }
        




        
    } // El cuerpo del método Main termina aquí
}