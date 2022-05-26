using System;

namespace laba3.Classes
{
    public class Hamster : Pet
    {
        public override void AnimalEat()
        {
            Console.WriteLine($"A hamster eats seeds");
        }
    }
}