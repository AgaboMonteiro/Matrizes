using System;
using MinhaBliblioteca;

class Exercicio05
{
    static int diagonal(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int diagonal = 0;
        for (int i = 0; i < linhas; i++)
            for (int j = 0; j < colunas; j++)
                if (j >= colunas - linhas && i + j == colunas - 1)
                {
                    diagonal = matriz[i, j];
                    Console.WriteLine(diagonal);
                }

        return diagonal;
    }

    static void Main()
    {
        int linhas, colunas;
        Console.WriteLine("Entre com a quantidade de linhas e colunas da matriz:");
        linhas = int.Parse(Console.ReadLine());
        colunas = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas, colunas];

        //Bliblioteca.lerMatriz(matriz);
        Bliblioteca.gerarMatriz(matriz);
        Bliblioteca.mostrarMatriz(matriz);
        diagonal(matriz);

    }
}