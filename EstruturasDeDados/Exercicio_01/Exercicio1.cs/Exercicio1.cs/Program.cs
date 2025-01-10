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
            List<int> list = new List<int>();



            while (true)
            {
                Console.WriteLine("Digite um numero.. O Programa será encerrado quando o comando secreto for digitado!");
                var entrada = Console.ReadLine();



                if (entrada == "-1")
                {
                    Console.WriteLine("Parabéns voce descobriu o comando secreto.");

                    break;
                }

                if (entrada == "")
                {
                    Console.WriteLine("Opção invalida Tente Novamente.");

                    continue;
                }


                else
                {
                    var numero = Convert.ToInt32(entrada);
                    list.Add(numero);
                }
            }
            Console.WriteLine("Numeros Digitados em Ordem crescente.");
            Console.WriteLine();
            list.Sort();

            foreach (int item in list)
            {

                Console.WriteLine(item);
            }




            Console.WriteLine("Precione qualquer tecla pra encerrar...");
            Console.ReadKey();
        }
    }
}
