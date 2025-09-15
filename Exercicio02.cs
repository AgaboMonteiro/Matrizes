using System;
using MinhaBliblioteca;

class Exercicio02
{
static int getMax(int[,] matriz)
{
    int linhas = matriz.GetLength(0);
    int colunas = matriz.GetLength(1);
    int maior = matriz[0, 0];
    for (int i = 0; i < linhas; i++)
        for (int j = 0; j < colunas; j++)
            if (matriz[i, j] > maior)
            {
                maior = matriz[i, j];
            }
    return maior;
    }

    static void Main()
    {


        int linhas, colunas;
        Console.WriteLine("Entre com a quattidade de linhas e colunas da matriz:");
        linhas = int.Parse(Console.ReadLine());
        colunas = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas, colunas];

        //Bliblioteca.lerMatriz(matriz);
        Bliblioteca.gerarMatriz(matriz);
        Bliblioteca.mostrarMatriz(matriz);
    Console.WriteLine("O maior valor da matriz é: " + getMax(matriz));
}
    
    
}