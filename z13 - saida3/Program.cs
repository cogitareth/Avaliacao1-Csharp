using System;

class Program
{
    static void Main()
    {
        string linha1 = new string('-', 39); // primeira linha com 39 traços
        string linha2 = "|" + new string(' ', 37) + "|"; // segunda linha com | nas extremidades e espaço em branco no meio
        string linha3 = "|                x = 35               |"; // terceira linha com x = 35 centralizado
        string linha4 = "|" + new string(' ', 37 - "x = 35".Length) + "x = 35" + new string(' ', 37 - "x = 35".Length) + "|"; // quarta linha com x = 35 no meio
        string linha5 = linha2; // quinta linha igual à segunda linha
        string linha6 = linha3; // sexta linha igual à terceira linha
        string linha7 = "|" + new string(' ', 37 - "x = 35".Length) + "x = 35|"; // sétima linha com x = 35 no canto inferior direito
        string linha8 = linha1; // oitava linha igual à primeira linha

        // Imprime as linhas conforme as características descritas
        Console.WriteLine(linha1);
        Console.WriteLine(linha2);
        Console.WriteLine(linha3);
        Console.WriteLine(linha4);
        Console.WriteLine(linha5);
        Console.WriteLine(linha6);
        Console.WriteLine(linha7);
        Console.WriteLine(linha8);
    }
}