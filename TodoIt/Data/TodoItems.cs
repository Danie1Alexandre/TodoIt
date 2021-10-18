using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Model;
using TodoIt.Data;

namespace TodoIt.Data
{
    public class TodoItems
    {
        private static Todo[] arrayTodo = new Todo[0];
        public static Todo[] ArrayTodo { get { return arrayTodo; } }
        
        public int Size()
        {
            return arrayTodo.Length;
        }
       
        public Todo[] FindAll()
        {
            return arrayTodo;
        }
       
        // new Todo boject 
        public static Todo NewTodo(string description)
        {

            var newTodo = new Todo(TodoSequencer.NextToDoSequnceNumber(), description);

            int size = arrayTodo.Length + 1;
            Array.Resize(ref arrayTodo, size);
            arrayTodo[size - 1] = newTodo;

            return newTodo;
        }

        //Looking upp id
        public Todo FindById(int todoId)
        {
            Todo findTodo = new Todo(0, "");
            try
            {
                foreach (Todo item in arrayTodo)
                {
                    if (item.TodoId.Equals(todoId))
                        findTodo = (item);
                }
            }
            catch
            {
                Console.WriteLine("/n Erro when finding id ");
            }
            return findTodo;
        }
     
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            List<Todo> listTodo = new List<Todo>();
            try
            {
                foreach (Todo item in arrayTodo)
                {
                    if (item.Done.Equals(doneStatus))
                        listTodo.Add(item);
                }
            
            }
            catch
            {
                Console.WriteLine("/n FindByDone error");
            }

            return listTodo.ToArray();
        }
        public Todo[] FindByAssignee(int personId)
        {
            List<Todo> listTodo = new List<Todo>();
            try
            {
                foreach (Todo item in arrayTodo)
                {
                    if (item.Assignee != null)
                        if (item.Assignee.PersonID == personId)
                            listTodo.Add(item);
                }
            }
            catch
            {
                Console.WriteLine("/n FindByAssignee error");
            }


            return listTodo.ToArray();
        }
        public Todo[] FindByAssignee(Person assignee)
        {
            List<Todo> listTodo = new List<Todo>();
            try
            {
                foreach (Todo item in arrayTodo)
                {
                    if (item.Assignee != null)
                        if (item.Assignee == assignee)
                            listTodo.Add(item);
                }
            }
            catch
            {
                Console.WriteLine("/n FindByAssignee error ");
            }

            return listTodo.ToArray();
        }
        public Todo[] FindUnassignedTodoItems()
        {
            List<Todo> listTodo = new List<Todo>();
            try
            {
                foreach (Todo item in arrayTodo)
                {
                    if (item.Assignee == null)
                        listTodo.Add(item);
                }
        
            }
            catch
            {
                Console.WriteLine("/n indUnassignedTodoItems error ");
            }

            return listTodo.ToArray();
        }
        public static void RemoveFromArrayTodo(Todo obTodo)
        {
            TodoItems ob = new TodoItems();
            try
            {
                int removeIndex = Array.IndexOf(arrayTodo, obTodo);

                Array.ConstrainedCopy(arrayTodo, removeIndex + 1, arrayTodo, removeIndex, ob.Size() - (removeIndex + 1));
                Array.Resize(ref arrayTodo, ob.Size() - 1);
            }
            catch
            {
                Console.WriteLine("/n removing  items failed.  ");
            }

        }
        public void clear()
        {
            arrayTodo = Array.Empty<Todo>();
        }
    }
}
