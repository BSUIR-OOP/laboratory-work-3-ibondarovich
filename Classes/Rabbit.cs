using System;

namespace laba3.Classes
{
    public class Rabbit : Pet
    {
        public override void AnimalEat()
        {
            Console.WriteLine($"Rabbit eats grass");
        }
    }
}