using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Model;

namespace TodoIt.Data
{
    public class TodoItems
    {
        private static Todo[] todoArray = new Todo[0];

        public Todo[] TodoArray
        {
            get { return todoArray; }
            set { todoArray = value; }
        }

        public int Size()
        {
            return todoArray.Length;
        }

        public Todo[] FindAll() { return todoArray; }

        public Todo FindById(int personId, string description)
        {
            Todo findTodoId = new Todo(personId, description);
            Todo[] todoFound = new Todo[Size()];

            for (int i = 0; i < Size(); i++)
            {
                if (findTodoId.TodoId == todoArray[i].TodoId)
                {
                    todoFound[1] = todoArray[i];
                    break;
                }
            }
            return todoFound[1];
        }

        public Todo addNewTodo()
        {
            Todo newTodo = new Todo (TodoSequencer.NextToDoId(),"");

            //incrase size of arry
            int arraySize = Size() + 1;
            Array.Resize(ref todoArray, arraySize);

            //-1 is nedded to set newPerson to start in arry number 0.
            todoArray[arraySize - 1] = newTodo;

            return newTodo;
        }

        public void Clear()
        {
            todoArray = Array.Empty<Todo>();
        }

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            int arraySize = 0;
            Todo[] todoFound = new Todo[arraySize];
            int addItem = 0;
            
            for (int i = 0; i < Size(); i++)
            {
                if (todoArray[i].Done == doneStatus)
                {
                    arraySize++;
                    Array.Resize(ref todoFound, arraySize);
                    todoFound[addItem] = todoArray[i];
                    addItem++;
                }
            }
            return todoFound;
        }
        
        public Todo[] FindByAssignee(int personId) 
        {
            int arraySize = 0;
            Todo[] todoFound = new Todo[arraySize];
            int addItem = 0;

            for (int i = 0; i < Size(); i++)
            {
                if (todoArray[i].Assignee.PersonID == personId)
                {
                    arraySize++;
                    Array.Resize(ref todoFound, arraySize);
                    todoFound[addItem] = todoArray[i];
                    addItem++;
                }
            }
            return todoFound;
        }

        public Todo[] FindByAssignee(Person assignee)
        {
            int arraySize = 0;
            Todo[] todoFound = new Todo[arraySize];
            int addItem = 0;

            for (int i = 0; i < Size(); i++)
            {
                if (todoArray[i].Assignee == assignee)
                {
                    arraySize++;
                    Array.Resize(ref todoFound, arraySize);
                    todoFound[addItem] = todoArray[i];
                    addItem++;
                }
            }
            return todoFound;
        }

        public Todo[] FindUnassignedTodoItems()
        {
            int arraySize = 0;
            Todo[] todoFound = new Todo[arraySize];
            int addItem = 0;

            for (int i = 0; i < Size(); i++)
            {
                if (todoArray[i].Assignee == null)
                {
                    arraySize++;
                    Array.Resize(ref todoFound, arraySize);
                    todoFound[addItem] = todoArray[i];
                    addItem++;
                }
            }
            return todoFound;
        }

    
        public Todo[] removeObjectFromArray(int todoId )
        {

            int arraySize = 0;
            Todo[] todoFound = new Todo[arraySize];
            int addItem = 0;

            for (int i = 0; i < Size(); i++)
            {
                if (todoArray[i].TodoId == todoId)
                {
                    Array.Clear(todoArray,i,1);
                }
                else
                {
                    arraySize++;
                    Array.Resize(ref todoFound, arraySize);
                    todoFound[addItem] = todoArray[i];
                    addItem++;
                }
            }
            todoArray = todoFound;
            return  todoArray;
        }
    }
}
