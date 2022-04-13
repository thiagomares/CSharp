using System;

namespace Sequencia_de_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando a sequencia de fibonacci
            // A sequencia de fibonacci nada mais é que a soma dos dois valores anteriores, começando por 0 e 1

            Int64 a = 0, b = 1, c = 0;

            Console.WriteLine("Digite o valor que vc quer contar ");
            Int64 Contador = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequencia de fibonacci com " + Contador + " Valores");

            for (int i = 0; i <= Contador; i++)
            {
                Console.Write(c + ", ");
                c = a + b;

                // o A vai assumir o valor de b e o b de c
                a = b;
                b = c;
            }
        }
    }


    // class outro
    // {
    //     static void potencia(string[] args)
    //     {
    //         Console.WriteLine("Digite o valor que vc quer contar ");
    //         Int64 Contador = int.Parse(Console.ReadLine());

    //         Console.WriteLine("Sequencia de fibonacci com " + Contador + " Valores");

    //         for (int i = 0; i <= Contador; i++)
    //     }
    // }
}