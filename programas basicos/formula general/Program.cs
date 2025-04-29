using System;

class Program
{
    static void Main()
    {

        Console.Write("Introduce el valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el valor de c: ");
        double c = Convert.ToDouble(Console.ReadLine());

     
        double discriminante = b * b - 4 * a * c;

        if (discriminante > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            Console.WriteLine($"Las soluciones reales son: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminante == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"La solución doble es: x = {x}");
        }
        else
        {
         
            double parteReal = -b / (2 * a);
            double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
            Console.WriteLine($"Las soluciones complejas son: x1 = {parteReal} + {parteImaginaria}i, x2 = {parteReal} - {parteImaginaria}i");
        }
    }
}
