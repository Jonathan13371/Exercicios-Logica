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

            int[] numeros = new int[5];

            Console.WriteLine("Digite 5 numeros inteiros.");
            for (int i  = 0; i  <  5; i ++)
            {
              var num = Convert.ToInt32(Console.ReadLine());

                numeros[i] = num;
            }
            
            Console.WriteLine();
            Console.WriteLine("números em ordem inversa..");
            
            Array.Sort(numeros);
            
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }









            Console.WriteLine("Precione qualquer tecla para encerrrar....");
            Console.ReadKey();
        }
    }
}
