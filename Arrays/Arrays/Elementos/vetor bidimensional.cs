using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Elementos
{
    class vetor_bidimensional
    {
        public static void VetoresBidimensionais()
        {
            /*
                Para criar uma matriz bidimensional, basta que façamos como as matrizes unidimensionais, porém, 
                inserindo em sua declaração, uma virgula dentro do simbolo de array, da seguinte forma:

                int[,] nome_do_vetor = new int[];
            */

            int[,] vetor = new int[3, 3];
            int i = 0;
            int b = 0;

            while (i <= 2)
            {
                while (b <= 2 && b <= i) {
                    vetor[i, b] = b ;
                    b++;
                }
                
                i++;
            }

            foreach (int cont in vetor) 
            {
                Console.WriteLine(cont);
            }
        }
    }
}
