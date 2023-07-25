using L20230712_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719_02
{

    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo info = Console.ReadKey();

            Random rand = new Random();
            int playerX = 1;
            int playerY = 1;
            int sizeOfX = rand.Next(3, 50);
            int sizeOfY = rand.Next(3, 50);
            int goalX = rand.Next(2, sizeOfX);
            int goalY = rand.Next(2, sizeOfY);

            List<Character> characters = new List<Character>();
            characters.Add(new Player(playerX, playerY));

            int goblinCount = rand.Next(4);
            for (int i = 0; i < goblinCount; i++)
            {
                characters.Add(new Goblin(rand.Next(3, sizeOfX - 2), rand.Next(3, sizeOfY - 2)));
            }

            int slimeCount = rand.Next(4);
            for (int i = 0; i < slimeCount; i++)
            {
                characters.Add(new Slime(rand.Next(3, sizeOfX - 2), rand.Next(3, sizeOfY - 2)));
            }

            int hogCount = rand.Next(4);
            for (int i = 0; i < hogCount; i++)
            {
                characters.Add(new Hog(rand.Next(3, sizeOfX - 2), rand.Next(3, sizeOfY - 2)));
            }
            Map map = new Map(sizeOfX, sizeOfY, goalX, goalY, characters);

            map.DrawMap(characters);
            
            while (info.Key != ConsoleKey.Escape)
            {
                info = Console.ReadKey();
                for (int i = 1; i < characters.Count; i++)
                {
                    characters[i].Move(map, characters[0]);
                }
                characters[0].Move(info.Key, map, characters);
                map.DrawMap(characters);
            }

            map = null;
            characters = null;
        }
    }
}
