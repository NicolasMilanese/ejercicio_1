using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int alumnos1,notas1, acumulador, promedio;
            string año,turno, notas, alumnos;

            acumulador=0;


            Console.WriteLine("ingrese año");
            año=Console.ReadLine();
            Console.WriteLine("ingrese turno");
            turno=Console.ReadLine();   
            Console.WriteLine("ingrese cantidad de alumnos");
            alumnos=Console.ReadLine();
            alumnos1= Convert.ToInt32 (alumnos);

        


            for (int i = 0; i < alumnos1; i++)
            {
            Console.WriteLine("ingrese nota");
            notas=Console.ReadLine();
            notas1=Convert.ToInt32 (notas);
            acumulador=acumulador+notas1;
        
            }
            promedio=acumulador/alumnos1;

            Console.WriteLine ("el promedio de notas en " +  año + " año" + " turno "  +  turno  + " es de " + promedio);

        }
    }
}
