class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n");

        while (num >= 0)
        {
            Console.Write($"{num}, ");
            num--;
        }
    }
}