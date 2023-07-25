﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class Transform : Component
    {
        public Transform() 
        {
            x = 0;
            y = 0;
        }

        ~Transform() 
        { 

        }

        public int x;
        public int y;

        public void Translate(int addX, int addY)
        {
            x += addX;
            y += addY;
        }
    }
}
