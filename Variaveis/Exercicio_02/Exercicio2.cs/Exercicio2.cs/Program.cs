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
            decimal precoProduto, valorFinal;
            int quantidade = 0;
            decimal Desconto = 0;


            Console.Write("Preço do Produto:"); precoProduto = decimal.Parse(Console.ReadLine());
            Console.Write("Quantidade: "); quantidade = int.Parse(Console.ReadLine());
            
            valorFinal = precoProduto * quantidade;
            if (valorFinal >= 100)
            {
                Desconto = valorFinal / 10;
                valorFinal -= Desconto;
                Console.WriteLine($"Valor com desconto aplicado: {valorFinal}");

            }
            else
            {
                Console.WriteLine($"Valor a Pagar: {valorFinal}");
            }
            Console.ReadKey();

        }
    }
}
