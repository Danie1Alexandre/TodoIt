using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Data;
using Xunit;
using TodoIt.Model;

namespace Todoit.Tests
{
    public class TodoItemsTests
    {
        [Fact]
        public void ArrayTodoTests()
        {
            TodoItems theMatrix = new TodoItems();
            Todo[] array = new Todo[2];
            theMatrix.TodoArray = array;
            Person neo = new Person(1999) { FirstName = "Neo", LastName = "The One"};
            Todo jump = new Todo(1,"jump") { Done = true, Assignee = neo };
            Todo run = new Todo(2, "run") { Done = true, Assignee = neo };

            theMatrix.TodoArray[0] = jump;
            theMatrix.TodoArray[1] = run;

            Assert.Equal(theMatrix.TodoArray[0].Description, jump.Description);
            Assert.Equal(1, theMatrix.TodoArray[0].TodoId);
            Assert.Equal(theMatrix.TodoArray[1].Assignee, run.Assignee );
            Assert.True(theMatrix.TodoArray[1].Done);
            Assert.Equal(theMatrix.TodoArray[0], jump);
        }

        [Fact]
        public void SizeTest()
        {
            TodoItems theMatrix = new TodoItems();
            Todo[] array = new Todo[3];

            theMatrix.TodoArray = array;

            Assert.Equal(array.Length, theMatrix.Size());
            Assert.Equal(3, theMatrix.Size());
            Assert.NotEqual(5, theMatrix.Size());
        }

        [Fact]
        public void FindAll()
        {
            TodoItems theMatrix = new TodoItems();
            Todo[] array = new Todo[3];
            Todo[] arrayFound = new Todo[3];
            Person neo = new Person(1999) { FirstName = "Neo", LastName = "The One" };
            Todo jump = new Todo(1, "jump") { Done = true, Assignee = neo };
            Todo run = new Todo(2, "run") { Done = true, Assignee = neo };

            array[0] = jump;
            array[1] = run;
            theMatrix.TodoArray = array;
            arrayFound = theMatrix.FindAll();

            Assert.Equal(arrayFound, theMatrix.TodoArray);
            Assert.Equal(arrayFound[0].Assignee, theMatrix.TodoArray[0].Assignee);
            Assert.Equal(run, arrayFound[1]);
            Assert.Equal(jump.Done, arrayFound[1].Done);
            Assert.Equal(2, arrayFound[1].TodoId);
            
            Assert.NotEqual(jump, arrayFound[1]);
        }

        [Fact]
        public void FindByIdTests()
        {
            TodoItems theMatrix = new TodoItems();
            Todo[] array = new Todo[3];
            Person neo = new Person(1999) { FirstName = "Neo", LastName = "The One" };
            Todo jump = new Todo(1, "jump") { Done = true, Assignee = neo };
            Todo run = new Todo(2, "run") { Done = true, Assignee = neo };

            array[0] = jump;
            array[1] = run;
            theMatrix.TodoArray = array;

            Assert.Equal(theMatrix.FindById(1,"").TodoId, jump.TodoId);
            Assert.Equal(1, theMatrix.FindById(1, "").TodoId);
            Assert.Equal(2, theMatrix.FindById(2, "").TodoId);
            Assert.Equal(array[0].Assignee, theMatrix.FindById(1, "").Assignee);
            
            Assert.NotEqual(3, theMatrix.FindById(2, "").TodoId);
        }

        [Fact]
        public void addNewToDOTests()
        {
            TodoItems theMatrix = new TodoItems();
            theMatrix.Clear();
            Person neo = new Person(1999) { FirstName = "Neo", LastName = "The One" };
            
            theMatrix.addNewTodo().Description ="fly";
            theMatrix.TodoArray[0].Done = true;
            theMatrix.TodoArray[0].Assignee = neo;

            Assert.Equal(neo, theMatrix.TodoArray[0].Assignee);
            Assert.Equal(1, theMatrix.TodoArray[0].TodoId);
            Assert.Equal(2, theMatrix.addNewTodo().TodoId);
            Assert.Equal(2, theMatrix.TodoArray[1].TodoId);
            Assert.Equal("", theMatrix.TodoArray[1].Description);
            Assert.True(theMatrix.TodoArray[0].Done);
            Assert.Equal("fly", theMatrix.TodoArray[0].Description);
            Assert.NotEqual("walk", theMatrix.TodoArray[0].Description);
        }
        [Fact]
        public void ClearTodoiemTests()
        {
            TodoItems theMatrix = new TodoItems();
            theMatrix.Clear();
            theMatrix.addNewTodo().Description = "fly";
            theMatrix.addNewTodo().Description = "run";

            Assert.Equal("fly", theMatrix.TodoArray[0].Description);
            Assert.Equal(2, theMatrix.TodoArray.Length);

            theMatrix.Clear();
            Assert.NotEqual(2, theMatrix.TodoArray.Length);
            Assert.Empty(theMatrix.TodoArray);
        }

        [Fact]
        public void FindByDoneStatusTests()
        {
            TodoItems theMatrix = new TodoItems();
            Todo[] array = new Todo[2];
            Todo[] arrayDone = new Todo[0];
            int arraySize;

            Person neo = new Person(1999) { FirstName = "Neo", LastName = "The One" };
            Todo jump = new Todo(1, "jump") { Done = true, Assignee = neo };
            Todo run = new Todo(2, "run") { Done = false, Assignee = neo };

            array[0] = jump;
            array[1] = run;
            theMatrix.TodoArray = array;

            arrayDone = theMatrix.FindByDoneStatus(true);
            arraySize = arrayDone.Length;

            Assert.True(arrayDone[0].Done);
            Assert.Equal(!false, arrayDone[0].Done);
            Assert.Equal(1,arraySize);
        }

        [Fact]
        public void FindByAssigneeIntTests()
        {
            TodoItems theMatrix = new TodoItems();
   
            Todo[] array = new Todo[2];
            Todo[] array2 = new Todo[0];
            int arraySize;
            Person neo = new Person(1) { FirstName = "Neo", LastName = "The One" };
            Person Trinity = new Person(2) { FirstName = "Trinity", LastName = "in love" };
            Todo jump = new Todo(1, "jump") { Done = true, Assignee = neo };
            Todo run = new Todo(2, "run") { Done = false, Assignee = Trinity };
           
            array[0] = jump;
            array[1] = run;
            theMatrix.TodoArray = array;


            array2 = theMatrix.FindByAssignee(1);
            arraySize = array2.Length;

            Assert.Equal(neo, array2[0].Assignee);
            Assert.NotEqual(Trinity, array2[0].Assignee);
            Assert.Equal(1, arraySize);
        }

        [Fact]
        public void FindByAssigneePersonTests()
        {
            TodoItems theMatrix = new TodoItems();

            Todo[] array = new Todo[2];
            Todo[] array2 = new Todo[0];
            int arraySize;
            Person neo = new Person(1) { FirstName = "Neo", LastName = "The One" };
            Person Trinity = new Person(2) { FirstName = "Trinity", LastName = "in love" };
            Todo jump = new Todo(1, "jump") { Done = true, Assignee = neo };
            Todo run = new Todo(2, "run") { Done = false, Assignee = Trinity };

            array[0] = jump;
            array[1] = run;
            theMatrix.TodoArray = array;


            array2 = theMatrix.FindByAssignee(neo);
            arraySize = array2.Length;

            Assert.Equal(neo, array2[0].Assignee);
            Assert.NotEqual(Trinity, array2[0].Assignee);
            Assert.Equal(1, arraySize);
        }

        [Fact]
        public void FindUnassignedTodoItemsTests()
        {
            TodoItems theMatrix = new TodoItems();
            Todo[] array = new Todo[2];
            Todo[] array2 = new Todo[0];
            int arraySize;
            Person neo = new Person(1) { FirstName = "Neo", LastName = "The One" };
            Person Trinity = new Person(2) { FirstName = "Trinity", LastName = "in love" };
            Todo jump = new Todo(1, "jump") { Done = true, Assignee = neo};
            Todo run = new Todo(2, "run") { Done = false, Assignee = null};

            array[0] = jump;
            array[1] = run;
            theMatrix.TodoArray = array;

            array2 = theMatrix.FindUnassignedTodoItems();
            arraySize = array2.Length;

            Assert.Null(array2[0].Assignee);
            Assert.NotEqual(Trinity, array2[0].Assignee);
            Assert.NotEqual("jump", array2[0].Description);
            Assert.Equal("run", array2[0].Description);
            Assert.Equal(1, arraySize);
        }

        [Fact]
        public void removeObjectFromArrayTests()
        {
            TodoItems theMatrix = new TodoItems();
            Todo[] array = new Todo[2];
            int arraySize;
            Person neo = new Person(1) { FirstName = "Neo", LastName = "The One" };
            Person Trinity = new Person(2) { FirstName = "Trinity", LastName = "in love" };
            Todo jump = new Todo(1, "jump") { Done = true, Assignee = neo };
            Todo run = new Todo(2, "run") { Done = false, Assignee = Trinity };

            array[0] = jump;
            array[1] = run;
            theMatrix.TodoArray = array;
            arraySize = theMatrix.TodoArray.Length;
           
            Assert.Equal(neo, array[0].Assignee);
            Assert.Equal(array.Length, theMatrix.TodoArray.Length);

            theMatrix.removeObjectFromArray(1);

            Assert.Equal(Trinity, theMatrix.TodoArray[0].Assignee);
            Assert.NotEqual(neo, theMatrix.TodoArray[0].Assignee);
            Assert.NotEqual(array.Length, theMatrix.TodoArray.Length);
        }
    }
}
