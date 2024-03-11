using System;
public class Program
{
    public static void Main()
    {
        
        //4
        Console.WriteLine("introdueix el dia de referencia:");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine("introdueix el mes de referencia:");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("introdueix l'any de referencia:");
        int year = int.Parse(Console.ReadLine());

        DateTime reff = new DateTime(year, month, day);

        Console.WriteLine("introdueix el dia a comparar");
        int compday = int.Parse(Console.ReadLine());
        Console.WriteLine("introdueix el mes a comparar");
        int compmonth = int.Parse(Console.ReadLine());
        Console.WriteLine("introdueix l'any a comparar");
        int compyear =int.Parse(Console.ReadLine());

        DateTime comp = new DateTime(compyear, compmonth, compday);

        if(comp.Year != reff.Year)
        {
            if(comp.Year < reff.Year)
            {
                Console.WriteLine("la segona data es anterior a la primera");
            }
            else
            {
                Console.WriteLine("la segona data es posterior a la primera");
            }
        }
        else if(comp.Month != reff.Month)
        {
            if (comp.Month < reff.Month)
            {
                Console.WriteLine("la segona data es anterior a la primera");
            }
            else
            {
                Console.WriteLine("la segona data es posterior a la primera");
            }
        }
        else if (comp.Day != reff.Day)
        {
            if (comp.Day < reff.Day)
            {
                Console.WriteLine("la segona data es anterior a la primera");
            }
            else
            {
                Console.WriteLine("la segona data es posterior a la primera");
            }
        }
        
        //5
        DateTime data = DateTime.Now;
        Console.WriteLine(data.DayOfWeek);
        
    }
}