using System;

namespace Persons
{
    public class Student : Person
    {
        private double _gpa;

        public Student(string firstName, string lastName, string adress, int id, double gpa) : base(firstName, lastName, adress, id)
        {
            _gpa = gpa;
        }

        public double Gpa
        {
            get
            {
                return _gpa;
            }
            set
            {
                _gpa = value;
            }
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Adress : {Adress}, ID: {Id}, GPA: {Gpa}");
        }
    }
}
