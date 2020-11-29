using System;

namespace Lesson016_HT_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string text = Console.ReadLine();
            int color = int.Parse(Console.ReadLine());
            Prints.Print(text, color);

        }
    }
}
