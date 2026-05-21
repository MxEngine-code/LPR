using System;
class Program
{
    static void Main()
    {
        while(true){
            Console.Clear();
            Console.Write("Digite o número: ");
            float n;
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out n)) break;
                Console.WriteLine("Entrada inválida!");
                Console.Write(": ");
            }
        
            if (n%2==0) Console.WriteLine("Número é par!");
            else Console.WriteLine("Número é ímpar!");
            Console.WriteLine("Aperte qualquer tecla para continuar ou digite exit para sair: ");
            if (Console.ReadLine().ToLower() == "exit") break;
    }
    }
}