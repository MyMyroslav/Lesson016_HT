using System;
namespace Lesson016_HT_Task2
{
    public static class Prints
    {
        static Prints()
        {
        }
         public static void Print(string str, int color)
        {
            switch (color)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{str}");
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{str}");
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{str}");
                    break;

                default:
                    break;
            }
            
            }
            
        }
    }

