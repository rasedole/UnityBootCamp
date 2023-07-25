using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230724_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine myEngine = new Engine();

            myEngine.Instantiate(new GameObject());

            GameObject wall = new GameObject();
            wall.name = "Wall";
            wall.AddComponent(new Renderer());

            myEngine.Instantiate(wall);

            myEngine.Run();
        }
    }
}