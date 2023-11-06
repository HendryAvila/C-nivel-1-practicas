using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
            que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:
            a. 1 si el número es positivo.
            b. -1 si el número es negativo.
             c. 0 si el número es cero.*/
             int n1, n2 = 0;
             Console.WriteLine("Ingrese un numero");
             n1 = int.Parse(Console.ReadLine());
             positivoNegativoCero(n1, ref n2);
             Console.WriteLine("La variable recibida por referencia es: " + n2);
        } 
        static void positivoNegativoCero (int n1, ref int n2){
          if (n1 >0)
          {
            n2 = 1;
          }else if (n1 < 0)
          {
            n2 = -1;
          }else
          {
            n2 = 0;
          }
        }
    }
}
