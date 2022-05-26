using System;

namespace laba3.Classes
{
    public class Cat : Pet
    {
        public override void AnimalEat()
        {
            Console.WriteLine($"A cat eats meat");
        }
    }
}