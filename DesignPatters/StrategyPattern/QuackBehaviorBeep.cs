using System;

namespace StrategyPattern
{
    public class QuackBehaviorBeep : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Beep Beep -!!!");
        }
    }
}