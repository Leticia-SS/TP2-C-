using TP2_Library;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira seu salário Bruto mensal:");
        double salary = Convert.ToDouble(Console.ReadLine());

        Library library = new Library();
        library.CalculoSalarioLiquido(salary);
    }
}