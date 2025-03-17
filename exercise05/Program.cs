
using TP2_Library;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a temperatura (em Celsius)");
        int celsius = Convert.ToInt32(Console.ReadLine());

        Library library = new Library();
        library.ConversaoTemperatura(celsius);

    }
}