using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== STRATEGY PATTERN ==========");

            Duck realDuck = new realDuctContext();
            realDuck.DoFly();
            realDuck.Display();
        }
    }
}