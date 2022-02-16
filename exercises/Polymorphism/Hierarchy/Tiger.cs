using System;

namespace Hierarchy
{
    public class Tiger : Felime
    {
        public Tiger(string name, string type, double weight, string livingRegion) : base(name, type, weight, livingRegion)
        {

        }

        public override string MakeSound()
        {
            return "ROAR!!!";
        }

        public override void Eat(Food food)
        {
            if (!food.GetType().Name.Equals(nameof(Meat)))
            {
                throw new ArgumentException($"Tigers are not eating that type of food!");
            }
            else
            {
                _foodEaten += food._quantity;
            }
        }
    }
}
