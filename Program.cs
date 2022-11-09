using System;

namespace Toy_____Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacationCost = double.Parse(Console.ReadLine());
            int puzzel = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());


            double puzzelPrice = puzzel + 2.60;
            int dollPrice = doll + 3;
            double bearPrice = bear + 4.10;
            double minionPrice = minion + 8.20;
            int truckPrice = truck + 2;
            double toysPrice = puzzelPrice + dollPrice + bearPrice + minionPrice + truckPrice;
            int toysCount = puzzel + doll + bear + minion + truck;


            if (toysCount > 50)
            {
                toysPrice = toysPrice * 0.75;
            }
            toysPrice = toysPrice * 0.9;

            if (vacationCost <= toysPrice)
            {
                Console.WriteLine($"Yes! {toysPrice - vacationCost:f2}lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacationCost - toysPrice:f2}lv needed.");
            }
            
        }
    }
}
