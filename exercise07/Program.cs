using TP2_Library;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira um número inteiro:");
        int number = Convert.ToInt32(Console.ReadLine());

        Library library = new Library();
        library.ParImpar(number);
    }
}