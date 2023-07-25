using L20230712_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719_02
{
    internal class Character
    {
        public Character()
        {
            _xPos = 1;
            _yPos = 1;
            _healthPoint = 100;
            _gold = 0;
            _state = 1;
        }
        ~Character() { }

        public int xPos
        {
            get
            {
                return _xPos;
            }
            set
            {
                if (value > 0)
                {
                    _xPos = value;
                }
            }
        }
        public int yPos
        {
            get
            {
                return _yPos;
            }
            set
            {
                if (value > 0)
                {
                    _yPos = value;
                }
            }
        }
        public int healthPoint
        {
            get
            {
                return _healthPoint;
            }
            set
            {
                _healthPoint = value;
            }
        }
        public int gold
        {
            get
            {
                return _gold;
            }
            set
            {
                _gold = value;
            }
        }

        public int state
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        private int _xPos = 0;
        private int _yPos = 0;
        private int _healthPoint = 0;
        private int _gold = 0;
        private int _state = 0;

        public virtual void Move(Map map, Character anotherCharacter)
        {

        }
        public virtual void Move(ConsoleKey key, Map map, List<Character> characters)
        {

        }

        public virtual void Move(ConsoleKey key, Map map, Character anotherCharacter)
        {
            switch (key)
            {
                case ConsoleKey.Z:
                    if (anotherCharacter.state == 1)
                    {
                        Attack(anotherCharacter);
                    }
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
                    if (yPos < (map.ySize - 2))
                    {
                        yPos++;
                    }
                    else
                    {

                    }
                    break;
            }
        }
        public void Attack(Character anotherCharacter)
        {
            if ((Math.Abs(xPos - anotherCharacter.xPos) <= 1) && (Math.Abs(yPos - anotherCharacter.yPos) <= 1))
            {
                anotherCharacter.healthPoint -= 20;
                if (anotherCharacter.healthPoint <= 0)
                {
                    anotherCharacter.state = 0;
                }
            }
            else
            {

            }
        }
    }
}
