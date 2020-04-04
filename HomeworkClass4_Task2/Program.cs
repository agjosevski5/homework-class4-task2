using System;

namespace HomeworkClass4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Today is: {now.ToString("dd / MM / yyyy")}");
            string addedDays = now.AddDays(3).ToString("dd/MM/yyyy");
            Console.WriteLine($"Three day from now: {addedDays}");

            DateTime month = now.AddMonths(1);
            string monthString = month.ToString("dd/MM/yyyy");
            Console.WriteLine($"One month from now: {monthString}");

            string oneMonth3Days = month.AddDays(3).ToString("dd/MM/yyyy");
            Console.WriteLine($"One month and three days from now: {oneMonth3Days}");

            string addedYears = now.AddYears(-1).AddMonths(-2).ToString("dd/MM/yyyy");
            Console.WriteLine($"One years and two months ago: {addedYears}");

            string currentMonth = now.ToString("MMMM");
            Console.WriteLine($"Current month: {currentMonth}");

            string currentYear = now.ToString("yyyy");
            Console.WriteLine($"Current Year: {currentYear}");

            Console.ReadLine();
        }
    }
}
