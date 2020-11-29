using System;

namespace Lesson016_HT_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Accauntant accauntant1 = new Accauntant();
            Enum e_1 = Workers.junior;
            int e1 = Convert.ToInt32(e_1);
            Enum e_2 = Workers.middle;
            int e2 = Convert.ToInt32(e_2);
            Enum e_3 = Workers.senjor;
            int e3 = Convert.ToInt32(e_3);
            accauntant1.AskForBonus(Workers.junior,e1);
            accauntant1.AskForBonus(Workers.middle, e2);
            accauntant1.AskForBonus(Workers.senjor, e3);
        }
    }
}
