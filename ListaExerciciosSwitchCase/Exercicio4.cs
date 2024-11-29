using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosSwitchCase
{
    internal class Exercicio4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número correspondente a opção: \n Opção 1: exibir Olá Mundo \n Opção 2: Bem vindos ao c# \n Opção 3: Sair ");
            int escolha = Convert.ToInt16(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Olá, Mundo!");
                    break;

                case 2:
                    Console.WriteLine("Bem vindos ao C#!");
                    break;

                case 3:
                    Console.WriteLine("Saindo...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Programa finalizado");
                    break;

                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }
    }
}