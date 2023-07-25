using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace L20230712_02
{
    internal class Player
    {
        public Player() 
        {
            _playerX = 1;
            _playerY = 1;
            _healthPoint = 100;
            _manaPoint = 100;
            _gold = 0;
        }
        ~Player() 
        { 
        }

        public int playerX
        {
            get
            {
                return _playerX;
            }
            set
            {
                if(value >= 0)
                {
                    _playerX = value;
                }
            }
        }

        public int playerY
        {
            get
            {
                return _playerY;
            }
            set
            {
                if (value >= 0)
                {
                    _playerY = value;
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
                if (value >= 0)
                {
                    _healthPoint = value;
                }
            }
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

        public int gold
        {
            get
            {
                return _gold;
            }
            set
            {
                if (value >= 0)
                {
                    _gold = value;
                }
            }
        }

        private int _playerX = 1;
        private int _playerY = 1;
        private int _healthPoint = 100;
        private int _manaPoint = 100;
        private int _gold = 0;


        public void Move(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("Move Left");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("Move Right");
                    break;
                case ConsoleKey.UpArrow:
                    Console.WriteLine("Move Up");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("Move Down");
                    break;
                defalut:
                    break;
            }
        }
    }
}
