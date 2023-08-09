using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230727_01
{
    class Map
    {
        public Map()
        {
            map = new int[25, 10]
            {
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
                {1,0,0,0,0,0,0,0,0,0 },
            };

            x = 5;
            y = 5;
        }

        ~Map()
        {

        }

        public int[,] map;
        public int x;
        public int y;

        public void RenderSide()
        {
            for (int i = 0; i < 26; i++)
            {
                Console.SetCursorPosition(4, i + 4);
                Console.WriteLine('#');
                Console.SetCursorPosition(15, i + 4);
                Console.WriteLine('#');
            }

            for (int j = 0; j < 12; j++)
            {
                Console.SetCursorPosition(j+4, 4);
                Console.WriteLine('#');
                Console.SetCursorPosition(j+4, 30);
                Console.WriteLine('#');
            }
        }
        public void RenderMap(Block block)
        {
            for (int i = 0; i < map.GetLength(1); i++)
            {
                for (int j = 0; j < map.GetLength(0); j++)
                {
                    Console.SetCursorPosition(i + x, j + y);
                    if (map[j, i] == 1)
                    {
                        Console.WriteLine('*');
                    }
                    else
                    {
                        Console.WriteLine(' ');
                    }
                }
            }

            RenderSide();
            RenderBlock(block);
        }

        public void RenderBlock(Block block)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.SetCursorPosition(i + block.x, j + block.y);
                    if(block.blockAppearance[j, i] == 1)
                    {
                        Console.WriteLine('*');
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
