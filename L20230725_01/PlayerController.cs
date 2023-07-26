using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class PlayerController : Component
    {
        protected CheckPlayerMovable checkPlayerMovable;

        public PlayerController()
        {

        }

        public PlayerController(int[,] map)
        {
                    
        }

        ~PlayerController()
        {

        }
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
            if (InputKey.GetKeyDown(ConsoleKey.W))
            {
                if (checkPlayerMovable.upMove)
                {
                    transform.Translate(0, -1);
                }
            }
            if (InputKey.GetKeyDown(ConsoleKey.S))
            {
                if (checkPlayerMovable.downMove)
                {
                    transform.Translate(0, 1);
                }
            }
            if (InputKey.GetKeyDown(ConsoleKey.A))
            {
                if (checkPlayerMovable.leftMove)
                {
                    transform.Translate(-1, 0);
                }
            }
            if (InputKey.GetKeyDown(ConsoleKey.D))
            {
                if (checkPlayerMovable.rightMove)
                {
                    transform.Translate(1, 0);
                }
            }
        }
    }
}
