using System;

namespace programas_basicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== División de dos números ===");

            
            Console.Write("Ingresa el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

          
            Console.Write("Ingresa el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

       
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

