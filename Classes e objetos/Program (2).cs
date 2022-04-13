// See https://aka.ms/new-console-template for more information
using System;
using Classes_e_objetos.classes;

Console.WriteLine("Hello, World");

#region POO e Funções
// Importando uma funcão
Classes_e_objetos.classes.teste.Testando();


// Criando um objeto com uma classe
NovaClasse Orientação_a_objetos = new NovaClasse();

// inserindo dados em um objeto
NovaClasse p1 = new NovaClasse();
p1.Idade = 23;
p1.Nome = "Thiago";
System.Console.WriteLine("Nome: " + p1.Nome + "; Idade: " + p1.Idade);

#endregion

#region Métodos Sem Parâmetros
    // Aqui nos vamos aprender a definir métodos
    // Um método não retorna ou recebe qualquer valor, somente realiza uma função especifica
    // E para criar uma função que nao retorna nada, nos vamos utilizar a estrutura assim:
    // É importante que coloquemos as inserções de novos métodos seja antes da declaração de classe e método

    Metodos gol = new Metodos();
    gol.Ola_mundo();
    class Metodos
    {
        public void Ola_mundo()
        {
            System.Console.WriteLine("Gol Do galo");
        }
    }

    


#endregion

#region Métodos com parâmetros
    // 
#endregion
