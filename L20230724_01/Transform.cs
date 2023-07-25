using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230724_01
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

        public void Translate(int addX, int addY)
        {
            x += addX;
            y += addY;
        }

        public override void Update()
        {
            Console.WriteLine("Transform Update");
        }

        public int x;
        public int y;
    }
}
