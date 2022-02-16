using System;

namespace exercise_7
{
    internal class Dog
    {
        private string _name;
        private string _sex;
        private Dog _mother;
        private Dog _father;

        public Dog(string name, string sex, Dog mother = null, Dog father = null)
        {
            _name = name;
            _sex = sex;
            _mother = mother;
            _father = father;
        }

        public void SetMother(Dog mother)
        {
            if (mother._sex == "female")
            {
                _mother = mother;
            }
        }

        public void SetFather(Dog father)
        {
            if (father._sex == "male")
            {
                _father = father;
            }
        }

        public void FathersName()
        {
            if(_father == null)
            {
                Console.WriteLine("Unknown");
            }
            else
            {
                Console.WriteLine(_father._name);
            }
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return _mother == otherDog._mother;
        }
    }
}
