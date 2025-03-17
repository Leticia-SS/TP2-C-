class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a primeira data: ");
        DateTime date1 = Convert.ToDateTime(Console.ReadLine());

        Console.WriteLine("Digite a segunda data: ");
        DateTime date2 = Convert.ToDateTime(Console.ReadLine());

        if (date1 < date2)
        {
            // Tinha alguns problemas no código dependendo da data que digitavam fosse maior ou igual a outra, ent to trocando as variaveis de lugar de acordo com a data mais recente sendo date1
            DateTime newDate1 = date1;
            date1 = date2;
            date2 = newDate1;
    
        }
        
        int totalMonth = date1.Month - date2.Month, totalDays = date1.Day - date2.Day, totalYears = date1.Year - date2.Year;

        if (totalMonth < 0)
        {
            totalMonth += 12;
        } 

        if (totalDays < 0)
        {
            totalMonth--;
            totalDays = DateTime.DaysInMonth(date1.Year, date1.Month) + totalDays;
        }

        Console.WriteLine($"Diferença das datas = {totalYears} anos, {totalMonth} meses, {totalDays} dias");

    }
}