using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
    // Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 
    //más una comisión del 5% sobre el total facturado por cada empleado.
    // Hacer un programa para ingresar el total facturado por un empleado 
    //y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
        {
           float totalfacturado;
           float comisión;
           float sueldofinal;

           Console.WriteLine("Ingrese el total facturado");
           totalfacturado = float.Parse(Console.ReadLine());

           comisión = totalfacturado * 5/100;

           sueldofinal = comisión + 15000;

           Console.WriteLine("El Sueldo final es: " + sueldofinal);

        }
    }
}
