using System;

namespace laba3.Classes
{
    public abstract class Pet
    {
        public string Name {get; set;}
        public int Age;
        public string Color;

        public void AnimalColor()
        {
            Console.WriteLine($"{Name} is a {Color}");
        }

        public void AnimalAge()
        {
            if(Age == 1)
            {
                Console.WriteLine($"{Name} is a {Age} year old");
            }
            else
            {
                Console.WriteLine($"{Name} is a {Age} years old");
            }
        }

        public abstract void AnimalEat();
    }
}