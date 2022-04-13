namespace Métodos_Com_Parametros.Classes
{
    public class passagem_por_referencia
    {
        // Passagem de parametros por valor

        public void valor(int val1, int val2)
        {
            // Quando fazemos a passagem de parametros por valor, é exatamente desta forma que estamos vendo, inserindo o tipo de dado e rodando o mesmo dentro do método
            val1 += val2;
            System.Console.WriteLine(val1 + val2);
        }

        // Passagem de Parametros por referência
        public void Referencia(ref int val1)
        {
            // Quando utilizamos um valor por referencia, toda modificação que temos naquela variavel anteriormente será absolvida na referência
            System.Console.WriteLine(val1 + 40);
        }
    }
}