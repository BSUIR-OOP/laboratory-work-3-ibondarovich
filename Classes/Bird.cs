using System;

namespace laba3.Classes
{
    public class Bird : Pet
    {
        public override void AnimalEat()
        {
            Console.WriteLine($"A Bird eats insects");
        }
    }
}