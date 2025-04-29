using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (EsPrimo(numero))
        {
            Console.WriteLine($"{numero} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} NO es un número primo.");
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }
}

