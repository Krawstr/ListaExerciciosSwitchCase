using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosSwitchCase
{
    internal class Exercicio9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a classificação etária do filme [G, PG, PG-13, R]");
            string classificacao = Console.ReadLine().ToUpper();

            switch (classificacao)
            {
                case "G":
                    Console.WriteLine("Livre");
                    break;

                case "PG":
                    Console.WriteLine("Para maiores de 10 anos");
                    break;

                case "PG-13":
                    Console.WriteLine("Para maiores de 13 anos");
                    break;

                case "R":
                    Console.WriteLine("Para maiores de 18");
                    break;

                default:
                    Console.WriteLine("Classificação não reconhecida");
                    break;
            }


        }
    }
}