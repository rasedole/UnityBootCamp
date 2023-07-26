using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class InputKey
    {
        public InputKey() 
        { 

        }

        ~InputKey() 
        {

        }

        public static ConsoleKey key;

        public static bool GetKeyDown(ConsoleKey checkKey)
        {
            if(checkKey == key)
            {
                return true;
            }
            return false;
        }
    }
}
