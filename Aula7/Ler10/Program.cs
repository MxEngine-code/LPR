using System;
class Program
{
    static int[] numeros = new int[10];
    static void Main()
    {
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
            //;if (numeros[i] % 2 == 0) 1numerospar.Append(numeros)
        }
        int ipares = 0;
        int iimpares = 0;
        int[] numerospar = new int[10];
        int[] numerosimp = new int[10];

        foreach (int x in numeros) if (x%2==0) {
            numerospar[ipares] = x;
            ipares++;
        } else {
            numerosimp[iimpares] = x;
            iimpares++;
        }
        Console.Write("Números pares:");
        for (int x = 0; x<ipares; x++) Console.Write($" {numerospar[x]}");
        Console.WriteLine();
        Console.Write("Números impares:");
        for (int x = 0; x<iimpares; x++) Console.Write($" {numerosimp[x]}");
    }
}
