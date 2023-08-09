using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace L20230727_01
{
    class Block
    {
        public Block()
        {
            state = 0;
            blockAppearance = new int[5, 5];
            rand = new Random();
            blockRectangular = new int[5, 5]
            {
                {0,0,0,0,0},
                {0,0,1,1,0},
                {0,0,1,1,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
            blockLong = new int[5, 5]
{
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,0,0,0}
            };
            blockL = new int[5, 5]
            {
                {0,0,0,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,1,1,0},
                {0,0,0,0,0}
            };
            blockInversedL = new int[5, 5]
            {
                {0,0,0,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,1,1,0,0},
                {0,0,0,0,0}
            };
            blockS = new int[5, 5]
            {
                {0,0,0,0,0},
                {0,0,1,1,0},
                {0,1,1,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
            blockZ = new int[5, 5]
            {
                {0,0,0,0,0},
                {0,1,1,0,0},
                {0,0,1,1,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
            blockT = new int[5, 5]
            {
                {0,0,0,0,0},
                {0,0,1,0,0},
                {0,1,1,1,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };

            x = 8;
            y = 5;
        }

        ~Block()
        {

        }

        public int state;
        public int[,] blockAppearance;
        protected Random rand;
        protected int[,] blockRectangular;
        protected int[,] blockLong;
        protected int[,] blockL;
        protected int[,] blockInversedL;
        protected int[,] blockS;
        protected int[,] blockZ;
        protected int[,] blockT;
        public int x;
        public int y;

        public void MakeBlock()
        {
            state = rand.Next(0, 7);
            switch (state)
            {
                case 0:
                    blockAppearance = blockRectangular;
                    break;
                case 1:
                    blockAppearance = blockLong;
                    break;
                case 2:
                    blockAppearance = blockL;
                    break;
                case 3:
                    blockAppearance = blockInversedL;
                    break;
                case 4:
                    blockAppearance = blockS;
                    break;
                case 5:
                    blockAppearance = blockZ;
                    break;
                case 6:
                    blockAppearance = blockT;
                    break;
            }
        }

        public void MoveBlock(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    x--;
                    break;
                case ConsoleKey.RightArrow:
                    x++;
                    break;
                case ConsoleKey.UpArrow:
                    SpinBlock(true);
                    break;
                case ConsoleKey.Z:
                    SpinBlock(true);
                    break;
                case ConsoleKey.X:
                    SpinBlock(false);
                    break;
                case ConsoleKey.DownArrow:
                    y++;
                    break;
                case ConsoleKey.Spacebar:

                    break;
                case ConsoleKey.Tab:
                    MakeBlock();
                    x = 8;
                    y = 5;
                    break;
                default:
                    break;
            }
        }

        protected void SpinBlock(bool Clockwise)
        {
            int[,] temp = new int[5,5];
            if (Clockwise)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        temp[i, j] = blockAppearance[j, 4 - i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        temp[j, 4-i] = blockAppearance[i, j];
                    }
                }
            }
            blockAppearance = temp;
        }

        public void RenderBlock()
        {

        }
    }
}
