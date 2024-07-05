using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterApp
{
    internal class Person
    {
        private int _id;
        private string _firstName;
        private string _lastName;

        public int Id
        {
            get { return _id; }
            init { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }       

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Person(int id, string firstName, string lastName)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return $"Кадр: {Id}, по имени: {FirstName} {LastName}";
        }
    }
}
