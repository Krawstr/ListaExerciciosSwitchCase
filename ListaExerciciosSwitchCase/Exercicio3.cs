using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosSwitchCase
{
    internal class Exercicio3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade da pessoa");
            int idade = Convert.ToInt16(Console.ReadLine());

            switch (idade)
            {
                case int n when (n >= 0 && n <= 12):
                    Console.WriteLine("Criança");
                    break;

                case int n when (n >= 13 && n <= 17):
                    Console.WriteLine("Adolescente");
                    break;

                case int n when (n >= 18 && n <= 59):
                    Console.WriteLine("Adulto");
                    break;

                case int n when (n >= 60):
                    Console.WriteLine("Idoso");
                    break;

                default:
                    Console.WriteLine("Idade invalida");
                    break;
            }
        }
    }
}