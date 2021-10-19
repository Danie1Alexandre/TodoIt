using System;
using Xunit;
using TodoIt.Model;

namespace Todoit.Tests
{
    public class TodoTests
    {
        [Fact] //Test for TodoConstructo and Property for id and Description
        public void TodoConstructorTests()
        {
            Todo exempelTodo = new Todo(1999, "mr andersson");
            int exempelId = 1999;
            string exempeDescription = "mr andersson";
            Assert.Equal(exempelTodo.TodoId, exempelId);
            Assert.Equal(exempelTodo.Description, exempeDescription);
        }

        //Test for Done Property, first test match, second test confirm not macthing 
        [Fact]
        public void TodoDoneTests()
        {
            Todo exempelTodo = new Todo(0, "value");
            bool exempeDone = false;
            exempelTodo.Done = false;
            Assert.Equal(exempelTodo.Done,exempeDone);
            exempelTodo.Done = true;
            Assert.NotEqual(exempelTodo.Done, exempeDone);
        }

        //Test for Assignee
        [Fact]
        public void TodoAssigneeTests()
        {
            Todo exempelTodo = new Todo(0, null);
            Assert.Null(exempelTodo.Assignee);
        }
    }
}
