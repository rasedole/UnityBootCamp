using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class MeshFilter : Component
    {
        public MeshFilter() 
        {
            shape = ' ';
        }

        public MeshFilter(char newShape)
        {
            shape = newShape;
        }

        ~MeshFilter() 
        {

        }

        public char shape;
    }
}
