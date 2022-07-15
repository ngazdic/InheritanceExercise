using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
        }

        public bool Migratory { get; set; }

        public bool Predators { get; set; }

        public string FeatherColors { get; set; }

        public int Flyspeed { get; set; }


    }

}