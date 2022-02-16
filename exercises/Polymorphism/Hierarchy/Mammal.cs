namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        protected string _livingRegion;

        public Mammal(string name, string type, double weight, string livingRegion) : base (name, type, weight)
        {
            _livingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{_animalName}[{_animalType}, {_animalWeight}, {_livingRegion}, {_foodEaten}] ";
        }
    }
}
