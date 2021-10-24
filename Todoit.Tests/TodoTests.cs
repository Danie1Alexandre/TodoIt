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
            Person HAL9000 = new Person(1999) { FirstName = "Neo", LastName = "The One" };
            Todo todoObject = new Todo(2001, "Space odyssey") { Assignee = HAL9000, Done = true};

            Assert.Equal(2001, todoObject.TodoId);
            Assert.Equal("Space odyssey", todoObject.Description);
            Assert.Equal(HAL9000, todoObject.Assignee);
            Assert.True(todoObject.Done);
        }


 
    }
}
