using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Model;
using Xunit;

namespace Todoit.Tests
{
    public class TodoTests
    {
        [Fact]
        public void CreatTodoTests()
        {
            Todo theMatrix = new Todo(1, "Enter the Matrix");
            Todo[] array = new Todo[1];
            Person neo = new Person(1999) { FirstName = "Neo", LastName = "The One" };
            Todo jump = new Todo(1, "jump") { Done = true, Assignee = neo };

            Assert.Equal(1, jump.TodoId);
            Assert.Equal("jump", jump.Description);
            Assert.Equal(neo, jump.Assignee);
            Assert.True(jump.Done);
        }


 
    }
}
