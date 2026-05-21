using System;
class Program
{
    static int lerInt(string texto)
    {

        Console.Write($"{texto}: ");
        int resul;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out resul)) break;
            Console.WriteLine("Entrada inválida!");
            Console.Write(": ");
        }
        return resul;
    }
    static void Main()
    {
        int A = lerInt("Digite o primeiro número");
        int B = lerInt("Digite o segundo número");
        int C = lerInt("Digite o terceiro número");
        int D = lerInt("Digite o quarto número");

        Console.WriteLine($"A dirença do produto sde {A} e {B} por {C} e {D} é {(A*B)-(C*D)}");
    }
}