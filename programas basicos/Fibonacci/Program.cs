using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Serie de Fibonacci del 1 al 50:");

        int a = 0;
        int b = 1;

        while (b <= 50)
        {
            Console.WriteLine(b);
            int temp = b;
            b = a + b;
            a = temp;
        }
    }
}

