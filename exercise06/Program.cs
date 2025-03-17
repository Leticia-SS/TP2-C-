using TP2_Library;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira seu peso");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira sua altura:");
        double height = Convert.ToDouble(Console.ReadLine());

        Library library = new Library();
        library.CalculoIMC(height, weight);
    }
}