using System;

class Program
{
    static void Main()
    {
        // Lê o valor de I
        int I = Convert.ToInt32(Console.ReadLine());

        // Monta a frase "Feliz natal!" com a última letra 'a' repetida I vezes
        string frase = "Feliz nata" + new string('a', I) + "l!";

        // Imprime a frase com quebra de linha
        Console.WriteLine(frase);
    }
}
