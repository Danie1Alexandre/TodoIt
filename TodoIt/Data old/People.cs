using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Model;

namespace TodoIt.Data
{
    public class People
    {
        private static Person[] personArray = new Person[0];


        public People (Person[] creatPersonArray)
        {
            personArray = creatPersonArray;
        }


        public int Size()
        {
            return personArray.Length;
        }

        /*Allow change on array size on personArray
        public People(int number)
        {
            Person[] newArray = new Person[number];
            personArray = newArray;
        }*/

        public Person[] FindAll()
        {
            return personArray;
        }

        //Metod used for find matching id in personArray
        public Person FindById(int personId)
        {
            Person findById = new Person();
           
            try
            {
                for (int i = 0; i < Size(); i++)
                {
                    if (personArray[i].PersonID.Equals(personId))
                    {
                        findById = personArray[i];
                    }
                }
            }
            catch
            {
                Console.WriteLine("\n no id was found ");
            }
            return findById;
        }

 

       
        

       

        /*public void copyArray (Person[] newArray)
        {
            for (int i = 0; i < personArray.Length; i++)
            {
                personArray[i] = newArray[i];
            }
        }


        public void Clear()
        {
            personArray = Array.Empty<Person>();
        }*/





        /*

        public Person[] FindAll()
        {
            Person[] returnArray = new Person[personArray.Length];

            for (int i = 0; i < personArray.Length; i++)
            {
                returnArray[i] = personArray[i];
            }
            return returnArray;
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
        public static void ArrayObjectRemove(int personId)
        {
            People people = new People();
            try
            {
                int indexToRemove = Array.IndexOf(personArray, people.FindById(personId));
                List<Person> temp = new List<Person>(personArray);

                temp.RemoveAt(indexToRemove);
                personArray = temp.ToArray();
            }
            catch
            {
                Console.WriteLine("Error removing from Array");
            }

        }


        public void Clear()
        {
            personArray = Array.Empty<Person>();
        }

        */
    }

    
   
}
