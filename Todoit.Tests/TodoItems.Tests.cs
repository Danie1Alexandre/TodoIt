using System;
using Xunit;
using TodoIt.Data;
using TodoIt.Model;

namespace Todoit.Tests
{
    public class TodoItemsTests
    {
        [Fact]

        public void SizeandClearTests()
        {
            TodoItems ob = new TodoItems();
            ob.clear();
            Assert.Equal(0, ob.Size());

            for (int i = 0; i < 5; i++)
            {
                Todo actualTodoItem = TodoItems.NewTodo("test" + i);
            }

            Assert.Equal(5, ob.Size());

            ob.clear();
            Assert.Empty(TodoItems.ArrayTodo);
            
        }
    }
}
