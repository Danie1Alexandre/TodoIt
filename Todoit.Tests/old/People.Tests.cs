/*using System;
using Xunit;
using TodoIt.Data;
using TodoIt.Model;
using System.Collections.Generic;

namespace Todoit.Tests
{
    public class PeopleTests
    {
        // checks Person[] array size in pepole class 
        //[Fact]
        /*public void ArraySizeTests()
        {
            People arraySize = new People(5);

            Assert.Equal(5, arraySize.Size());
            Assert.NotEqual(1, arraySize.Size());
        }
        
        //testing find all method 
        [Fact]
        public void ArrayReturn()
        {
            People arrayReturn = new People(0);

            // testing no array match to verify testArray is not the same as arrayReturn
            Person[] testArray = new Person[5];
            Assert.NotEqual(testArray, arrayReturn.FindAll());

            // Now testing if array is matching by copy content, which means find all method can successfully return array content if test pass
            testArray = arrayReturn.FindAll();
            Assert.Equal(testArray, arrayReturn.FindAll()); 
        }*/


        
        /*
        [Fact]
        public void FindByIdTests()
        {
           
            Person[] testPersonArray = new Person[5];

            Person Neo = new Person(1999);
            Neo.FirstName = "Neo";
            Neo.LastName = "redpill";
            testPersonArray[2] = Neo;
            People personWithId = new People(testPersonArray);
            
            Person[] comparePersonArray = new Person[5];
            comparePersonArray[2] = personWithId.FindById(1999);


            Assert.Equal(testPersonArray[2], comparePersonArray[2]);
        }
            
        /*

        [Fact]
        public void ClearTests()
        {
            People personWithId = new People(5);
            Person[] testPersonArray = new Person[5];

            Person Neo = new Person(1999);
            Neo.FirstName = "Neo";
            Neo.LastName = "redpill";
            testPersonArray[2] = Neo;
            personWithId.Clear();
            testPersonArray = personWithId.Clear();

            Assert.Equal(testPersonArray[2], personWithId.FindById(1999));
        }




    }}*/



       /* [Fact]
        public void clearSizeTests()
        {
            People people = new People();

            people.Clear();
            Assert.Equal(0, people.Size());
        }
        [Fact]
        public void AddPeopleTests()
        {
            People people = new People();
            
            Person[] expctedArray = new Person[4];
           
            people.Clear();
            for (int i = 0; i < expctedArray.Length; i++)
            {
                Person actualArray = people.NewPerson("tesla", "testsson" + i);
                expctedArray[i] = actualArray;

            }
            Assert.Equal(expctedArray.ToString(), People.PersonArray.ToString());

            Assert.Equal(people.FindAll(), People.PersonArray);
            Assert.Equal(4, people.Size());
            Assert.Equal(people.FindById(2), People.PersonArray[1]);
            people.Clear();
            Assert.Empty(People.PersonArray);
            
        }
        [Fact]
        public void ArrayRemoveTests()
        {
            People people = new People();

            people.Clear();
            Random remove = new Random();
            int id = 0;
            int indexToRemove = remove.Next(0, 4);
            List<Person> temp = new List<Person>();
            for (int i = 0; i < 4; i++)
            {
                Person actualArray = people.NewPerson("tesla", "testsson" + i);

                temp.Add(actualArray);
                if (indexToRemove == i)
                {
                    id = actualArray.PersonID;
                    temp.RemoveAt(indexToRemove);
                }

            }

            People.ArrayObjectRemove(id);
            Assert.Equal(temp.ToArray(), People.PersonArray);
            people.Clear();
        }

        

        */
