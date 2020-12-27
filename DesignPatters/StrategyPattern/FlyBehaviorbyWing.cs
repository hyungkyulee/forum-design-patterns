using System;

namespace StrategyPattern
{
    public class FlyBehaviorbyWing : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Duct is flying by its wing.");
        }
    }
}