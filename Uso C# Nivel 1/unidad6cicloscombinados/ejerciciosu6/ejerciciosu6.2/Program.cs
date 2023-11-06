using System;

namespace ejerciciosu6._2
{
    class Program
    {
/*2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros
.Se pide determinar e informar:
El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
Informar cuántos grupos están formados por todos números ordenados de mayor a menor.*/        
        static void Main(string[] args)
        {//main
        int n, acu = 0, conl = 0, pi = 0, conti = 0, conn, min, conOrdenados = 0; 
        float porcentaje, pmayori = 0, grupoMAyorPorcentaje = 0;
        bool banderaOrdenados = true;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
         for (int i = 0; i < 5; i++)
         {//for
        conti = 0;
        conn = 0;
        min = n;
        banderaOrdenados = false;
        while (n != 0)
        {//while de adentro
        conn++;
        if (n % 2 != 0)
        {
            conti++;

            //punto b
            if(n <= min)
                min = n;
            
            else
             banderaOrdenados = false;

        }

        Console.WriteLine("Ingrese un numero");
         n = int.Parse(Console.ReadLine());

        }//while de adentro
        if (conti >0)//verifico que sea mayor a 0
        {
            
         porcentaje = conti*100/conn;
         if (porcentaje > pmayori)
         {
           pmayori = porcentaje; //aca el porcentaje mayor 
           grupoMAyorPorcentaje = i + 1;
         }
        }
         if(banderaOrdenados)
          conOrdenados++;
        
         }//for
        Console.WriteLine("La lista " + grupoMAyorPorcentaje + " tiene el mayor porcentaje que es " + pmayori );
        Console.WriteLine("La cantidad de grupos ordenados es: " + conOrdenados);
        }//termina main
    }
}
