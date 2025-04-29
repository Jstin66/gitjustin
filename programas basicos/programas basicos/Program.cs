using System;

namespace programas_basicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== División de dos números ===");

            // Pedir el primer número
            Console.Write("Ingresa el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            // Pedir el segundo número
            Console.Write("Ingresa el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            // Validar que el segundo número no sea cero
            if (numero2 != 0)
            {
                double resultado = numero1 / numero2;
                Console.WriteLine($"El resultado de dividir {numero1} entre {numero2} es: {resultado}");
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

