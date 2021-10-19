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

        // adds property to Person id only return value allowed
        public int PersonID
        {
            get { return personId; }
        }

        //constructor that can build the object and add id nummber to person
        public Person(int newid)
        {
            personId = newid;
        }
       
        //constructor that can build the object without arguments
        public Person()
        {
  
        }

        // adds property to first name, and null + empty test.
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

                    throw new ArgumentException ("First name can not be null or empty");
                }
                firstName = value;
            }
        
        }

        // adds property to last name, and null + empty test.
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
                    throw new ArgumentException("Last name can not be null or empty");
                }
                lastName = value;
            }
        } 
    }
}
