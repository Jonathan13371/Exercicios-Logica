using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz_1 = new int[3, 3]; /*Matriz/Array bidimensional*/
            


            for (int linha = 0; linha < 3; linha++)
            {

                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"Preencha a matriz 3x3 Linha: {linha}, Coluna: {coluna}: "); matriz_1[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Exibindo a matriz
            Console.WriteLine("\nMatriz 3x3 preenchida:");
            for (int linha = 0; linha < 3; linha++) // Itera sobre as linhas
            {
                for (int coluna = 0; coluna < 3; coluna++) // Itera sobre as colunas
                {
                    Console.Write(matriz_1[linha, coluna] + "\t"); // Exibe o valor na posição atual
                }
                Console.WriteLine(); // Pula para a próxima linha


            }
            Console.WriteLine("\nPressione qualquer tecla para encerrar...");
            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
        }
    }
}
