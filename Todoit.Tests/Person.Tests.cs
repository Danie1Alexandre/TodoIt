using System;
using Xunit;
using TodoIt.Model;

namespace Todoit.Tests
{
    public class PersonTests
    {
        [Fact]
        public void IdTests()
        {
            int idTestNummber = 0;
            Person TestPersonId = new Person();
            Assert.Equal(TestPersonId.PersonID, idTestNummber);
        }
        [Fact]
        public void FirstNameTest()
        {
            string firstNameTest = "Exmpelname"; 
            Person testPerson = new Person();
            testPerson.FirstName = firstNameTest;
            Assert.Equal(testPerson.FirstName, firstNameTest);
            Assert.NotNull(testPerson.FirstName);
        }
        [Theory]
        [InlineData("")]
        [InlineData(null)]

        public void FirstnamenullAndEmptyTests(string firstname)
        {
            Person persontest = new Person();

            ArgumentException ifNullEmpty = Assert.Throws<ArgumentException>(() => persontest.FirstName = firstname);
            Assert.Equal("First name must have a value", ifNullEmpty.Message);
        }
        [Fact]
        public void LastNameTest()
        {
            string LastNameTest = "Exmpelname";
            Person testPerson = new Person();
            testPerson.LastName = LastNameTest;
            Assert.Equal(testPerson.LastName, LastNameTest);
            Assert.NotNull(testPerson.LastName);
        }
        [Theory]
        [InlineData("")]
        [InlineData(null)]

        public void LastNameNullAndEmptyTests(string lastname)
        {
            Person persontest = new Person();

            ArgumentException ifNullEmpty = Assert.Throws<ArgumentException>(() => persontest.LastName = lastname);
            Assert.Equal("Last name must have a value", ifNullEmpty.Message);
        }


    }
}
