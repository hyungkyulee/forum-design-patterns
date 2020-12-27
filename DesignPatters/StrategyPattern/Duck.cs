using System;

namespace StrategyPattern
{
    public abstract class Duck
    {
        private protected IFlyBehavior flyBehavior;
        private protected IQuackBehavior quackBehavior;
        
        public Duck()
        {
        }

        public abstract void Display();
        public void Swim()
        {
            Console.WriteLine("Duck is swimming...");
        }

        public void DoFly()
        {
            flyBehavior.Fly();
        }

        public void DoQuack()
        {
            quackBehavior.Quack();
        }
    }
}