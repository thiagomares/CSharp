using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_controles.Estruturas_de_controle
{
    class estruturaGoTO
    {
        public static void GoTO()
        {
            /* 
             * A estrutura go to funciona como um laço de repetição, porém, e
             * le irá se comportar na verdade como um ponto de controle do codigo
            */
            Inicio: // Quando endereçamos este label, podemos criar uma estrutura que retorne para este ponto especifico do codigo
            Console.WriteLine("Escolha uma opção");

            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (op)
            {
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    break;
                    goto case 1;
            }
            Console.WriteLine("Deseja realizar mais alguma operação? S/N");
            string restart = Console.ReadLine();
            if (restart == "S" || restart == "s") 
            {
                goto Inicio;
            }
        }
    }
}
