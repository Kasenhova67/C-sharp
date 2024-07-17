using System;

public class DateService
{
    static int CheckDay(string str)
    {
        while (true)
        {
            if (int.TryParse(str, out int number) && number > 0 && number<=31)
            {
                return number;
            }
            Console.WriteLine("The entered number is not correct.Try again.");
            str = Console.ReadLine();
        }
    }

    static int CheckMonth(string str)
    {
        while (true)
        {
            if (int.TryParse(str, out int number) && number > 0 && number<13)
            {
                return number;
            }
            Console.WriteLine("The entered number is not correct.Try again.");
            str = Console.ReadLine();
        }
    }

    static int CheckYear(string str)
    {
        while (true)
        {
            if (int.TryParse(str, out int number) && number>=0)
            {
                return number;
            }
            Console.WriteLine("The entered number is not correct.Try again.");
            str = Console.ReadLine();
        }
    }
     public string GetDay(string date)
    {
        DateTime parsedDate;
        if (DateTime.TryParse(date, out parsedDate))
        {
            return parsedDate.DayOfWeek.ToString();
        }
        else
        {
            return "Некорректный формат даты";
        }
    }

    public int GetDaysSpan(int day, int month, int year)
    {
        bool isLeapYear = DateTime.IsLeapYear(year);

        if (month == 2 && day == 29 && !isLeapYear)
        {
            Console.WriteLine("Указанная дата некорректна: 29 февраля не существует в указанном году.");
            return -1;
        }

        DateTime currentDate = DateTime.Now.Date;
        DateTime specifiedDate;

        try
        {
            specifiedDate = new DateTime(year, month, day);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Указанная дата некорректна.");
            return -1;
        }

        if (currentDate > specifiedDate)
        {
            TimeSpan span = currentDate - specifiedDate;
            return span.Days;
        }
        else
        {
            return -1;
        }
    }

}