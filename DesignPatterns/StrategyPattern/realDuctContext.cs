using System;

namespace StrategyPattern
{
    public class realDuctContext : Duck
    {
        // 5) simulate a model (create a context)
        public realDuctContext()
        {
            FlyBehavior = new FlyBehaviorbyWing();
            QuackBehavior = new QuackBehaviorQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real duck and able to fly...");
        }
    }
}