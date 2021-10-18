using System;
using Xunit;
using TodoIt.Data;
using TodoIt.Model;
using System.Collections.Generic;

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
        [Fact]
        public void FindTodoTests()
        {
            Person findPerson = new Person(PersonSequencer.NextPersonId());
            findPerson.FirstName = "testman";
            findPerson.LastName = "testsson";
            Person testman2 = new Person(PersonSequencer.NextPersonId());
            testman2.FirstName = "testman2";
            testman2.LastName = "testsson2";
            
            List<Todo> listfindPerson = new List<Todo>();
            List<Todo> listtestman2 = new List<Todo>();
            List<Todo> unAssigned = new List<Todo>();
            Todo[] arrDone = new Todo[1];
            List<Todo> ArrNotDone = new List<Todo>();
            TodoItems ob = new TodoItems();
            ob.clear();
            for (int i = 0; i < 5; i++)
            {

                Todo actualTodoItem = TodoItems.NewTodo("test" + i);
                if (i == 0)
                {
                    TodoItems.ArrayTodo[i].Done = true;
                    arrDone[0] = TodoItems.ArrayTodo[i];
                    unAssigned.Add(TodoItems.ArrayTodo[i]);
                }
                else { ArrNotDone.Add(TodoItems.ArrayTodo[i]); }
                if (i == 1 || i == 3)
                {
                    TodoItems.ArrayTodo[i].Assignee = testman2;
                    listtestman2.Add(TodoItems.ArrayTodo[i]);
                }
                if (i == 2)
                {
                    TodoItems.ArrayTodo[i].Assignee = findPerson;
                    listfindPerson.Add(TodoItems.ArrayTodo[i]);
                }
                if (i > 3)
                {
                    unAssigned.Add(TodoItems.ArrayTodo[i]);
                }
            }


            Assert.Equal(TodoItems.ArrayTodo, ob.FindAll());
            Assert.Equal(TodoItems.ArrayTodo[1], ob.FindById(2));
            Assert.Equal(TodoItems.ArrayTodo[3], ob.FindById(4));

            Assert.Equal(arrDone, ob.FindByDoneStatus(true));
            Assert.Equal(ArrNotDone.ToArray(), ob.FindByDoneStatus(false));

            Assert.Equal(listtestman2.ToArray(), ob.FindByAssignee(testman2));

            Assert.Equal(listfindPerson.ToArray(), ob.FindByAssignee(findPerson.PersonID));

            Assert.Equal(unAssigned.ToArray(), ob.FindUnassignedTodoItems());

            ob.clear();
            Assert.Empty(TodoItems.ArrayTodo);
        }
    }

}
