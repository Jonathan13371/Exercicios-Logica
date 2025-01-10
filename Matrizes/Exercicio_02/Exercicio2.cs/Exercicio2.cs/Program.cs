using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            var soma = 0;

            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {


                    Console.Write($"Preancha a Matriz 4X4  linha: [{linha}]  [Coluna:{coluna}] :"); matriz[linha, coluna] 
                     = Convert.ToInt32(Console.ReadLine());

                    if (linha + coluna == 4 || linha + coluna == 0)
                    {
                        soma += matriz[linha, coluna];
                    }

                }

            }
            Console.WriteLine();
            Console.WriteLine("Matriz 4x4");
            
            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"A soma de todos os elementos da diagonal principa é {soma}...");
            Console.WriteLine();
            Console.WriteLine("\nPressione qualquer tecla para encerrar...");
            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de sair
        }
    }
}
