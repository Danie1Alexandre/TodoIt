using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    public class Todo
    {
        // Private fields and propertys to allow access to private members outside the class
        private readonly int todoId;
        private string description;
        private bool done;
        private Person assignee;

        // adds property to todo id only return value allowed
        public int TodoId
        {
            get { return todoId; }
        }

        // adds property to todo description 
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        // constructor for Todo class 
        public Todo(int todoId, string description)
        {
            this.todoId = todoId;
            Description = description;
            Done = false;
            Assignee = null;
        }

        // adds property to todo Done
        public bool Done 
        { 
            get { return done; } set { done = value; } 
        }
        
        // adds property to todo Assignee 
        public Person Assignee 
        { 
            get { return assignee; } set { assignee = value; } 
        }
    } 
   
}
