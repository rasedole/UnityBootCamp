using L20230712_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719_02
{
    internal class Monster : Character
    {
        public Monster() 
        {

        }

        ~Monster() 
        { 

        }
        public override void Move(Map map, Character anotherCharacter)
        {
            int nextMove = 0;
            int xDis = (anotherCharacter.xPos - xPos);
            int yDis = (anotherCharacter.yPos - yPos);
            Random rand = new Random();
            if (Math.Abs(xDis) == Math.Abs(yDis))
            {
                if (xDis == 0)
                {
                    nextMove = 0;
                }
                else if (rand.Next(0, 100) <= 49)
                {
                    if (xDis > 0)
                    {
                        nextMove = 2;
                    }
                    else
                    {
                        nextMove = 1;
                    }
                }
                else
                {
                    if (yDis > 0)
                    {
                        nextMove = 4;
                    }
                    else
                    {
                        nextMove = 3;
                    }
                }
            }
            else if (Math.Abs(xDis) > Math.Abs(yDis))
            {
                if (xDis > 0)
                {
                    nextMove = 2;
                }
                else
                {
                    nextMove = 1;
                }
            }
            else
            {
                if (yDis > 0)
                {
                    nextMove = 4;
                }
                else
                {
                    nextMove = 3;
                }
            }

            switch (nextMove)
            {
                case 1:
                    if (xPos > 1)
                    {
                        map._map[]
                        xPos--;
                    }
                    else
                    {

                    }
                    break;
                case 2:
                    if (xPos < (map.xSize - 2))
                    {
                        xPos++;
                    }
                    else
                    {

                    }
                    break;
                case 3:
                    if (yPos > 1)
                    {
                        yPos--;
                    }
                    else
                    {

                    }
                    break;
                case 4:
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
    }
}
