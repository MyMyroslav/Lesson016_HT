using System;
namespace Lesson016_HT_Task3
{
    public class Accauntant
    {
        public Accauntant()
        {
        }
       
        public bool AskForBonus(Workers workers, int hours)
        {
            int max = 50;
            if(hours > max)
            {
                Console.WriteLine($"Give premia to {workers}");
                return true;
            }
            else
                Console.WriteLine($"Do not give Premia to {workers}");
            return false;
        }

    }
}
