using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719_02
{
    internal class Goblin : Monster
    {
        public Goblin()
        {
            healthPoint = 100;
            gold = 10;
            xPos = 3;
            yPos = 7;
        }

        public Goblin(int inXPos, int inYPos)
        {
            healthPoint = 100;
            gold = 10;
            xPos = inXPos;
            yPos = inYPos;
        }

        ~Goblin()
        {

        }
    }
}
