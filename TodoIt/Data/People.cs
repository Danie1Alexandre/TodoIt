using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Model;

namespace TodoIt.Data
{
    public class People
    {
        private static Person[] personArray = new Person[0];
        public static Person[] PersonArray { get { return personArray; } }

       //Checks array lenght
        public int Size()
        {
          return personArray.Length;
        }
        public Person[] FindAll()
        {
            Person[] returnArray = new Person[personArray.Length];

            for (int i = 0; i < personArray.Length; i++)
            {
                returnArray[i] = personArray[i];
            }
            return returnArray;
        }
        public Person FindById(int personId)
        {
            Person personById = new Person();

            try
            {
                for (int i = 0; i < Size(); i++)
                {
                    if (personArray[i].PersonID.Equals(personId))
                    {
                        personById = personArray[i];
                    }

                }
            }
            catch
            {
                Console.WriteLine("\n no id was found ");
            }
            return personById;
        }
        public Person NewPerson(string FirstName, string LastName)
        {

            Person personObject = new Person(PersonSequencer.NextPersonId());
            personObject.FirstName = FirstName;
            personObject.LastName = LastName;

            int size = personArray.Length + 1;
            Array.Resize(ref personArray, size);
            personArray[personArray.Length - 1] = personObject;

            return personObject;
        }

       

        public void Clear()
        {
            personArray = Array.Empty<Person>();
        }


    }


   
}
