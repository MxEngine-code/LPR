using System;
class Program
{
    static int[] numeros = new int[5];
    static void Main()
    {
        int maior = 0;
        int pos = 0;
        Console.WriteLine("Pedirei para que vc digite os numeros");
        for (int i = 0; i<numeros.Length; i++)
        {
            Console.Write($"Digite o {i+1} numero: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numeros[i])) break;
                Console.WriteLine("Entrada inválida!");
                Console.Write(": ");
            }
            
            if (numeros[i] > maior) {
                maior = numeros[i];
                pos = i;
            }
        }
        
        Console.WriteLine($"Vetor:");
        foreach (int i in numeros)
        {
            Console.Write($" {i}");
        }
        Console.WriteLine($"Maior: {maior}");
        Console.WriteLine($"Posição: {pos}");
    }
}