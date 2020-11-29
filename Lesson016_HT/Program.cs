using System;

namespace Lesson016_HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime dt1 = DateTime.Parse("02/06/2002");
            DateTime dt2 = DateTime.Parse(DateTime.Now.ToString());
            DateTime dt3 = DateTime.Parse("02/06/2021");
            int days = (dt2 - dt1).Days;
            Console.WriteLine($"I live {days} days");

            double month = (dt2 - dt1).Days / 30;
            Console.WriteLine($"I live {month} days");
            double year = (dt2 - dt1).Days / 365;
            Console.WriteLine($"I live {year} days");

            DateTime Variable = DateTime.Now;
            int NumOfDaysTillNextMonth = 0;

            while (Variable < dt3) 
            {
                Variable = Variable.AddDays(1);
                NumOfDaysTillNextMonth++;
                
            }
            Console.WriteLine($"Days till my next birthday: {NumOfDaysTillNextMonth}");
        }
    }
}
