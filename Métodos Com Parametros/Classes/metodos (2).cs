namespace Métodos_Com_Parametros.Classes
{
    public class Metodos
    {
        // Metodos com parâmetros permite que nos inserimos dados para que realize uma função com inserção e retorno de dados

        // Criando uma função simples para termos como base

        public void Simples()
        {
            System.Console.WriteLine("Olá, mundo");
        }

        // Criando métodos com parametros. A Unica diferença de um método sem para um método com parâmetros é que no escopo da declaração nos inserimos os dados

        public void Parametros(int parametro1,int parametro2)
        {
            System.Console.WriteLine(parametro1 + parametro2);
        }
    }
}