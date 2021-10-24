using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class TodoSequencer
    {
        private static int toDoId;

        public int ToDoId
        {
            get { return toDoId; }
            set { toDoId = value; }
        }

        public static int NextToDoId() { return ++toDoId; }

        public static int ResetToDO() { return toDoId = 0; }
    }
}
