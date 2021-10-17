using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    public class Person
    {
        // Private fields and propertys to allow access to private member outside the class
        private readonly int personId;
        private string firstName;
        private string lastName;


        public int PersonID
        {
            get { return personId; }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name must have a value");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name must have a value");
                }
                lastName = value;
            }
        }

        public Person()
        {

        }
        public Person(int newid)
        {
            personId = newid;
        }


    }
}
