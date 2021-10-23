using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    class Person
    {
        private readonly int personId;
        private string firstName;
        private string lastName;

        // Constructor (id and personid not needed)
        public Person(int id)
        {
            personId = id;
        }

        public int PersonID
        {
            get {return personId;}
        }

        // Properties
        public string FirstName
        {
            get {return firstName;}
            set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be null or empty");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be null or empty");
                }
                lastName = value;
            }
        }

    }
}
