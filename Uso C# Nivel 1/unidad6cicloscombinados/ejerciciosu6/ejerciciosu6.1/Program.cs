using System;

namespace ejerciciosu6._1
{
    class Program
    {//Hacer un programa para ingresar 10 números. 
    //El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
        static void Main(string[] args)
        { int con , numero, conp = 0;
        for (int x = 0; x < 10; x++)
        {
            
        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());

        con = 0;
        for(int i = 1; i <= numero; i++){
        if(numero%i == 0){
            con++;
        }
        
       }
                
       if(con == 2){
        conp++;
       }
        }
        Console.WriteLine("De los 10 numeros " + conp + " son primos");

        }
    }
}