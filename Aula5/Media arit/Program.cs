using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace ParouNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool func = true;
            while(func){
                Console.Clear();
                Console.Write("Digite quantos números serão: ");
                int q;
                int q1 = 0;
                int qn = 0;
                float numeros = 0;
                while (true) {
                    if (int.TryParse(Console.ReadLine(), out q))
                    {
                        break;
                    }
                    Console.WriteLine("Digite um valor válido!");
                }
            
                int n;
                while (qn < q)
                {
                    Console.Write($"Digite o {qn+1}a número: ");
                    while (true) {
                        if (int.TryParse(Console.ReadLine(), out n))
                        {
                            break;
                        }
                        Console.WriteLine("Digite um valor válido!");
                    }

                    if (n % 2 == 0)
                    {
                        numeros += n;
                        q1++;
                    } 
                    qn++;
                }
                Console.WriteLine($"A média é de {numeros/q1}");
                Console.WriteLine("Digite qualquer tecla para continuar, ou exit para sair.");
                if (Console.ReadLine().ToLower() == "exit") func = false;
            }
        }
    }
}