using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TodoIt.Model;

namespace Todoit.Tests
{
    public class PersonTests
    {
        [Fact]
        public void setNameAndIdTests()
        {
            Person neo = new Person(1999) {FirstName = "Neo", LastName = "The One"};

            Assert.Equal(1999,neo.PersonID);
            Assert.Equal("Neo", neo.FirstName);
            Assert.Equal("The One", neo.LastName);
            Assert.NotEqual("Mr.Andresson", neo.LastName);
        }
    }
}
