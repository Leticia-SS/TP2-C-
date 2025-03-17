class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua data de nascimento: ");
        DateTime birthDate = Convert.ToDateTime(Console.ReadLine());

        int year = birthDate.Year, month = birthDate.Month, day = birthDate.Day;


        DateTime currentTime = DateTime.Now;
        int currentYear = currentTime.Year, currentMonth = currentTime.Month, currentDay = currentTime.Day;


        int ageYear = currentYear - year, ageMonth = currentMonth - month, ageDay = currentDay - day;

        if (currentMonth < month || (currentMonth == month && currentDay <= day)) 
        {
            ageYear--;
            ageMonth += 12; // Se o atual for menor o valor de ageMonth vai ser negativo, ent adicionar 12 ajusta para a real diferença em meses
        }

        if (ageDay < 0)
        {
            ageMonth--;
            ageDay = DateTime.DaysInMonth(currentYear, currentMonth) + ageDay; 
            //Método do DateTime, referencia: https://learn.microsoft.com/pt-br/dotnet/api/system.datetime.daysinmonth?view=netcore-3.1 
        }

        //Console.WriteLine($"currentTime = {currentTime} / birthDate = {birthDate}");
        //Console.WriteLine($"Idade em anos = {ageYear}")
        //Console.WriteLine($"Idade em meses = {ageMonth}");

        Console.WriteLine($"Sua idade é {ageYear} anos e {ageMonth} meses e {ageDay} dias");


    }
}
