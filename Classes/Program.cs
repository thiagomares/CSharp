using System;

/* Escalabilidade de um codigo

    De Fora para dentro:

    Namespace > Classe > Funções > Métodos > operações 
*/
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Olá Mundo");

            ClasseFodase.Teste();
        }
    }
    class ClasseFodase
    {
        // Exemplo de uma classe
        public static void Teste()
        {
            System.Console.WriteLine("Gol Da Alemanha");
        }
    }
}
