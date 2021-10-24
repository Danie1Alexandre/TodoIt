using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Data;
using Xunit;
using TodoIt.Model;

namespace Todoit.Tests
{
    public class PeopleTests
    {
        [Fact]
        public void ArrayWithPeopleTests()
        {
            People theMatrix = new People();
            Person[] array = new Person[3];
            Person neo = new Person(1999) { FirstName = "Neo", LastName = "The One" };
            Person morpheus = new Person(1999) { FirstName = "morpheus", LastName = "Red Pill" };
            Person Trinity = new Person(1999) { FirstName = "Trinity", LastName = "Blue Pill" };

            array[0] = neo;
            array[1] = morpheus;
            array[2] = Trinity;
            theMatrix.ArrayWithPeople = array;

            Assert.Equal(theMatrix.ArrayWithPeople[0].FirstName, neo.FirstName);
            Assert.Equal(theMatrix.ArrayWithPeople[1].FirstName, morpheus.FirstName);
            Assert.Equal(theMatrix.ArrayWithPeople[2].PersonID, Trinity.PersonID);
            Assert.Equal(1999, theMatrix.ArrayWithPeople[2].PersonID);
        }

        [Fact]
        public void ArrayLenghtTests()
        {
            People theMatrix = new People();
            Person[] array = new Person[3];
        
            theMatrix.ArrayWithPeople = array;

            Assert.Equal(array.Length,theMatrix.Size());
            Assert.Equal(3, theMatrix.Size());
            Assert.NotEqual(5, theMatrix.Size());
        }

        [Fact]
        public void FindAllTests()
        {
            People theMatrix = new People();
            Person[] array = new Person[3];
            Person[] foundArray = new Person[0];
            Person neo = new Person(1999) { FirstName = "Neo", LastName = "The One" };
            Person morpheus = new Person(1999) { FirstName = "morpheus", LastName = "Red Pill" };
            Person Trinity = new Person(1999) { FirstName = "Trinity", LastName = "Blue Pill" };

            array[0] = neo;
            array[1] = morpheus;
            array[2] = Trinity;
            theMatrix.ArrayWithPeople = array;

            foundArray = theMatrix.FindAll();

            Assert.Equal(foundArray, theMatrix.ArrayWithPeople);
            Assert.Equal(foundArray[0].FirstName, theMatrix.ArrayWithPeople[0].FirstName);
            Assert.Equal(morpheus, foundArray[1]);
            Assert.NotEqual(Trinity, foundArray[1]);
            Assert.Equal(neo.PersonID, foundArray[2].PersonID);
            Assert.Equal(1999, foundArray[2].PersonID);
        }

        [Fact]
        public void FindByIdTests()
        {
            People theMatrix = new People();
            Person[] array = new Person[3];
            Person neo = new Person(1999) { FirstName = "Neo", LastName = "The One" };
            Person morpheus = new Person(2003) { FirstName = "morpheus", LastName = "Red Pill" };
            Person Trinity = new Person(2000) { FirstName = "Trinity", LastName = "Blue Pill" };
            Person testPerson = new Person(0) { FirstName = "test", LastName = "imNotZero" };

            array[0] = neo;
            array[1] = morpheus;
            array[2] = Trinity;
            theMatrix.ArrayWithPeople = array;

            Assert.Equal(theMatrix.FindById(1999).LastName, neo.LastName );
            Assert.Equal(1999, theMatrix.FindById(1999).PersonID);
            Assert.Equal(2003, theMatrix.FindById(2003).PersonID);
            Assert.Equal(array[0].LastName, theMatrix.FindById(1999).LastName);

            Assert.NotEqual(2001, theMatrix.FindById(2003).PersonID);
        }

        [Fact]
        public void addNewPersonTests()
        {
            People theMatrix = new People();
            theMatrix.addNewPerson("Mr.", "Andersson");

            Assert.Equal("Mr.", theMatrix.ArrayWithPeople[0].FirstName);
            Assert.Equal("Andersson", theMatrix.ArrayWithPeople[0].LastName);
            Assert.Equal(1, theMatrix.ArrayWithPeople[0].PersonID);

            Assert.NotEqual("Trinity.", theMatrix.ArrayWithPeople[0].FirstName);
        }

        [Fact]
        public void ClearTests()
        {
            People theMatrix = new People();
            theMatrix.Clear();
            theMatrix.addNewPerson("Neo", "The One");
            theMatrix.addNewPerson("Mr.", "Andersson");

            Assert.Equal(2,theMatrix.ArrayWithPeople.Length);
            theMatrix.Clear();
            Assert.NotEqual(2, theMatrix.ArrayWithPeople.Length);
            Assert.Empty(theMatrix.ArrayWithPeople);
        }





    }
}
