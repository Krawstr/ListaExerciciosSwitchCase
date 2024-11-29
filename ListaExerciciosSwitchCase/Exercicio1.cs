using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosSwitchCase
{
    internal class Exercicio1
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite um número um número de 1 a 7");
            int numero = Convert.ToInt16(Console.ReadLine());

            switch (numero)
            {

                case 1:
                    Console.WriteLine("Domingo");
                    break;

                case 2:
                    Console.WriteLine("Segunda");
                    break;

                case 3:
                    Console.WriteLine("Terça");
                    break;

                case 4:
                    Console.WriteLine("Quarta");
                    break;

                case 5:
                    Console.WriteLine("Quinta");
                    break;

                case 6:
                    Console.WriteLine("Sexta");
                    break;

                case 7:
                    Console.WriteLine("Sabado");
                    break;

                default:
                    Console.WriteLine("Esse número não corresponde a um dia da semana");
                    break;
            }
        }
    }
}