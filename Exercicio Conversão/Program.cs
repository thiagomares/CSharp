// Criando um programa que converta Celsisus <> Fahreinheit <> Kelvin

using System;

namespace Exercicio_Conversão
{
    class Program
    {
        public static object C { get; private set; }

        static void Main(string[] args)
        {
            string t;

            Console.WriteLine("Você deseja converter [C]elsius ou [F]ahreinheit");
            t = Console.ReadLine();

            // Bloco que converte Celsius em Fahreinheit
            if (t == "C" || t == "c")
            {
                Console.WriteLine("Digite o valor que quer converter");
                double celsius = Convert.ToDouble(Console.ReadLine());
                celsius = celsius * 1.8 + 32;
                Console.WriteLine(celsius);
            }

            // Bloco que coverte Fahreinheit em Celsius    
            if (t == "F" || t == "f")
            {
                Console.WriteLine("Digite o valor que quer converter");
                double Fahreinheit = Convert.ToDouble(Console.ReadLine());
                Fahreinheit = (Fahreinheit - 32) / 1.8;
                Console.WriteLine(Fahreinheit);
            }
        }
    }
}
