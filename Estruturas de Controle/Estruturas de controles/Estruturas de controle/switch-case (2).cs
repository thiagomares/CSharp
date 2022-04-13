using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_controles.Estruturas_de_controle
{
    class switch_case
    {
        public static void SwitchCase()
        {
            // O switch case fará como uma cadeia de estruturas se, porém, ocupando menos espaço e deixando o codigo mais legivel

            string Opcao = Console.ReadLine();

            switch (Opcao) 
            {
                case "1":
                    Console.WriteLine("Opção1");
                    break;

                case "2":
                    Console.WriteLine("Opção2");
                    break;
                default:
                    Console.WriteLine("Erro");
                    break;

            }
        }
    }
}
