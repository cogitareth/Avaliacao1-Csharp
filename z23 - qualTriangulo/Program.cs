using System;

class Program
{
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int A = int.Parse(entrada[0]);
        int B = int.Parse(entrada[1]);
        int C = int.Parse(entrada[2]);

        if (ValidaTriangulo(A, B, C))
        {
            if (A == B && B == C)
            {
                Console.WriteLine("Valido-Equilatero");
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("Valido-Isoceles");
            }
            else
            {
                Console.WriteLine("Valido-Escaleno");
            }

            if (VerificaTrianguloRetangulo(A, B, C))
            {
                Console.WriteLine("Retangulo: S");
            }
            else
            {
                Console.WriteLine("Retangulo: N");
            }
        }
        else
        {
            Console.WriteLine("Invalido");
        }
    }

    static bool ValidaTriangulo(int a, int b, int c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    static bool VerificaTrianguloRetangulo(int a, int b, int c)
    {
        if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}