using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 100);

        Console.WriteLine("Adivinhe o número de 1 a 100:");
        int number = Convert.ToInt32(Console.ReadLine());

        while (randomNumber != number)
        {
            if (number > randomNumber)
            {
                Console.WriteLine("Palpite muito alto.... diminua um pouco\n");
            } else
            {
                Console.WriteLine("Palpite muito baixo.... aumenta um pouco\n");
            }
            Console.WriteLine("Tente novamente: ");
            number = Convert.ToInt32(Console.ReadLine());

        }

        Console.WriteLine($"Parabéns, você acertou!!!\nPalpite = {number} | Número = {randomNumber}");
    }
}