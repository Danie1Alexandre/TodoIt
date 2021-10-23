using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Model;

namespace TodoIt.Data
{
    class People
    {
        private static Person[] arrayWithPeople = new Person[0];

        public  Person[] ArrayWithPeople
        {
            get { return arrayWithPeople;}
            set { arrayWithPeople = value;}
        }

        public int Size() 
        {
            return arrayWithPeople.Length;
        }

        public Person[] FindAll() {return arrayWithPeople;}

        public Person FindById(int personId)
        {
            Person findPersonId = new Person(personId);
            
            Person[] personFound = new Person[Size()];
            

            for (int i = 1; i < Size(); i++)
            {

                if (findPersonId.PersonID == arrayWithPeople[i].PersonID)
                {
                    personFound[1] = arrayWithPeople[i];
                    break;
                }
            }
            return personFound[1];
        }

        public Person addNewPerson(string firstName, string lastName)
        {
            Person newPerson = new Person(PersonSequencer.NextPersonId());


            newPerson.FirstName = firstName;
            newPerson.LastName = lastName;

            //incrase size of arry
            int arraySize = Size() + 1;
            Array.Resize(ref arrayWithPeople, arraySize);

            //-1 is nedded to set newPerson to start in arry number 0.
            arrayWithPeople[arraySize - 1 ]  = newPerson; 

            return  newPerson;
        }
        public void Clear()
        {
            arrayWithPeople = Array.Empty<Person>();
        }

        public Person[] removeObjectFromArray(int personId)
        {
            int arraySize = 0;
            Person[] personFound = new Person[arraySize];
            int addItem = 0;

            for (int i = 0; i < Size(); i++)
            {
                if (arrayWithPeople[i].PersonID == personId)
                {
                    Array.Clear(arrayWithPeople, i, 1);
                }
                else
                {
                    arraySize++;
                    Array.Resize(ref personFound, arraySize);
                    personFound[addItem] = arrayWithPeople[i];
                    addItem++;
                }
            }
            arrayWithPeople = personFound;
            return arrayWithPeople;
        }
    }
} 
