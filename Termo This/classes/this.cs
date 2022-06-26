namespace Termo_This.classes
{
    public class Acessar
    {
        string senha = "Thiago";
        public bool Login(string senha)
        {
            return this.senha == senha; // Nos utilizamos a palavra this para referenciar a variavel local
        }
    }
}