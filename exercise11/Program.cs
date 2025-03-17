using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("===== TABUADA =====\n");
        Console.WriteLine($"1 X {number} = {number}");
        Console.WriteLine($"2 X {number} = {number * 2}");
        Console.WriteLine($"3 X {number} = {number * 3}");
        Console.WriteLine($"4 X {number} = {number * 4}");
        Console.WriteLine($"5 X {number} = {number * 5}");
        Console.WriteLine($"6 X {number} = {number * 6}");
        Console.WriteLine($"7 X {number} = {number * 7}");
        Console.WriteLine($"8 X {number} = {number * 8}");
        Console.WriteLine($"9 X {number} = {number * 9}");
        Console.WriteLine($"10 X {number} = {number * 10}");
    }
}