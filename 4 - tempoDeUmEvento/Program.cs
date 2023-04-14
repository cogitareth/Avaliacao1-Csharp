using System;

class Program
{
    static void Main(string[] args)
    {
        string[] startDayInput = Console.ReadLine().Split(' ');
        int startDay = int.Parse(startDayInput[1]);

        string[] startTimeInput = Console.ReadLine().Split(':');
        int startHour = int.Parse(startTimeInput[0]);
        int startMinute = int.Parse(startTimeInput[1]);
        int startSecond = int.Parse(startTimeInput[2]);

        string[] endDayInput = Console.ReadLine().Split(' ');
        int endDay = int.Parse(endDayInput[1]);

        string[] endTimeInput = Console.ReadLine().Split(':');
        int endHour = int.Parse(endTimeInput[0]);
        int endMinute = int.Parse(endTimeInput[1]);
        int endSecond = int.Parse(endTimeInput[2]);

        int durationSeconds = ((endDay - startDay) * 86400) + ((endHour - startHour) * 3600) + ((endMinute - startMinute) * 60) + (endSecond - startSecond);

        int durationDays = durationSeconds / 86400;
        durationSeconds %= 86400;
        int durationHours = durationSeconds / 3600;
        durationSeconds %= 3600;
        int durationMinutes = durationSeconds / 60;
        durationSeconds %= 60;

        Console.WriteLine($"{durationDays} dia(s)");
        Console.WriteLine($"{durationHours} hora(s)");
        Console.WriteLine($"{durationMinutes} minuto(s)");
        Console.WriteLine($"{durationSeconds} segundo(s)");
    }
}