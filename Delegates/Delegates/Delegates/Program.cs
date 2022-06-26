// See https://aka.ms/new-console-template for more information

using Delegates.classe;

namespace Delegates
{
    class Program
    {
        delegate void Opercoes(int num1, int num2);

        static void Main(string[] args)
        {
            #region Delegates

            delegates d = new delegates();

            Opercoes conta = null;
            conta += d.Somar;
            Opercoes multiplica = null;
            multiplica = d.Multiplica;

            conta += multiplica;
            conta(12, 21);
            /*
             * Método Delegate
             *
             * O método delegate faz com que os métodos importados a ele se comportem como um método interno,
             * sem a necessidade de referenciar a classe em todas as vezes que necessitarmos utilizar.
             */


            #endregion

        }
    }
}