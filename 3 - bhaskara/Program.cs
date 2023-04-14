using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string[] values = Console.ReadLine().Split(' ');
        double a, b, c, delta, x1, x2;
        a = double.Parse(values[0]);
        b = double.Parse(values[1]);
        c = double.Parse(values[2]);

        delta = b * b - 4 * a * c;

        if (a == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("R1 = {0:F5}", x1);
            Console.WriteLine("R2 = {0:F5}", x2);
        }
    }
}