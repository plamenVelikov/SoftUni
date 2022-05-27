using System;

namespace Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            •	On the first input line – lost games count – integer in the range[0…1000].
            //•	On the second line – headset price – floating - point number in the range[0…1000].
            //•	On the third line – mouse price – floating - point number in the range[0…1000].
            //•	On the fourth line – keyboard price – floating - point number in the range[0…1000].
            //•	On the fifth line – display price – floating - point number in the range[0… 1000].

            int gamesLost = int.Parse(Console.ReadLine());
            float priceHeadset = float.Parse(Console.ReadLine());
            float priceMouse = float.Parse(Console.ReadLine());
            float priceKeyboard = float.Parse(Console.ReadLine());
            float priceDisplay = float.Parse(Console.ReadLine());
            int counterHeadset = 0;
            int counterMouse = 0;
            int counterKeyboard = 0;
            int counterDisplay = 0;

            for (int i = 1; i <= gamesLost; i++)
            {
                if (i % 2 == 0)
                {
                    counterHeadset++;
                }
                if (i % 3 == 0)
                {
                    counterMouse++;
                }
                if (i % 2 == 0 && i % 3 == 00)
                {
                    counterKeyboard++;
                    if (counterKeyboard % 2 == 0)
                    {
                        counterDisplay++;
                    }
                }
            }
            float expenses = counterHeadset * priceHeadset + counterMouse * priceMouse + counterKeyboard * priceKeyboard + priceDisplay * counterDisplay;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
