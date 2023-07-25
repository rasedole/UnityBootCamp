using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230724_01
{
    class Renderer : Component
    {
        public Renderer()
        {

        }

        ~Renderer()
        {

        }

        public override void Start()
        {
            Console.WriteLine("Renderer Start()");
        }

        public override void Update()
        {
            Console.WriteLine("Renderer Update()");
        }

        public void Render()
        {
            Console.WriteLine("Renderer Render()");
        }
    }
}
