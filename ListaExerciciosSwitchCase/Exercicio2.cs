using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosSwitchCase
{
    internal class Exercicio2
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite um número");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escola a operação matemática que deseja executar [+, -, *, /]");
            string escolha = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite um outro número");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            switch (escolha)
            {
                case "+":
                    Console.WriteLine(Soma(numero1, numero2));
                    break;

                case "-":
                    Console.WriteLine(Subtracao(numero1, numero2));
                    break;

                case "*":
                    Console.WriteLine(Multiplicacao(numero1, numero2));
                    break;

                case "/":

                    if (numero2 == 0)
                    {
                        Console.WriteLine("Não existe divisão por 0");
                        break;
                    }
                    Console.WriteLine(Divisao(numero1, numero2));
                    break;

                default:
                    Console.WriteLine("Operação invalida");
                    break;

            }

        }

        public static double Soma(double x, double y)
        {
            return x + y;
        }

        public static double Subtracao(double x, double y)
        {
            return x - y;
        }

        public static double Multiplicacao(double x, double y)
        {
            return x * y;
        }

        public static double Divisao(double x, double y)
        {
            return x / y;
        }
    }
}
