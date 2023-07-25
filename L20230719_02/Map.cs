using L20230719_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace L20230712_02
{
    internal class Map
    {
        public Map()
        {
            _xSize = 1;
            _ySize = 1;
            _map = new int[5, 5];
        }

        public Map(int inXSize, int inYSize, int inGoalX, int inGoalY, List<Character> characters)
        {
            _xSize = inXSize;
            _ySize = inYSize;
            _goalPos[0] = inGoalX;
            _goalPos[1] = inGoalY;
            _map = new int[inXSize, inYSize];
            MakeMap(characters);
        }

        ~Map() { }

        public int xSize
        {
            get
            {
                return _xSize;
            }
            set
            {
                if (value >= 1)
                {
                    _xSize = value;
                }
            }
        }
        public int ySize
        {
            get
            {
                return _ySize;
            }
            set
            {
                if (value >= 1)
                {
                    _ySize = value;
                }
            }
        }

        public int[] goalPos
        {
            get
            {
                return _goalPos;
            }
            set
            {
                if ((value[0] >= 0) && (value[1] >= 0) && (value[0] < _xSize) && (value[1] < _ySize))
                {
                    _goalPos = value;
                }
            }
        }

        private int _xSize = 1;
        private int _ySize = 1;
        private int[] _goalPos = new int[2];
        public int[,] _map;

        public void MakeMap(List<Character> characters)
        {
            for (int i = 0; i < _ySize; i++)
            {
                for (int j = 0; j < _xSize; j++)
                {
                    for (int k = 0; k < characters.Count; k++)
                    {
                        if ((characters[k].state == 1) && (i == characters[k].yPos) && (j == characters[k].xPos))
                        {
                            if (characters[k] is Slime)
                            {
                                _map[j, i] = 3;
                            }
                            else if (characters[k] is Goblin)
                            {
                                _map[j, i] = 4;
                            }
                            else if (characters[k] is Hog)
                            {
                                _map[j, i] = 5;
                            }
                            else
                            {

                            }
                        }
                    }
                    if (_map[j, i] < 3)
                    {
                        if ((i == 0) || (j == 0) || (i == (_ySize - 1)) || (j == (_xSize - 1)))
                        {
                            _map[j, i] = 1;
                        }
                        else if ((i == goalPos[0]) && (j == goalPos[1]))
                        {
                            _map[j, i] = 2;
                        }
                        else
                        {
                            _map[j, i] = 0;
                        }
                    }
                }
            }
        }

        public void DrawMap(List<Character> characters)
        {
            Console.Clear();

            for (int i = 0; i < _ySize; i++)
            {
                for (int j = 0; j < _xSize; j++)
                {
                    if ((i == characters[0].yPos) && (j == characters[0].xPos))
                    {
                        Console.Write("P" + " ");
                    }
                    else if (_map[j,i] == 2)
                    {
                        Console.Write("E" + " ");
                    }
                    else if (_map[j, i] == 3)
                    {
                        Console.Write("S" + " ");
                    }
                    else if (_map[j, i] == 4)
                    {
                        Console.Write("G" + " ");
                    }
                    else if (_map[j, i] == 5)
                    {
                        Console.Write("H" + " ");
                    }
                    else if (_map[j, i] == 1)
                    {
                        Console.Write("*" + " ");
                    }
                    else
                    {
                        Console.Write(" " + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("플레이어의 HP : " + characters[0].healthPoint);
        }
    }
}
