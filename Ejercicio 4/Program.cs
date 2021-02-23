using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double num1,num2,num3;
            Console.Write("Ingrese el primer numero: ");
            num1 = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer numero: ");
            num3 = Double.Parse(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("El numero mayor de todos los datos es: " + num1);
            }
            else if (num2 > num3)
            {
                
                Console.WriteLine("El numero " + num2 + " es mayor que el tercer dato ingresado");

            }
            else
            {
                Console.WriteLine("El numero " + num3 + " es mayor que el segundo dato ingresado");
            }
            Console.ReadKey();
        }
    }
}
