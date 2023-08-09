using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class Program
    {
        static int[,] map =
            {
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } };

        static void Main(string[] args)
        {
            Engine myEngine = Engine.GetInstance();

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (map[y, x] == 1)
                    {
                        GameObject floor = new GameObject();
                        floor.name = "floor";
                        floor.transform.x = x;
                        floor.transform.y = y;
                        floor.AddComponents(new MeshFilter(' '));
                        floor.AddComponents(new MeshRenderer());
                        myEngine.Instantiate(floor);

                        GameObject wall = new GameObject();
                        wall.name = "wall";
                        wall.transform.x = x;
                        wall.transform.y = y;
                        wall.AddComponents(new MeshFilter('*'));
                        wall.AddComponents(new MeshRenderer());
                        myEngine.Instantiate(wall);
                    }
                    else if (map[y,x] == 0)
                    {
                        GameObject floor = new GameObject();
                        floor.name = "floor";
                        floor.transform.x = x;
                        floor.transform.y = y;
                        floor.AddComponents(new MeshFilter(' '));
                        floor.AddComponents(new MeshRenderer());
                        myEngine.Instantiate(floor);
                    }
                }
            }

            GameObject goal = new GameObject();
            goal.name = "goal";
            goal.transform.x = 8;
            goal.transform.y = 8;
            goal.AddComponents(new MeshFilter('G'));
            goal.AddComponents(new MeshRenderer());
            goal.AddComponents(new GoalIn());
            myEngine.Instantiate(goal);

            GameObject enemy = new GameObject();
            enemy.name = "enemy";
            enemy.transform.x = 3;
            enemy.transform.y = 3;
            enemy.AddComponents(new MeshFilter('M'));
            enemy.AddComponents(new Status(100, 0, 40));
            enemy.AddComponents(new CheckPlayerMovable());
            enemy.AddComponents(new MonsterController());
            enemy.AddComponents(new MeshRenderer());
            myEngine.Instantiate(enemy);

            GameObject player = new GameObject();
            player.name = "player";
            player.transform.x = 1;
            player.transform.y = 1;
            player.AddComponents(new MeshFilter('P'));
            player.AddComponents(new Status(100, 100, 0));
            player.AddComponents(new CheckPlayerMovable());
            player.AddComponents(new PlayerAttack());
            player.AddComponents(new PlayerController());
            player.AddComponents(new MeshRenderer());
            myEngine.Instantiate(player);

            myEngine.Run();
        }
    }
}
