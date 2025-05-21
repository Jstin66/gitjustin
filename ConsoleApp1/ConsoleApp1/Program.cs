using System;

public class FibonacciSeries
{
    public static void Main(string[] args)
    {
        Console.Write("Ingresa el número de términos para la serie de Fibonacci: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Por favor, ingresa un número positivo.");
        }
        else if (n == 1)
        {
            Console.WriteLine("Serie de Fibonacci:");
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine("Serie de Fibonacci:");
            int a = 0, b = 1, c;
            Console.Write(a + " " + b + " ");

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}