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
            Random NumeroAleatorio = new Random();
            
            var num = NumeroAleatorio.Next(1,20);
            var tentativaNum = 0;
            var tentativaRestantes = 5;
            Console.WriteLine(num);

            Console.WriteLine("Numero Aleatorio Gerado. Você tem 5 tentativas. Tente Acertar!");
            for (int i = 1; i <= 5; i++)
            {

                tentativaNum = Convert.ToInt32(Console.ReadLine());
                tentativaRestantes --;

                if (tentativaNum > num)
                {
                   
                    Console.WriteLine($"Dica: O numero secreto é menor que o ultimo numero digitado, Voce tem {tentativaRestantes} tentativas.");
                
                }
                
                if (tentativaNum < num)

                {                 
                   
                 Console.WriteLine($"Dica: O numero é maior que o ultimo numero digitado, Voce tem {tentativaRestantes} tentativas.");

                }

                
                
                if (tentativaNum == num)
                {
                    Console.Clear();
                    Console.WriteLine($"Parabèns o numero era {num} e Voce Acertou!!");
                   
                    Console.WriteLine("\nPressione qualquer tecla para encerrar...");
                    Console.ReadKey(); // Espera o usuário pressionar qualquer tecla
                    break;
                }
                else if (tentativaRestantes == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Você não consegui o numero era {num}. Continue tentando... ");
                    
                    Console.WriteLine("\nPressione qualquer tecla para encerrar...");
                    Console.ReadKey(); // Espera o usuário pressionar qualquer tecla
                    break;
                }

            }


           
        }
    }
}
