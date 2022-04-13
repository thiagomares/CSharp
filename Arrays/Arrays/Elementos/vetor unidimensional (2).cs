using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Elementos
{
    class vetor_unidimensional
    {
        public static void VetorUnidimensional() // Isto aqui é uma função
        {
            int[] Vetor = new int[5]; // Um Vetor de 5 posições do tipo inteiro

            string[] VetorString = { "Thiago", "Thalia" }; // Temos esta forma simplificada de gerar um vetor.
            /*
                Obs.: Caso coloquemos mais itens no array, possivelmente teremos problemas
            */
            int Contador = 0;

            while (Contador <= 4)
            {
                Vetor[Contador] = Contador;
                Contador++;
            }


            /*
                Imprimindo os valores de um array    
            */

            foreach (int i in Vetor) // Iterando o vetor
            {
                Console.WriteLine(i);
            }
        }
    }
    class teste
    {
        public static void Testando() 
        {
            Console.WriteLine("Olá Mundo");
        }
    }
}
