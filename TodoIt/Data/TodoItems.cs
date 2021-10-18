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
        public void clear()
        {
            arrayTodo = Array.Empty<Todo>();
        }
    }
}
