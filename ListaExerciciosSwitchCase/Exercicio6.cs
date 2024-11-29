using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosSwitchCase
{
    internal class Exercicio6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha um número para selecionar sua bebida: \n 1 - Café \n 2 - Chá \n 3 - Suco \n 4 Refrigerante");
            int escolha = Convert.ToInt16(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Café");
                    break;

                case 2:
                    Console.WriteLine("Chá");
                    break;

                case 3:
                    Console.WriteLine("Suco");
                    break;

                case 4:
                    Console.WriteLine("Refrigerante");
                    break;

                default:
                    Console.WriteLine("Selecione uma opção valida");
                    break;

            }
        }
    }
}