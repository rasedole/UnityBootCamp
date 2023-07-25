using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine myEngine = new Engine();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i == 1) && (j == 1))
                    {

                    }
                    else
                    {
                        GameObject wall = new GameObject();
                        wall.name = "wall";
                        wall.transform.x = i;
                        wall.transform.y = j;
                    //if((i == 1) && (j == 1))
                    //{
                    //    wall.AddComponents(new MeshFilter('P'));
                    //}
                        if ((i > 0) && (i < 9) && (j > 0) && (j < 9))
                        {
                            wall.AddComponents(new MeshFilter(' '));
                        }
                        else
                        {
                            wall.AddComponents(new MeshFilter('*'));
                        }
                        wall.AddComponents(new MeshRenderer());
                        myEngine.Instantiate(wall);
                    }
                }
            }

            GameObject player = new GameObject();
            player.name = "player";
            player.transform.x = 1;
            player.transform.y = 1;
            player.AddComponents(new MeshFilter('P'));
            player.AddComponents(new MeshRenderer());

            myEngine.Instantiate(player);

            myEngine.Run();
        }
    }
}
