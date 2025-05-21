using System;

class Program
{
    static void Main()
    {
       
        int[] numeros = new int[10];

        Console.WriteLine("Ingresa 10 números desordenados:");

        
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");

          
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.Write("Entrada inválida. Ingresa un número válido: ");
            }
        }

       
        Array.Sort(numeros);

      
        Console.WriteLine("\nNúmeros ordenados (ascendente):");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
