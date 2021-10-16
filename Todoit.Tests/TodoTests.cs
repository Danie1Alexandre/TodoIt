using System;
using Xunit;
using TodoIt.Model;

namespace Todoit.Tests
{
    public class TodoTests
    {
        [Fact]
        public void ToTests()
        {
            int todoId = 0;
            string description = "a";
            bool done = false;
            Person assignee = null;

            Todo todoTest = new Todo (todoId, description);

            Assert.NotNull(todoTest);
            Assert.Equal(todoTest.TodoId, todoId);
            Assert.Equal(todoTest.Description, description);
            Assert.Equal(todoTest.Done, done);
            Assert.Equal(todoTest.Assignee, assignee);
        }
    }

}
