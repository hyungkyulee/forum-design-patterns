using System;

namespace StrategyPattern
{
    public class QuackBehaviorQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack -!!!");
        }
    }
}