using System;

namespace MinhaBliblioteca
{
    class Bliblioteca
    {

        public static void lerMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            Console.WriteLine("Entre com os dados da matriz: ");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"[{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }//fim for colunas
            }//fim for linhas   
        }

        public static void mostrarMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            Console.WriteLine("***Matriz***");
            for (int i = 0; i < linhas; i++)
            {

                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz[i, j] + " | ");

                }//fim for colunas
                Console.WriteLine();
            }//fim for linhas
        }
    
    public static void gerarMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            Random rand = new Random(); //gerador de numeros aleatorios
            Console.WriteLine("Gerando matriz... ");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = rand.Next(0, 100); //gera numeros entre 0 e 99
                }//fim for colunas
            }//fim for linhas   
        }

}

}
