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
            string nome;
            int idade;
            decimal altura;

            Console.WriteLine("Informe Nome: Idade: Altura: ");
            Console.Write("Nome:"); nome = Console.ReadLine();
            Console.Write("Idade:"); idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Altura:"); altura = Convert.ToDecimal(Console.ReadLine());
            
           
            Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}");

            Console.WriteLine();
            Console.WriteLine("Utilizando Classe");
            /*Implantação com Classe*/
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Informe Nome: Idade: Altura: ");
            Console.Write("Nome:"); pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade:"); pessoa1.Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Altura:"); pessoa1.Altura = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();
            pessoa1.Exbir();

            Console.ReadKey();
        }
    }
    }

