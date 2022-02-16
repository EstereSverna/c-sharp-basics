using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _directory;

        public PhoneDirectory() 
        {
            _directory = new SortedDictionary<string, string>();
        }

        public int Find(string name)
        {
            if (_directory.ContainsKey(name))
            {
                return _directory.Keys.ToList().IndexOf(name);
            }
            else
            {
                return -1;
            }
        }

        public string GetNumber(string name) 
        {
            if (_directory.ContainsKey(name)) 
            {
                return _directory[name];
            } 
            else 
            {
                return null;
            }
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new ArgumentException("name and number cannot be null");
            }
            var i = Find(name);
            if (i >= 0)
            {
                _directory[name] = number;
            }
            else
            {
                var newEntry = new PhoneEntry { name = name, number = number };
                _directory.Add(newEntry.name, newEntry.number);
            }
        }
    }
}