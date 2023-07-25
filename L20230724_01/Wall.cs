using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230724_01
{
    internal class Wall : GameObject
    {
        public Wall() 
        {
            AddComponent(new Renderer());
        }
        ~Wall() 
        {

        }
    }
}
