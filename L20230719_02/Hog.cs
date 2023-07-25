using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719_02
{
    internal class Hog : Monster
    {
        public Hog()
        {
            healthPoint = 100;
            gold = 10;
            xPos = 5;
            yPos = 5;
        }

        public Hog(int inXPos, int inYPos)
        {
            healthPoint = 100;
            gold = 10;
            xPos = inXPos;
            yPos = inYPos;
        }

        ~Hog()
        {

        }
    }
}
