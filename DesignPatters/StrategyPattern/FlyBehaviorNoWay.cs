using System;

namespace StrategyPattern
{
    public class FlyBehaviorNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Duck is NOT able to fly.");
        }
    }
}