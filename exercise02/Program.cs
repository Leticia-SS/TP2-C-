class Program
{
    static void Main(string[] args)
    {
        // Referencias: https://learn.microsoft.com/pt-br/dotnet/api/system.timespan?view=net-8.0 https://learn.microsoft.com/pt-br/dotnet/api/system.math.floor?view=net-9.0

        DateTime currentTime = DateTime.Now, birthDate;

        Console.WriteLine("Informe uma data de nascimento");
        birthDate = Convert.ToDateTime(Console.ReadLine());
        
        // Igualar os anos
        birthDate = birthDate.AddYears(currentTime.Year - birthDate.Year);


        if (birthDate < currentTime)
        {
            // Se o anv jpa passou, verifica os dias pro proximo ano
            birthDate = birthDate.AddYears(1);

        }

        TimeSpan interval = birthDate - currentTime;

        double total = interval.TotalDays;

        Console.WriteLine($"Dias até próximo aniversário: {Math.Ceiling(total)}");
    }
}