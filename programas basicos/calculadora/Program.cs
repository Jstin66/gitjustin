using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\nCalculadora");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - División");
            Console.WriteLine("5 - Potencia");
            Console.WriteLine("6 - Salir");
            Console.Write("Elige una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                continue;
            }

            if (opcion == 6)
            {
                Console.WriteLine("¡Adiós!");
                break;
            }

            if (opcion < 1 || opcion > 6)
            {
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                continue;
            }

            Console.Write("Ingresa el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine($"Resultado: {num1 / num2}");
                    else
                        Console.WriteLine("No se puede dividir entre cero.");
                    break;
                case 5:
                    Console.WriteLine($"Resultado: {Math.Pow(num1, num2)}");
                    break;
            }

        } while (opcion != 6);
    }
}
