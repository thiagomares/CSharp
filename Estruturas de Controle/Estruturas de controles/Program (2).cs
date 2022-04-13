using Estruturas_de_controles.Estruturas_de_controle;
using System;

namespace Estruturas_de_controles
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Estruturas aninhadas

            // Estruturas aninhadas nada mais são que operações condicionais uma dentro da outra.

            int num = 10;

            if (num >= 5) 
            {
                Console.WriteLine("Este número é maior ou igual a 5");

                if (num % 2 == 0)
                {
                    Console.WriteLine("E também é par");
                }
            }
            #endregion

            #region Operador Ternário
            // Sintaxe do operador ternário

            string Msg;

            Msg = num < 10 ? "menor que 10" : "maior que 10"; 
            /* 
             * Desta forma, a variável irá verificar se aquela condição se torna verdadeira ou falsa, 
             * sem a necessidade de uma variável de controle completa.
            */

            Console.WriteLine(Msg);
            #endregion

            switch_case.SwitchCase();
            estruturaGoTO.GoTO();
        }
    }
}
