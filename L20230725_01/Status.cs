using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class Status : Component
    {
        public Status() 
        {
            hp = 1;
            mp = 1;
            gold = 0;
        }

        public Status(int inHp, int inMp, int inGold)
        {
            hp = inHp;
            mp = inMp;
            gold = inGold;
        }

        ~Status() 
        {

        }

        public override void Update()
        {

        }

        public int hp;
        public int mp;
        public int gold;
    }
}
