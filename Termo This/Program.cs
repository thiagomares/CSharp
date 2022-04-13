using Termo_This.classes;

class termoThis
{
    static void Main(string[] args)
    {
        Acessar a = new Acessar();
        if (a.Login("Ana Clar"))
        {
            System.Console.WriteLine("Olá, Mundo");
        }
        else
        {
            System.Console.WriteLine("Senha Errada");
        }
    }
}