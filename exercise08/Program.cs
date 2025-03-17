using TP2_Library;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira uma nota de 0 a 10");
        int grade = Convert.ToInt32(Console.ReadLine());

        bool isValid = grade <= 10 && grade >= 0;

        Library library = new Library();

        if (isValid) 
        {
            library.ClassificarNota(grade);
        } else
        {
            Console.WriteLine("Nota inválida");
        }
    }
}