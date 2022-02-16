using System;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string name, string type, double weight, string livingRegion) : base(name, type, weight, livingRegion)
        {

        }

        public override string MakeSound()
        {
            return "squeeak";
        }

        public override void Eat(Food food)
        {
            if (!food.GetType().Name.Equals(nameof(Vegetable)))
            {
                throw new ArgumentException($"Mouses are not eating that type of food!");
            }
            else
            {
                _foodEaten += food._quantity;
            }
        }
    }
}
