using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719_01
{
    class Player
    {
        public Player()
        {
            Console.WriteLine("플레이어가 생성 되었다.");
            _hp = 0;
            _mp = 0;
            _gold = 0;
        }

        public Player(int inHp, int inMp, int inGold)
        {
            Console.WriteLine("플레이어가 생성 되었다.");
            _hp = inHp;
            _mp = inMp;
            _gold = inGold;
        }
        ~Player()
        {
            Console.WriteLine("플레이어가 삭제 되었다.");
        }

        public int hp 
        {
            get
            {
                return _hp;
            }
            set
            {
                if(value > 0) 
                {
                    _hp = value;
                }
            }
        }

        public int mp
        {
            get;
            set;
        }

        public int gold
        {
            get;
            set;
        }
                
        private int _hp;
        private int _mp;
        private int _gold;

        public void Move()
        {
            DetailMove();
        }
        public void Attack()
        {
            Console.WriteLine("플레이어가 공격한다.");
        }
        public void Die()
        {
            Console.WriteLine("플레이어가 죽었다.");
        }

        private void DetailMove()
        {
            Console.WriteLine("플레이어가 움직인다.");
        }
    }
}
