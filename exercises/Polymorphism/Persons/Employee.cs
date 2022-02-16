using System;

namespace Persons
{
    public class Employee : Person
    {
        private string _jobTitle;

        public Employee(string firstName, string lastName, string adress, int id, string jobTitle) : base(firstName, lastName, adress, id)
        {
            _jobTitle = jobTitle;
        }

        public string JobTitle
        {
            get
            {
                return _jobTitle;
            }
            set
            {
                _jobTitle = value;
            }
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Adress : {Adress}, ID: {Id}, Job title: {JobTitle}");
        }
    }
}
