using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L20230725_01
{
    class CheckPlayerMovable : Component
    {
        public CheckPlayerMovable()
        {
            walls = new List<GameObject>();
            leftMove = true;
            rightMove = true;
            upMove = true;
            downMove = true;
        }

        ~CheckPlayerMovable()
        {

        }

        List<GameObject> walls;
        public bool leftMove;
        public bool rightMove;
        public bool upMove;
        public bool downMove;

        public override void Start()
        {
            Engine engine = Engine.GetInstance();
            foreach (var gameObject in engine.gameObjects)
            {
                if (gameObject.name.Equals("wall"))
                {
                    walls.Add(gameObject);
                }
            }
        }

        public override void Update()
        {

            leftMove = true;
            rightMove = true;
            upMove = true;
            downMove = true;
            foreach (var wall in walls)
            {

                if ((wall.transform.x == (transform.x - 1)) && (wall.transform.y == transform.y))
                {
                    leftMove = false;
                }
                else if ((wall.transform.x == (transform.x + 1))  && (wall.transform.y == transform.y))
                {
                    rightMove = false;
                }
                if ((wall.transform.x == transform.x) && (wall.transform.y == (transform.y - 1)))
                {
                    upMove = false;
                }
                else if ((wall.transform.x == transform.x) && (wall.transform.y == (transform.y + 1)))
                {
                    downMove = false;
                }
            }
        }
    }
}
