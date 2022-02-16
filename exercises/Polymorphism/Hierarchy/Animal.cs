namespace Hierarchy
{
    public class Animal
    {
        protected string _animalName;
        protected string _animalType;
        protected double _animalWeight;
        protected int _foodEaten;

        protected Animal(string name, string type, double weight)
        {
            _animalName = name;
            _animalType = type;
            _animalWeight = weight;
            _foodEaten = 0;
        }

        public virtual string MakeSound()
        {
            return "";
        }

        public virtual void Eat(Food food)
        {

        }

        public override string ToString()
        {
            return $"{_animalName}[{_animalType}, {_animalWeight}, {_foodEaten}]";
        }
    }
}
