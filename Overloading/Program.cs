using System;

class Sobrecarga
{
    static void Main(string[] args)
    {
        Sobrecarga carga = new Sobrecarga();
        string nome = carga.overload("Thiago");
        Console.WriteLine(nome); // Aqui o compilador retorna o valor que damos
        carga.overload();   // Já aqui ele vai retornar o que nos deixamos no nosso primeiro método.
    }

    public void overload()
    {
        // O Overload nada mais é criar vários métodos com várias assinaturas
        Console.WriteLine("Olá mundo");
    }

    public string overload(string teste)
    {
        // se este método não tivesse qualquer tipo de parâmetro instanciado dentro da sua declaração, este método simplesmente exibiria um erro, pois não pode existir dois métodos com a mesma assinatura, contudo, quando inserimos algo dentro dos parametros, eles são coisas diferentes.
        return teste;
    }
}