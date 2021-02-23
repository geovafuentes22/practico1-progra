using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double nota1, nota2, nota3, prom;

            Console.WriteLine("Ingresa tu primera nota");
            nota1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu segunda nota");
            nota2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu tercera nota");
            nota3 = Double.Parse(Console.ReadLine());

            prom = (nota1 + nota2 + nota3) / 3;
            if(prom >= 7)
            {
                Console.WriteLine("Promocionado");

            }else if(prom >=4)
            {
                Console.WriteLine("Regular");
            }else
            {
                Console.WriteLine("Reprobado");
            }
            Console.ReadKey();
        }
    }
}
