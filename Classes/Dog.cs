using System;

namespace laba3.Classes
{
    public class Dog : Pet
    {
        public override void AnimalEat()
        {
            Console.WriteLine($"A dog eats meat");
        }
    }
}