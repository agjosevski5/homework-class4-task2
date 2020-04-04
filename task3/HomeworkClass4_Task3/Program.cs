using System;

namespace HomeworkClass4_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myBirthday = Convert.ToDateTime("09/13/2000");
            int age = AgeCalculator(myBirthday);
            Console.WriteLine($"I'm {age} years old");
            Console.ReadLine();
        }

        static int AgeCalculator(DateTime myBirthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - myBirthday.Year;

            if (myBirthday > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
