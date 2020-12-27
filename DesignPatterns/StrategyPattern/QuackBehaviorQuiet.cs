using System;

namespace StrategyPattern
{
    public class QuackBehaviorQuiet : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quiet -!!!");
        }
    }
}