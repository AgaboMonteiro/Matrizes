using System;
using MinhaBliblioteca;

class Exercicio08

{
    static int contarRaiosMesmoLugar(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int cont = 0;
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] > 1)
                {
                    cont = 1;
                }
            }
        }
        return cont;
    }

    static void Main()
    {
        int x, y, linhas, colunas;
        Console.WriteLine("Entre com a quantidade de linhas e colunas da matriz:");
        linhas = int.Parse(Console.ReadLine());
        colunas = int.Parse(Console.ReadLine());
        int[,] mapa = new int[linhas, colunas];

        Console.WriteLine("Entre com a quantidade de raios:");
        int quantidadeRaios = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadeRaios; i++)
        {
            Console.WriteLine("Entre com as coordenadas x e y do ponto do raio:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            mapa[x, y]++;
        }
        MinhaBliblioteca.Bliblioteca.mostrarMatriz(mapa);
        int cont = contarRaiosMesmoLugar(mapa);
        Console.WriteLine(cont);
    }
}

