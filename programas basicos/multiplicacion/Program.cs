using System;

namespace Multiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 * num2;

            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
            Console.ReadKey();
        }
    }
}
