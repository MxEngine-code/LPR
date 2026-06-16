using System.Numerics;

int[,] matriz = new int[3,4];

//linha 0 = idade
//linha 1 = peso
//linha 2 = altura

//coluna 0 = Hulk
matriz[0,0] = 50;
matriz[1,0] = 300;
matriz[2,0] = 2;

//coluna 1 = Homem_aranha
matriz[0,1] = 18;
matriz[1,1] = 70;
matriz[2,1] = 2;

//coluna 0 = Capitão_america
matriz[0,2] = 33;
matriz[1,2] = 100;
matriz[2,2] = 2;

//coluna 0 = Thanos
matriz[0,3] = 1000;
matriz[1,3] = 500;
matriz[2,3] = 3;

Console.WriteLine($"O peso do home aranha é {matriz[1,1]}");

matriz[1,1] = 75;

Console.WriteLine($"O peso do home aranha é {matriz[1,1]}");

foreach (int i in matriz)
{
    Console.WriteLine($"{i}\n");
}