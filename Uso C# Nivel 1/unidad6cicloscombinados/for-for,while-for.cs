using System;

namespace unidad6cicloscombinados
{
    class Program
    {
        static void Main(string[] args)
        { int acu, edad, promedio, con = 0;
        //While con While//

        Console.WriteLine("Ingrese su edad"); //pido una edad inicial
        edad = int.Parse(Console.ReadLine());
        while (edad > 0 && edad != 0) 
        {
        acu = 0;//inicializo aqui para que cada vez que se reinicie el ciclo empiece de 0 para poder sacar el promedio de cada uno
        con = 0; //inicializo aqui para que cada vez que se reinicie el ciclo empiece de 0 para poder sacar el promedio de cada uno
            
        while(edad != 0){// con el 0 paro el ciclo asi que pueden poner cuantas edades quieran
        acu += edad;
        con++;
        Console.WriteLine("Ingrese su edad");
        edad = int.Parse(Console.ReadLine());
        }    
         
        promedio = acu / con;
        
        Console.WriteLine("El promedio del equipo numero: " + con + "es: " +promedio);

        Console.WriteLine("Ingrese una edad para continuar o un 0 para terminar");
        edad = int.Parse(Console.ReadLine());
        }

      
        
        }                                 //aqui termina el main
    }
}


/*Ciclos combinados*/
            //for con for//
            //for (int x = 0; x < 10; x++) // 10 porque son 10 equipos contituidos por 20 personas cada uno por eso el for de abajo es 20.
            //{/*primero for*/
            //acu = 0;//el acumulador va aqui para que cada vuelta del form me la cuenta    
            //for (int i = 0; i < 20; i++) //20, porque 20 personas conforman el plantel del barcelona y quiero cargar la edad de cada uno
            //{/*Primero for*/
            //Console.WriteLine("Ingrese su edad");
            /*edad = int.Parse(Console.ReadLine());
            acu+= edad; //aqui le pido que me vaya acumulando la edad para luego sacar el promedio
            
                
            }//segundo for termina
            promedio = acu/20; //el promedio es la division entre acu(las edades acumuladas) y 20 que son las vueltas del ciclo
            con++; //añado un contador para saber de que equipo es el promediod ado
            Console.WriteLine("El promedio del equipo numero " + con + "es: " + promedio);
            }/*Termina primer for*/


// for con while//

//For con While//
        /*for (int i = 0; i < 10; i++)
        {//inicia el cilo de 10 equipos
        Console.WriteLine("Ingrese su edad"); //pido una edad inicial
        edad = int.Parse(Console.ReadLine());
        acu = 0;//inicializo aqui para que cada vez que se reinicie el ciclo empiece de 0 para poder sacar el promedio de cada uno
        con = 0; //inicializo aqui para que cada vez que se reinicie el ciclo empiece de 0 para poder sacar el promedio de cada uno
        while(edad != 0){// con el 0 paro el ciclo asi que pueden poner cuantas edades quieran
        acu += edad;
        con++;
        Console.WriteLine("Ingrese su edad");
        edad = int.Parse(Console.ReadLine());
        }    
         
        promedio = acu / con;
        
        Console.WriteLine("El promedio del equipo numero: " + con + "es: " +promedio);*/

            
       // }//finaliza el primer ciclo


       //While con for//

       /*  Console.WriteLine("Ingrese 1 para continuar o 0 para finalizar");
        edad = int.Parse(Console.ReadLine());
        //while con for//
        while(edad != 0){ // con el 0 corto el ciclo
            acu = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese su edad");
                edad = int.Parse(Console.ReadLine());
                acu += edad; 
            }
            promedio = acu/10;
            Console.WriteLine("El promedio es: " + promedio);

            Console.WriteLine("Ingrese 1 para continuar o 0 para finalizar");
            edad = int.Parse(Console.ReadLine());
        }*/
        
            
        
           
            