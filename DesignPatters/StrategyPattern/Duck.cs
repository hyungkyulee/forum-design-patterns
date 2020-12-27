using System;

namespace StrategyPattern
{
    public abstract class Duck
    {
        // 1) de-couple the changeable parts
        public IFlyBehavior FlyBehavior { get; private protected set; }
        public IQuackBehavior QuackBehavior { get; private protected set; }

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
            FlyBehavior.Fly();
        }

        public void DoQuack()
        {
            QuackBehavior.Quack();
        }

        // 4) preapre a setter method to be changeable in a runtime
        public void setFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }

        public void setQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }
    }
}