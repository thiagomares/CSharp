// See https://aka.ms/new-console-template for more information
using Métodos_Com_Parametros.Classes;

Console.WriteLine("Hello, World!");

#region Métodos com parametros
    Metodos Param = new Metodos();
    Param.Parametros(431, 32);
#endregion

#region Passagem de dados por valor e referência
    passagem_por_referencia Metodos = new passagem_por_referencia();
    Metodos.valor(10, 0);
    int valor_qualquer = 10;
    Metodos.Referencia(ref valor_qualquer); 
    // Quando precisamos passar um valor por referencia, utilizamos utilizar da palavra reservada ref, para que o dotnet entenda que aquele valor é o valor de referencia
#endregion

string Nome = Console.ReadLine();
System.Console.WriteLine(Nome);
