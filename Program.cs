using System;
using MinhaBliblioteca;

class Program
{

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
    }
    
    
}