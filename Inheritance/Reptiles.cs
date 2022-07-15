using System;
namespace Inheritance
{
    public class Reptiles : Animal
    {
        public Reptiles()
        {
        }

        public string SkinColor { get; set; }

        public int NumberOfLegs { get; set; }

        public int LifeExpectancy { get; set; }

        public bool LiveInWater { get; set; }
    }
}

