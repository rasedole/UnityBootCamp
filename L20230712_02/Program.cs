using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230712_02
{
    internal class Program
    {
        static Random random = new Random();
        static int playerX = 1;
        static int playerY = 1;
        static int mapNumber = 1;
        static int healthPoint = 100;
        static int level = 0;

        static int[,] returnMap(int num)
        {
            switch (num)
            {
                case 1:
                    return map1;
                case 2:
                    return map2;
                case 3:
                    return map3;
                case 4:
                    return map4;
                default:
                    return null;
            }
        }

        //static int[,] map1 =
        //{
        //    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        //    { 1, 0, 3, 3, 0, 0, 0, 0, 0, 1 },
        //    { 1, 0, 1, 1, 0, 0, 0, 0, 0, 1 },
        //    { 1, 0, 3, 3, 0, 0, 0, 0, 0, 2 },
        //    { 1, 0, 3, 3, 0, 0, 0, 0, 0, 2 },
        //    { 1, 0, 1, 1, 0, 0, 0, 0, 0, 1 },
        //    { 1, 0, 0, 0, 1, 1, 1, 0, 0, 1 },
        //    { 1, 0, 0, 0, 0, 0, 1, 0, 0, 1 },
        //    { 1, 1, 1, 2, 2, 2, 1, 1, 1, 1 }
        //};

        //static int[,] map2 =
        //{
        //    {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
        //    {1,0,0,0,1,0,0,0,1,0,0,0,1,0,1 },
        //    {1,0,0,0,1,0,0,0,1,0,1,0,0,0,1 },
        //    {1,0,0,0,1,0,1,0,3,3,3,3,3,0,1 },
        //    {2,0,0,0,1,0,1,0,3,3,3,3,3,0,1 },
        //    {2,0,0,0,1,0,1,0,3,3,3,3,3,0,1 },
        //    {1,0,0,0,1,0,1,0,1,0,1,0,1,0,1 },
        //    {1,0,0,0,0,0,1,0,1,0,1,0,1,0,1 },
        //    {1,0,0,0,0,0,1,0,0,0,0,0,0,0,1 },
        //    {1,1,1,1,1,1,1,1,1,1,1,1,2,2,1 }
        //};

        //static int[,] map3 =
        //{
        //    { 1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
        //    { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2 },
        //    { 1, 0, 3, 1, 3, 1, 0, 0, 0, 1, 1 },
        //    { 1, 0, 3, 1, 3, 1, 0, 0, 0, 1, 1 },
        //    { 1, 0, 3, 1, 3, 1, 0, 0, 0, 1, 1 },
        //    { 1, 0, 3, 1, 3, 1, 0, 0, 0, 1, 1 },
        //    { 1, 0, 3, 1, 3, 1, 0, 0, 0, 1, 1 },
        //    { 1, 0, 3, 1, 3, 1, 0, 0, 0, 1, 1 },
        //    { 1, 0, 3, 0, 3, 1, 0, 0, 0, 1 ,1 },
        //    { 1, 0, 3, 1, 3, 1, 0, 0, 0, 1 ,1 },
        //    { 1, 0, 3, 1, 3, 1, 0, 0, 0, 1 ,1 },
        //    { 1, 0, 3, 1, 3, 1, 0, 0, 0, 1 ,1 },
        //    { 1, 0, 1, 1, 1, 1, 0, 0, 0, 1 ,1 },
        //    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 ,1 }
        //};

        //static int[,] map4 =
        //{
        //    {1,1,1,1,1,1,1,1,1,1,1,1,2,2,1 },
        //    {1,0,0,0,0,0,0,0,0,0,0,1,0,0,1 },
        //    {1,0,1,1,1,1,1,1,1,0,0,1,1,3,1 },
        //    {1,0,1,3,0,0,0,0,0,0,0,1,0,0,1 },
        //    {2,0,1,0,3,1,1,1,1,1,1,1,3,1,1 },
        //    {2,0,1,0,1,1,1,1,1,1,1,1,0,0,1 },
        //    {2,0,1,0,1,3,3,0,3,1,3,1,1,3,1 },
        //    {2,0,1,0,1,3,3,1,3,1,3,1,0,0,1 },
        //    {1,1,1,0,1,0,0,1,0,1,3,1,3,0,1 },
        //    {1,0,0,0,1,0,0,1,0,1,3,1,1,3,1 },
        //    {1,3,1,0,1,3,3,1,0,3,3,1,3,0,1 },
        //    {1,3,1,0,1,3,3,3,3,3,3,1,3,0,1 },
        //    {1,3,1,0,1,3,1,1,1,1,1,1,3,1,1 },
        //    {1,0,1,0,1,3,0,0,0,0,0,1,3,0,1 },
        //    {1,0,1,0,1,3,3,3,0,0,0,1,3,0,1 },
        //    {1,0,1,0,1,3,3,3,0,0,0,1,1,3,1 },
        //    {1,0,1,0,3,3,3,3,3,0,0,1,3,0,1 },
        //    {1,0,1,3,3,3,3,3,3,3,0,1,3,0,1 },
        //    {1,3,1,1,1,1,1,1,1,1,1,1,3,0,1 },
        //    {1,3,3,3,3,3,3,3,3,3,3,3,3,3,1 },
        //    {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 }
        //};

        static int[,] map1 = new int[25, 25];
        static int[,] map2 = new int[25, 25];
        static int[,] map3 = new int[25, 25];
        static int[,] map4 = new int[25, 25];

        static void Process(ConsoleKey Key, int[,] map)
        {
            switch (Key)
            {
                case ConsoleKey.LeftArrow:
                    healthPoint--;
                    if (map[playerY, playerX - 1] == 2)
                    {
                        playerX += (returnMap(mapNumber - 1).GetLength(1) - 3);
                        mapNumber--;
                    }
                    else if (map[playerY, playerX - 1] == 0)
                    {
                        playerX--;
                    }
                    else if (map[playerY, playerX - 1] == 3)
                    {
                        map[playerY, playerX - 1] = 0;
                        playerX--;
                        healthPoint += 10;
                        level++;
                    }
                    else
                    {
                    }
                    break;
                case ConsoleKey.RightArrow:
                    healthPoint--;
                    if (map[playerY, playerX + 1] == 2)
                    {
                        playerX -= (returnMap(mapNumber).GetLength(1) - 3);
                        mapNumber++;
                    }
                    else if (map[playerY, playerX + 1] == 0)
                    {
                        playerX++;
                    }
                    else if (map[playerY, playerX + 1] == 3)
                    {
                        map[playerY, playerX + 1] = 0;
                        playerX++;
                        healthPoint += 10;
                        level++;
                    }
                    else
                    {
                    }
                    break;
                case ConsoleKey.UpArrow:
                    healthPoint--;
                    if (map[playerY - 1, playerX] == 2)
                    {
                        playerY += (returnMap(mapNumber - 2).GetLength(0) - 3);
                        mapNumber -= 2;

                    }
                    else if (map[playerY - 1, playerX] == 0)
                    {
                        playerY--;
                    }
                    else if (map[playerY - 1, playerX] == 3)
                    {
                        map[playerY - 1, playerX] = 0;
                        playerY--;
                        healthPoint += 10;
                        level++;
                    }
                    else
                    {
                    }
                    break;
                case ConsoleKey.DownArrow:
                    healthPoint--;
                    if (map[playerY + 1, playerX] == 2)
                    {
                        playerY -= (returnMap(mapNumber).GetLength(0) - 3);
                        mapNumber += 2;
                    }
                    else if (map[playerY + 1, playerX] == 0)
                    {
                        playerY++;
                    }
                    else if (map[playerY + 1, playerX] == 3)
                    {
                        map[playerY + 1, playerX] = 0;
                        playerY++;
                        healthPoint += 10;
                        level++;
                    }
                    else
                    {
                    }
                    break;
                case ConsoleKey.Tab:
                    if (mapNumber < 4)
                    {
                        mapNumber++;
                    }
                    else
                    {
                        mapNumber = 1;
                    }
                    healthPoint -= 50;
                    playerX = 1;
                    playerY = 1;
                    MapSetting(mapNumber);
                    break;
                default:
                    break;
            }
        }
        static void Render(int mapNum)
        {
            Console.Clear();
            score();
            switch (mapNum)
            {
                case 1:
                    DrawMap(map1.GetLength(0), map1.GetLength(1), map1);
                    break;
                case 2:
                    DrawMap(map2.GetLength(0), map2.GetLength(1), map2);
                    break;
                case 3:
                    DrawMap(map3.GetLength(0), map3.GetLength(1), map3);
                    break;
                case 4:
                    DrawMap(map4.GetLength(0), map4.GetLength(1), map4);
                    break;
                default:
                    break;
            }
        }

        static void DrawMap(int yLength, int xLength, int[,] map)
        {

            for (int y = 0; y < yLength; y++)
            {
                for (int x = 0; x < xLength; x++)
                {
                    if ((x == playerX) && (y == playerY))
                    {
                        Console.Write("P" + " ");
                        if (map[y, x] == 3)
                        {
                            map[y, x] = 0;
                            healthPoint += 10;
                            level++;
                        }
                    }
                    else if (map[y, x] == 1)
                    {
                        Console.Write("*" + " ");
                    }
                    else if (map[y, x] == 0)
                    {
                        Console.Write(" " + " ");
                    }
                    else if (map[y, x] == 2)
                    {
                        Console.Write("o" + " ");
                    }
                    else if (map[y, x] == 3)
                    {
                        Console.Write("\\" + " ");
                    }
                    else if (map[y, x] == 4)
                    {
                        Console.Write("E" + " ");
                    }
                    else
                    {
                        Console.Write(map[y, x] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void score()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.Write("-" + " ");
            }
            Console.WriteLine();
            Console.Write("HP : " + healthPoint);
            Console.Write("        " + "Level : " + level);
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < 25; i++)
            {
                Console.Write("-" + " ");
            }
            Console.WriteLine();
        }

        static int[,] MakeMap(int sizeOfX, int sizeOfY)
        {
            int coinNum = 0;
            coinNum = random.Next(0, (sizeOfY - 2) * (sizeOfX - 2));
            int[,] coinPos = new int[coinNum, 2];   //coin의 위치를 저장하는 배열

            //코인 위치를 저장
            for (int i = 0; i < coinNum; i++)
            {
                coinPos[i, 0] = random.Next(1, sizeOfX - 1);
                coinPos[i, 1] = random.Next(1, sizeOfY - 1);
            }

            int[,] newMap = new int[sizeOfY, sizeOfX];
            //코인을 맵에 배치
            for (int j = 0; j < coinNum; j++)
            {
                if (random.Next(1, 4) == 3)
                {
                    newMap[coinPos[j, 1], coinPos[j, 0]] = 3;
                }
                else
                {

                }
            }

            for (int x = 0; x < sizeOfX; x++)
            {
                for (int y = 0; y < sizeOfY; y++)
                {
                    if ((y == 0) || (y == (sizeOfY - 1)))
                    {
                        newMap[y, x] = 1;
                    }
                    else if ((x == 0) || (x == (sizeOfX - 1)))
                    {
                        newMap[y, x] = 1;
                    }
                    else if (newMap[y, x] != 3)
                    {
                        newMap[y, x] = 0;
                    }
                    else
                    {

                    }
                }
            }
            return newMap;
        }

        //static void CountCoin()
        //{
        //    for (int i = 0; i < map1.GetLength(1); i++)
        //    {
        //        for (int j = 0; j < map1.GetLength(0); j++)
        //        {
        //            if (map1[j, i] == 3)
        //            {
        //                lastCoin++;
        //            }
        //            else
        //            {

        //            }
        //        }
        //    }

        //    for (int i = 0; i < map2.GetLength(1); i++)
        //    {
        //        for (int j = 0; j < map2.GetLength(0); j++)
        //        {
        //            if (map2[j, i] == 3)
        //            {
        //                lastCoin++;
        //            }
        //            else
        //            {

        //            }
        //        }
        //    }

        //    for (int i = 0; i < map3.GetLength(1); i++)
        //    {
        //        for (int j = 0; j < map3.GetLength(0); j++)
        //        {
        //            if (map3[j, i] == 3)
        //            {
        //                lastCoin++;
        //            }
        //            else
        //            {

        //            }
        //        }
        //    }

        //    for (int i = 0; i < map4.GetLength(1); i++)
        //    {
        //        for (int j = 0; j < map4.GetLength(0); j++)
        //        {
        //            if (map4[j, i] == 3)
        //            {
        //                lastCoin++;
        //            }
        //            else
        //            {

        //            }
        //        }
        //    }
        //}

        static void ProcessAll(ConsoleKey Key, int number)
        {
            switch (number)
            {
                case 1:
                    Process(Key, map1);
                    return;
                case 2:
                    Process(Key, map2);
                    return;
                case 3:
                    Process(Key, map3);
                    return;
                case 4:
                    Process(Key, map4);
                    return;
                default:
                    return;
            }
        }

        static void MapSetting(int exceptNum = 0)
        {
            if (exceptNum != 1)
            {
                map1 = MakeMap(random.Next(3, 25), random.Next(3, 25));
            }
            if (exceptNum != 2)
            {
                map2 = MakeMap(random.Next(3, 25), random.Next(3, 25));
            }
            if (exceptNum != 3)
            {
                map3 = MakeMap(random.Next(3, 25), random.Next(3, 25));
            }
            if (exceptNum != 4)
            {
                map4 = MakeMap(random.Next(3, 25), random.Next(3, 25));
            }
        }

        static void Setting()
        {
            MapSetting();
            //CountCoin();
            Render(mapNumber);
        }

        static void Main(string[] args)
        {
            Setting();
            while ((level < 100) && (healthPoint > 0))
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                ProcessAll(info.Key, mapNumber);
                Render(mapNumber);
            }
            if (healthPoint <= 0)
            {
                Console.WriteLine("Game Over");
            }
            else
            {
                Console.WriteLine("Game Clear");
            }
        }
    }
}
