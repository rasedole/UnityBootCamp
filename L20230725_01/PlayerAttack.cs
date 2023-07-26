using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class PlayerAttack : Component
    {
        public PlayerAttack()
        {
            enemies = new List<GameObject>();
        }

        ~PlayerAttack()
        {

        }

        public List<GameObject> enemies;

        public override void Start()
        {
            Engine engine = Engine.GetInstance();
            foreach (var gameObject in engine.gameObjects)
            {
                if (gameObject.name == "enemy")
                {
                    enemies.Add(gameObject);
                }
            }
        }

        public override void Update()
        {
            if (InputKey.GetKeyDown(ConsoleKey.Spacebar))
            {
                foreach (var gameObject in enemies)
                {
                    if (Math.Pow((gameObject.transform.x - transform.x),2) + Math.Pow((gameObject.transform.y - transform.y), 2) <= 2)
                    {
                        foreach (var component in gameObject.components)
                        {
                            if (component is Status)
                            {
                                Status temp = component as Status;
                                temp.hp -= 20;
                            }
                        }
                    }
                }
            }
        }
    }
}
