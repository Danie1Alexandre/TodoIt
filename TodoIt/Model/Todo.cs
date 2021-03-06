using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    public class Todo
    {
        private readonly int todoId;
        private string description;
        private bool done;
        private Person assignee;

        public Todo(int id, string newDescription)
        {
            todoId = id;
            description = newDescription;
        }

        public int TodoId
        {
            get { return todoId; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        public Person Assignee
        {
            get { return assignee; }
            set { assignee = value; }
        }
    }
}
