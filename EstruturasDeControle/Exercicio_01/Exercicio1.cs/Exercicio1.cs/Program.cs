using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercicio1.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[5];
            int MaiorDeIdade = 0;


            Console.WriteLine("Digite Idade de 5 pessoas....");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite a idade numero: {i +1}");
                
                
                var idadesDigitadas  = Convert.ToInt32(Console.ReadLine());

                idades[i] = idadesDigitadas;




            }
            for (int i = 0; i < 5; i++)
            {
                if (idades[i] >= 18)
                {
                    MaiorDeIdade++;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Idade Digitadas...");
            foreach (int i in idades)
            {

                Console.Write($"{i} ,");

            }
            Console.WriteLine();
            Console.WriteLine($"Tem {MaiorDeIdade} pessoas maiores de 18 anos de idade.");


            Console.ReadKey();

        }
    }
}
