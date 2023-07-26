using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class MonsterController : Component
    {
        protected CheckPlayerMovable checkPlayerMovable;

        public MonsterController() 
        {

        }

        public MonsterController(int[,] map)
        {

        }

        ~MonsterController() 
        {

        }

        Random rand = new Random();

        public override void Start()
        {
            foreach (var component in gameObject.components)
            {
                if (component is CheckPlayerMovable)
                {
                    checkPlayerMovable = (component as CheckPlayerMovable);
                }
            }
        }

        public override void Update()
        {
            GameObject player = Engine.Find("player");

            if ((player.transform.x == transform.x) && (player.transform.y == transform.y))
            {
                Engine.Quit();
            }

            switch (rand.Next(1,6))
            {
                case 1:
                    if (checkPlayerMovable.upMove)
                    {
                        transform.Translate(0, -1);
                    }
                    break;
                case 2:
                    if (checkPlayerMovable.downMove)
                    {
                        transform.Translate(0, 1);
                    }
                    break;
                case 3:
                    if (checkPlayerMovable.leftMove)
                    {
                        transform.Translate(-1, 0);
                    }
                    break;
                case 4:
                    if (checkPlayerMovable.rightMove)
                    {
                        transform.Translate(1, 0);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
