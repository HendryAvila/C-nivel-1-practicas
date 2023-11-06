using System;

namespace ejercicio2
{
    class Program
    {

        static void Main(string[] args)
        {//empieza el main
        //Ciclo For//
      /*  float acu = 0;
        float a;
        float promedio;


        for(a = 0; a < 100; a++){
            
      Console.WriteLine("ingrese un numero");
        a = float.Parse(Console.ReadLine());
        acu += a;
        }

        promedio = acu/100;
        Console.WriteLine("el promedio es; " + promedio); */
        //TERMINA EL CICLO FOR//
             //CICLO WHILE//
/*Ya conocemos el Ciclo FOR. El mismo nos permite, a partir de una configuración previamente establecida,
repetir un conjunto de instrucciones siempre y cuando conozcamos la cantidad de veces que necesitamos que el mismo se ejecute
Hay ocasiones en las que no se conocerá la cantidad de veces que un algoritmo deberá ser ejecutado; 
en dichos casos se utiliza otro tipo de ciclo,
denominado ciclo inexacto, que repetirá el conjunto de instrucciones dado dependiendo de una condición establecida.
Existen básicamente dos tipos de ciclos inexactos en la programación. Por un lado el While y por otro lado en Do While.
El ciclo While (del inglés “mientras”) comenzará a ciclar siempre y cuando la condición dada sea verdadera
y seguirá ciclando hasta tanto esa situación no cambie.*/

  /*           int n = 0;
 while(n<30){
   n++;
   Console.WriteLine(n);
 }*/
/*int a, con = 0;

Console.WriteLine("Ingrese un numero");
a = int.Parse(Console.ReadLine());

while(a != 0){
  con++;
  Console.WriteLine("Ingrese un numero");
  a = int.Parse(Console.ReadLine());


}

Console.WriteLine("el numero de numeros ingresados fue: " + con + "numeros");*/


 


 //{
    
 //}
    //TERMINA EL  CICLO WHILE//
       //ciclo DO WHILE//
/*Este ciclo funciona casi de la misma manera que el ciclo While tradicional. La diferencia fundamental es que la primer vuelta se ejecutará siempre,
y recién para la segunda es que la condición será evaluada para determinar si continuar ciclando o concluir el bloque.
Un ejemplo codificado sería:*/

/*int n = 0;
do{
   n++;
}while(n<10)*/

int a;


do{
  Console.WriteLine("Ingrese un numero");
  a = int.Parse(Console.ReadLine());

}
while(a != 0);
  








    

    
     }//finaliza el main
   

    } //namespace
    
    } //using  

    
    