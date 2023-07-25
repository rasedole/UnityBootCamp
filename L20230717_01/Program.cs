using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace L20230717_01
{
    internal class Program
    {
        static int[,] map1 =
{
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 1 },
            { 1, 0, 1, 1, 0, 0, 1, 0, 0, 1 },
            { 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 },
            { 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 },
            { 1, 0, 1, 1, 0, 0, 1, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
        };

        static int playerX = 1;
        static int playerY = 1;

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

        static void Process(ConsoleKey Key)
        {
            switch (Key)
            {
                case ConsoleKey.LeftArrow:
                    if (map1[playerY, playerX - 1] == 2)
                    {
                        playerX += (map1.GetLength(1) - 3);
                    }
                    else if (map1[playerY, playerX - 1] == 0)
                    {
                        playerX--;
                    }
                    else if (map1[playerY, playerX - 1] == 3)
                    {
                        map1[playerY, playerX - 1] = 0;
                        playerX--;
                    }
                    else
                    {
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (map1[playerY, playerX + 1] == 2)
                    {
                        playerX -= (map1.GetLength(1) - 3);
                    }
                    else if (map1[playerY, playerX + 1] == 0)
                    {
                        playerX++;
                    }
                    else if (map1[playerY, playerX + 1] == 3)
                    {
                        map1[playerY, playerX + 1] = 0;
                        playerX++;
                    }
                    else
                    {
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (map1[playerY - 1, playerX] == 2)
                    {
                        playerY += (map1.GetLength(0) - 3);

                    }
                    else if (map1[playerY - 1, playerX] == 0)
                    {
                        playerY--;
                    }
                    else if (map1[playerY - 1, playerX] == 3)
                    {
                        map1[playerY - 1, playerX] = 0;
                        playerY--;
                    }
                    else
                    {
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (map1[playerY + 1, playerX] == 2)
                    {
                        playerY -= (map1.GetLength(0) - 3);
                    }
                    else if (map1[playerY + 1, playerX] == 0)
                    {
                        playerY++;
                    }
                    else if (map1[playerY + 1, playerX] == 3)
                    {
                        playerY++;
                    }
                    else
                    {
                    }
                    break;
                default:
                    break;
            }
        }

        static void Render()
        {
            Console.Clear();
            DrawMap(map1.GetLength(0), map1.GetLength(1), map1);
        }

        static void Main(string[] args)
        {
            Render();
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                Process(info.Key);
                Render();
            }
        }
    }
}
