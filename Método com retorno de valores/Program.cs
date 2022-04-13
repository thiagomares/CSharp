using System;

class Retorno
{
    static void Main(string[] args)
    {
        Metodos m = new Metodos();
        Retorno r = new Retorno(); // Caso eu queira fazer um retorno de métodos que estejam dentro da propria classe, eu tenho que chamá-la de onde ela estiver, como se fosse uma classe externa.
        Console.WriteLine(r.retorno("Thiago"));
    }
    public string retorno(string nome) // Ele dá erro pois se não tiver retorno, ele vai gerar erro
    {
        return nome;
    }
    // Nos podemos passar um método durante a criação do metodo e o parametro pedir outro tipo de variável
    public int CodigoChar(char caractere)
    {
        int codigo = caractere;
        return codigo;
    }
}

class Metodos
{
    public string retorno(string nome) // Ele dá erro pois se não tiver retorno, ele vai gerar erro
    {
        return nome;
    }
    // Nos podemos passar um método durante a criação do metodo e o parametro pedir outro tipo de variável
    public int CodigoChar(char caractere)
    {
        int codigo = caractere;
        return codigo;
    }
}