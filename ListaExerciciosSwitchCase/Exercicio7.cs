using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosSwitchCase
{
    internal class Exercicio7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário");
            double salario = Convert.ToDouble(Console.ReadLine());
            double valorImposto = 0;


            switch (salario)
            {
                case double n when (n >= 1 && n <= 1500):
                    valorImposto = salario * 0.05;
                    Console.WriteLine($"Valor do imposto com base no seu salario é: {valorImposto}");
                    break;

                case double n when (n >= 1501 && n <= 3000):
                    valorImposto = salario * 0.1;
                    Console.WriteLine($"Valor do imposto com base no seu salario é: {valorImposto}");
                    break;

                case double n when (n >= 3001):
                    valorImposto = salario * 0.15;
                    Console.WriteLine($"Valor do imposto com base no seu salario é: {valorImposto}");
                    break;
            }
        }
    }
}