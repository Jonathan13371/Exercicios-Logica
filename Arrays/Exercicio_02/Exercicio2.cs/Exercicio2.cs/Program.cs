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
            int[] numeros = new int[10];
            int soma = 0;
            int media = 0;
            int MaiorNumero = int.MinValue;

            Console.WriteLine("Digite 10 numeros...");
            for (int i = 0; i < numeros.Length; i++)
            {

                numeros[i] = Convert.ToInt32(Console.ReadLine());
                soma += numeros[i];

                if (numeros[i] > MaiorNumero)
                {
                    MaiorNumero = numeros[i];

                }

            }
            media = soma / numeros.Length;
            Console.WriteLine($"Soma dos numeros {soma} media: {media}");
            Console.WriteLine($"Numero Maior numero informado: {MaiorNumero}");

            Console.WriteLine("\nPressione qualquer tecla para encerrar...");
            Console.ReadKey(); // Espera o usuário pressionar qualquer tecla

        }
    }
    }

