using L20230719_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace L20230712_02
{
    internal class Player : Character
    {
        public Player()
        {
            healthPoint = 100;
            _manaPoint = 100;
            gold = 0;
        }

        public Player(int inPlayerX, int inPlayerY)
        {
            healthPoint = 100;
            _manaPoint = 100;
            gold = 0;
            xPos = inPlayerX;
            yPos = inPlayerY;
        }


        ~Player()
        {
        }

        public int manaPoint
        {
            get
            {
                return _manaPoint;
            }
            set
            {
                if (value >= 0)
                {
                    _manaPoint = value;
                }
            }
        }

        private int _manaPoint = 100;

        public override void Move(ConsoleKey key, Map map, List<Character> characters)
        {
            switch (key)
            {
                case ConsoleKey.Z:
                    Attack(characters);
                    break;
                case ConsoleKey.LeftArrow:
                    if (xPos > 1)
                    {
                        xPos--;
                    }
                    else
                    {

                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (xPos < (map.xSize - 2))
                    {
                        xPos++;
                    }
                    else
                    {

                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (yPos > 1)
                    {
                        yPos--;
                    }
                    else
                    {

                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (yPos < (map.ySize-2))
                    {
                        yPos++;
                    }
                    else
                    {

                    }
                    break;
            }
        }

        public void Attack(List<Character> characters)
        {
            for(int i = 1; i < characters.Count; i++)
            {
                if ((Math.Abs(xPos - characters[i].xPos) <= 1) && (Math.Abs(yPos - characters[i].yPos) <= 1))
                {
                    characters[i].healthPoint -= 20;
                    if (characters[i].healthPoint <= 0)
                    {
                        characters[i].state = 0;
                    }
                }
                else
                {

                }
            }
        }
    }
}