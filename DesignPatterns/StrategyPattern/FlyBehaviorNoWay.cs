using System;

namespace StrategyPattern
{
    public class FlyBehaviorNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("The duck is hurt, and NOT able to fly.");
        }
    }
}