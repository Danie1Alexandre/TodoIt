using System;
using Xunit;
using TodoIt.Data;
using TodoIt.Model;

namespace Todoit.Tests
{
    public class PeopleTests
    {
        [Fact]
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
       



    }
    
}
