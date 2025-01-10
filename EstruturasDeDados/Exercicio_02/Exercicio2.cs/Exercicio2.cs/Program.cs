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

            Stack<string> nomes = new Stack<String>();

            nomes.Push("José");
            nomes.Push("Maria");
            nomes.Push("Luiz");
            foreach (var nome in nomes)
            {

                Console.WriteLine($"Pilha Original : {nome}");

            }
            Console.WriteLine();

            while (nomes.Count > 0)
            {
                string nomeRemovido = nomes.Pop();
                Console.WriteLine($"Nome Removido: {nomeRemovido}");
                Console.WriteLine();

                if (nomes.Count > 0)
                {

                    foreach (var nome in nomes)
                    {

                        Console.WriteLine($"Nome Restantes: {nome}");

                    }

                }

                else

                {

                    Console.WriteLine("Pilha  Vazia..");

                }
                Console.WriteLine();

            }



            Console.WriteLine("Precione Qualquer Tecla Para Encerrar..");
            Console.ReadKey();
        }
    }
}
