using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double num1, num2, num3, num4, proceso1, proceso2;

            Console.WriteLine("Ingrese el primer numero");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            num3 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            num4 = Double.Parse(Console.ReadLine());

            proceso1 = num1 + num2;
            proceso2 = num3 * num4;

            Console.WriteLine("La suma de los digitos es: "+proceso1);
            Console.WriteLine("El producto de los digitos es: " + proceso2);

            Console.ReadKey();

        }
    }
}
