using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosSwitchCase
{
    internal class Exercicio5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma nota de 0 a 10");
            int nota = Convert.ToInt16(Console.ReadLine());


            switch (nota)
            {
                case int n when (n >= 9 && n <= 10):
                    Console.WriteLine("Classificação: A");
                    break;

                case int n when (n >= 7 && n <= 8):
                    Console.WriteLine("Classificação: B");
                    break;

                case int n when (n >= 5 && n <= 6):
                    Console.WriteLine("Classificação: C");
                    break;

                case int n when (n >= 3 && n <= 4):
                    Console.WriteLine("Classificação: D");
                    break;

                case int n when (n >= 0 && n <= 2):
                    Console.WriteLine("Classificação: F");
                    break;

                default:
                    Console.WriteLine("Por favor digite uma nota valida");
                    break;
            }
        }
    }
}