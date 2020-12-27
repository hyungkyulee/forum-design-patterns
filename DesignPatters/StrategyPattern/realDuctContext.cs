using System;

namespace StrategyPattern
{
    public class realDuctContext : Duck
    {

        public realDuctContext()
        {
            flyBehavior = new FlyBehaviorbyWing();
            quackBehavior = new QuackBehaviorQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real duck and cannot fly, but swim...");
        }
    }
}