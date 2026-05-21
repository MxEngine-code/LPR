using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite um valor: ");
        float r;
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out r)) break;
            Console.WriteLine("Entrada inválida!");
            Console.Write(": ");
        }
        Console.WriteLine($"A área do círculo é {(3.14159 * (r*r)):F4}");
    }
}