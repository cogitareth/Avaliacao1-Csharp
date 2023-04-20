using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string nome = Console.ReadLine();
            double grauDificuldade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] notasString = Console.ReadLine().Split(' ');
            double[] notas = new double[7];
            for (int j = 0; j < 7; j++)
            {
                notas[j] = double.Parse(notasString[j], CultureInfo.InvariantCulture);
            }

            Array.Sort(notas);

            double somaNotas = 0.0;
            for (int j = 1; j < 6; j++)
            {
                somaNotas += notas[j];
            }

            double resultado = somaNotas * grauDificuldade;

            Console.WriteLine(nome + " " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}