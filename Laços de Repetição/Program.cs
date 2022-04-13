using System;

namespace Laços_de_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Laço while

            /*
                O laço While é um laço de repetição utilizado para realizar uma estrutura
                que dependa de que repita alguma instrução
            */

            int contador = 0;

            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            /*
                Temos ainda o do while, que faz exatamente a mesma coisa que o laço while comum,
                contudo, nos indicamos a ele que ele faça o bloco de codigo antes da verificação verdade
            */

            do
            {
                Console.WriteLine(contador);
                contador++;
            } while (contador <= 20);

            #endregion

            #region Laço For
            /*
                O laço for tem um intuito muito parecido com o laço while, contudo, o laço for irá
                realizar a verificação da condição verdade de forma diferente.

                Primeiro ele irá ler como está a condição inicial, em seguida a condição de parada e 
                por fim ele irá realizar a ação, e tudo isso será declarado no bloco verdade.
            */

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region For Each
            /*
                O laço for each funciona similarmente como o for of ou for in do javascript
            */

            int[] Matriz = { 1, 2, 3, 4, 5 };

            foreach (var Valor in Matriz)
            {
                Console.WriteLine(Valor);
            }
            #endregion
        }
    }
}
