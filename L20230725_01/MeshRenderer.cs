using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class MeshRenderer : Component
    {
        protected MeshFilter meshFilter;
        protected Status status;

        public MeshRenderer()
        {

        }

        ~MeshRenderer()
        {

        }

        public override void Start()
        {
            foreach (var component in gameObject.components)
            {
                if (component is MeshFilter)
                {
                    meshFilter = (component as MeshFilter);
                }
                if (component is Status)
                {
                    status = (component as Status);
                }
            }
        }

        public virtual void Render()
        {
            if (status == null)
            {
                Console.SetCursorPosition(transform.x, transform.y);
                Console.WriteLine(meshFilter.shape);
            }
            else if (status.hp > 0)
            {

                Console.SetCursorPosition(transform.x, transform.y);
                Console.WriteLine(meshFilter.shape);
            }
            if (gameObject.name == "enemy")
            {
                Console.SetCursorPosition(0, 15);
                Console.WriteLine(' ');
                Console.SetCursorPosition(1, 15);
                Console.WriteLine(' ');
                Console.SetCursorPosition(2, 15);
                Console.WriteLine(' ');
                Console.SetCursorPosition(0, 15);
                Console.WriteLine(status.hp);
            }
            else if (gameObject.name == "player")
            {
                Console.SetCursorPosition(5, 15);
                Console.WriteLine(' ');
                Console.SetCursorPosition(6, 15);
                Console.WriteLine(' ');
                Console.SetCursorPosition(7, 15);
                Console.WriteLine(' ');
                Console.SetCursorPosition(5, 15);
                Console.WriteLine(status.hp);
            }
        }
    }
}
