using System;

namespace StrategyPattern
{
    // 3) implement behaviour classes via interface
    public class FlyBehaviorbyWing : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Duct is flying by its wing.");
        }
    }
}