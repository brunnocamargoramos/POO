using System;

// ### Abstração
// Está relacionado em abstrair e simplificar objetos complexos do mundo real.

// Classe base abstrata representando um animal
abstract class Animal
{
    public string Nome { get; set; }
    
    public Animal(string nome)
    {
        Nome = nome;
    }
    
    // Método abstrato para ser implementado pelas subclasses
    public abstract void FazerSom();
    
    public void MostrarNome()
    {
        Console.WriteLine($"O nome do animal é {Nome}.");
    }
}

// ### Encapsulamento
// Esconder características intrínsecas de um objeto para outro objeto.

class Mamifero : Animal
{
    private int idade;
    
    public Mamifero(string nome, int idade) : base(nome)
    {
        this.idade = idade;
    }
    
    public int GetIdade()
    {
        return idade;
    }
    
    public override void FazerSom()
    {
        Console.WriteLine("O mamífero faz um som genérico.");
    }
}

// ### Herança
// Permite a criação de classes derivadas, herdando métodos e atributos de uma classe base.

class Cachorro : Mamifero
{
    public Cachorro(string nome, int idade) : base(nome, idade) {}
    
    public override void FazerSom()
    {
        Console.WriteLine("O cachorro late: Au Au!");
    }
}

class Gato : Mamifero
{
    public Gato(string nome, int idade) : base(nome, idade) {}
    
    public override void FazerSom()
    {
        Console.WriteLine("O gato mia: Miau!");
    }
}

// ### Polimorfismo
// Subclasses que herdaram a mesma classe base podem responder a mesma mensagem, mas de uma forma diferente.

class Program
{
    static void Main()
    {
        Mamifero[] animais = new Mamifero[]
        {
            new Cachorro("Rex", 5),
            new Gato("Felix", 3)
        };

        foreach (var animal in animais)
        {
            animal.MostrarNome();
            Console.WriteLine($"Idade: {animal.GetIdade()} anos");
            animal.FazerSom();
        }
    }
}
