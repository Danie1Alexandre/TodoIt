/*using System;
using Xunit;
using TodoIt.Model;

namespace Todoit.Tests
{
    public class PersonTests
    {
        //Test for id Property, first test match year, second test confirm not macthing year
        [Fact]
        public void PrintIdTests()
        {
            Person TestPerson = new Person(1999);

            int exempelYear = 1999;
            Assert.Equal(TestPerson.PersonID, exempelYear);

            exempelYear = 1997;
            Assert.NotEqual(TestPerson.PersonID, exempelYear);
        }

        //Test for first name Property, first test match, second test confirm not macthing 
        [Fact]
        public void FirstNamePersonTests()
        {
            Person TestPerson = new Person();

            TestPerson.FirstName = "My Name is jeff";

            string exempelName = "My Name is jeff";

            Assert.Equal(TestPerson.FirstName, exempelName);

            //no match test
            exempelName = "Im not jeff";

            Assert.NotEqual(TestPerson.FirstName, exempelName);
            Assert.NotEmpty(TestPerson.FirstName);
            Assert.NotNull(TestPerson.FirstName);
        }

        // Excexption test for firstname to see if exception message works
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NullAndEmptyFirstNamePersonTests(string testName)
        {
            Person TestPerson = new Person();
            var exception = Assert.Throws<ArgumentException>(() => TestPerson.FirstName = testName);
            Assert.Equal("First name can not be null or empty", exception.Message);
        }

        //Test for Last name Property, first test match, second test confirm not macthing 
        [Fact]
        public void LastNamePersonTests()
        {
            Person TestPerson = new Person();

            TestPerson.LastName = "Andersson";

            string exempelName = "Andersson";

            Assert.Equal(TestPerson.LastName, exempelName);

            //no match test
            exempelName = "Im not Andresson";

            Assert.NotEqual(TestPerson.LastName, exempelName);
            Assert.NotEmpty(TestPerson.LastName);
            Assert.NotNull(TestPerson.LastName);
        }

        // Excexption test for last name to see if exception message works
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NullAndEmptyLasttNamePersonTests(string testName)
        {
            Person TestPerson = new Person();
            var exception = Assert.Throws<ArgumentException>(() => TestPerson.LastName = testName);
            Assert.Equal("Last name can not be null or empty", exception.Message);
        }

    }
 
}
*/