using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosSwitchCase
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número para calcular o fatorial: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("O fatorial não é definido para números negativos.");
                return;
            }

            long fatorial = 1;

            switch (numero)
            {
                case 0:
                    fatorial = 1;
                    break;

                default:
                    for (int i = 1; i <= numero; i++)
                    {
                        fatorial *= i;
                    }
                    break;


            }

            Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
        }
    }
}