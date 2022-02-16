using System;

namespace Persons
{
    abstract public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _adress;
        private int _id;

        public Person (string firstName, string lastName, string adress, int id)
        {
        _firstName = firstName;
        _lastName = lastName;
        _adress = adress;
        _id = id;
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                _adress = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        virtual public void Display()
        {
            Console.WriteLine($"Name: {_firstName} {_lastName}, Adress : {_adress}, ID: {_id}");
        }
    }
}
