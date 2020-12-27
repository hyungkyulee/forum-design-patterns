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
            realDuck.DoQuack();
            realDuck.Display();

            realDuck.setFlyBehavior(new FlyBehaviorNoWay());
            realDuck.setQuackBehavior(new QuackBehaviorQuiet());
            realDuck.DoFly();
            realDuck.DoQuack();
        }
    }
}