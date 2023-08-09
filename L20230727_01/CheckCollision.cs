using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230727_01
{
    class CheckCollision
    {
        public CheckCollision() 
        {
            blockMovable = true;
        }

        ~CheckCollision() 
        {

        }

        public bool blockMovable;

        public void Check(Block block, Map map)
        {
            int xDis = block.x - map.x;
            int yDis = block.y - map.y;

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (block.blockAppearance[j, i] == 1)
                    {
                        if (map.map[yDis,xDis+1] == 1)
                        {
                            Console.SetCursorPosition(30, 30);
                            Console.WriteLine('^');
                            //blockMovable = false;
                            //break;
                        }
                        
                    }
                }
            }
            blockMovable = true;
        }
    }
}
