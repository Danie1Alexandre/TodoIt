using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class PersonSequencer
    {
        private static int personId;

        // Metod that increment next personId number
        public static int NextPersonId()
        {
            return ++ personId;   
        }

        // Metod that reset personId number
        public static int Reset()
        {
            return  personId = 0;   
        }

    }
}
