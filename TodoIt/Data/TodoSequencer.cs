using System;
using System.Collections.Generic;
using System.Text;


namespace TodoIt.Data
{
    public class TodoSequencer
    {
        private static int toDoSequnceNumber;



        // Metod that increment next  number
        public static int NextToDoSequnceNumber()
        {
            return ++toDoSequnceNumber;
        }

        // Metod that reset number
        public static int ResetToDoSequnceNumber()
        {
            return toDoSequnceNumber = 0;
        }

    }
}
