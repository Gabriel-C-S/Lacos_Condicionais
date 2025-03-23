using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lacos
{
    internal class Lacos
    {
        static void Main()
        {
            int A;
            int B;
            int C;

            Console.WriteLine("Digite o valor de A: ");
            while (!int.TryParse(Console.ReadLine(), out A))
            {
                Console.WriteLine("Por favor, insira um número válido para A.");
            }
            Console.WriteLine("Digite o valor de B: ");
            while (!int.TryParse(Console.ReadLine(), out B))
            {
                Console.WriteLine("Por favor, insira um número válido para B.");
            }
            Console.WriteLine("Digite o valor de C: ");
            while (!int.TryParse(Console.ReadLine(), out C))
            {
                Console.WriteLine("Por favor, insira um número válido para C.");
            }

            int soma = A + B;

            if (soma > C)
            {
                Console.WriteLine($"A soma de {A} + {B} é maior do que {C}.");
            }
            else if (soma < C)
            {
                Console.WriteLine($"A soma de {A} + {B} é menor do que {C}.");
            }
            else if (soma == C)
            {
                Console.WriteLine($"A soma de {A} + {B} é igual a {C}.");
            }
        }
    }
}

