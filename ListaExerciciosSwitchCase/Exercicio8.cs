using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosSwitchCase
{
    internal class Exercicio8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite F para Fahrenheit e C para Celsiu");
            string escolha = Convert.ToString(Console.ReadLine()).ToUpper();

            double celsius = 0;
            double fahrenheit = 0;

            switch (escolha)
            {
                case "F":
                    Console.WriteLine("Digite a temperatura em fahrenheit para ser convertida para celsius");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = (fahrenheit - 32) / 1.8;
                    Console.WriteLine($"A temperatura em graus celsius é: {celsius}");
                    break;

                case "C":
                    Console.WriteLine("Digite a temperatura em celsius para ser convertida em fahrenheit");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    fahrenheit = (celsius * 1.8) + 32;
                    Console.WriteLine($"A temperatura em fahrenheit é: {fahrenheit}");
                    break;

                default:
                    Console.WriteLine("Opção não reconhecida");
                    break;
            }
        }
    }
}