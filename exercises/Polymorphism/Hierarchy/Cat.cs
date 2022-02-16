using System;

namespace Hierarchy
{
    public class Cat : Felime
    {
        private readonly string _breed;

        public Cat(string name, string type, double weight, string livingRegion, string breed) : base (name, type, weight, livingRegion)
        {
           _breed = breed;
        }

        public override string MakeSound()
        {
            return "meowwww";
        }

        public override void Eat(Food food)
        {
            _foodEaten += food._quantity;
        }

        public override string ToString()
        {
            return $"{_animalName}[{_animalType}, {_breed}, {_animalWeight}, {_livingRegion}, {_foodEaten}] ";
        }
    }
}
