using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Insira os dados de Cadastro:");
        Console.WriteLine("Nome: ");
        string name = Console.ReadLine();
        Console.WriteLine("Telefone: ");
        string phone = Console.ReadLine();
        Console.WriteLine("Email: ");
        string email = Console.ReadLine();
        Console.WriteLine("Idade: ");
        string age = Console.ReadLine();

        Console.WriteLine($"Dados Cadastrados:\nNome: {name}\nEmail: {email}\nTelefone: {phone}\nIdade: {age}");

    }

}