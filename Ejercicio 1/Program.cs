using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double precio1, cantidad, proceso;

            Console.WriteLine("Ingrese el precio del articulo");
            precio1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de articulos que lleva");
            cantidad = Double.Parse(Console.ReadLine());

            proceso = cantidad * precio1;

            Console.Write("El total a pagar es: $" + proceso);
            Console.ReadLine();
        }
    }
}
