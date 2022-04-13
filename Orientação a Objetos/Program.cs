using System;
using classes;

namespace Orientação_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes e objetos

            /* 
                O que são classes e o que são objetos?

                Classes são conjunto de instancias e funções que servem basicamente para facilitar a herança e polimorfismo de dados.

                Objetos basicamente, em C#, são estruturas que podemos interagir


            */

            Outro();
            outraClasse.Outro();
            importandoClasses.Importador(); // Importei uma classe que está em outro arquivo de codigo
        }

        public static void Outro()
        {
            System.Console.WriteLine("Outra instancia dentro de uma classe");
            // Nos não podemos criar classes dentro de outra classe. Toda vez que precisarmos criar uma classe, ela pode ser feita em outro arquivo, utilizando depois tecnicas de call desta instancia, ou no mesmo namespace, apenas referenciando a mesma
        }
    }
    class outraClasse
    {
        public static void Outro(){
            System.Console.WriteLine("Undo");
        }
    }
}
