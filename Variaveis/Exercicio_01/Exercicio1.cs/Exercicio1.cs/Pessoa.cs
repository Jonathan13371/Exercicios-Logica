using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.cs
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public decimal Altura { get; set; }




        public void Exbir()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos, Altura: {Altura} m.");
        }
    }
}
