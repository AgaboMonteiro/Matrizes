using System;
using MinhaBliblioteca;

class Exercicio03
{
    static int cont(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        Console.WriteLine("Digite um valor para achar se há valores iguais na matriz:");
        int x = int.Parse(Console.ReadLine());
        int cont = 0;
        for (int i = 0; i < linhas; i++)
            for (int j = 0; j < colunas; j++)
                if (matriz[i, j] == x)
                {
                    cont++;
                }
        
        return cont;
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
        int qtd = cont(matriz);

        Console.WriteLine("A quantidade de elementos iguais na matriz é: " + qtd);

    }
}